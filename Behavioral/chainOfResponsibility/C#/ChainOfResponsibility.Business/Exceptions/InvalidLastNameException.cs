using System;

namespace ChainOfResponsibility.Business.Exceptions
{
    public class InvalidLastNameException : Exception
    {
        public InvalidLastNameException(string lastName)
            :base($"{lastName} is invalid")
        { }
    }
}
