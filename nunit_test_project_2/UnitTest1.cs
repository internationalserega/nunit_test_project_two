using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://github.com/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='↵'])[8]/following::ya-tr-span[1]")).Click();
            driver.FindElement(By.Id("login_field")).Clear();
            driver.FindElement(By.Id("login_field")).SendKeys("internationalserega");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("Z21nonStop21Z");
            driver.FindElement(By.Id("login_field")).Click();
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Name("commit")).Click();
            driver.FindElement(By.XPath("//div[@id='repos-container']/h2/a/ya-tr-span")).Click();
            driver.FindElement(By.Id("repository_name")).Click();
            driver.FindElement(By.Id("repository_name")).Clear();
            driver.FindElement(By.Id("repository_name")).SendKeys("internationalserega/unit_test_c_sharp_two");
            driver.FindElement(By.Id("repository_auto_init")).Click();
            driver.FindElement(By.XPath("//body")).Click();
            driver.FindElement(By.XPath("//form[@id='new_repository']/div[4]/button/ya-tr-span")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}