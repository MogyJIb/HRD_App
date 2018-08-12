using HRD_DataLibrary.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Errors
{
    class WrongPasswordException : ApiException
    {
        public WrongPasswordException(ErrorType errorType) : base(errorType) { }

        public override string Message => "Неверный пароль";
    }
}