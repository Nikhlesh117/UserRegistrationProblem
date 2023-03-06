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
        [TestMethod]
        public void GivenUserFistName_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                string firstName = "Nikh";

                bool FirstName = regexValidation.FirstName(firstName);
            }
            catch (ValidateException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);

            }
        }

        [TestMethod]
        public void GivenUserLastName_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                string lastName = "Rao";

                bool LastName = regexValidation.LastName(lastName);
            }
            catch (ValidateException e)
            {

                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmailId_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                string email = "Rao.Nikh.com";

                bool Email = regexValidation.Email(email);
            }
            catch (ValidateException e)
            {
                Assert.AreEqual("Invalid Email", e.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                string number = "91 0863053941";

                bool PhoneNumber = regexValidation.Mobile(number);

            }
            catch (ValidateException e)
            {
                Assert.AreEqual("Invalid Phone Number", e.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                string password = "Nikoo1r@q";

                bool Password = regexValidation.PasswordR4(password);

            }
            catch (ValidateException e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }
    }
}