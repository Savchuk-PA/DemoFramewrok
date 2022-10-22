using OpenQA.Selenium;

namespace Selenium.PagesObject
{
    public class AuthorizationPageObject
    {
        private IWebDriver _webdriver;
        private readonly By _loginInputButton = By.Name("username");
        private readonly By _passwordInputButton = By.Name("password");
        private readonly By _enterAuthButtonMain = By.XPath("//a[@data-ui='registration']");
        
        public AuthorizationPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        public MainMenuPagesObject Login(string login, string password)
        {
            
            _webdriver.FindElement(_loginInputButton).SendKeys(login);
            _webdriver.FindElement(_passwordInputButton).SendKeys(password);

            return new MainMenuPagesObject(_webdriver);
        }


    }
}