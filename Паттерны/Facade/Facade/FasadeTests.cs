using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facade
{
    [TestClass]
    public class FasadeTests
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void AutorizationUser()
        {
            string login = "prohorzyazyulya";
            string password = "Prohor1997";

            new PurchaseFacade().UserAuthorizationProcess(login, password);
        }
    }
}
