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

namespace HRD_App.Rest
{
    class AccountService : IAccountService
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
                AuthSession authSession = await response.Content.ReadAsAsync<AuthSession>();
                return authSession;
            }
            else
            {
                Error error = await response.Content.ReadAsAsync<Error>();
                throw ApiException.Create(error.ErrorType);
            }
        }
    }
}