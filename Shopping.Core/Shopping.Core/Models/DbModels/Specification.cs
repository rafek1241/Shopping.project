namespace Shopping.Core.Models.DbModels
{
    public class Specification
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}