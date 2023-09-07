using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using System;
using OpenQA.Selenium;

namespace CalculatorTest
{
    [TestClass]
    public class ScenarioStandard : WPFSession
    {

        protected WindowsElement ElipseControl;
        protected AppiumWebElement WEElipseControl;
        protected AppiumWebElement ElementoAllinternoDiUIStatusElipse;
        protected WindowsElement RectangleControl;
        protected AppiumWebElement WERectangleControl;
        protected AppiumWebElement ElementoAllinternoDiUIStatusRectangle;
        protected WindowsElement BackgroundControl;
        protected AppiumWebElement WEBackgroundControl;
        protected AppiumWebElement ElementoAllinternoDiUIStatusBG;


        public void BaseTest()
        {

            ElipseControl = session.FindElementByAccessibilityId("ElipseControl");
            WEElipseControl = ElipseControl.FindElementByAccessibilityId("UIStatus");
            ElementoAllinternoDiUIStatusElipse = WEElipseControl.FindElementByAccessibilityId("lblStatus");

            RectangleControl = session.FindElementByAccessibilityId("RectangleControl");
            WERectangleControl = RectangleControl.FindElementByAccessibilityId("UIStatusR");
            ElementoAllinternoDiUIStatusRectangle = WERectangleControl.FindElementByAccessibilityId("lblStatus");

            BackgroundControl = session.FindElementByAccessibilityId("BackgroundControl");
            WEBackgroundControl = BackgroundControl.FindElementByAccessibilityId("UIStatusB");
            ElementoAllinternoDiUIStatusBG = WEElipseControl.FindElementByAccessibilityId("lblStatus");
        }

        [TestMethod]
        public void lunch()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ClickButtonMeasuring()
        {
            session.FindElementByAccessibilityId("btnMeasuring").Click();
            BaseTest();
            Assert.AreEqual("EMisuring", ElementoAllinternoDiUIStatusElipse.Text);
            Assert.AreEqual("EMisuring", ElementoAllinternoDiUIStatusRectangle.Text);
            Assert.AreEqual("EMisuring", ElementoAllinternoDiUIStatusBG.Text);
        }

        [TestMethod]
        public void ClickButtonRed1()
        {
            session.FindElementByAccessibilityId("btnWorking").Click();
            BaseTest();
            Assert.AreEqual("EWorking", ElementoAllinternoDiUIStatusElipse.Text);
            Assert.AreEqual("EWorking", ElementoAllinternoDiUIStatusRectangle.Text);
            Assert.AreEqual("EWorking", ElementoAllinternoDiUIStatusBG.Text);

        }


        [TestMethod]
        public void ClickButtonReset1()
        {
            session.FindElementByAccessibilityId("btnIdle").Click();
            BaseTest();
            Assert.AreEqual("EIdle", ElementoAllinternoDiUIStatusElipse.Text);
            Assert.AreEqual("EIdle", ElementoAllinternoDiUIStatusRectangle.Text);
            Assert.AreEqual("EIdle", ElementoAllinternoDiUIStatusBG.Text);

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
