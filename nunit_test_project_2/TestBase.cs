using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace GitRepos
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected string baseURL;


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

        protected void goToPageInGit()
        {
            driver.Navigate().GoToUrl("https://github.com/login");
        }

        protected void autorization(AccountData account)
        {
            driver.FindElement(By.Id("login_field")).SendKeys(account.Username);//вводим логин
            driver.FindElement(By.Id("password")).SendKeys(account.Password);//вводим пароль
            driver.FindElement(By.Name("commit")).Click();//авторизуемся на кнопку 

        }

        protected void goToPageCreateRepositori()
        {
            driver.FindElement(By.XPath("//*[@class='btn btn-sm btn-primary']")).Click();//переходим на экран создаие репозитория
        }

        protected void NameRepositori(string namerepos)
        {
            driver.FindElement(By.Id("repository_name")).SendKeys(namerepos);//name repo
        }

        protected void DiscriptionNewRepositori(string commentari)
        {
            driver.FindElement(By.Id("//*[@id='repository_description']")).SendKeys(commentari);//komment
        }

        protected void ButtonCreateNewRepositori()
        {
            driver.FindElement(By.XPath("//*[@class='btn-primary btn']")).Click();//создаём репозиторий
        }

        protected void ClickTestRep()
        {
            driver.FindElement(By.XPath("//div[@id='repos-container']/ul/li[3]/div/div/a/ya-tr-span[2]")).Click();//нажимаем на тестовый репозиторий
        }

        protected void ClickDeleteRepoSeting()
        {
            driver.FindElement(By.XPath("//*[@class='details-reset details-overlay details-overlay-dark flex-md-order-1 flex-order-2']")).Click();//нажимаем на удалить репозиторий
        }

        protected void NameDeleteRepo(string namerepos)
        {
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/form/p/input")).SendKeys(namerepos);//вставляем в поле скопированнное название репозитория
        }

        protected void ClickDeleteRepoFinish()
        {
            driver.FindElement(By.XPath("//*[@class ='btn-danger btn btn-block']")).Click();//потверждение удаление репозитория
        }

    }
}
