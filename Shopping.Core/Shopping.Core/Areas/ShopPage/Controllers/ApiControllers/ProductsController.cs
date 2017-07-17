using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Shopping.Core.Models;
using Shopping.Core.Areas.ShopPage.Controllers.BaseControllers;
using Shopping.Core.Areas.ShopPage.Controllers.Logic;
using Shopping.Core.Models.HelperModels;

namespace Shopping.Core.Areas.ShopPage.Controllers.ApiControllers
{
    public class ProductsController : ApiLogicBaseController<ProductsLogic>
    {
        //private ShopEntities db = new ShopEntities();

        // GET: api/Products
        [HttpPost]
        public ResponseModel GetProducts()
        {
            return Logic.GetProducts();
        }

        // GET: api/Products/5
        public ResponseModel GetProducts(long id)
        {
            return Logic.GetProducts(id);
        }

        // PUT: api/Products/5
        public ResponseModel PutProducts(long id, Products product)
        {
            return Logic.UpdateProducts(id, product);
        }

        // POST: api/Products
        public ResponseModel PostProducts(Products product)
        {
            return Logic.AddProduct(product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Products))]
        public ResponseModel DeleteProducts(long id)
        {
            return Logic.RemoveProduct(id);
        }

    }
}