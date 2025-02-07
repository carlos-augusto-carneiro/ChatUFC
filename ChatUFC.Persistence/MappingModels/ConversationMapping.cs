using ChatUFC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Persistence.MappingModels;

public class ConversationMapping : IEntityTypeConfiguration<Conversation>
{
    public void Configure(EntityTypeBuilder<Conversation> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("Id").HasColumnOrder(1);
        
        builder.HasOne(x => x.user)
              .WithMany(x => x.Conversations)
              .HasForeignKey(x => x.UserId)
              .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.CreatedAt).IsRequired().HasColumnName("CreatedAt");
        builder.Property(x => x.UpdatedAt).IsRequired().HasColumnName("UpdatedAt");
        builder.Property(x => x.EndAt).IsRequired().HasColumnName("EndAt");
        builder.Property(x => x.status).IsRequired().HasColumnName("Status");

        builder.HasMany(x => x.Messages)
               .WithOne(x => x.Conversation)
               .HasForeignKey(x => x.ConversationId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
