using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Chatbox.Controllers
{
    public class ChatController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly IWebHostEnvironment _env;

        public ChatController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _httpClient = new HttpClient();
            _apiKey = configuration["OpenAI:ApiKey"]; // Lấy API key từ file cấu hình
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AskQuestion(string question)
        {
            // Đọc file JSON từ thư mục Assets
            var dataPath = Path.Combine(_env.ContentRootPath, "Assets", "data.json");
            var jsonData = System.IO.File.ReadAllText(dataPath);

            // Chuyển đổi JSON thành đối tượng C#
            var laptops = JsonConvert.DeserializeObject<List<Laptop>>(jsonData);

            // Xử lý dữ liệu tùy thuộc vào câu hỏi
            var responseContent = "";
            if (question.Contains("giá từ thấp đến cao"))
            {
                var sortedLaptops = laptops.OrderBy(l => l.Price).ToList();
                responseContent = JsonConvert.SerializeObject(sortedLaptops);
            }
            else if (question.Contains("giá cao đến thấp"))
            {
                var sortedLaptops = laptops.OrderByDescending(l => l.Price).ToList();
                responseContent = JsonConvert.SerializeObject(sortedLaptops);
            }

            //var requestData = new
            //{
            //    model = "text-davinci-004", // Giả sử đây là tên model của GPT-4
            //    messages = new[] { new { role = "user", content = question } }
            //};

            var requestData = new
            {
                model = "gpt-3.5-turbo-1106", // Sử dụng model chat
                messages = new[] { new { role = "user", content = question } }
            };

            var jsonContent = JsonConvert.SerializeObject(requestData);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _apiKey);

            var response = await _httpClient.PostAsync("https://api.openai.com/v1/chat/completions", httpContent);
            if (!response.IsSuccessStatusCode)         
            {
                return Json(new { error = "Lỗi khi giao tiếp với API." });
            }

            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<OpenAIChatResponse>(responseString);
            if (responseObject?.Choices == null || responseObject.Choices.Count == 0)
            {
                return Json(new { error = "Không có dữ liệu trả về từ API." });
            }

            // Kiểm tra null trước khi truy cập Content
            var answer = responseObject.Choices[0].Message?.Content ?? "Không thể lấy văn bản từ phản hồi của API.";
            return Json(new { answer = answer });
        }
        public class Laptop
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            // Thêm các thuộc tính khác tùy theo cấu trúc của file JSON
        }

        public class OpenAIChatResponse
        {
            public List<OpenAIChatChoice>? Choices { get; set; }
        }

        public class OpenAIChatChoice
        {
            public OpenAIChatMessage? Message { get; set; }
        }

        public class OpenAIChatMessage
        {
            public string? Role { get; set; }
            public string? Content { get; set; }
        }
    }
}
