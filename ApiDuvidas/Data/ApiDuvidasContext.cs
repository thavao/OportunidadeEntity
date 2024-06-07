using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ApiDuvidas.Data
{
    public class ApiDuvidasContext : DbContext
    {
        public ApiDuvidasContext (DbContextOptions<ApiDuvidasContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Duvidas> Duvidas { get; set; } = default!;
    }
}
