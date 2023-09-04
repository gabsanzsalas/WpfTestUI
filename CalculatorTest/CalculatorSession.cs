//******************************************************************************
//
// Copyright (c) 2017 Microsoft Corporation. All rights reserved.
//
// This code is licensed under the MIT License (MIT).
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//******************************************************************************

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Threading;

namespace CalculatorTest
{
    public class CalculatorSession
    {
        // Note: append /wd/hub to the URL if you're directing the test at Appium
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string pathApp = @"C:\Repos\UI\WpfTestUI\WpfTestUI\bin\Debug\net6.0-windows\WpfTestUI.exe";

        protected static WindowsDriver<WindowsElement> session;

        public static void Setup(TestContext context)
        {
            // Launch Calculator application if it is not yet launched
            if (session == null)
            {
                AppiumOptions appOptions = new AppiumOptions();
                appOptions.AddAdditionalCapability("app", pathApp);
                appOptions.AddAdditionalCapability("platformName", "Windows");
                //appOptions.AddAdditionalCapability("deviceName", "WindowsPC");
                Thread.Sleep(TimeSpan.FromSeconds(5));

                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appOptions);

                //// Create a new session to bring up an instance of the Calculator application
                //// Note: Multiple calculator windows (instances) share the same process Id
                //DesiredCapabilities appCapabilities = new DesiredCapabilities();
                //appCapabilities.SetCapability("app", CalculatorAppId);
                ////appCapabilities.SetCapability("deviceName", "mer-sanzg1");
                //session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
                Assert.IsNotNull(session);

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }
        }

        public static void TearDown()
        {
            // Close the application and delete the session
            if (session != null)
            { 
                session.Quit();
                session = null;
            }
        }
    }
}
