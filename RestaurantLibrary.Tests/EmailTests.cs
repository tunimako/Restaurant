using RestaurantLibrary.Repositories;
using System.Windows.Forms;
using Xunit;

namespace RestaurantLibrary.Tests
{
    public class EmailTests
    {
        [Theory]
        [InlineData("email@gmail.com")]
        [InlineData("email@yahoo.com")]
        [InlineData("email@hotmail.com")]
        [InlineData("email@msn.com")]
        public void EmailCheck_ConfirmsThatEmailIsNotValid(string email)
        {
            //Act
            var textBox = new TextBox();
            var lable = new Label();
            textBox.Text = email;
            bool actual = Email.EmailCheck(textBox, lable);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("emailgmail.com")]
        [InlineData("email@yhoo.com")]
        [InlineData("")]
        public void EmailCheck_ConfirmsThatEmailIsValid(string email)
        {
            //Act
            var textBox = new TextBox();
            var lable = new Label();
            textBox.Text = email;   
            bool actual = Email.EmailCheck(textBox, lable);

            //Assert
            Assert.False(actual);
        }
    }
}
