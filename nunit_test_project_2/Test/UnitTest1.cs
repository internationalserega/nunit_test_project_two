using NUnit.Framework;

namespace GitRepos
{
    [TestFixture]
    public class GitReposeCreate : TestBase
    {
        [Test]
        public void GitReposeCreateTest()
        {
            app.Navigator.goToPageInGit();
            app.Navigator(new AccountData("internationalserega", "Z21nonStop21Z"));
            app.Navigator.goToPageCreateRepositori();
            app.text.NameRepositori("unit_test_c_sharp_TESSTOVI");
            app.text.DiscriptionNewRepositori("commentari");
            app.button.ButtonCreateNewRepositori();
        }
    }
}
