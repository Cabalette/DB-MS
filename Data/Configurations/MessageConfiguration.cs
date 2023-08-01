using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.Property(x => x.id).HasColumnType("BIGINT").IsRequired();
            builder.Property(x => x.text).HasColumnType("VARCHAR(64)");
            builder.Property(x => x.chat_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.status_id).HasColumnType("SMALLINT").IsRequired();
            builder.Property(x => x.user_uid).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.quoted_message_id).HasColumnType("BIGINT");

            builder.HasIndex(x => x.id).IsUnique();
        }
    }
}
