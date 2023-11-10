using Mango.ProductAPI.Domains.Domains;
using Mango.ProductAPI.Domains.Models.Base;

namespace Mango.ProductAPI.Domains.Models
{
    public class Category : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relationships
        public Product Product { get; set; }
    }
}
