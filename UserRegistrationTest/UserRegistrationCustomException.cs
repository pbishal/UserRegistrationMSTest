using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationTest
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME
        }

        /// <summary>
        /// Created a type variable of Type ExceptionType
        /// </summary>
        ExceptionType type;
        readonly string message;

        /// <summary>
        /// Parameterised constructor 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}