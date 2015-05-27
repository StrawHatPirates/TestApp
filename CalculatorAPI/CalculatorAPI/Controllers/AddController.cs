using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    public class AddController : ApiController
    {
        [Route("api/add")]
        [HttpGet]
        public double Add(double x,double y)
        {
            return (x + y);
        }
    }
}