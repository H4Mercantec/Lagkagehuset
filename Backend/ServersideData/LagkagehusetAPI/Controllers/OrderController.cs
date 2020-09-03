using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServersideData;
using ServersideData.EntityAsModel;
using ServersideData.Model;

namespace LagkagehusetAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        public IDataAccess dataAcccess;



        public OrderController(ILogger<OrderController> logger, ServersideData.IDataAccess dataAcccess)
        {
            _logger = logger;
            this.dataAcccess = dataAcccess;
        }



        [HttpPost()]
        public async Task<ActionResult<ShopModel>> Post()
        {
            var random = new Random();

            var pickupCode = new System.Text.StringBuilder();
            for(var i = 0; i < 10; i++)
            {
                pickupCode.Append(random.Next(1, 9));
            }
            return Ok("Order placed. Please use this code to pickup order = " + pickupCode.ToString());

        }
    }
}
