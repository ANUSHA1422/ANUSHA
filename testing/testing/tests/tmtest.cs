
using OpenQA.Selenium.Chrome;
using testing.pages;
using NUnit.Framework;
using testing.utilities;

namespace testing.tests

{
    [ TestFixture]
    public class TMtest : Commondriver
    {
        [SetUp]
        public void LoginActions()
        {
             driver = new ChromeDriver();
            login_page loginPageobj = new();
            loginPageobj.loginsteps(driver);

            homepage homePageobj = new homepage();
            homePageobj.goToTmPage(driver);

        }

        [Test]
        public void CreateTMtest()
        {
            tmpage tmPageobj = new tmpage();
            tmPageobj.CreateTm(driver);

        }

        [Test]
        public void EditTMtest()
        {
            tmpage tmPageobj = new tmpage();
            tmPageobj.EditTm(driver);
        }


        [Test]
        public void DeleteTMtest()
        {
            tmpage tmPageobj = new tmpage();
            tmPageobj.DeleteTm(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {

            driver.Quit();
        }


        //IWebDriver driver = new ChromeDriver();

        //login page object intialization and definition//

                    //loginpage loginPageobj = new loginpage();
                    //loginPageobj.loginsteps(driver);

                    //homepage homePageobj = new homepage();
                    // homePageobj.goTOTmPage(driver);

                    //tmpage tmPageobj = new tmpage();
                    // tmPageobj.CreateTm(driver);


                    // tmPageobj.EditTm(driver);

                    // tmPageobj.DeleteTm(driver);

     }


    //Thread.Sleep(1000);

    //IWebElement goToEditNewCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
    //goToEditNewCode.Click();

    //IWebElement goToDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
    //goToDeleteButton.Click();

    //driver.SwitchTo().Alert().Accept();
}

