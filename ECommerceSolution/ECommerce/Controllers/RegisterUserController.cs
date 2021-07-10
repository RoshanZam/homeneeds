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
    public class RegisterUserController : ApiController
    {
        HOMENEEDSEntities1 entities = new HOMENEEDSEntities1();
        [HttpPost]
        public HttpResponseMessage Register(tblCustomer customer)
        {
            int? result = null;
            result = entities.uspCheckUserAlreadyRegistered(customer.Email_Address, customer.Phone_Number).FirstOrDefault();
            if(result == null)
            {
                entities.tblCustomers.Add(customer);
                entities.SaveChanges();
            }
            else
            {
                return Request.CreateResponse("Employee already exists");
            }
            return Request.CreateResponse("Rsgistered Sucessfully");
        }
    }
}
