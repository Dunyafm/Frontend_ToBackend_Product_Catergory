using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Models
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CatergoryNameId { get; set; }
        public CatergoryName CatergoryName { get; set; }
    }
}
