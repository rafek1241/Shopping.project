using Shopping.Core.Areas.ShopPage.Controllers.BaseControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shopping.Core.Models.HelperModels;
using Shopping.Core.Areas.ShopPage.Models.Mappers.ProductsRequests;
using Shopping.Core.Models;

namespace Shopping.Core.Areas.ShopPage.Controllers.Logic
{
    public class ProductsLogic : LogicBase
    {
        public ProductsLogic(ShopEntities db) : base(db)
        {
        }
        internal ResponseModel GetProducts()
        {
            var response = new ResponseModel();

            try
            {
                response.Data = Database.Products.ToList();
                response.Success = true;
            }
            catch (Exception err)
            {
                response.SetErrors(err);
            }
            return response;
        }

        internal ResponseModel GetProducts(long id)
        {

            var response = new ResponseModel();

            try
            {
                response.Data = Database.Products.Single(x => x.Id == id);
                response.Success = true;
            }
            catch (Exception err)
            {
                response.SetErrors(err);
            }
            return response;
        }

        internal ResponseModel UpdateProducts(long id, Products product)
        {

            var response = new ResponseModel();

            //var validator = new ProductsValidator();
            //var result = ValidateData<Products, Validator>(product, validator); -- If true - we will go forward, if not - error.

            try
            {
                var item = Database.Products.Single(x => x.Id == id);
                product.Id = item.Id;
                Database.Products.Remove(item);
                Database.Products.Add(item);
                Database.SaveChanges();

                response.Success = true;
            }
            catch (Exception err)
            {
                response.SetErrors(err);
            }
            return response;
        }

        internal ResponseModel AddProduct(Products product)
        {

            var response = new ResponseModel();

            //var validator = new ProductsValidator();
            //var result = ValidateData<Products, Validator>(product, validator); -- If true - we will go forward, if not - error.
            try
            {
                Database.Products.Add(product);
                Database.SaveChanges();
                response.Success = true;
            }
            catch (Exception err)
            {
                response.SetErrors(err);
            }
            return response;
        }

        internal ResponseModel RemoveProduct(long id)
        {

            var response = new ResponseModel();

            try
            {
                var item = Database.Products.Find(id);
                if (item != null)
                {
                    Database.Products.Remove(item);
                    response.Success = true;
                    Database.SaveChanges();
                }
                else
                {
                    response.Success = false;
                    response.Errors = "Nie znaleziono obiektu o podanym identyfikatorze!";
                }
            }
            catch (Exception err)
            {
                response.SetErrors(err);
            }
            return response;
        }
    }
}