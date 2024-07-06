using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Rol");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.NombreRol).IsRequired().HasMaxLength(25);

            builder.Property(e => e.Description).IsRequired().HasMaxLength(50);

            builder.HasMany(e => e.UserRoles).WithOne(e => e.Rol).HasForeignKey(e => e.RolId);
        }
    }
}   