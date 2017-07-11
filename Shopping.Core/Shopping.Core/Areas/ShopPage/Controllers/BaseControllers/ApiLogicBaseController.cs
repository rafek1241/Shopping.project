using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Shopping.Core.Areas.ShopPage.Controllers.BaseControllers
{
    public class ApiLogicBaseController<T> : ApiController where T : class, new()
    {
        public T Logic { get; }

        public ApiLogicBaseController() {
            Logic = (T)Activator.CreateInstance(typeof(T));

        }



    }
}
