using OpenQA.Selenium;

namespace Selenium.PageObjects;

public class MainMenuPageObject
{
    private IWebDriver _driver;
    
    private readonly By loginButton = By.XPath("//a[@href = '/#']");


    public MainMenuPageObject(IWebDriver driver)
    {
        _driver = driver;
    }

    public void SignIn()
    {
        _driver.FindElement(loginButton).Click();
        
    }
}