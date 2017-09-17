using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Core.Models.DbModels
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Specification> Specification { get; set; }
    }
}