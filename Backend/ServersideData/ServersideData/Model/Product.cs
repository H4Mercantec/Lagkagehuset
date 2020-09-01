using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServersideData.Model
{
    public class Product
    {
        [Key]
        public int productID { get; set; }

        public string name { get; set; }
    }
}
