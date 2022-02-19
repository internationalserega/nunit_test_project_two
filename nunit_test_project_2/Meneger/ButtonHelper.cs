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
    public class ButtonHelper : HelperBase
    {
        public ButtonHelper(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void ButtonCreateNewRepositori()
        {
            driver.FindElement(By.XPath("//*[@class='btn-primary btn']"))
                .Click();//кнопка создание репозитория
        }

        public void SettingRepo()
        {
            driver.FindElement(By.Id("settings-tab")).Click();
        }

        public void ClickDeleteRepoSeting()
        {
            driver.FindElement(By.XPath("//*[@class='details-reset details-overlay details-overlay-dark flex-md-order-1 flex-order-2']"))
                .Click();//кнопка удалить репозиторий
        }

        public void ClickDeleteRepoFinish()
        {
            driver.FindElement(By.XPath("//*[@class ='btn-danger btn btn-block']"))
                .Click();//потверждение удаление репозитория
        }
    }
}