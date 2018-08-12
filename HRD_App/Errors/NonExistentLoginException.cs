using HRD_DataLibrary.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_App.Errors
{
    class NonExistentLoginException : ApiException
    {
        public NonExistentLoginException(ErrorType errorType) : base(errorType) { }

        public override string Message => "Такого логина не существует";
    }
}