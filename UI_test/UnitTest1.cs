using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using System;
using System.Diagnostics;

using System.Threading;


namespace UI_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1()
        {
            WelcomeForm welForm = new WelcomeForm();
            welForm.openPage();
            var checkWelcome = welForm.isOpened();
            Assert.AreEqual(checkWelcome, true);
            welForm.go2firstPage();

            FirstPageForm firstPage = new FirstPageForm();
            var check1st = firstPage.isOpened();
            Assert.AreEqual(check1st, true);

            firstPage.inputPass();
            firstPage.inputLogin();
            firstPage.inputDomain();
            firstPage.clickDropDown();
            firstPage.clickDotCom();
            firstPage.clickCheckBox();

            firstPage.clickGoThirdPage();

            SecPageForm secPage = new SecPageForm();
            var check2nd = secPage.isOpened();
            Assert.AreEqual(checkWelcome, true);

            //page 3
            secPage.unselectAll();
            secPage.select3random();
            //AqualityServices.Browser.Driver.FindElementByCssSelector("div.avatar-and-interests__section.avatar-and-interests__interests-section").SendKeys("C:\\test_pic\\icon.png").Click();
            //FindElementByClassName("align__cell avatar-and-interests__avatar-upload-button button button--solid button--blue").SendKeys("C:\\test_pic\\icon.png");

            var inputButton = AqualityServices.Get<IElementFactory>().GetButton(By.XPath("//*[@class='avatar-and-interests__upload-button']"), "uploadImageButton");
            AqualityServices.Browser.WaitForPageToLoad();
            inputButton.ClickAndWait();


            AqualityServices.Browser.Driver.Quit();
        }


        [TestMethod]
        public void testCase2()
        {
            WelcomeForm welForm = new WelcomeForm();
            welForm.openPage();
            var checkWelcome = welForm.isOpened();
            Assert.AreEqual(checkWelcome, true);
            welForm.go2firstPage();

            FirstPageForm firstPage = new FirstPageForm();
            bool check = firstPage.hideHelpAndWait();

            Assert.AreEqual(check, false);

            AqualityServices.Browser.Quit();
        }

        [TestMethod]
        public void testCase3()
        {
            WelcomeForm welForm = new WelcomeForm();
            welForm.openPage();
            var checkWelcome = welForm.isOpened();
            Assert.AreEqual(checkWelcome, true);
            welForm.go2firstPage();

            FirstPageForm firstPage = new FirstPageForm();
            var check = firstPage.hideCookieAndWait();
            Assert.AreEqual(check, false);

            AqualityServices.Browser.Quit();
        }

        [TestMethod]
        public void testCase4()
        {
            WelcomeForm welForm = new WelcomeForm();
            welForm.openPage();
            var checkWelcome = welForm.isOpened();
            Assert.AreEqual(checkWelcome, true);
            welForm.go2firstPage();

            FirstPageForm firstPage = new FirstPageForm();
            // page 2
            string text = firstPage.scrappText();
            Assert.AreEqual(text, "00:00:00");

            AqualityServices.Browser.Quit();
        }

    }
}
