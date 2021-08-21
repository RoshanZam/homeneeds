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
    [RoutePrefix("UserProfilePage")]
    public class UserProfileController : ApiController
    {
        HOMENEEDSEntities1 entities = new HOMENEEDSEntities1();

        [Route("GetUserDetails")]
        [HttpGet]
        public HttpResponseMessage GetUserDetails(tblCustomer customer)
        {
            var result = entities.uspGetCustomerDetails(customer.Customer_ID);
            return Request.CreateResponse(result);
        }

        [Route("UpdateAddress")]
        [HttpPut]
        public HttpResponseMessage UpdateAddress(tblCustomer customer)
        {
            var result = entities.uspUpdateAddress(customer.Address,customer.Email_Address);
            return Request.CreateResponse(result);
        }


    }
}
