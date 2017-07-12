using Shopping.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Shopping.Core.Areas.ShopPage.Controllers.BaseControllers
{
    public class ApiLogicBaseController<T> : ApiController where T : LogicBase
    {
        public T Logic { get; }

        public ApiLogicBaseController()
        {
            Logic = (T)Activator.CreateInstance(typeof(T), GetDbContext());
        }

        private ShopEntites GetDbContext()
        {
            //using (var ctx = new ShopEntites())
            //{
            //    return ctx;
            //}
            return new ShopEntites();
        }



    }
}
