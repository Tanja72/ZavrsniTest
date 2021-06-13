using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using KonacniTest.Lib;

namespace KonacniTest.PageObjects
{
    class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver) { }

        private IWebElement inputFirstName
        {
            get
            {
                return this.WaitForElementToBeVisible(By.Name("ime"));
            }
        }

        private IWebElement inputLastName
        {
            get
            {
                return this.WaitForElementToBeVisible(By.Name("prezime"));
            }
        }

        private IWebElement inputEmail
        {
            get
            {
                return this.WaitForElementToBeVisible(By.Name("email"));
            }
        }

        private IWebElement inputUsername
        {
            get
            {
                return this.WaitForElementToBeVisible(By.Name("korisnicko"));
            }
        }

        private IWebElement inputPassword
        {
            get
            {
                return this.WaitForElementToBeVisible(By.Name("lozinka"));
            }
        }

        private IWebElement inputPasswordRepeat
        {
            get
            {
                return this.WaitForElementToBeVisible(By.Name("lozinkaOpet"));
            }
        }

        private IWebElement buttonRegister
        {
            get
            {
                return this.WaitForElementToBeVisible(By.Name("register"));
            }
        }

        public void EnterFirstName(string FirstName)
        {
            this.inputFirstName.SendKeys(FirstName);
        }

        public void EnterLastName(string LastName)
        {
            this.inputLastName.SendKeys(LastName);
        }

        public void EnterUsername(string Username)
        {
            this.inputUsername.SendKeys(Username);
        }

        public void EnterEmail(string Email)
        {
            this.inputEmail.SendKeys(Email);
        }

        public void EnterPassword(string Password)
        {
            this.inputPassword.SendKeys(Password);
        }

        public void EnterPasswordAgain(string PasswordAgain)
        {
            this.inputPasswordRepeat.SendKeys(PasswordAgain);
        }

        public HomePage ClickOnRegisterButton()
        {
            this.buttonRegister.Click();
            this.ExplicitWait(250);
            return new HomePage(this.driver);
        }

    }
    
}
