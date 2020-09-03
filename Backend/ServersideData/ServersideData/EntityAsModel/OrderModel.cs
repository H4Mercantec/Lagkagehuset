using ServersideData.Model;
using System;
using System.Collections.Generic;

namespace ServersideData.EntityAsModel
{
    public class OrderModel
    {
        public string orderNumber { get; set; }
        public Shop shop { get; set; }
        public Customer customer { get; set; }
        public Code code { get; set; }
        public IEnumerable<ProductModel> products { get; set; }
        public DateTime orderTime { get; set; }
    }
}