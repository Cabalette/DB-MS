using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class FileConfiguration : IEntityTypeConfiguration<DB_MS.Models.File>
    {
        public void Configure(EntityTypeBuilder<DB_MS.Models.File> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.type_id).HasColumnType("SMALLINT").IsRequired();
            builder.Property(x => x.caption).HasColumnType("VARCHAR");
            builder.Property(x => x.url).HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.title).HasColumnType("VARCHAR(64)");
            //builder.Property(x => x.crop).HasColumnType();

            builder.HasIndex(x => x.id).IsUnique();
        }
    }
}
