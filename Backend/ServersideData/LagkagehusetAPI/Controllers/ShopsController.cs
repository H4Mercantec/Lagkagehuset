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
    public class ShopsController : ControllerBase
    {
        private readonly ILogger<ShopsController> _logger;
        public IDataAccess dataAcccess;



        public ShopsController(ILogger<ShopsController> logger, ServersideData.IDataAccess dataAcccess)
        {
            _logger = logger;
            this.dataAcccess = dataAcccess;
        }


        [HttpGet]
        public async Task<ActionResult<List<ShopModel>>> Get(bool includeRollData = false)
        {
            return dataAcccess.GetShopsWithInventory().ToList();
        }



        [HttpGet("{city}")]
        public async Task<ActionResult<ShopModel>> Get(string city)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
