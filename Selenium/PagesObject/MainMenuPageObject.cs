using OpenQA.Selenium;
using System.Collections.Generic;
using System.Text;
using System;
namespace Selenium.PagesObject;

public class MainMenuPagesObject
{
    private IWebDriver _webDriver;
    private readonly By enterAuthButtonMain = By.XPath("//a[@data-ui='auth']");
    
    

    public MainMenuPagesObject(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }
    
    public AuthorizationPageObject SignIn()
    {
        _webDriver.FindElement(enterAuthButtonMain).Click();
        return new AuthorizationPageObject(_webDriver);
    }
}