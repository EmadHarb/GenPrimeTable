using Microsoft.AspNetCore.Mvc;
using PrimeTable.Frontend.Models;
using Newtonsoft.Json;

namespace PrimeTable.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(int size = 3)
        {
            var model = new MultiplicationTableViewModel();
            using (var httpClient = new HttpClient())
            {
                var baseUrl = _configuration["ApiSettings:BaseUrl"];
                var endpoint = _configuration["ApiSettings:MultiplicationTableEndpoint"];
                string apiUrl = $"{baseUrl}{endpoint}{size}";

                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<MultiplicationTableViewModel>(content);
                }
            }
            return View(model);
        }
    }
}
