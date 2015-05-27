using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    public class MultiplyController : ApiController
    {
        [HttpGet]
        [Route("api/multiply")]
        public double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
