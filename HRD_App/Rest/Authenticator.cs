using HRD_DataLibrary.General;
using HRD_DataLibrary.Models;
using System.Threading.Tasks;

namespace HRD_App.Rest
{
    public class Authenticator
    {
        private static AuthSession session;
            
        public async static Task Login(Account account)
        {
            session = await RestApi.AccountService.Login(account);
            RestApi.SetSession(session.Id);
        }

        public static string GetSessionId()
        {
            return (session == null) ? null : session.Id;
        }
    }
}
