using Mango.ProductAPI.Domains.Domains;
using Mango.ProductAPI.Persistence.Domains.Base;

namespace Mango.ProductAPI.Persistence.Domains
{
    public class Category : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relationships
        public Product Product { get; set; }
    }
}
