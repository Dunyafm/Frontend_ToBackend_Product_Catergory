using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Models
{
    public class Card : BaseEntity
    {
        public string Image { get; set; }
        public int Percent { get; set; }
        public string Title { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
    }
}
