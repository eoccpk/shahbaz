using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using e_commerce_web.models;

namespace e_commerce_web.Data
{
    public class e_commerce_webContext : DbContext
    {
        public e_commerce_webContext (DbContextOptions<e_commerce_webContext> options)
            : base(options)
        {
        }

        public DbSet<e_commerce_web.models.Product> Product { get; set; } = default!;
    }
}
