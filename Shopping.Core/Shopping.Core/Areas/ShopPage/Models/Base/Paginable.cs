using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Core.Areas.ShopPage.Models.Base
{
    public abstract class Paginable
    {
        public int PageSize { get; set; }
        public int PageOffset { get; set; }
        public Paginable(int pageSize = 9999, int pageOffset = 1)
        {
            this.PageOffset = pageOffset;
            this.PageSize = pageSize;
        }
    }
}
