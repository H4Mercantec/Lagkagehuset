using ServersideData.Model;

namespace ServersideData.EntityAsModel
{
    public class InventoryModel
    {
        public int inventoryID { get; set; }
        public int amount { get; set; }

        public ProductModel product {get; set;}
    }
}