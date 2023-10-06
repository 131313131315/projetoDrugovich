using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Data.Mapping;
using Teste.Domain.Entities;

namespace Teste.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Gerente>? Gerente { get; set; }
        public DbSet<Grupo>? Grupo { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>(new ClienteMap().Configure);
            builder.Entity<Gerente>(new GerenteMap().Configure);
            builder.Entity<Grupo>(new GrupoMap().Configure);
        }
    }


}
