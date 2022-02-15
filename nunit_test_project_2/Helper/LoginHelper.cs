using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GitRepos
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void autorization(AccountData account)
        {
            driver.FindElement(By.Id("login_field")).SendKeys(account.Username);//вводим логин
            driver.FindElement(By.Id("password")).SendKeys(account.Password);//вводим пароль
            driver.FindElement(By.Name("commit")).Click();//авторизуемся на кнопку 

        }
    }
}
