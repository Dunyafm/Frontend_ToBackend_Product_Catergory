using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Models
{
    public class CatergoryName : BaseEntity
    {
        public int CatergoryId { get; set; }
        public Catergory Category { get; set; }
    }
}
