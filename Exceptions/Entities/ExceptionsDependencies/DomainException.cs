using System;

namespace Exceptions.Entities.ExceptionsDependencies
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}

