using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Models
{
    public class Catergory : BaseEntity
    {
        public string Image { get; set; }
        public string Description { get; set; }
        public string Icons { get; set; }

    }
}
