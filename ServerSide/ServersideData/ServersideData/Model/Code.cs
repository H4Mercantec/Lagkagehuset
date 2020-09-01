using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServersideData.Model
{
    public class Code
    {
        [Key]
        public int codeID { get; set; }

        public string code { get; set; }
        public DateTime validToDate { get; set; }

    }
}
