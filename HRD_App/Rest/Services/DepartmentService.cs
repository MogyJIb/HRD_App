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
    public class DepartmentService : Service<Department>, IDepartmentService
    {
        public const string NAME = "departments";

        public DepartmentService(HttpClient httpClient, Dictionary<string, string> args) 
            : base(NAME, httpClient, args) { }
    }
}