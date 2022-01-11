using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace UI_test
{
    class SecPageForm
    {
        private IReadOnlyCollection<IWebElement> checkboxes = AqualityServices.Browser.Driver.FindElementsByCssSelector("div > span.checkbox.small > label > span");
        private List<IWebElement> trueList = new List<IWebElement>(AqualityServices.Browser.Driver.FindElementsByCssSelector("div > span.checkbox.small > label > span"));
        public bool isOpened()
        {
            bool check = AqualityServices.Browser.Driver.PageSource.Contains("Your password requires at least 10 characters.");
            return check;
        }

        public void unselectAll()
        {
            trueList[20].Click();
        }

        public void select3random()
        {
            var length = trueList.Count;
            Assert.AreEqual(length, 21);
            Random x = new Random();
            var i = 0;
            while (i < 3)
            {
                int n = x.Next(length - 1);
                if (n != 17 && n != 20)
                {
                    trueList[n].Click();
                    i++;
                }
            }
        }
    }
}
