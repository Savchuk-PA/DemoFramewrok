using System.Threading;
using OpenQA.Selenium;

namespace Selenium.PageObjects;

public class AuthorizationPageObject
{
    private IWebDriver _driver;
    private By _loginButton = By.XPath("//a[@href = '/#']");
    private By _inputEmailOrPhone = By.XPath("//input[@data-test-id = 'input__login']");
    private By _inputPassword = By.XPath("//input[@data-test-id = 'input__password']");
    private By _signButton = By.XPath("//button[@data-test-id = 'button__sign-in']");
    private By _forgetPasswordButton = By.XPath("//button[@data-test-id = 'button__sign-in']");
    private By _registrationButton = By.XPath("//button[@data-test-id = 'button__sign-up']");
    private By _noAccountText = By.XPath("//span[@data-test-id = 'text__footer']");
    private By _signInTextInModal = By.XPath("//h4[@data-test-id = 'text__name-modal-base']");
    private By _buttonCloseModal = By.XPath("//img[@data-test-id = 'button__close-modal']");
    
    
    public AuthorizationPageObject(IWebDriver driver)
    {
        _driver = driver;
    }

    public void Login(string login, string password)
    {
        _driver.FindElement(_inputEmailOrPhone).SendKeys(login);
        _driver.FindElement(_inputPassword).SendKeys(password);
        _driver.FindElement(_signButton).Click();
    }
}