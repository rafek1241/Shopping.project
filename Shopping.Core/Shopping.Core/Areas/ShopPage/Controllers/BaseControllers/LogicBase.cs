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
    public class LogicBase
    {
        protected readonly ShopEntites Db;
        public LogicBase(ShopEntites db)
        {
            Db = db;
        }
    }
}
