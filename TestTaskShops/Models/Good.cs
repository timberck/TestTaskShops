using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTaskShops.Models
{
    public class Good
    {
        [Key]
        public string name { set; get; }
        public string description { set; get; }

        public string shop_name { set; get; }
        public Good(Good a)
        {
            this.name = a.name;
            this.description = a.description;
            this.shop_name = a.shop_name;
        }
        public Good()
        {
            this.name = "name";
            this.description = "some description";
            this.shop_name = "shop name";
        }
    }
}