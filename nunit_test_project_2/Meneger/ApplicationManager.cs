using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace GitRepos
{
   public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper LoginHelper;
        protected NavigationHelper navigator;
        protected ButtonHelper buttons;
        protected TextHelper text;

        public ApplicationManager()
        {
            LoginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            buttons = new ButtonHelper(driver);
            text = new TextHelper(driver);
        }

        public void stop()
        {
            driver.Quit();
        }

        public LoginHelper auth
        {
            get
            {
                return LoginHelper;
            }
        }
        public NavigationHelper Navigator
        {
            get
            {
                return NavigationHelper;
            }
        }
        public ButtonHelper button
        {
            get
            {
                return ButtonHelper;
            }
        }
        public TextHelper text
        {
            get
            {
                return TextHelper;
            }
        }
    }
}