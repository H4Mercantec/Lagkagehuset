using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServersideData.Model
{
    public class Shop
    {
        [Key]
        public int shopID { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string postCode { get; set; }
        public string phoneNumber { get; set; }
    }
}
