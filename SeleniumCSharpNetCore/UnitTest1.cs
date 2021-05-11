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

            //Enter 'Tomato' in the Autocomplete box
            CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Tomato");

            //Click 'Celery' in the AjaxCheckboxList
            CustomControl.Click(Driver.FindElement(By.CssSelector(".o-ochk > ul:nth-child(1) > li:nth-child(1) > label:nth-child(1) > div:nth-child(3)")));

            //Enter 'Cauliflower in the AjaxDropdown
            CustomControl.SelectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");

            //Enter 'Almond' in the Combobox
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Assert.Pass();
        }

        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com");
        }

    }
}