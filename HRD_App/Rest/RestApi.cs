using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Rest
{
    public class RestApi
    {
        private const string SESSION = "session";
        private const string BASE_URL = "http://localhost:54536/api/";
        private static HttpClient httpClient;

        public static IAccountService AccountService
        {
            get { return new AccountService(httpClient); }
        }
        public static IDepartmentService DepartmentService
        {
            get { return new DepartmentService(httpClient); }
        }

        static RestApi()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BASE_URL);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static void SetSession(string sessionId)
        {
            if (httpClient == null || sessionId == null) return;

            HttpRequestHeaders headers = httpClient.DefaultRequestHeaders;
            if (headers.Contains(SESSION)) headers.Remove(SESSION);

            headers.Add(SESSION, sessionId);
        }
    }
}
