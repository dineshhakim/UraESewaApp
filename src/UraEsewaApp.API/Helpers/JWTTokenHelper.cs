using Jose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UraEsewaApp.API.Helpers
{
    public class JWTTokenHelper
    {
        private long ToUnixTime(DateTime dateTime)
        {
            return (int)(dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }


        //{"iss", "YOUR_AUTH0_DOMAIN"},
        //{"aud", "YOUR_CLIENT_ID"},
        //{"sub", "anonymous"},

        public string CreateToken(string iss, string aud, string sub)
        {
            //Store Key somewhere safe and get it from there
            var secretKey = Encoding.ASCII.GetBytes("aspnet-WebApp1-c23d27a4-eb88-4b18-9b77-2a93f3b15119");
            DateTime issued = DateTime.Now;
            DateTime expire = DateTime.Now.AddMinutes(10);

            var payload = new Dictionary<string, object>()
                {
                    {"iss", iss},
                    {"aud", aud},
                    {"sub", sub},
                    {"iat", ToUnixTime(issued).ToString()},
                    {"exp", ToUnixTime(expire).ToString()}
                };

            string token = JWT.Encode(payload, secretKey, JwsAlgorithm.HS256);
            return token;
        }


    }
}
