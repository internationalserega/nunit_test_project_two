using NUnit.Framework;

namespace GitRepos
{
    [TestFixture]
    public class GitReposeCreate : TestBase
    {
       
        [Test]
        public void GitReposeCreateTest()
        {
            goToPageInGit();
            autorization(new AccountData ("internationalserega", "Z21nonStop21Z"));
            goToPageCreateRepositori();
            NameRepositori("unit_test_c_sharp_TESSTOVI");
            DiscriptionNewRepositori("commentari");
            ButtonCreateNewRepositori();
        }
    }
}
