using NUnit.Framework;

namespace GitRepos
{
    [TestFixture]
    public class GitReposeCreate : TestBase
    {
        [Test]
        public void GitReposeCreateTest()
        {
            navigator.goToPageInGit();
            LoginHelper.autorization(new AccountData ("internationalserega", "Z21nonStop21Z"));
            navigator.goToPageCreateRepositori();
            NameRepositori("unit_test_c_sharp_TESSTOVI");
            DiscriptionNewRepositori("commentari");
            ButtonCreateNewRepositori();
        }
    }
}
