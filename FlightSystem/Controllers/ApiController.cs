using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using FlightSystem.Models;

namespace FlightSystem.Controllers
{
    public class ApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Flight> flights = new List<Flight>();
            HttpClient client = new HttpClient();

            var response = await client.GetAsync("http://localhost:34003/api/Api");
            var jsonResponse = await response.Content.ReadAsStringAsync();
            flights = JsonConvert.DeserializeObject<List<Flight>>(jsonResponse);
            
            {
                return View(flights);
            }
        }
    }
}



 