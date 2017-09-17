using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Core.Models.DbModels
{
    public class Discount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        /// <summary>
        /// Percentage lower the price of product.
        /// </summary>
        public bool IsDiscount { get; set; }
        /// <summary>
        /// -Count- in one price.
        /// </summary>
        public bool IsCountInOnePrice { get; set; }
        /// <summary>
        /// Is this Product has extra product provided via cart.
        /// </summary>
        public bool IsExtraProduct { get; set; }
        /// <summary>
        /// Count of items should considered as one
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Percentage of discount
        /// </summary>
        public double Percentage { get; set; }

        public DateTime? StartOfPromotionTime { get; set; }
        public DateTime? EndOfPromotionTime { get; set; }
    }
}