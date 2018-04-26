using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTaskShops.Models
{
    public class Shop
    {
        [Key]
        public string name { set; get; }
        public string address { set; get; }
        public string working_hours {set; get;}
        
    }
}