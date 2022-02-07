using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace GitRepos
{
    [TestFixture]
    public class GitRepos
    {
        private IWebDriver driver;
        private string baseURL;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseURL = "https://github.com/login";
            driver.Manage().Window.Maximize();
            
        }


        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }


        [Test]
        public void GitReposeCreate()
        {
            goToPageInGit();
            normalaizeBrowser();
            autorization(new AccountData ("internationalserega", "Z21nonStop21Z"));
            goToPageCreateRepositori();
            NameRepositori("unit_test_c_sharp_TESSTOVI");
            DiscriptionNewRepositori("commentari");
            ButtonNewRepositori();
        }

        private void ButtonNewRepositori()
        {
            driver.FindElement(By.XPath("//form[@id='new_repository']/div[4]/button/ya-tr-span")).Click();//создаём репозиторий
        }

        private void DiscriptionNewRepositori(string commentari)
        {
            driver.FindElement(By.Id("//*[@id='repository_description']")).SendKeys(commentari);//komment
        }

        private void NameRepositori(string namerepos)
        {
            driver.FindElement(By.Id("repository_name")).SendKeys(namerepos);//name repo
        }

        private void goToPageCreateRepositori()
        {
            driver.FindElement(By.XPath("//div[@id='repos-container']/h2/a/ya-tr-span")).Click();//переходим на экран создаие репозитория
        }

        private void autorization(AccountData account)//АТВОРИЗУЕМСя
        {
            driver.FindElement(By.Id("login_field")).SendKeys(account.Username);
            driver.FindElement(By.Id("password")).SendKeys(account.Password);
            driver.FindElement(By.Name("commit")).Click();
        }

        private void normalaizeBrowser()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='↵'])[8]/following::ya-tr-span[1]")).Click();
            //расширяем окно баузера
        }

        private void goToPageInGit()
        {
            driver.Navigate().GoToUrl("https://github.com/login");
        }
    }
}
