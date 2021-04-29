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
        public void Given_FirstName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
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
        public void GivenFirstName_IfNotStartsWithCapital_ButMinThreeCharacter_ShouldReturnFalse(string invalidFirstName)
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
        public void GivenFirstName_IfAll_LettersAreCapital_AndMinThreeCharacters_ShouldReturnFalse(string invalidFirstName)
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
