using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpression;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        UserRegistration userRegistration;
        [TestInitialize]
        public void TestSetup()
        {
            userRegistration = new RegularExpression.UserRegistration();
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
    }
}
