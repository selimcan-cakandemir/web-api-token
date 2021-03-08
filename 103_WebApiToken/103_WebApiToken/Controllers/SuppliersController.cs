using _103_WebApiToken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _103_WebApiToken.Controllers
{
    [Authorize]
    public class SuppliersController : ApiController
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        public IHttpActionResult GetSuppliers()
        {
            return Ok(db.Suppliers.ToList());
        }
    }
}
