using SeleniumTest.Utilities;
using SeleniumTest.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using NUnit;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumTest.Steps
{
    [Binding]
    class CommonSteps
    {

        private DriverPoC driver = new DriverPoC();
        private LoginPage loginPage = new LoginPage();
        private MainPage mainPage = new MainPage();

        public CommonSteps()
        {
            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, mainPage);
        }

        [Given(@"I navigate to Vizor '(.*)' Page")]
        public void GivenINavigateToVizorPage(string pageName)
        {
            switch (pageName.ToLower())
            {
                case "login":

                    driver.Navigate().GoToUrl(Properties.Settings.Default.WebAppUrl);
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

        [Given(@"I enter '(.*)' and '(.*)' and click Login button")]
        public void GivenIEnterAndAndClickLoginButton(string userName, string password)
        {
            loginPage.UsernameInputSendNewKeys(userName);
            loginPage.PasswordSendNewKeys(password);
            loginPage.LoginButtonClick();
        }

        [Then(@"I sign out")]
        public void ThenISignOut()
        {
            mainPage.SignOutButtonClick();
            IAlert alert = driver.SwitchTo().Alert();
                //.switchTo().alert();
            alert.Accept();
        }



    }
}
