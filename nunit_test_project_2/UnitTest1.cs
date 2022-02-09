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
            linkSingIn();
            autorization(new AccountData ("internationalserega", "Z21nonStop21Z"));
            goToPageCreateRepositori();
            NameRepositori("unit_test_c_sharp_TESSTOVI");
            DiscriptionNewRepositori("commentari");
            ButtonNewRepositori();
        }

        private void ButtonNewRepositori()
        {
            driver.FindElement(By.XPath("//*[@class='btn-primary btn']")).Click();//создаём репозиторий
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
            driver.FindElement(By.XPath("//*[@class='btn btn-sm btn-primary']")).Click();//переходим на экран создаие репозитория
        }

        private void autorization(AccountData account)//АТВОРИЗУЕМСя
        {
            driver.FindElement(By.Id("login_field")).SendKeys(account.Username);
            driver.FindElement(By.Id("password")).SendKeys(account.Password);
            driver.FindElement(By.Name("commit")).Click();
        }

        private void linkSingIn()
        {
            driver.FindElement(By.XPath("//*[@class='HeaderMenu-link flex-shrink-0 no-underline']")).Click();
            //расширяем окно баузера
        }

        private void goToPageInGit()
        {
            driver.Navigate().GoToUrl("https://github.com/login");
        }
    }
}
