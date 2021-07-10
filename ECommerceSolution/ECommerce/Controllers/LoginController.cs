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
    public class LoginController : ApiController
    {
        HOMENEEDSEntities1 entities = new HOMENEEDSEntities1();
        [HttpPost]
        public HttpResponseMessage Register(tblCustomer customer)
        {
            var result = entities.uspCheckUserAlreadyRegistered(customer.Email_Address, customer.Phone_Number);
            if (result != null)
            {
                result = entities.uspLogin(customer.Email_Address, customer.Phone_Number, customer.Password);
                
            }
            return Request.CreateResponse(result);
        }
    }
}
