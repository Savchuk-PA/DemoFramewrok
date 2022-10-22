using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;

namespace Selenium.pages
{
    public class MainPage
    {
        private WebDriver driver;
        private WebDriverWait wait;

        public MainPage(WebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public RegistrationPage GetRegistrationPage()
        {
            IWebElement registration = wait.Until(e => e.FindElement(By.XPath("//a[@data-ui='auth']")));
            registration.Click();
            return new RegistrationPage(driver, wait);
        }

    }
}