using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium.pages
{
    public class RegistrationPage
    {
        private WebDriver driver;
        private WebDriverWait wait;

        public RegistrationPage(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void SetEmail(string email)
        {
            wait.Until(e => e.FindElement(By.Name("email"))).SendKeys(email);
        }

        public void SubmitRegistration()
        {
           var element =  driver.FindElement(By.XPath(Locators.submitButton));
           element.Click();
        }
    }
}