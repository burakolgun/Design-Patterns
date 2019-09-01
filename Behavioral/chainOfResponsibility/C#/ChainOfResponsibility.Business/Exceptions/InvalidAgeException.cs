using System;

namespace ChainOfResponsibility.Business.Exceptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message)
            :base(message)
        { }
    }
}
