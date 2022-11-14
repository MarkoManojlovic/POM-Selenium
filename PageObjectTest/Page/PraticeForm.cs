

using OpenQA.Selenium;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.DevTools.V105.Audits;
using PageObjectTest.Driver;
using WebDriver = PageObjectTest.Driver.WebDriver;

namespace PageObjectTest.Page
{
    public class PraticeForm
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => driver.FindElement(By.Id("lastName"));
        public IWebElement Email => driver.FindElement(By.Id("userEmail"));
        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-1"));
        public IWebElement MobileNumber => driver.FindElement(By.Id("userNumber"));
        public IWebElement Subjcet => driver.FindElement(By.Id("subjectsContainer"));
        public IWebElement Hobbis => driver.FindElement(By.Id("hobbies-checkbox-1"));
        public IWebElement Button => driver.FindElement(By.Id("submit"));

        public void EnterName(string name)
        {
            FirstName.SendKeys(name);
        }
        public void EnterLastName (string name)
        {
            LastName.SendKeys(name);
        }
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }
        public void SelectGender()
        {
            Gender.Click();
        }
        public void EnterMobileNumber (string number)
        {
            MobileNumber.SendKeys(number);
        }
        public void EnterSubjcet(string name)
        {
            Subjcet.Click();
            Subjcet.SendKeys(name);
            Subjcet.Click();

        }
        public void SelectHobbis()
        {
            Hobbis.Click();
        }
        public void PressButton()
        {
            Button.Submit();
        }




    }
}
