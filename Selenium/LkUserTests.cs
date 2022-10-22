using System;
using System.Drawing;
using System.IO;
using System.Threading;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Selenium;


public class LkUserTests : TestBase
{

    private JObject testUser;
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        //driver = new ChromeDriver();
        testUser = (JObject) testData["testUser2"];
        driver.Navigate().GoToUrl("https://old.kzn.opencity.pro/");
        Authorization(testUser["login"].ToString(), testUser["password"].ToString());
    }
    

    [Test]
    public void ExampleTests()
    {
        
        driver.Navigate().GoToUrl("https://old.kzn.opencity.pro/cabinet/createorder");
        Thread.Sleep(5000);
    }
}