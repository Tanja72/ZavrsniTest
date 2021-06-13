using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace KonacniTest.PageObjects
{
    class BasePage
    {

        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(20));
        }

        protected WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }
        }

        protected void GoToURL(string url)
        {
            this.driver.Navigate().GoToUrl(url);
        }

        protected IWebElement WaitForElementToBeVisible(By Selector)
        {
            return this.wait.Until(EC.ElementIsVisible(Selector));
        }

        protected IWebElement WaitForElementToBeClickable(By Selector)
        {
            return this.wait.Until(EC.ElementToBeClickable(Selector));
        }

        protected IWebElement WaitForElementToExist(By Selector)
        {
            return this.wait.Until(EC.ElementExists(Selector));
        }

        protected IWebElement FindElement(By Selector)
        {
            IWebElement ReturnElement = null;
            try
            {
                ReturnElement = this.driver.FindElement(Selector);
            }
            catch (NoSuchElementException)
            {
            }

            if (ReturnElement != null)
            {
            }

            return ReturnElement;
        }

        protected void ExplicitWait(int waitTime)
        {
            System.Threading.Thread.Sleep(waitTime);
        }
    }
}
