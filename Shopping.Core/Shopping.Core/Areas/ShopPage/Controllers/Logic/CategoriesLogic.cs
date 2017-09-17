using Shopping.Core.Areas.ShopPage.Controllers.BaseControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shopping.Core.Models;
using Shopping.Core.Models.HelperModels;
using System.Data.Entity;
using System.Collections;
using Syncfusion.JavaScript.Shared.Serializer;
using System.Web.Script.Serialization;

namespace Shopping.Core.Areas.ShopPage.Controllers.Logic
{
    public class CategoriesLogic : LogicBase
    {
        public CategoriesLogic(ShopEntities db) : base(db)
        {
        }

        public ResponseModel GetCategories()
        {
            var response = new ResponseModel();
            try
            {
                response.Data = Database.Categories.ToList();
            }
            catch (Exception error)
            {
                return response.SetErrors(error);
            }
            response.Success = true;
            return response;
        }

        public ResponseModel GetCategorySpecification(long idOfCategory)
        {
            var response = new ResponseModel();
            try
            {
                response.Data = Database.Specifications.Where(x => x.Category.Id == idOfCategory).ToList();
            }
            catch (Exception error)
            {
                return response.SetErrors(error);
            }
            response.Success = true;
            return response;

        }

    }
}