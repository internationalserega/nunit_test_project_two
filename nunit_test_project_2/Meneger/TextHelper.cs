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
    public class TextHelper : HelperBase
    {
        public TextHelper(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void NameRepositori(string namerepos)
        {
            driver.FindElement(By.Id("repository_name"))
                .SendKeys(namerepos);//name repo
        }

        public void DiscriptionNewRepositori(string commentari)
        {
            driver.FindElement(By.Id("//*[@id='repository_description']"))
                .SendKeys(commentari);//komment
        }

        public void NameDeleteRepo(string namerepos)
        {
            driver.FindElement(By.XPath("//div[@id='options_bucket']/div[10]/ul/li[4]/details/details-dialog/div[3]/form/p/input"))
                .SendKeys(namerepos);//вставляем в поле скопированнное название репозитория
        }
    }
}