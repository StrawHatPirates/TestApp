using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    public class DivideController : ApiController
    {
        [Route("api/divide")]
        [HttpGet]
        public double Divide(double x,double y)
        {
            if(y == 0)
            {
                return -1;
            }else
            {
                return (x / y);
            }
        }
    }
}
