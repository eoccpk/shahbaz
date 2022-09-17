using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using e_commerce.modals;

namespace e_commerce.Data
{
    public class e_commerceContext : DbContext
    {
        public e_commerceContext (DbContextOptions<e_commerceContext> options)
            : base(options)
        {
        }

        public DbSet<e_commerce.modals.products> products { get; set; } = default!;
    }
}
