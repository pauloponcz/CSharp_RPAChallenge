using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBot
{
    internal class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public void AcessURL(string str_url)
        {
            driver.Navigate().GoToUrl(str_url);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//button[text() = 'Start']")).Click();

        }

        public void FillInData(System.Data.DataTable dt_Data)
        {
            Console.WriteLine("[DEBUG] Preenchendo Informações...");
            foreach (DataRow row in dt_Data.Rows)
            {
                //Fill in the First Name field
                driver.FindElement(By.XPath("//input[@ng-reflect-name = 'labelFirstName']")).SendKeys(row[0].ToString());
                //Fill in the Last Name field
                driver.FindElement(By.XPath("//input[@ng-reflect-name = 'labelLastName']")).SendKeys(row[1].ToString());
                //Fill in the Company Name field
                driver.FindElement(By.XPath("//input[@ng-reflect-name = 'labelCompanyName']")).SendKeys(row[2].ToString());
                //Fill in the Role in Company field
                driver.FindElement(By.XPath("//input[@ng-reflect-name = 'labelRole']")).SendKeys(row[3].ToString());
                //Fill in the Address field
                driver.FindElement(By.XPath("//input[@ng-reflect-name = 'labelAddress']")).SendKeys(row[4].ToString());
                //Fill in the Email field
                driver.FindElement(By.XPath("//input[@ng-reflect-name = 'labelEmail']")).SendKeys(row[5].ToString());
                //Fill in the First Name field
                driver.FindElement(By.XPath("//input[@ng-reflect-name = 'labelPhone']")).SendKeys(row[6].ToString());

                //Click in Submit
                driver.FindElement(By.XPath("//input[@type = 'submit']")).Click();

            }
        }

    }
}
