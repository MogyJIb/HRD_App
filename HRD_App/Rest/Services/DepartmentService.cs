using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HRD_App.Errors;
using HRD_App.Utils;
using HRD_DataLibrary.Errors;
using HRD_DataLibrary.Models;

namespace HRD_App.Rest
{
    public class DepartmentService:IDepartmentService
    {
        private const string NAME = "departments";
        private HttpClient httpClient;
        private Dictionary<string, string> args;

        public DepartmentService(HttpClient httpClient, Dictionary<string, string> args)
        {
            this.httpClient = httpClient;
            this.args = args;
        }

        public async Task<List<Department>> GetDepartments()
        {
            HttpResponseMessage response = await httpClient.GetAsync(NAME + "?" + UrlArgsUtil.makeArgs(args));

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<Department>>();
            }
            else
            {
                ErrorType errorType = await response.Content.ReadAsAsync<ErrorType>();
                throw ApiException.Create(errorType);
            }
        }
    }
}