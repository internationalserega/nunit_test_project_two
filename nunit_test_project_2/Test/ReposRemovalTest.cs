using NUnit.Framework;
using OpenQA.Selenium;


namespace GitRepos
{
    [TestFixture]
    public class GitDeleteRepos : TestBase
    { 

        [Test]
        public void ReposRemovalTest()
        {
            navigator.goToPageInGit();
            LoginHelper.autorization(new AccountData ("internationalserega", "Z21nonStop21Z"));
            navigator.ClickTestRep();
            driver.FindElement(By.Id("settings-tab")).Click();
            ClickDeleteRepoSeting();
            NameDeleteRepo("internationalserega/unit_test_c_sharp_TESSTOVI");
            ClickDeleteRepoFinish(); 
        }
    }
}
