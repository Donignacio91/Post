using Microsoft.EntityFrameworkCore;
using ShopPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPost.Data
{
    public class ContextShop : DbContext
    {
        public
         ContextShop(DbContextOptions<ContextShop> options) : base(options)
        { }
        public DbSet<Camiseta> Camisetas { get; set; }
    }
}
