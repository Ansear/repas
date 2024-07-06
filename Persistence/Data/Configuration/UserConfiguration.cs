using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Apellido).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Tipo_Documento).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Num_Documento).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Correo).IsRequired().HasMaxLength(50);
            
            builder.Property(e => e.Usuario).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Contraseña).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(50);

            builder.HasMany(e => e.UserRoles).WithOne(p => p.User).HasForeignKey(e => e.UserId);    
        }
    }
}