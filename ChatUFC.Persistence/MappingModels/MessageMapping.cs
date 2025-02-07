using ChatUFC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUFC.Persistence.MappingModels;

public class MessageMapping : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("Id");
        builder.Property(x => x.Title).IsRequired().HasMaxLength(255).HasColumnName("Title");
        builder.HasOne(x => x.Conversation).WithMany(x => x.Messages).HasForeignKey(x => x.ConversationId).OnDelete(DeleteBehavior.Cascade);
        builder.Property(x => x.PostMessage).IsRequired().HasColumnName("PostMessage");
        builder.Property(x => x.Content).IsRequired().HasColumnType("TEXT").HasColumnName("Content");
        builder.Property(x => x.Created).IsRequired().HasColumnName("CreatedAt");
    }
}
