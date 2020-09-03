using System.Collections.Generic;

namespace ServersideData.EntityAsModel
{
    public class ShopModel
    {
        public int shopID { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string postCode { get; set; }
        public string phoneNumber { get; set; }

        public List<InventoryModel> Inventories { get; set; }
    }
}