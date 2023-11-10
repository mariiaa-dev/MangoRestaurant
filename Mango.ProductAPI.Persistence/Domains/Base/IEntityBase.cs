namespace Mango.ProductAPI.Persistence.Domains.Base
{
    public interface IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
