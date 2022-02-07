using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private string baseURL;
       

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
        }

        [TearDown]
        public void TeardownTest()
        {
            {
                driver.Quit();
            }
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='↵'])[8]/following::ya-tr-span[1]")).Click();//пееходим на старницу аторизации
            driver.FindElement(By.Id("login_field")).SendKeys("internationalserega");//вводим логин
            driver.FindElement(By.Id("password")).SendKeys("Z21nonStop21Z");//вводим пароль
            driver.FindElement(By.Name("commit")).Click();//авторизуемся на кнопку 
            driver.FindElement(By.XPath("//div[@id='repos-container']/ul/li[3]/div/div/a/ya-tr-span[2]")).Click();//нажимаем на тестовый репозиторий
            driver.FindElement(By.XPath("//a[@id='settings-tab']/span/ya-tr-span")).Click();
            driver.FindElement(By.Id("tr-popup")).Click();
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/summary/ya-tr-span")).Click();
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/p[2]/strong/ya-tr-span")).Click();
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/form/p/input")).Click();
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/form/p/input")).SendKeys("internationalserega/unit_test_c_sharp_TESSTOVI");//вставляем в поле скопированнное название репозитория
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/form/button/span/ya-tr-span")).Click();//потверждение удаление репозитория
        }
    }
}
