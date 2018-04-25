namespace Facade
{
    class PurchaseFacade
    {
        private MainPage mainPage;
        private SignInPage signInPage;
        private MailBoxPage mailBoxPage;
        private CreatingMessagePage creatingMessagePage;

        public MainPage MainPage 
        {
            get
            {
                if (mainPage == null)
                {
                    mainPage = new MainPage();
                }
                return mainPage;
            }
        }

        public SignInPage SignInPage 
        {
            get
            {
                if (signInPage == null)
                {
                    signInPage = new SignInPage();
                }
                return signInPage;
            }
        }

        public MailBoxPage MailBoxPage 
        {
            get
            {
                if (mailBoxPage == null)
                {
                    mailBoxPage = new MailBoxPage();
                }
                return mailBoxPage;
            }
        }

        public CreatingMessagePage CreatingMessagePage 
        {
            get
            {
                if (creatingMessagePage == null)
                {
                    creatingMessagePage = new CreatingMessagePage();
                }
                return creatingMessagePage;
            }
        }

        public void UserAuthorizationProcess(string login, string password)
        {
            this.MainPage.Navigate("");

            this.MainPage.AssertUrl();
            this.MainPage.AssertAllElementsIsVisible();
            this.MainPage.ClickGoButton();

            this.SignInPage.AssertUrl();
            this.SignInPage.AssertAllElementsIsVisible();
            this.SignInPage.Autorization(login, password);

            this.MailBoxPage.AssertUrl();
            this.MailBoxPage.AssertAllElementsIsVisible();
            this.MailBoxPage.VerifyYourUserName(login);
            this.MailBoxPage.ClickButtonWriteMessegeButton();

            this.CreatingMessagePage.AssertUrl();
            this.CreatingMessagePage.AssertAllElementsIsVisibleWriteMessage();
        }
    }
}
