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
        private readonly DataAccess dataAccess;
        private List<ShopModel> tempTestShops = new List<ShopModel>() {
            new ShopModel()
            {
                shopID = 1,
                address = "Søndergade 2",
                city = "Viborg",
                phoneNumber = "80808080",
                postCode = "8800",
                Inventories = new List<InventoryModel>()
                {
                    new InventoryModel()
                    {
                        inventoryID = 1,
                        amount = 154,
                        product = new ProductModel()
                        {
                            productID = 1,
                            name = "Giffel"
                        }
                    },

                    new InventoryModel()
                    {
                        inventoryID = 2,
                        amount = 3,
                        product = new ProductModel()
                        {
                            productID = 2,
                            name = "Københavner birkes"
                        }
                    }
                }
            },
            new ShopModel()
            {
                shopID = 2,
                address = "Vestergade 26",
                city = "Birkerød",
                phoneNumber = "54235868",
                postCode = "3460",
                Inventories = new List<InventoryModel>()
                {
                    new InventoryModel()
                    {
                        inventoryID = 1,
                        amount = 10,
                        product = new ProductModel()
                        {
                            productID = 1,
                            name = "Giffel"
                        }
                    }
                }
            }
        };



    public ShopsController(ILogger<ShopsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<ShopModel>>> Get(bool includeRollData = false)
        {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.GetShopsWithInventory().ToList();
            var tempData = tempTestShops;
            if (!includeRollData)
            {
                foreach (var shop in tempTestShops)
                {
                    shop.Inventories = null;
                }
            }
            return tempTestShops;
        }



        [HttpGet("{city}")]
        public async Task<ActionResult<ShopModel>> Get(string city)
        {
            var shopSelected = tempTestShops.FirstOrDefault(shop => shop.city == city);
            if (shopSelected == null) return NotFound($"{city} was not found");

            return shopSelected;
        }
    }
}
