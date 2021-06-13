using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using KonacniTest.Lib;

namespace KonacniTest.PageObjects
{
    class LoginPage: BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        private IWebElement inputUsername
        {
            get
            {
                return this.FindElement(By.Name("username"));
            }
        }

        private IWebElement inputPassword
        {
            get
            {
                return this.FindElement(By.Name("password"));
            }
        }

        private IWebElement buttonLogin
        {
            get
            {
                return this.FindElement(By.Name("login"));
            }
        }

        private IWebElement labelPrijava
        {
            get
            {
                return this.WaitForElementToBeVisible(By.XPath("//h2[text()='Prijava']"));
            }
        }

        public bool IsPageDisplayed()
        {
            return this.labelPrijava.Displayed;
        }

        public void EnterUsername(string Username)
        {
            this.inputUsername.SendKeys(Username);
        }

        public void EnterPassword(string Password)
        {
            this.inputPassword.SendKeys(Password);
        }

        public HomePage ClickOnLoginButton()
        {
            this.buttonLogin.Click();
            this.WaitForElementToBeVisible(By.XPath("//h2[contains(text(), 'Welcome back')]"));
            this.ExplicitWait(250);
            return new HomePage(this.driver);
        }
    }
}
