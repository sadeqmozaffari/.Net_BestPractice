namespace Porject_02.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Family { get; set; }
        public string? WebsiteUrl { get; set; }
    }
}
