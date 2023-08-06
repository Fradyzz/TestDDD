using Prueba.Domain.SeedWork.ValueObjects;

namespace Prueba.Domain.SeedWork
{
    public class Entity
    {
        public IdValue Id { get; set; }
        public NameValue Name { get; set; }
        public DescriptionValue Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime DeletedAt { get; set; } = DateTime.Now;
    }
}