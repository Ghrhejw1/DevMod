using Xunit.Sdk;
using Validators;

namespace MainTest
{
    [TestClass]
    public class ValidatorTests
    {
        [DataRow("username", true)]
        [DataRow("user!", false)]
        [DataRow("username123", false)]
        [DataRow(null, false)]
        [TestMethod]
        public void TestLoginValidator(string username, bool expected)
        {
            var validator = new LoginValidator();
            Assert.AreEqual(expected, validator.Validate(username));
        }



        [DynamicData(nameof(DynamicDataMethod), DynamicDataSourceType.Method)]
        [TestMethod]
        public void TestPasswordValidator(string password, bool expected)
        {
            var validator = new PasswordValidator();
            Assert.AreEqual(expected, validator.Validate(password));
        }

        public static object[][] DynamicDataMethod()
        {
            return new object[][]
            {
                new object[] { "password123", false },
                new object[] { "Password123", false },
                new object[] { "Password123!", true },
                new object[] { null, false }
            };
        }

    }
}
