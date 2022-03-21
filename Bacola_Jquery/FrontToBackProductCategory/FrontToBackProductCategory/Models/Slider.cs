using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Models
{
    public class Slider : BaseEntity 
    {

        public int Id { get; set; }
        public string Image { get; set; }
        public string MyProperty { get; set; }

    }
}
