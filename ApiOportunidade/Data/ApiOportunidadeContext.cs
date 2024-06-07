using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ApiOportunidade.Data
{
    public class ApiOportunidadeContext : DbContext
    {
        public ApiOportunidadeContext (DbContextOptions<ApiOportunidadeContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Oportunidade> Oportunidade { get; set; } = default!;
    }
}
