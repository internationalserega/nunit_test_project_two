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
        protected ApplicationManager app;

        [SetUp]
        public void Setup()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void Teardown()
        {
            app.stop();
        }
    }
}
