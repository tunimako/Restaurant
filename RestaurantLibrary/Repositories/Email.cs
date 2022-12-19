using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantLibrary.Repositories
{
    public static class Email
    {
        public static bool EmailCheck(TextBox emailText, Label errorlable)
        {
            errorlable.ForeColor = Color.Red;

            if (!IsEmailAddressNotEmpty(emailText.Text))
            {
                errorlable.Text = "Email address can't be empty.";
                return false;
            }
            else if (!IsEmailAddressContainsEta(emailText.Text))
            {
                errorlable.Text = "Email must contain @ sign.";
                return false;
            }
            else if (!EmailAddressDomainCheck(emailText.Text))
            {
                errorlable.Text = $"Unrecognized domain - {EmailAddressDomain(emailText.Text)}";
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsEmailAddressContainsEta(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool EmailAddressDomainCheck(string email)
        {
            string[] possibleEmailDomains = new string[] { "gmail.com", "yahoo.com", "hotmail.com", "msn.com"};

            if (possibleEmailDomains.Contains(EmailAddressDomain(email)))
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        private static string EmailAddressDomain(string email)
        {
            string[] splitedEmailAddress = email.Split('@');

            return splitedEmailAddress[1];
        }
        private static bool IsEmailAddressNotEmpty(string email)
        {
            if (email != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}