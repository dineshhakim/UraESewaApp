using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UraEsewaApp.API.Controllers
{
    [Route("[controller]")]
    public class PaymentController : Controller
    {

        // GET api/values/5
        [HttpGet("Validate/{token}")]
        public string Validate(string token)
        {
            return "value";
        }


    }
}
