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
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(WebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void goToPageInGit()
        {
            driver.Navigate().GoToUrl("https://github.com/login");
        }

        public void goToPageCreateRepositori()
        {
            driver.FindElement(By.XPath("//*[@class='btn btn-sm btn-primary']"))
                .Click();//переходим на экран создаие репозитория
        }

        public void ClickTestRep()
        {
            driver.FindElement(By.XPath("//div[@id='repos-container']/ul/li[3]/div/div/a/ya-tr-span[2]"))
                .Click();//нажимаем на тестовый репозиторий
        }

    }
}