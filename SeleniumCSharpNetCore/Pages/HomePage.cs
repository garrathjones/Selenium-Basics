using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        public void ClickLogin() => lnkLogin.Click();
    }


}
