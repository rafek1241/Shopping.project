﻿using Shopping.Core.Areas.ShopPage.Controllers.BaseControllers;
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
        public CategoriesLogic(ShopEntites db) : base(db)
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
                response.Errors = error.Message;
                response.Success = false;
                return response;
            }
            response.Success = true;
            return response;
        }

    }
}