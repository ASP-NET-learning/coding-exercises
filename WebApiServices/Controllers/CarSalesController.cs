using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiServices.Helpers;
using WebApiServices.Models;


// 不知道要怎麼顯示這個亂數
namespace WebApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarSalesController : ControllerBase
    {
        private readonly CarSalesContext _context; 
        List<CarSales> CarSalesNumber;

        public CarSalesController(CarSalesContext context)
        {
            // 初始化 CarSalesNumber
            Utility util = new Utility();
            int[] random1 = util.getNumbers(12);
            int[] random2 = util.getNumbers(12);
            CarSalesNumber = new List<CarSales>()
            {
                new CarSales() {Id = 1, Car ="BMW", Salesdata = random1},
                new CarSales() {Id = 2, Car ="BENZ", Salesdata = random2}
            };
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarSales>>> GetCarSalesNumber()
        {
            return CarSalesNumber;
        }

        
        // 這裡做 GET id 呈現結果

        [HttpGet("{id}")]
        public async Task<ActionResult<CarSales>> GetSingleCarSalesNumber(int id)
        {
            var carItem = CarSalesNumber[id];
            if (carItem == null)
            {
                return NotFound();
            }
            return Ok(carItem);
        }
    }
}

