using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    public class InvalidFullNameException : Exception
    {
        public InvalidFullNameException(string message) : base(message) { }

        public InvalidFullNameException() : base() { }
    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }

        public InvalidAgeException() : base() { }
    }

    public class InvalidDepartmentNoException : Exception
    {
        public InvalidDepartmentNoException(string message) : base(message) { }

        public InvalidDepartmentNoException() : base() { }
    }

    public class InvalidExperienceException : Exception
    {
        public InvalidExperienceException(string message) : base(message) { }

        public InvalidExperienceException() : base() { }
    }
}
