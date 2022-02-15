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
        protected LoginHelper LoginHelper;
        protected NavigationHelper navigator;
        protected ButtonHelper buttons;
        protected TextHelper text;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseURL = "https://github.com/login";
            driver.Manage().Window.Maximize();
            LoginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            buttons = new ButtonHelper(driver);
            text = new TextHelper(driver);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
