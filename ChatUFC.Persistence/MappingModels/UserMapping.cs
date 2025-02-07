using ChatUFC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Persistence.MappingModels;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("Id").HasColumnOrder(1);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnName("Name").HasColumnOrder(2);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(150).HasColumnName("Email").HasColumnOrder(3);
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.Password).IsRequired().HasMaxLength(255).HasColumnName("Password").HasColumnOrder(4);
        builder.Property(x => x.Registration).IsRequired().HasColumnName("Registration").HasColumnOrder(5);
        builder.Property(x => x.DateCreating).IsRequired().HasColumnName("DataCreating").HasColumnOrder(6);

        builder.HasMany(x => x.Conversations)
            .WithOne(x => x.user)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
