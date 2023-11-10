using Mango.ProductAPI.Domains.Models;
using Mango.ProductAPI.Domains.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Mango.ProductAPI.Domains.Domains
{
    public class Product : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(1,1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        //Relationships
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
