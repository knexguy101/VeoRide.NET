using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;

namespace VeoRide.NET
{
    public class VeoRideClient
    {
        public CookieContainer CookieJar { get; set; }
        public HttpClientHandler Handler { get; set; }
        public HttpClient Client { get; set; }
        private string AuthToken = null;
        private string VerificationCode = null;

        public VeoRideClient(CancellationToken Cancellation, string SMS = "", WebProxy Proxy = null)
        {
            if (SMS != "")
            {
                SetupClient(Proxy);
                var getSMS = Functions.GET.SMSCode(this, SMS);
                var SMSData = getSMS.Content.ReadAsStringAsync().Result;
                while(!Cancellation.IsCancellationRequested)
                {
                    if(VerificationCode == null)                    
                        Thread.Sleep(250);
                    else
                    {
                        //bad idea to not check for certain jobject params but at this point you can just fix it as you like
                        //TODO check status code and check if certain items exist in content
                        var verifySMS = Functions.POST.VerifyCode(this, this.VerificationCode, SMS);
                        var VerifyData = verifySMS.Content.ReadAsStringAsync().Result;
                        JObject temp = JObject.Parse(VerifyData);
                        if(temp["msg"].Value<string>() == "Request Success")
                        {
                            AuthToken = temp["data"]["jwtAuthentication"]["accessToken"].Value<string>();
                            break;
                        }
                    }
                }
            }
        }

        public void SetVerificationCode(string Code)
        {
            this.VerificationCode = Code;
        }

        public void DisposeClient()
        {
            Client.Dispose();
            Handler.Dispose();
        }

        public string GetAuthToken()
        {
            return AuthToken;
        }

        public HttpResponseMessage GetResponse(HttpRequestMessage Request)
        {
            return Client.SendAsync(Request).Result;
        }

        public bool IsClientValid()
        {
            return AuthToken != null;
        }

        private void SetupClient(WebProxy Proxy)
        {
            this.CookieJar = new CookieContainer();
            this.Handler = new HttpClientHandler()
            {
                AllowAutoRedirect = true,
                Proxy = Proxy,
                CookieContainer = this.CookieJar
            };
            this.Client = new HttpClient(Handler);
            this.Client.DefaultRequestHeaders.ConnectionClose = false; //keep-alive
        }
    }
}
