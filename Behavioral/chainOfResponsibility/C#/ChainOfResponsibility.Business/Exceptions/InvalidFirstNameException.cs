using System;

namespace ChainOfResponsibility.Business.Exceptions
{
    public class InvalidFirstNameException : Exception
    {
        public InvalidFirstNameException(string firstName) 
            :base($"{firstName} is invalid")
        { }
    }
}
