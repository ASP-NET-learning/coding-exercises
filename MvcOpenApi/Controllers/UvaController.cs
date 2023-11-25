using Microsoft.AspNetCore.Mvc;
using MvcOpenApi.Models;
using Newtonsoft.Json;


namespace MvcOpenApi.Controllers
{
    public class UvaController : Controller
    {
        public async Task<ActionResult> UvaPoint()
        {
            string targetURL = "https://data.moenv.gov.tw/api/v2/uv_s_01?api_key=e8dd42e6-9b8b-43f8-991e-b3dee723a52d&limit=1000&sort=datacreationdate%20desc&format=JSON";
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(targetURL);
            var JsonResponse = JsonConvert.DeserializeObject<Rootobject>(response);
            //ViewBag.response = response;
            return View(JsonResponse.records);
        }
    }
}


