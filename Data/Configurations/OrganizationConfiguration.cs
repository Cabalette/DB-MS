using DB_MS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace DB_MS.Data.Configurations
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.Property(x => x.id).HasColumnType("INTEGER").IsRequired();
            builder.Property(x => x.name).HasColumnType("VARCHAR(64)").IsRequired();
            builder.Property(x => x.avatar_id).HasColumnType("INTEGER");

            builder.HasKey(x => x.id);
            builder.HasIndex(x => x.id).IsUnique();
            builder.HasIndex(x => x.name).IsUnique();

            builder.HasMany(x => x.projects)
                   .WithOne(x=>x.organization)
                   .HasForeignKey(x=>x.organization_id)
                   .HasPrincipalKey(x => x.id);
        //    modelBuilder.Entity<Blog>()
        //.HasMany(e => e.Posts)
        //.WithOne(e => e.Blog)
        //.HasForeignKey(e => e.BlogId)
        //.HasPrincipalKey(e => e.Id);
        }
    }
}
