using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServersideData.Model
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-ZæøåÆØÅ 0-9]+$", ErrorMessage = "Kun danske bogstaver tilladt i {0}")]
        public string name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 6)]
        [RegularExpression(@"^[0-9 +]+$", ErrorMessage = "Kun tal tilladt i {0}")]
        public string phonenumber { get; set; }

    }
}
