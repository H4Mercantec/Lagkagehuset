﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServersideData.Model
{
    public class Inventory
    {
        [Key]
        public int inventoryID { get; set; }
        [ForeignKey("shopID")]
        public int shopID { get; set; }
        [ForeignKey("productID")]
        public int productID { get; set; }
        public int amount { get; set; }

        public Inventory(int inventoryID, int shopID, int productID, int amount)
        {
            this.inventoryID = inventoryID;
            this.shopID = shopID;
            this.productID = productID;
            this.amount = amount;
        }
    }
}
