using Shopping.Core.Areas.ShopPage.Controllers.BaseControllers;
using Shopping.Core.Areas.ShopPage.Controllers.Logic;
using Shopping.Core.Areas.ShopPage.Models.Mappers.ProductsRequests;
using Shopping.Core.Models.HelperModels;
using System.Web.Http;

namespace Shopping.Core.Areas.ShopPage.Controllers.ApiControllers
{
    public class ProductsController : ApiLogicBaseController<ProductsLogic>
    {
        [HttpPost]
        public ResponseModel GetProducts()
        {
            return Logic.GetProducts();
        }

        [HttpPost]
        public ResponseModel GetProductsByCategory(IdRequest model)
        {
            return Logic.GetProductsByCategory(model.Id);
        }
        [HttpPost]
        public ResponseModel SortProducts(SortRequest model)
        {
            return Logic.SortProducts(model);
        }



    }
}
