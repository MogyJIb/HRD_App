using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRD_DataLibrary.Errors;

namespace HRD_App.Errors
{
    public class ApiException : Exception
    {
        public ErrorType ErrorType { get; }

        public ApiException(ErrorType errorType) : base() { ErrorType = errorType; }
        
        public override string Message => "Default API exception";

        public static ApiException Create(ErrorType errorType)
        {
            switch(errorType)
            {
                case ErrorType.WrongPassword:
                    return new WrongPasswordException(errorType);
                case ErrorType.NonExistentLogin:
                    return new NonExistentLoginException(errorType);
                case ErrorType.AuthanticationFaild:
                    return new AuthanticationFaildException(errorType);
                default:
                    return new ApiException(errorType);
            }
        }
    }
}