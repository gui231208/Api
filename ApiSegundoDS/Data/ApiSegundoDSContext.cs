using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiSegundoDS.models;

namespace ApiSegundoDS.Data
{
    public class ApiSegundoDSContext : DbContext
    {
        public ApiSegundoDSContext (DbContextOptions<ApiSegundoDSContext> options)
            : base(options)
        {
        }

        public DbSet<ApiSegundoDS.models.Aluno> Aluno { get; set; } = default!;
        public DbSet<ApiSegundoDS.models.Professor> Professor { get; set; } = default!;
        public DbSet<ApiSegundoDS.models.Escola> Escola { get; set; } = default!;
    }
}
