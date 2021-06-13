using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using KonacniTest.Lib;
using System.Diagnostics;

namespace KonacniTest
{
    class SeleniumTests : BaseTest
    {

        [SetUp]
        public void SetUp()
        {
            Logger.setFileName(@"/Users/Tanja/Documents/Test/SeleniumTests.log");
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            this.wait = new WebDriverWait(this.driver, new TimeSpan(0, 0, 10));
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Close();
        }
    }
}