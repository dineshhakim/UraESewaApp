using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UraEsewaApp.Models.ViewModels
{
    public class RequestBody
    {
        public string token { get; set; }
        public string valid { get; set; }
        public string amount { get; set; }
        public Properties properties { get; set; }
    }
}
