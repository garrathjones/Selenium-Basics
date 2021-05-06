using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {

        
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            //ChromeOptions chromeOptions = new ChromeOptions();
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.CssSelector(".o-ochk > ul:nth-child(1) > li:nth-child(1) > label:nth-child(1) > div:nth-child(3)")).Click();
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            string comboBoxControlName = "ContentPlaceHolder1_AllMealsCombo";

            CustomControl1.ComboBox(comboBoxControlName,"Almonds");
            Assert.Pass();
        }
    }
}