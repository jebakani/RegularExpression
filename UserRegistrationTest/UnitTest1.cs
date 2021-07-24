using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpression;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        UserRegistration userRegistration;
        UserRegistrationAnnotation user;
        [TestInitialize]
        public void TestSetup()
        {
            userRegistration = new RegularExpression.UserRegistration();
            user = new UserRegistrationAnnotation();
        }
        [TestCategory("NameTest")]
        [TestMethod]
        public void TestFirstName1()
        {
            //Assign
            string expected = "1";
            string name = "Jebakani";
            //act
            string actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestFirstName2()
        {
            //Assign
            string expected = "0";
            string name = "jeb7kani";
            //act
            string actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestFirstNameException()
        {
            //Assign
            string expected = "Name should not be empty";
            string name = "";
            try
            {
                //act
                string actual = userRegistration.CheckName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomeException e)
            {
                //assert
                Assert.AreEqual(e.Message, expected);
            }
        }
        [TestMethod]
        public void TestLastName1()
        {
            //Assign
            string expected = "1";
            string name = "Ishwarya";
            //act
            string actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastName2()
        {
            //Assign
            string expected = "1";
            string name = "ishw7arya";
            //act
            string actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastNameException()
        {
            //Assign
            string expected = "Name should not be null";
            string name = null;
            try
            {
                //act
                string actual = userRegistration.CheckName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomeException e)
            {
                //assert
                Assert.AreEqual(e.Message, expected);
            }
        }
        [TestCategory("Email")]
        [TestMethod]
        public void EmailTest1()
        {
            //Assign
            string expected = "1";
            string emailId= "abc-100@yahoo.com";
            //act
            string actual = userRegistration.EmailCheck(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailTest2()
        {
            //Assign
            string expected = "0";
            string emailId = "vji-shwar@ya@gmail.com";
            //act
            string actual = userRegistration.EmailCheck(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailExceptionTest()
        {
            //Assign
            string expected = "Email should not be null";
            string emailId = null;
            //act
            string actual = userRegistration.EmailCheck(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCategory("Moblie number validation")]
        [TestMethod]
        public void MobileTest1()
        {
            //Assign
            string expected = "1";
            string mobileNo = "91 7373377956";
            //act
            string actual = userRegistration.MobileNumberCheck(mobileNo);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void MobileTest2()
        {
            //Assign
            string expected = "0";
            string mobileNo = "919826737645";
            //act
            string actual = userRegistration.MobileNumberCheck(mobileNo);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest1()
        {
            //Assign
            string expected = "1";
            string password = "Chan@748292";
            //act
            string actual = userRegistration.CheckPassword(password);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest2()
        {
            //Assign
            string expected = "0";
            string password = "exo*w7)9qS";
            //act
            string actual = userRegistration.CheckPassword(password);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordExceptionTest()
        {
            //Assign
            string expected = "Password should not be empty";
            string password = "";
            //act
            try
            {
                string actual = userRegistration.CheckPassword(password);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomeException ce)
            {
                //assert
                Assert.AreEqual(ce.Message, expected);
            }
        }
        /// <summary>
        /// Checks for validation using annotation
         /// </summary>
        [TestMethod]
        public void CheckForValidation()
        {
            user.firstName = "Jebakani";
            user.lastName = "Ishwarya";
            user.phoneNumber = "9908735627";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "Satisfied all the validation";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation using annotation = if name is not valid 
        /// </summary>
        [TestMethod]
        public void CheckForValidation1()
        {
            user.firstName = "je";
            user.lastName = "Ishwarya";
            user.phoneNumber = "9908735627";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "First Name should be min of 3";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation using annotation = if phone number not valid
        /// </summary>
        [TestMethod]
        public void CheckForValidation2()
        {
            user.firstName = "Jebakani";
            user.lastName = "Ishwarya";
            user.phoneNumber = "99087356";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "Phone number should exactly 10";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation and return happy if validation is true
        /// </summary>
        [TestMethod]
        public void CheckValidityAndReturnHappy()
        {
            user.firstName = "Jebakani";
            user.lastName = "Ishwarya";
            user.phoneNumber = "9908735632";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "Happy";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation and return sad if validation is false
        /// </summary>
        [TestMethod]
        public void CheckValidityAndReturnSad()
        {
            user.firstName = "Jebakani";
            user.lastName = "Ishwarya";
            user.phoneNumber = "99087356";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "Sad";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //data row attribute used to pass input to the test method
        //it passes the parameter to the test method 
        [DataRow("abc@gmail.com","1")]
        [DataRow("abc-.gail.com","0")]
        [DataRow("abcdf2.com","1")]
        [DataRow("abc+h@tvs.com","1")]
        //method to run multiple test cases
        public void TestParameterizeTest(string eMail,string expected)
        {
            string actual = userRegistration.EmailCheck(eMail);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation of the data using custom exception
        /// </summary>
        [TestMethod]
        public void CheckValidityUsingCustomException()
        {
            user.firstName = "Jebakani";
            user.lastName = "Ishwarya";
            user.phoneNumber = "99087356";
            user.EmailAddress = "abc@gmail.com";
            user.Password = "Exo@chanbaek21";
            string expected = "Phone number Should be 10 digit";
            string actual = UserRegistration.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }


    }
}
