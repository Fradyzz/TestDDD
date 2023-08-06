using Prueba.Domain.CainetAggregate.ValueIObjects;
using Prueba.Domain.SeedWork;
using Prueba.Domain.SeedWork.ValueObjects;

namespace Prueba.Domain.CainetAggregate
{
    public class Cabinet : Entity
    {
        public PathValue Path { get; set; }

        public Cabinet(IdValue id, NameValue name, DescriptionValue description, PathValue path)
        {
            Id = id;
            Name = name;
            Description = description;
            Path = path;
        }
    }
}