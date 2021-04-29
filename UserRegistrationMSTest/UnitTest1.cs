using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTest;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Patterns patterns;

        public UnitTest1()
        {
            patterns = new Patterns();
        }

        /// <summary>
        /// Validate first name
        /// </summary>
        [TestMethod]
        [DataRow("Bishal")]
        [DataRow("Omprakash")]
        [DataRow("Sanju")]
        [DataRow("Himanshu")]
        [DataRow("Vishal")]
        [DataRow("Priyanshu")]
        [DataRow("Ankita")]
        [DataRow("Nilima")]
        [DataRow("Arjun")]
        public void GivenFirstName_ShouldReturnTrue_IfFirstLettersIsCapital(string name)
        {
            try
            {
                string result = patterns.ValidateFirstName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Valid First Name", e.Message);
            }
        }

        /// <summary>
        /// If entered Invalid last name should return false.
        /// </summary>
        [TestMethod]
        [DataRow("bishal")]
        [DataRow("shailesh")]
        [DataRow("prateek")]
        [DataRow("himanshu")]
        [DataRow("shubham")]
        [DataRow("niraj")]
        [DataRow("prabhat")]
        public void GivenFirstName_ShouldReturnFalse_FirstNameIsNotStartWith_CapitalLetter(string invalidFirstName)
        {
            try
            {
                string result = patterns.ValidateFirstName(invalidFirstName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        [DataRow("BISHAL")]
        [DataRow("NIKU")]
        [DataRow("SHAILESH")]
        [DataRow("HIMANSHU")]
        [DataRow("SHUBHAM")]
        [DataRow("SANJU")]
        public void GivenFirstName_ShouldReturnFalse_IfAllLettersAreInCapital(string invalidFirstName)
        {
            try
            {
                string result = patterns.ValidateFirstName(invalidFirstName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

        /// <summary>
        /// Validate first name
        /// </summary>
        [TestMethod]
        [DataRow("Pradhan")]
        [DataRow("Satapathy")]
        [DataRow("Sash")]
        [DataRow("Kumar")]
        [DataRow("Gupta")]
        [DataRow("Jaiswal")]
        public void GivenLastName_ShouldReturnTrue_IfFirstLettersIsCapital(string name)
        {
            try
            {
                string result = patterns.ValidateFirstName(name);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Valid First Name", e.Message);
            }
        }

        /// <summary>
        /// If entered Invalid last name should return false.
        /// </summary>
        [TestMethod]
        [DataRow("pradhan")]
        [DataRow("satapathy")]
        [DataRow("dash")]
        [DataRow("kumar")]
        [DataRow("gupta")]
        [DataRow("jaiswal")]
        public void GivenLastName_ShouldReturnFalse_FirstNameIsNotStartWith_CapitalLetter(string invalidFirstName)
        {
            try
            {
                string result = patterns.ValidateFirstName(invalidFirstName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [TestMethod]
        [DataRow("PRADHAN")]
        [DataRow("SATAPATHY")]
        [DataRow("DASH")]
        [DataRow("KUMAR")]
        [DataRow("GUPTA")]
        [DataRow("JAISWAL")]
        public void GivenLastName_ShouldReturnFalse_IfAllLettersAreInCapital(string invalidFirstName)
        {
            try
            {
                string result = patterns.ValidateFirstName(invalidFirstName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }

        }
    }
}
