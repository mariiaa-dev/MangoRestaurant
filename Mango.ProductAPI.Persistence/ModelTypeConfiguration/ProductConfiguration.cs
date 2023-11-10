using Mango.ProductAPI.Persistence.Domains;
using Mango.ProductAPI.Persistence.ModelTypeConfiguration.BaseEntityConfiguration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mango.ProductAPI.Persistence.ModelTypeConfiguration;

internal class ProductConfiguration : BaseEntityConfiguration<Product>
{
    public new void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);
    }
}
