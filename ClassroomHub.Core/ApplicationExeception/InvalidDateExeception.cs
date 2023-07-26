using System;

namespace ClassroomHub.Core.ApplicationExeception
{
    public class InvalidDateExeception : ApplicationException
    {
        public InvalidDateExeception(string message) :base(message)
        { }
    }
}
