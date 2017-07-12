using Microsoft.AspNet.Identity.EntityFramework;
using Shopping.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Core.Areas.ShopPage.Controllers.BaseControllers
{
    //Maybe change for static class - to prevent creating Entity objects - use only one instead.
    public class LogicBase
    {
        protected readonly ShopEntites Database;
        public LogicBase(ShopEntites db)
        {
            Database = db;
        }
    }
}
