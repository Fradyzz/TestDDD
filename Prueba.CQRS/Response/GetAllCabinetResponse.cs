namespace Prueba.CQRS.Response
{
    public class GetAllCabinetResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
    }
}