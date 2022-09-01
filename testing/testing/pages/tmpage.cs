
using NUnit.Framework;
using OpenQA.Selenium;

namespace testing.pages
{
    public class tmpage
    {
        

        public void CreateTm(IWebDriver driver)
        {

            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\'container\']/p/a"));
            CreateNewButton.Click();

            IWebElement TypeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[2]/span"));
            TypeCodeDropDown.Click();

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("abc");

            IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
            DescriptionTextBox.SendKeys("abc");

            IWebElement PriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PriceTag.Click();

            IWebElement PriceTextBox = driver.FindElement(By.Id("Price"));
            PriceTextBox.SendKeys("22");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(4000);

            IWebElement GoToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            GoToLastPageButton.Click();

            IWebElement NewCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(NewCode.Text == "abc", "actual code and expected code do not match");



            //Assertion second method
            //if (NewCode.Text == "abc")
            //{
            //    Assert.Pass("new record successfully created.");
            //}

            //else

            //{
            //    Assert.Fail("new record unsuccessfull.");

            //}

        }

        public void EditTm(IWebDriver driver)
        {

            IWebElement GoToEditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            GoToEditButton.Click();

            IWebElement editTypeCodeTexbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            editTypeCodeTexbox.Click();

            IWebElement EditCodeTB = driver.FindElement(By.Id("Code"));
            EditCodeTB.SendKeys("mrng");

            IWebElement EditDescriptionTB = driver.FindElement(By.Id("Description"));
            EditDescriptionTB.SendKeys("mrng");

            IWebElement EditPriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            EditPriceTag.Click();

            IWebElement EditPrice = driver.FindElement(By.Id("Price"));
            EditPrice.SendKeys("14");

            IWebElement GoToSaveButton = driver.FindElement(By.Id("SaveButton"));
            GoToSaveButton.Click();
            Thread.Sleep(1000);

            IWebElement GoToLPButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            GoToLPButton.Click();

            Thread.Sleep(1000);

            IWebElement EditNewcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(EditNewcode.Text == "abcmrng", "actual code and expected code  match");


            //if (EditNewcode.Text == "abcmrng")
            //{
            //    Console.WriteLine("edit successfull");
            //}

            //else
            //{
            //    Console.WriteLine("edit unsuccessfull");
            //}

        }

        //private static string NewMethod()
        //{
        //    return "abcmrng";
        //}

        public void DeleteTm(IWebDriver driver)
        {
            // click on delete button
            IWebElement goToDeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            goToDeleteButton.Click();

            // click on ok in the pop up
            driver.SwitchTo().Alert().Accept();


            IWebElement EditedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            EditedCode.Click();
            // validate your test

            Assert.That(EditedCode.Text  != "Automated text", "delete successfull");
            //if (Lastpage.Text == null)
            //{
            //    Console.WriteLine("DeleteTm successfull");

            //}
            //else
            //{
            //    Console.WriteLine("DeleteTm unsuccessfull");
            //}
        }
    }
}
