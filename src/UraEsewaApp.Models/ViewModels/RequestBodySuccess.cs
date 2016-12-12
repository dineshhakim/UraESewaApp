using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UraEsewaApp.Models.ViewModels
{
    public class RequestBodySuccess
    {
        public string token { get; set; }
        public string code { get; set; }
        public string message { get; set; }
        public string reference_id { get; set; }
        public string amount { get; set; }
        public Properties properties { get; set; }
    }
}
