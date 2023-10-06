using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Entities;

namespace Teste.Data.Mapping
{

    public class GerenteMap : IEntityTypeConfiguration<Gerente>
    {
        public void Configure(EntityTypeBuilder<Gerente> builder)
        {
            builder.ToTable("Gerente");
            builder.HasKey(c => c.Id);
        }
    }
}
