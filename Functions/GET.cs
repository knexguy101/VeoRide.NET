using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace VeoRide.NET.Functions
{
    class GET
    {
        public static HttpResponseMessage SMSCode(VeoRideClient Client, string SMS)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://manhattan-host.veoride.com:8444/api/auth/customers/{SMS}/verification_code");
            request.Headers.TryAddWithoutValidation("accept", "*/*");
            request.Headers.TryAddWithoutValidation("content-type", "application/json");
            request.Headers.TryAddWithoutValidation("connection", "keep-alive");
            request.Headers.TryAddWithoutValidation("accept-language", "en-us");
            request.Headers.TryAddWithoutValidation("accept-encoding", "br, gzip, deflate");
            request.Headers.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_1 like Mac OS X) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1");
            request.Headers.TryAddWithoutValidation("host", "manhattan-host.veoride.com:8444");
            return Client.GetResponse(request);
        }

        public static HttpResponseMessage RideLocations(VeoRideClient Client, Models.Coordinate Coordinate)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://manhattan-host.veoride.com:8444/api/v2/customers/vehicles?lat={Coordinate.Lat}&lng={Coordinate.Long}");
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

        public static HttpResponseMessage Me(VeoRideClient Client)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://manhattan-host.veoride.com:8444/api/customers/me");
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

        public static HttpResponseMessage Payments(VeoRideClient Client)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://manhattan-host.veoride.com:8444/api/customers/payments");
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

        public static HttpResponseMessage Balance(VeoRideClient Client)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://manhattan-host.veoride.com:8444/api/customers/me/balance");
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

        public static HttpResponseMessage InviteCode(VeoRideClient Client)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://manhattan-host.veoride.com:8444/api/customers/me/invite/code");
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

        public static HttpResponseMessage Membership(VeoRideClient Client)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://manhattan-host.veoride.com:8444/api/customers/membership/current");
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

        public static HttpResponseMessage ValidBikeID(VeoRideClient Client, string ID)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://manhattan-host.veoride.com:8444/api/customers/vehicles/{ID}");
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
