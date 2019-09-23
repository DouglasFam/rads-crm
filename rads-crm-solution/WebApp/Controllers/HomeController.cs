using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
     
        public async Task<IActionResult> Index()
        {
            List<Colaborador> ColaboradorList = new List<Colaborador>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:44393/api/colaborador"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ColaboradorList = JsonConvert.DeserializeObject<List<Colaborador>>(apiResponse);
                }
            }
            //    var apiResponse = await _httpclient.GetAsync(endpoint.ToString());
            //apiResponse.EnsureSuccessStatusCode();
            //string Content = apiResponse.Content.ReadAsStringAsync().Result;
            //reservationList = JsonConvert.DeserializeObject<List<Colaborador>>(Content);

            return View(ColaboradorList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
