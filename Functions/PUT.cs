using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace VeoRide.NET.Functions
{
    public class PUT
    {
        public static HttpResponseMessage Location(VeoRideClient Client, Models.Coordinate Coordinate)
        {
            JObject temp = new JObject()
            {
                {"lng", Coordinate.Long },
                {"lat", Coordinate.Lat }
            };
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, $"https://manhattan-host.veoride.com:8444/api/customers/me/area");
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
