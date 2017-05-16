using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest.PageObjects
{
    class MainPage
    {
        [FindsBy(How = How.Id, Using = "aMenu")]
        public IWebElement MenuButton { get; set; }
        [FindsBy(How = How.Id, Using = "systemAdminMenuLinkLabel")]
        public IWebElement SystemAdmin { get; set; }
        [FindsBy(How = How.Id, Using = "manageFirmUsersMenuLink")]
        public IWebElement ManagePortalUsers { get; set; }
        [FindsBy(How = How.Id, Using = "createFirmUserMenuLink")]
        public IWebElement CreatePortalUser { get; set; }
        [FindsBy(How = How.Id, Using = "logoutLogo")]
        public IWebElement SignOutButton { get; set; }

        //Actions
        public void SignOutButtonClick()
        {
            SignOutButton.Click();
        }
    }
    
}
