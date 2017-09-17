using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Core.Models.DbModels
{
    public class ProductImage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string Url { get; set; }
        public Product Product { get; set; }
    }
}