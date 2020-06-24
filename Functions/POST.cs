using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace VeoRide.NET.Functions
{
    class POST
    {
        public static HttpResponseMessage VerifyCode(VeoRideClient Client, string SMSCode, string SMS, string AppVersion = "3.4.0", string PhoneType = "iPhone XR")
        {
            JObject temp = new JObject()
            {
                {"code", SMSCode },
                {"phone", SMS },
                {"appVersion", AppVersion },
                {"phoneModel", PhoneType }
            };
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"https://manhattan-host.veoride.com:8444/api/auth/customers/verify_code");
            request.Content = new StringContent(temp.ToString(), Encoding.UTF8, "application/json");
            request.Headers.TryAddWithoutValidation("accept", "*/*");
            request.Headers.TryAddWithoutValidation("content-type", "application/json");
            request.Headers.TryAddWithoutValidation("connection", "keep-alive");
            request.Headers.TryAddWithoutValidation("accept-language", "en-us");
            request.Headers.TryAddWithoutValidation("accept-encoding", "br, gzip, deflate");
            request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_1 like Mac OS X) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1");
            request.Headers.TryAddWithoutValidation("host", "manhattan-host.veoride.com:8444");
            request.Headers.TryAddWithoutValidation("authorization", "Bearer " + Client.GetAuthToken());
            return Client.GetResponse(request);
        }
    }
}
