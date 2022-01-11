using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace UI_test
{
    class FirstPageForm
    {
        private IButton helpButton = AqualityServices.Get<IElementFactory>().GetButton(By.XPath("//*[@class='discrete']"), "hide help");
        private IButton cookieButton = AqualityServices.Get<IElementFactory>().GetButton(By.XPath("//*[@class='button button--solid button--transparent']"), "hide cookie");
        private IButton scrappButton = AqualityServices.Get<IElementFactory>().GetButton(By.XPath("//*[@class='timer timer--white timer--center']"), "get zero time");


        private IButton dropDownButton = AqualityServices.Get<IElementFactory>().GetButton(By.XPath("//*[@class='icon icon-chevron-down']"), "click dropdown");
        private IButton dotComButton = AqualityServices.Get<IElementFactory>().GetButton(By.XPath("//*[text()='.com']"), ".com");
        private IButton checkBoxButton = AqualityServices.Get<IElementFactory>().GetButton(By.XPath("//*[@class='checkbox__box']"), "termsCheckBox");

        private IButton nextPageButton = AqualityServices.Get<IElementFactory>().GetButton(By.CssSelector("div.login-form__section.align.align--fluid.align--even > div:nth-child(1) > a"), "go to next page");

        private ITextBox passTextBox = AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//*[@placeholder='Choose Password']"), "");
        private ITextBox loginTextBox = AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//*[@placeholder='Your email']"), "");
        private ITextBox domainTextBox = AqualityServices.Get<IElementFactory>().GetTextBox(By.XPath("//*[@placeholder='Domain']"), "input domaininput logininput password");



        public void clickDropDown()
        {
            dropDownButton.Click();
        }

        public void clickDotCom()
        {
            dotComButton.Click();
        }

        public void clickCheckBox()
        {
            checkBoxButton.Click();
        }

        public void clickGoThirdPage()
        {
            nextPageButton.Click();
            AqualityServices.Browser.WaitForPageToLoad();
        }

        public bool hideHelpAndWait()
        {
            helpButton.Click();
            helpButton.State.WaitForNotDisplayed();
            bool check = helpButton.State.IsDisplayed;
            return check;
        }

        public bool hideCookieAndWait()
        {
            cookieButton.Click();
            cookieButton.State.WaitForNotDisplayed();
            bool check = cookieButton.State.IsDisplayed;
            return check;
        }

        public string scrappText()
        {
            var text = scrappButton.GetText();
            string result = text.ToString();
            return result;
        }

        public void inputPass()
        {
            passTextBox.ClearAndType("This23Is587!Very2Safe34");
        }

        public void inputLogin()
        {
            loginTextBox.ClearAndType("justemail34563");
        }

        public void inputDomain()
        {
            domainTextBox.ClearAndType("gmail");
        }

        public bool isOpened()
        {
            bool check = AqualityServices.Browser.Driver.PageSource.Contains("Your password requires at least 10 characters.");
            return check;
        }
    }
}

