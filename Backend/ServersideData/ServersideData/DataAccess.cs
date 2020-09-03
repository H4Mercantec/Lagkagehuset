using System;
using System.Collections.Generic;
using System.Text;
using ServersideData.Model;
using ServersideData.EntityAsModel;

namespace ServersideData
{
    public class DataAccess : IDataAccess
    {
        private static TestData testData = new TestData();

        public int CheckOrder(IEnumerable<OrderModel> orders)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InventoryModel> ConvertToInvertoryModel(IEnumerable<Inventory> inven)
        {
            List<InventoryModel> inv = new List<InventoryModel>();
            foreach (Inventory i in inven)
            {
                InventoryModel var = new InventoryModel();
                ProductModel pro = new ProductModel();
                pro.productID = i.productID;
                pro.name = testData.products.Find(p => p.productID == i.productID).name;
                var.amount = testData.inventories.Find(i2 => i2.inventoryID == i.inventoryID && i2.productID == i.productID).amount;
                var.inventoryID = i.inventoryID;
                var.product = pro;
                inv.Add(var);
            }
            return inv;
        }

<<<<<<< Updated upstream
=======
        public ShopModel ConvertToShopModel(Shop shop, IEnumerable<InventoryModel> inven = null)
        {
            ShopModel sho = new ShopModel();
            sho.shopID = shop.shopID;
            sho.postCode = shop.postCode;
            sho.phoneNumber = shop.phoneNumber;
            sho.city = shop.city;
            sho.address = shop.address;
            if (inven == null)
            {
                sho.Inventories = new List<InventoryModel>();
            }
            else
            {
                sho.Inventories = new List<InventoryModel>(inven);
            }
            return sho;
        }

        public IEnumerable<Inventory> GetInventory(Shop shop)
        {
            return testData.inventories.FindAll(i => i.shopID == shop.shopID);
        }

        public IEnumerable<ShopModel> GetShops(string filter = "")
        {
            List<Shop> var = new List<Shop>();
            List<ShopModel> shops = new List<ShopModel>();
            var.AddRange(testData.shops.FindAll(s => s.city.StartsWith(filter)));
            foreach (Shop s in var)
            {
                shops.Add(ConvertToShopModel(s, ConvertToInvertoryModel(testData.inventories.FindAll(i => i.shopID == s.shopID))));
            }
            return shops;
        }

        public IEnumerable<ShopModel> GetShopsWithInventory(string filter = "")
        {
            throw new NotImplementedException();
        }

>>>>>>> Stashed changes
        public Code PlaceOrder(IEnumerable<Order> orders)
        {
            throw new NotImplementedException();
        }
<<<<<<< Updated upstream
=======


        /*private readonly SQLDbContext db;

        public DataAccess(SQLDbContext db)
        {
             this.db = db;
        }

        int Commit()
        {
              return db.SaveChanges();
        }*/



>>>>>>> Stashed changes
    }
}
