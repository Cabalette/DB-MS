using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class ChatMemberConfiguration : IEntityTypeConfiguration<ChatMember>
    {
        public void Configure(EntityTypeBuilder<ChatMember> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.chat_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.member_id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.last_readed_message_id).HasColumnType("BIGINT").IsRequired();

            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => new { x.chat_id, x.member_id }).IsUnique();
        }
    }
}
