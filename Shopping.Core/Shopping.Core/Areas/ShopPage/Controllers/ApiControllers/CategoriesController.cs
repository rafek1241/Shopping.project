using Shopping.Core.Areas.ShopPage.Models.Mappers.CategoriesRequests;
using Shopping.Core.Areas.ShopPage.Controllers.BaseControllers;
using Shopping.Core.Areas.ShopPage.Controllers.Logic;
using Shopping.Core.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Shopping.Core.Areas.ShopPage.Controllers.ApiControllers
{
    public class CategoriesController : ApiLogicBaseController<CategoriesLogic>
    {

        [HttpPost]
        public ResponseModel GetCategories()
        {
            return Logic.GetCategories();
        } 
        [HttpPost]
        public ResponseModel GetCategorySpecification(IdRequest model)
        {
            return Logic.GetCategorySpecification(model.Id);
        }
    }
}