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
            app.Navigator.goToPageInGit();
            app.Navigator(new AccountData("internationalserega", "Z21nonStop21Z"));
            navigator.ClickTestRep();
            app.button.SettingRepo();
            app.button.ClickDeleteRepoSeting();
            app.text.NameDeleteRepo("internationalserega/unit_test_c_sharp_TESSTOVI");
            app.button.ClickDeleteRepoFinish();
        }
    }
}
