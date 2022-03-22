using FrontToBackProductCategory.Models;
using System;
using System.Collections.Generic;


namespace FrontToBackProductCategory.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Catergory> Catergories { get; set; }
        public List<Product> Products { get; set; }
        public SliderDetail Detail { get; set; }

    }
}
