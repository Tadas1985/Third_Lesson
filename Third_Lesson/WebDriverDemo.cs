
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Third_Lesson
{
    public class WebDriverDemo
    {
        [Test]
        public static void TestChrome()
        {
            IWebDriver chrome = new ChromeDriver();
            //IWebDriver firefox = new FirefoxDriver();
            chrome.Url = "https://login.yahoo.com/";
            IWebElement loginField = chrome.FindElement(By.Id("login-username"));
            loginField.SendKeys("Tadas");
            IWebElement button = chrome.FindElement(By.Id("login-signin"));
            button.Click();

            //chrome.Quit();
        }

    }
}
