namespace Shopping.Core.Models.DbModels
{
    public class ProductSpecification
    {
        public long Id { get; set; }
        public Specification Specification { get; set; }
        public Product Product { get; set; }
        public string Value { get; set; }
    }
}