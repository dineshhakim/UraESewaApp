using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UraEsewaApp.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UraEsewaApp.API.Controllers
{
    [Route("[controller]")]
    public class TransactionController : Controller
    {
      
        // POST api/values
        [HttpPost]
        public void Post([FromBody]RequestBodySuccess value)
        {

        }
 
    }
}
