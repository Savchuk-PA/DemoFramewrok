using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium;

public class Test : TestBase
{
    [Test]
    public void test()
    {
        driver.Navigate().GoToUrl("https://old.kzn.opencity.pro");
        driver.FindElement(By.XPath("//a[@data-ui='auth']")).Click();
        
        driver.FindElement(By.Name("username")).SendKeys("asdasd");
        Thread.Sleep(3434);
        driver.Close();
        driver.Quit();
    }

}