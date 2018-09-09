using HRD_DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Rest.Services
{
    class WorkedTimeService : Service<WorkedTime>, IWorkedTimeService
    {
        public const string NAME = "worked_times";

        public WorkedTimeService(HttpClient httpClient, Dictionary<string, string> args)
            : base(NAME, httpClient, args) { }
    }
}