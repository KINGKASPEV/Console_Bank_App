using DeroyalBank.Core;

namespace DeroyalBankTesting.CreateAccountTest
{

    public class EmailValidationTests
    {
        [Theory]
        [InlineData("valid.email@example.com", true)]
        [InlineData("invalid-email-example.com", false)]
        [InlineData("another.invalid@.com", false)]
        [InlineData("no_at_symbol.com", false)]
        [InlineData("missingdot@com", false)]
        public void IsValidEmail_ValidatesEmail(string email, bool expectedIsValid)
        {
            // Arrange

            // Act
            bool isValid = CreateAccount.IsValidEmail(email);

            // Assert
            Assert.Equal(expectedIsValid, isValid);
        }

    }
}


