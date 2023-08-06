namespace Prueba.Domain.CainetAggregate.DTOs
{
    public class CabinetDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public int NumOfIndex { get; set; }
        public bool ViewMode { get; set; }
        public Guid GroupId { get; set; }
    }
}