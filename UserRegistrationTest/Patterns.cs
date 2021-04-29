using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationTest
{
    public class Patterns
    {
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{3,}$";

        //Validatinf first name, last name , email id, mobile number and password.
        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, REGEX_FIRSTNAME) ? "Valid First Name" :
           throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
    }
}
