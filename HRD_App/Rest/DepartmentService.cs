using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HRD_DataLibrary.Models;

namespace HRD_App.Rest
{
    class DepartmentService:IDepartmentService
    {
        private const string NAME = "departments";
        private HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Department>> GetDepartments()
        {
           
            List<Department> departments = new List<Department>();
            HttpResponseMessage response = await httpClient.GetAsync(NAME);

            //log
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Content.ToString());

            if (response.IsSuccessStatusCode)
            {
                departments = await response.Content.ReadAsAsync<List<Department>>();
            }
            return departments;
        }
    }
}