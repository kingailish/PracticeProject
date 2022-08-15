using OpenQA.Selenium;
using PracticeProject.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.PageObject
{
    public class HomeMenuPage
    {
        public IWebDriver driver;


        public HomeMenuPage()
        {
            driver = WebHooks.driver;
        }

        private By home = By.XPath("//li[@id='menu-item-586']//a[contains(text(),'Home')]");



        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public void ClickHomeMenuButton()
        {
            driver.FindElement(home).Click();
        }

        public bool PrepmajorHomeMenuPageIsDisplayed()
        {
            return driver.Url.Contains("prepmajor1com");

        }
    }
}