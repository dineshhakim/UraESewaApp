using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using UraEsewaApp.API.Helpers;
using UraEsewaApp.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UraEsewaApp.API.Controllers
{
    
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get([FromBody]RequestBody request)
        {
            var tokenhelper = new JWTTokenHelper();
            var token = tokenhelper.CreateToken("Nesdo", "nepal", "Abc");
            return token;
        }
        //   [Authorize(Policy = "AlwaysFail")]
        // POST api/values
        [HttpPost]        
        public string Post([FromBody]RequestBody request)
        {
            var tokenhelper = new JWTTokenHelper();
            var token = tokenhelper.CreateToken("Nesdo", "nepal", "Abc");
            return token;
        }

        [HttpPost("validate")]
        //[Route("~/payment/validate")]
        public string Validate([FromBody]RequestBody request)
        {
            var tokenhelper = new JWTTokenHelper();
            var token = tokenhelper.CreateToken("Nesdo", "nepal", "Abc");
            return token;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
