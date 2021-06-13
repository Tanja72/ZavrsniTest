using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using KonacniTest.Lib;

namespace KonacniTest.PageObjects
{
    class HomePage: BasePage
    {

        public HomePage(IWebDriver driver) : base(driver) { }

        private IWebElement labelQAShop
        {
            get
            {
                return this.FindElement(By.XPath("//h1[text()='Quality Assurance (QA) Shop']"));
            }
        }

        private IWebElement linkLogin
        {
            get
            {
                return this.FindElement(By.LinkText("Login"));
            }
        }

        private IWebElement linkRegister
        {
            get
            {
                return this.FindElement(By.LinkText("Register"));
            }
        }

        private IWebElement linkLogout
        {
            get
            {
                return this.FindElement(By.PartialLinkText("Logout"));
            }
        }

        private IWebElement linkViewCart
        {
            get
            {
                return this.FindElement(By.LinkText("View shopping cart"));
            }
        }

        private IWebElement alertSuccess
        {
            get
            {
                return this.FindElement(
                    By.XPath("//div[contains(@class, 'success') and contains(., 'Uspeh')]")
                );
            }
        }

        public bool IsCartEmpty()
        {
            this.linkViewCart.Click();
            this.ExplicitWait(100);
            IWebElement alert = this.FindElement(
                By.XPath("//div[contains(@class, 'warning') and contains(text(), 'Your cart is empty.')]")
            );

            return alert != null;
        }

        public void GoToPage()
        {
            this.GoToURL("http://shop.qa.rs");
        }

        public bool IsUserLoggedIn()
        {
            if (this.linkLogout != null)
            {
                return this.linkLogout.Displayed;
            } else
            {
                return false;
            }
        }

        public bool IsAlertSuccessVisible()
        {
            return this.alertSuccess.Displayed;
        }

        public LoginPage ClickOnLogin()
        {
            this.linkLogin.Click();
            this.WaitForElementToBeVisible(By.XPath("//h2[text()='Prijava']"));
            this.ExplicitWait(250);
            return new LoginPage(this.driver);
        }

        public bool IsPageDisplayed()
        {
            return this.labelQAShop.Displayed;
        }

    }
}
