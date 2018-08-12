using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRD_DataLibrary.Models;
using HRD_DataLibrary.General;

namespace HRD_App.Rest
{
    interface IAccountService
    {
        Task<AuthSession> Login(Account account);
    }
}
