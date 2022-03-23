using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Models
{
    public class Beverage : BaseEntity
    {
        public int CatergoryNameId { get; set; }
        public CatergoryName CatergoryName { get; set; }
    }
}
