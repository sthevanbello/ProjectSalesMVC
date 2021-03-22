using System;

namespace SalesProjectMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {

        public IntegrityException(string message) : base(message) 
        { 
        }

    }
}
