using Shopping.Core.Areas.ShopPage.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Core.Areas.ShopPage.Models.Mappers.ProductsRequests
{
    public class IdRequest
    {
        public long Id { get; set; }
    }
    public class CategoryIdRequest : Paginable
    {
        public long CategoryId;
    }
    public class SortRequest : CategoryIdRequest
    {
        public bool? Price { get; set; }
        public bool? Name { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }

        //Other sort properties

    }

}