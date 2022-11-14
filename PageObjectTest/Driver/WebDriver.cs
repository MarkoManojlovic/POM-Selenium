using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectTest.Driver
{
    public static class WebDriver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialization()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            Instance.Navigate().GoToUrl("");

        }
         public static void Cleanup()
        {
            Instance.Quit();
        }
    }
}
