using System;
using System.Collections.Generic;
using ServersideData.EntityAsModel;
using ServersideData.Model;

namespace ServersideData
{
    public interface IDataAccess 
    {
        int Commit();
        //Orders
        public Code PlaceOrder(IEnumerable<Order> orders);
<<<<<<< Updated upstream
=======
        public int CheckOrder(IEnumerable<OrderModel> orders);
        public IEnumerable<ShopModel> GetShops(string filter = "");
        public IEnumerable<ShopModel> GetShopsWithInventory(string filter = "");
        public IEnumerable<Inventory> GetInventory(Shop shop);
        public ShopModel ConvertToShopModel(Shop shop, IEnumerable<InventoryModel> inven = null);
        public IEnumerable<InventoryModel> ConvertToInvertoryModel(IEnumerable<Inventory> inven);
>>>>>>> Stashed changes

    }
}
