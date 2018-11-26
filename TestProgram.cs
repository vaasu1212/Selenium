using NUnit.Framework;

using NUnit;

using OpenQA.Selenium;

using OpenQA.Selenium.Firefox;

using System;

[TestFixture]

public class TestProgram

{

private IWebDriver driver;

[SetUp]

public void SetupTest()

{

//FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@”/Users/rakeshprabhakaran/Project/c#/expOne/lib/”, “geckodriver”);
FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("D:\\a\\1\\s\\Drivers", "geckodriver.exe");

//service.Port = 64444;

driver = new FirefoxDriver(service);
Console.WriteLine("Selenium Test script");
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

driver.Url ="https://code.visualstudio.com/";

}

[TearDown]

public void TeardownTest()

{

driver.Quit();

}

[Test]

public void testMethod()

{

String title = driver.Title;

System.Console.WriteLine("title of site is : "+title);

//IWebElement button =driver.FindElement(By.CssSelector('.link-button.dlink'));

//Assert.AreEqual(“Download for Mac\nStable Build” , button.Text);

}

}