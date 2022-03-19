using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Models
{
    public class Product : BaseEntity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Detail { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string SosialMediaIcon { get; set; }
        public string CovidInfo { get; set; }
        public string Navtabs { get; set; }


    }
}
