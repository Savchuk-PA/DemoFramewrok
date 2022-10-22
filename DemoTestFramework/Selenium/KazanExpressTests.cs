using System.Threading;
using Allure.Commons;
using Newtonsoft.Json.Linq;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.PageObjects;

namespace Selenium;

[TestFixture]
[AllureNUnit]
public class KazanExpressTests : TestBase
{
    private JObject testUser;
    
    
    [SetUp]
    public void SetUp()
    {
        driver.Navigate().GoToUrl("https://kazanexpress.ru/");
        testUser = (JObject) testData["testUser1"];
    }

    [Test]
    public void LoginUser()
    {
        Thread.Sleep(5000);
        MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
        mainMenu
            .SignIn();
        AuthorizationPageObject auth = new AuthorizationPageObject(driver);
            auth.
                Login(testUser["login"].ToString(), testUser["password"].ToString());
        Thread.Sleep(5000);
    }

    [TearDown]
    public void TearDown()
    {
        driver.Close();
    }
}