using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using testing.pages;

IWebDriver driver = new ChromeDriver();

//login page object intialization and definition//

login_page loginPageobj = new login_page();
loginPageobj.loginsteps(driver);

homepage homePageobj = new homepage();
homePageobj.goTOTmPage(driver);

tmpage tmPageobj = new tmpage();
tmPageobj.CreateTm(driver);


tmPageobj.EditTm(driver);

tmPageobj.DeleteTm(driver);


//Thread.Sleep(1000);

//IWebElement goToEditNewCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
//goToEditNewCode.Click();

//IWebElement goToDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
//goToDeleteButton.Click();

//driver.SwitchTo().Alert().Accept();

