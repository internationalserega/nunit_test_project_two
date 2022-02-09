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
        public void ReposRemovalTest()
        {
            goToPageInGit();
            autorization(new AccountData ("internationalserega", "Z21nonStop21Z"));
            ClickTestRep();
            driver.FindElement(By.Id("settings-tab")).Click();
            ClickDeleteRepoSeting();
            NameDeleteRepo("internationalserega/unit_test_c_sharp_TESSTOVI");
            ClickDeleteRepoFinish(); 
        }

        private void ClickDeleteRepoFinish()
        {
            driver.FindElement(By.XPath("//*[@class ='btn-danger btn btn-block']")).Click();//потверждение удаление репозитория
        }

        private void NameDeleteRepo(string namerepos)
        {
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/form/p/input")).SendKeys(namerepos);//вставляем в поле скопированнное название репозитория
        }

        private void ClickDeleteRepoSeting()
        {
            driver.FindElement(By.XPath("//*[@class='details-reset details-overlay details-overlay-dark flex-md-order-1 flex-order-2']")).Click();//нажимаем на удалить репозиторий
        }

        private void ClickTestRep()
        {
            driver.FindElement(By.XPath("//div[@id='repos-container']/ul/li[3]/div/div/a/ya-tr-span[2]")).Click();//нажимаем на тестовый репозиторий
        }

        private void autorization(AccountData account)
        {
            driver.FindElement(By.Id("login_field")).SendKeys(account.Username);//вводим логин
            driver.FindElement(By.Id("password")).SendKeys(account.Password);//вводим пароль
            driver.FindElement(By.Name("commit")).Click();//авторизуемся на кнопку 
        }

        private void goToPageInGit()
        {
            driver.Navigate().GoToUrl("https://github.com/login");
        }

    }
}
