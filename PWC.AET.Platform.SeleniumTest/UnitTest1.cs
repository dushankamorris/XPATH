using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PWC.AET.Platform.SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("Tampa");
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@name='btnK']")).Click();
            //validate
            Assert.IsTrue(driver.FindElements(By.XPath("//h3")).Count > 0,"There were no links");
        }


        [TestInitialize]
        public void Preconditioon()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Postcondition()
        {
            driver.Close();
        }
    }
}
