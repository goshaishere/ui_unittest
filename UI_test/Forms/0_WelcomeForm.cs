using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;


namespace UI_test
{
    class WelcomeForm
    {
        private IButton go2secondPageButton = AqualityServices.Get<IElementFactory>().GetButton(By.XPath("//*[@class='start__link']"), "WelcomeForm: click button");

        public void openPage()
        {
            var browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo("https://userinyerface.com/game.html%20target=");
            browser.WaitForPageToLoad();
        }

        public void go2firstPage()
        {
            go2secondPageButton.Click();
        }

        public bool isOpened()
        {
            bool check = AqualityServices.Browser.Driver.PageSource.Contains("Hi and welcome to User Inyerface");
            return check;
        }
    }
}
