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
    public class ApiLogicBaseController<CLogic> : ApiController where CLogic : LogicBase
    {
        public CLogic Logic { get; }
        public ApiLogicBaseController()
        {
            Database = Database ?? new ShopEntities();
            Logic = (CLogic)Activator.CreateInstance(typeof(CLogic), Database);
        }
        public ShopEntities Database { get; set; }
    }

}
