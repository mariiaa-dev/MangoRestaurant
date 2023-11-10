using Mango.ProductAPI.Persistence.Domains;
using Mango.ProductAPI.Persistence.ModelTypeConfiguration.BaseEntityConfiguration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mango.ProductAPI.Persistence.ModelTypeConfiguration
{
    internal class CategoryConfiguration : BaseEntityConfiguration<Category>
    {
        public new void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.HasOne(c => c.Product)
                   .WithOne(p => p.Category)
                   .HasForeignKey<Product>(p => p.CategoryId);
        }
    }
}
