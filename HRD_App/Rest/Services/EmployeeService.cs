using HRD_DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Rest.Services
{
    class EmployeeService : Service<Employee>, IEmployeeService
    {
        public const string NAME = "employees";

        public EmployeeService(HttpClient httpClient, Dictionary<string, string> args)
            : base(NAME, httpClient, args) { }
    }
}