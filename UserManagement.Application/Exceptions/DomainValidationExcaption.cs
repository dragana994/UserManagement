using System;

namespace UserManagement.Application.Exceptions
{
    public class DomainValidationException : Exception
    {
        public DomainValidationException(string message) : base(message)
        {
        }
    }
}