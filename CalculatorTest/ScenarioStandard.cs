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
        protected WindowsElement RectangleControl;
        protected WindowsElement BackgroundControl;
        protected WindowsElement TriangleControl;

        protected AppiumWebElement ElementElipseControl;
        protected AppiumWebElement ElementRectangleControl;
        protected AppiumWebElement ElementBackgroundControl;
        protected AppiumWebElement ElementTriangleControl;


        protected AppiumWebElement ElementoAllinternoDiUIStatusElipse;
        protected AppiumWebElement ElementoAllinternoDiUIStatusRectangle;
        protected AppiumWebElement ElementoAllinternoDiUIStatusBG;
        protected AppiumWebElement ElementoAllinternoDiUIStatusTriangle;


        public void BaseTest()
        {

            ElipseControl = session.FindElementByAccessibilityId("ElipseControl");
            RectangleControl = session.FindElementByAccessibilityId("RectangleControl");
            BackgroundControl = session.FindElementByAccessibilityId("BackgroundControl");
            TriangleControl = session.FindElementByAccessibilityId("TriangleControl");

            ElementElipseControl = ElipseControl.FindElementByAccessibilityId("StatusLabelElipse");
            ElementRectangleControl = RectangleControl.FindElementByAccessibilityId("StatusLabelFill");
            ElementBackgroundControl = BackgroundControl.FindElementByAccessibilityId("StatusLabelBG");
            ElementTriangleControl = TriangleControl.FindElementByAccessibilityId("StatusLabelTriangle");

            ElementoAllinternoDiUIStatusElipse = ElementElipseControl.FindElementByAccessibilityId("lblStatus");
            ElementoAllinternoDiUIStatusRectangle = ElementRectangleControl.FindElementByAccessibilityId("lblStatus");
            ElementoAllinternoDiUIStatusBG = ElementBackgroundControl.FindElementByAccessibilityId("lblStatus");
            ElementoAllinternoDiUIStatusTriangle = ElementTriangleControl.FindElementByAccessibilityId("lblStatus");
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
            Assert.AreEqual("Yes", ElementoAllinternoDiUIStatusElipse.Text);
            Assert.AreEqual("Fill", ElementoAllinternoDiUIStatusBG.Text);
            Assert.AreEqual("Online", ElementoAllinternoDiUIStatusTriangle.Text);
            Assert.AreEqual("Open", ElementoAllinternoDiUIStatusRectangle.Text);
        }

        [TestMethod]
        public void ClickButtonWorking()
        {
            session.FindElementByAccessibilityId("btnWorking").Click();
            BaseTest();
            Assert.AreEqual("Not", ElementoAllinternoDiUIStatusElipse.Text);
            Assert.AreEqual("NotFill", ElementoAllinternoDiUIStatusBG.Text);
            Assert.AreEqual("Offline", ElementoAllinternoDiUIStatusTriangle.Text);
            Assert.AreEqual("Close", ElementoAllinternoDiUIStatusRectangle.Text);

        }


        [TestMethod]
        public void ClickButtonIdle()
        {
            session.FindElementByAccessibilityId("btnIdle").Click();
            BaseTest();
            Assert.AreEqual("Idle", ElementoAllinternoDiUIStatusElipse.Text);
            Assert.AreEqual("Idle", ElementoAllinternoDiUIStatusBG.Text);
            Assert.AreEqual("Idle", ElementoAllinternoDiUIStatusTriangle.Text);
            Assert.AreEqual("Idle", ElementoAllinternoDiUIStatusRectangle.Text);

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
