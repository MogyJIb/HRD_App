using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Rest
{
    class RestApi
    {
        private const string BASE_URL = "http://localhost:54536/api/";
        private HttpClient httpClient;

        public RestApi()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BASE_URL);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public IDepartmentService DepartmentService()
        {
            return new DepartmentService(httpClient);
        }
    }
}
