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
using System;

namespace SeleniumTest.Steps
{
    [Binding]
    class MainPageSteps
    {
        private DriverPoC driver = new DriverPoC();
        private MainPage mainPage = new MainPage();

        public MainPageSteps()
        {
            PageFactory.InitElements(driver, mainPage);
        }

        [Given(@"I navigate to Create User page via menu")]
        public void GivenINavigateToCreateUserPageViaMenu()
        {
            driver.HoverOnElement(mainPage.MenuButton);
            driver.WaitForElementVisible(By.Id("systemAdminMenuLinkLabel"));
            Assert.True(mainPage.SystemAdmin.Displayed);
            driver.HoverOnElement(mainPage.SystemAdmin);
            driver.WaitForElementVisible(By.Id("manageFirmUsersMenuLink"));
            Assert.True(mainPage.ManagePortalUsers.Displayed);
            driver.HoverOnElement(mainPage.ManagePortalUsers);
            driver.WaitForElementVisible(By.Id("createFirmUserMenuLink"));
            Assert.True(mainPage.CreatePortalUser.Displayed);

            mainPage.CreatePortalUser.Click();
        }
    }
}
