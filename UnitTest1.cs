using UserRegistration;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Validate regexValidation;

        [TestInitialize]
        public void InitValidationObj()
        {
            regexValidation = new Validate();
        }
        [TestMethod]
        public void FirstNameTest_ShouldReturnTrue()
        {
            string firstName = "Nikh";
            var FirstName = regexValidation.FirstName(firstName);
            Assert.IsTrue(FirstName);

        }
        [TestMethod]
        public void LastNameTest_ShouldReturnTrue()
        {
            string lastName = "Rao";
            var LastName = regexValidation.LastName(lastName);
            Assert.IsTrue(LastName);

        }
        [TestMethod]
        public void EmailTest_ShouldReturnTrue()
        {
            string email = "Nik.Rao@fake.co.in";
            var Email = regexValidation.Email(email);
            Assert.IsTrue(Email);

        }
        [TestMethod]
        public void PhoneNumberTest_ShouldReturnTrue()
        {
            string number = "+91 9884466221";
            var PhoneNumber = regexValidation.Mobile(number);
            Assert.IsTrue(PhoneNumber);

        }
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue()
        {
            string passW = "Nikooooo";
            var password = regexValidation.PasswordR1(passW);
            Assert.IsTrue(password);
        }
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue2()
        {
            string passW = "Nikooooo";
            var password = regexValidation.PasswordR2(passW);
            Assert.IsTrue(password);

        }
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue3()
        {
            string passW = "Nikooo2o";
            var password = regexValidation.PasswordR3(passW);
            Assert.IsTrue(password);
        }
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue4()
        {
            string passW = "NikooA1r@q";
            var password = regexValidation.PasswordR4(passW);
            Assert.IsTrue(password);
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        public void Email(string a, string expected)
        {
            Validate validate = new Validate();

            string actual = validate.Emails(a);

            Assert.AreEqual(expected, actual);
        }
    }
}