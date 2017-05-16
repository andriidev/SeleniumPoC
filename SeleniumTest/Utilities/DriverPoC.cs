using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Drawing;


namespace SeleniumTest.Utilities
{
    class DriverPoC : IWebDriver
    {
private static IWebDriver driver;
        private static WebDriverWait wait;
        private static IJavaScriptExecutor jsExecutor;
        private static Actions builder;

        private static readonly Destructor Finalise = new Destructor();

        static DriverPoC()
        {
            driver = Initialize();
        }

        private static IWebDriver Initialize()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1024, 768);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            jsExecutor = driver as IJavaScriptExecutor;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            builder = new Actions(driver);

            return driver;
        }

        private sealed class Destructor
        {
            ~Destructor()
            {
                driver.Quit();
            }
        }

        public object ExecuteScript(string script, params object[] args)
        {
            return jsExecutor.ExecuteScript(script, args);
        }

        public void WaitForElementPresent(By by)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }


        public void WaitForElementClickable(By by)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public void WaitForElementVisible(By by)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public string CurrentWindowHandle
        {
            get
            {
                return driver.CurrentWindowHandle;
            }
        }

        public string PageSource
        {
            get
            {
                return driver.PageSource;
            }
        }

        public string Title
        {
            get
            {
                return driver.Title;
            }
        }

        public string Url
        {
            get
            {
                return driver.Url;
            }

            set
            {
                driver.Url = value;
            }
        }

        public ReadOnlyCollection<string> WindowHandles
        {
            get
            {
                return driver.WindowHandles;
            }
        }

        public void Close()
        {
            driver.Close();
        }

        public void Dispose()
        {
            driver.Dispose();
        }

        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

        public IOptions Manage()
        {
            return driver.Manage();
        }

        public INavigation Navigate()
        {
            return driver.Navigate();
        }

        public void Quit()
        {
            driver.Quit();
        }

        public ITargetLocator SwitchTo()
        {
            return driver.SwitchTo();
        }

        public void HoverOnElement(IWebElement element)
        {
            builder.MoveToElement(element).Build().Perform();
        }
    }
}
