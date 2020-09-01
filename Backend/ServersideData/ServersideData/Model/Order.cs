using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServersideData.Model
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }
        public string orderNumber { get; set; }

        [ForeignKey("shopID")]
        public int shopID { get; set; }

        [ForeignKey("customerID")]
        public int customerID { get; set; }

        [ForeignKey("codeID")]
        public int codeID { get; set; }

        [ForeignKey("productID")]
        public int productID { get; set; }
        public int amount { get; set; }
        public DateTime orderTime { get; set; }
    }
}
