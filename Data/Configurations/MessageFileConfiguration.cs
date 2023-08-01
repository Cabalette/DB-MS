using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class MessageFileConfiguration : IEntityTypeConfiguration<MessageFile>
    {
        public void Configure(EntityTypeBuilder<MessageFile> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.message_id).HasColumnType("BIGINT").IsRequired();
            builder.Property(x => x.file_id).HasColumnType("INTEGER").IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new { x.message_id, x.attachment_id }).IsUnique();
            builder.HasIndex(x => new { x.file_id, x.message_id }).IsUnique();
        }
    }
}
