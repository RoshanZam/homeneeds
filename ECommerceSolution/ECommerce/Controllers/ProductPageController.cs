using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("ProductPage")]
    public class ProductPageController : ApiController
    {
        HOMENEEDSEntities1 entities = new HOMENEEDSEntities1();

        [Route("GetAllProducts")]
        [HttpGet]
        public HttpResponseMessage GetAllProducts()
        {
            var result = entities.uspGetAllProducts();
            return Request.CreateResponse(result);
        }

        [Route("GetProductsForCategory")]
        [HttpGet]
        public HttpResponseMessage GetProductsForCategory(tblCategory category)
        {
            var result = entities.uspGetAllProductsBasedOnCategory(category.Category_ID);
            return Request.CreateResponse(result);
        }

        [Route("AddToCart")]
        [HttpPut]
        public HttpResponseMessage AddToCart(tblCart cart)
        {
            var result = entities.uspAddtoCart(cart.Product_ID, cart.Customer_ID, cart.Quantity);
            return Request.CreateResponse(result);
        }

        [Route("DeleteFromCartUsingProductId")]
        [HttpPut]
        public HttpResponseMessage DeleteFromCartUsingProductId(tblCart cart)
        {
            var result = entities.uspDeleteFromCartUsingProductId(cart.Product_ID);
            return Request.CreateResponse(result);
        }

        [Route("DeleteFromCartUsingCustomerId")]
        [HttpPut]
        public HttpResponseMessage DeleteFromCartUsingCustomerId(tblCart cart)
        {
            var result = entities.uspDeleteFromCartUsingProductId(cart.Customer_ID);
            return Request.CreateResponse(result);
        }
    }
}
