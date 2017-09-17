using Shopping.Core.Areas.ShopPage.Controllers.BaseControllers;
using System;
using System.Linq;
using Shopping.Core.Models.HelperModels;
using Shopping.Core.Models;
using System.Web;
using System.Collections.Generic;
using Shopping.Core.Areas.ShopPage.Models.Mappers.ProductsRequests;
using Shopping.Core.Models.DbModels;

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
                var results = new List<object>();
                foreach (var item in Database.Products)
                {
                    var list = new List<ProductImage>();
                    foreach (var item2 in item.Images)
                    {
                        item2.Url = VirtualPathUtility.ToAbsolute("~/") + item2.Url;
                        list.Add(item2);
                    }
                    item.Images = list;
                    results.Add(item);

                }
                response.Data = results;

                response.Success = true;
            }
            catch (Exception err)
            {
                response.SetErrors(err);
            }
            return response;
        }

        internal ResponseModel GetProductsByCategory(SortRequest model)
        {
            var response = new ResponseModel();

            try
            {
                response.Data = Database.Products.AsParallel()
       .Where(x => (model.PriceMin != null) && x.Price >= model.PriceMin)
       .Where(x => model.PriceMax != null && x.Price <= model.PriceMax)
       .OrderBy(x => model.Name != null && model.Name == true ? x.Name : null)
       .OrderByDescending(x => model.Name != null && (model.Name == false) ? x.Name : string.Empty)
       .OrderBy(x => model.Price != null && model.Price == true ? x.Price : Decimal.MinValue)
       .OrderByDescending(x => x)
       .Skip(model.PageOffset)
       .Take(model.PageSize)
       .ToList()
       ;
                response.Success = true;

            }
            catch (Exception err)
            {
                response.SetErrors(err);
            }
            return response;


        }
        internal ResponseModel GetProduct(long id)
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

        internal ResponseModel UpdateProducts(long id, Product product)
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

        internal ResponseModel AddProduct(Product product)
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