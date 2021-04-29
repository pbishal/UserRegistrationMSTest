using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationTest
{
    public class Patterns
    {
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{3,}$";
        public static string REGEX_LASTNAME = "^[A-Z][a-z]{3,}$";
        //public static string REGEX_MOBILENUMBER = "^[0-9]{2}[ ][0-9]{10}$";

        //Validatinf first name, last name , email id, mobile number and password.
        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, REGEX_FIRSTNAME) ? "Valid First Name" :
           throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");

        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, REGEX_FIRSTNAME) ? "Valid last Name" :
           throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_LASTNAME, "Invalid last Name");

        //public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, REGEX_MOBILENUMBER) ? "Valid last Name" :
        //   throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_MOBILENUMBER, "Invalid mobile number");

    }
}
