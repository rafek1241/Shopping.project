using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Core.Models.DbModels
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Discount Discount { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ICollection<ProductSpecification> Specification { get; set; }
    }
}