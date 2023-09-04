using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;

namespace CalculatorTest
{
    [TestClass]
    public class ScenarioStandard : WPFSession
    {

        [TestMethod]
        public void lunch()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ClickButtonBlue1()
        {
            WindowsElement Ucolors1 = session.FindElementByAccessibilityId("UColors1");
            AppiumWebElement weUColors1 = Ucolors1.FindElementByAccessibilityId("lblStatus");

            session.FindElementByAccessibilityId("btnBlue").Click();
            Assert.AreEqual("EBlue", weUColors1.Text);

        }

        [TestMethod]
        public void ClickButtonRed1()
        {
            WindowsElement Ucolors1 = session.FindElementByAccessibilityId("UColors1");
            AppiumWebElement weUColors1 = Ucolors1.FindElementByAccessibilityId("lblStatus");

            session.FindElementByAccessibilityId("btnRed").Click();
            Assert.AreEqual("ERed", weUColors1.Text);

        }

        [TestMethod]
        public void ClickButtonBlue2()
        {
            WindowsElement Ucolors2 = session.FindElementByAccessibilityId("UColors2");
            AppiumWebElement weUColors2 = Ucolors2.FindElementByAccessibilityId("lblStatus");


            session.FindElementByAccessibilityId("btnBlue2").Click();
            Assert.AreEqual("EBlue", weUColors2.Text);

        }

        [TestMethod]
        public void ClickButtonRed2()
        {
            WindowsElement Ucolors2 = session.FindElementByAccessibilityId("UColors2");
            AppiumWebElement weUColors2 = Ucolors2.FindElementByAccessibilityId("lblStatus");


            session.FindElementByAccessibilityId("btnRed2").Click();
            Assert.AreEqual("ERed", weUColors2.Text);

        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }
    }
}
