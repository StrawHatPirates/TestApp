using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    public class SubtractController : ApiController
    {
        [Route ("api/subtract")]
        [HttpGet]
        public double Subtract(double x,double y)
        {
            return (x - y);
        }
    }
}
