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
//FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("F:\\ProjectFolder\\Drivers", "geckodriver.exe");
var relpath=$AGENT_HOMEDIRECTORY;
//Console.WriteLine($AGENT_HOMEDIRECTORY);
FirefoxDriverService service = FirefoxDriverService.CreateDefaultService($AGENT_HOMEDIRECTORY +"/Drivers", "geckodriver.exe");
//service.Port = 64444;

driver = new FirefoxDriver(service);

driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

driver.Url ="https://code.visualstudio.com";

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
