using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
{
    public void Configure(EntityTypeBuilder<Tenant> builder)
    {
        builder.ToTable("Tenants").HasKey(t => t.Id);
        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(t => t.Name).HasColumnName("Name").IsRequired();
        builder.Property(t => t.Surname).HasColumnName("Surname").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate").IsRequired();
        builder.Property(t => t.StartedDate).HasColumnName("StartedDate").IsRequired();
        builder.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();

        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);
    }
}
