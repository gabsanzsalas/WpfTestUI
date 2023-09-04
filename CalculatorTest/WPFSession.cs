using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace CalculatorTest
{
    public class WPFSession
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string pathApp = @"C:\prova wpf\WpfTestUI\WpfTestUI\bin\Debug\net6.0-windows\WpfTestUI.exe";

        protected static WindowsDriver<WindowsElement> session;

        public static void Setup(TestContext context)
        {
            if (session == null)
            {
                AppiumOptions appOptions = new AppiumOptions();
                appOptions.AddAdditionalCapability("app", pathApp);
                appOptions.AddAdditionalCapability("platformName", "Windows");
                Thread.Sleep(TimeSpan.FromSeconds(5));


                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appOptions);
                Assert.IsNotNull(session);

                session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }
        }

        public static void TearDown()
        {
            if (session != null)
            { 
                session.Quit();
                session = null;
            }
        }
    }
}
