using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HRD_App.Errors;
using HRD_DataLibrary.Errors;
using HRD_DataLibrary.Models;
using HRD_DataLibrary.General;
using Newtonsoft.Json;

namespace HRD_App.Rest
{
    public class AccountService : IAccountService
    {
        private const string NAME = "accounts";
        private HttpClient httpClient;

        public AccountService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<AuthSession> Login(Account account)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync<Account>(NAME + "\\login", account);
            if (response.IsSuccessStatusCode)
            {
                string authSessionJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AuthSession>(authSessionJson);
            }
            else
            {
                ErrorType errorType = await response.Content.ReadAsAsync<ErrorType>();
                throw ApiException.Create(errorType);
            }
        }
    }
}