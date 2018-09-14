using HRD_App.Rest.Services;
using HRD_DataLibrary.Models;
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
        private static Dictionary<string, string> args = new Dictionary<string, string>();

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
            
            if (args.Keys.Contains(SESSION)) args.Remove(SESSION);

            args.Add(SESSION, sessionId);
        }

        public static IAccountService AccountService
        {
            get { return new AccountService(httpClient); }
        }

        public static IEmployeeService EmployeeService
        {
            get { return new EmployeeService(httpClient, args); }
        }

        public static IFiredEmployeeService FiredEmployeeService
        {
            get { return new FiredEmployeeService(httpClient, args); }
        }

        public static IHolidayService HolidayService
        {
            get { return new HolidayService(httpClient, args); }
        }

        public static IPositionService PositionService
        {
            get { return new PositionService(httpClient, args); }
        }

        public static IVacancyService VacancyService
        {
            get { return new VacancyService(httpClient, args); }
        }

        public static IWorkedTimeService WorkedTimeService
        {
            get { return new WorkedTimeService(httpClient, args); }
        }

        public static IDepartmentService DepartmentService
        {
            get { return new DepartmentService(httpClient, args); }
        }

        public static IResumeService ResumeService
        {
            get { return new ResumeService(httpClient, args); }
        }

        public static IRewardService RewardService
        {
            get { return new RewardService(httpClient, args); }
        }

    }
}
