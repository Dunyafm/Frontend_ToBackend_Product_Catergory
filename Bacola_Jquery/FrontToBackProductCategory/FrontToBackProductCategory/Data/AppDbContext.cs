using FrontToBackProductCategory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackProductCategory.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catergory> Catergories { get; set; }
        public DbSet<CatergoryName> CatergoryNames { get; set; }
        //public IEnumerable<object> Catergories { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Fruit> Fruits { get; set; }

        public DbSet<Beverage> Beverages { get; set; }
    }
}


