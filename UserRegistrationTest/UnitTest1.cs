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
            int expected = 1;
            string name = "Jebakani";
            //act
            int actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestFirstName2()
        {
            //Assign
            int expected = 0;
            string name = "jeb7kani";
            //act
            int actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastName1()
        {
            //Assign
            int expected = 1;
            string name = "Ishwarya";
            //act
            int actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestLastName2()
        {
            //Assign
            int expected = 1;
            string name = "ishw7arya";
            //act
            int actual = userRegistration.CheckName(name);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCategory("Email")]
        [TestMethod]
        public void EmailTest1()
        {
            //Assign
            int expected = 1;
            string emailId= "abc-100@yahoo.com";
            //act
            int actual = userRegistration.EmailCheck(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void EmailTest2()
        {
            //Assign
            int expected = 0;
            string emailId = "vji-shwar@ya@gmail.com";
            //act
            int actual = userRegistration.EmailCheck(emailId);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCategory("Moblie number validation")]
        [TestMethod]
        public void MobileTest1()
        {
            //Assign
            int expected = 1;
            string mobileNo = "91 7373377956";
            //act
            int actual = userRegistration.MobileNumberCheck(mobileNo);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void MobileTest2()
        {
            //Assign
            int expected = 0;
            string mobileNo = "919826737645";
            //act
            int actual = userRegistration.MobileNumberCheck(mobileNo);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest1()
        {
            //Assign
            int expected = 1;
            string password = "Chan@748292";
            //act
            int actual = userRegistration.CheckPassword(password);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void PasswordTest2()
        {
            //Assign
            int expected = 0;
            string password = "exo*w7)9qS";
            //act
            int actual = userRegistration.CheckPassword(password);
            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}
