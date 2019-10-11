using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using AutoIt;

namespace MainForm
{
    public class Main
    {
        // the driver is required to manage the browser connection
        private static IWebDriver driver;

        public static void loginTwitter(string user, string pwd)
        {
            // set driver to open G. Chrome
            driver = new ChromeDriver();
            // set url
            string url = "http://www.twitter.com";
            // go to the url
            driver.Navigate().GoToUrl(url);
            
            // create 'wait' object to wait 15 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // maximize the browser
            driver.Manage().Window.Maximize();
            AutoItX.Sleep(1000);
            // wait 10 seconds to find element LOGIN
            wait.Until(driver => driver.FindElement(By.Name("session[username_or_email]")));
            // set element login
            IWebElement elLogin = driver.FindElement(By.Name("session[username_or_email]"));

            // wait 10 seconds to find element PASSWORD
            wait.Until(driver => driver.FindElement(By.Name("session[password]")));
            //set element password
            IWebElement elPassword = driver.FindElement(By.Name("session[password]"));

            // setting the field LOGIN ans PASSWORD to value of user parameter
            elLogin.SendKeys(user);
            elPassword.SendKeys(pwd);

            // initiate a java script executor, so we can inject js to the page
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // emulate a click on the button
            js.ExecuteScript("var el = document.querySelector('[type=\"submit\"]');" +
                "el.click()");

            // if u want to close the driver
            //driver.Close();
        }

        // Facebook

        public static void loginFacebook(string user, string pwd)
        {
            // set driver to open G. Chrome
            driver = new ChromeDriver();
            // set url
            string url = "http://www.facebook.com";
            // go to the url
            driver.Navigate().GoToUrl(url);

            // create 'wait' object to wait 15 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // maximize the browser
            driver.Manage().Window.Maximize();
            AutoItX.Sleep(1000);
            // wait 10 seconds to find element LOGIN
            wait.Until(driver => driver.FindElement(By.Name("email")));
            // set element login
            IWebElement elLogin = driver.FindElement(By.Name("email"));

            // wait 10 seconds to find element PASSWORD
            wait.Until(driver => driver.FindElement(By.Name("pass")));
            //set element password
            IWebElement elPassword = driver.FindElement(By.Name("pass"));

            // setting the field LOGIN ans PASSWORD to value of user parameter
            elLogin.SendKeys(user);
            elPassword.SendKeys(pwd);

            // initiate a java script executor, so we can inject js to the page
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // emulate a click on the button
            js.ExecuteScript("var el = document.querySelector('[type=\"submit\"]');" +
                "el.click()");

            // if u want to close the driver
            //driver.Close();
        }

        // Gmail

        public static void loginGmail(string user, string pwd)
        {
            // set driver to open G. Chrome
            driver = new ChromeDriver();
            // set url
            string url = "http://www.gmail.com";
            // go to the url
            driver.Navigate().GoToUrl(url);

            // create 'wait' object to wait 15 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // maximize the browser
            driver.Manage().Window.Maximize();
            AutoItX.Sleep(1000);
            // wait 10 seconds to find element LOGIN
            wait.Until(driver => driver.FindElement(By.Id("identifierId")));
            // set element login
            IWebElement elLogin = driver.FindElement(By.Id("identifierId"));
            // set element next
            IWebElement btnNextLogin = driver.FindElement(By.Id("identifierNext"));
            elLogin.SendKeys(user);
            AutoItX.Sleep(1000);
            // click on next
            btnNextLogin.Click();

            // sleep to wait the page load
            AutoItX.Sleep(5000);

            // wait 10 seconds to find element PASSWORD
            wait.Until(driver => driver.FindElement(By.Name("password")));
            //set element password
            IWebElement elPassword = driver.FindElement(By.Name("password"));
            // set element next
            IWebElement btnNextPwd = driver.FindElement(By.Id("passwordNext"));
            elPassword.SendKeys(pwd);
            AutoItX.Sleep(1000);
            // click on next/login
            btnNextPwd.Click();

            // if u want to close the driver
            //driver.Close();
        }

        // GitHub

        public static void loginGit(string user, string pwd)
        {
            // set driver to open G. Chrome
            driver = new ChromeDriver();
            // set url
            string url = "https://github.com/login";
            // go to the url
            driver.Navigate().GoToUrl(url);

            // create 'wait' object to wait 15 seconds
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // maximize the browser
            driver.Manage().Window.Maximize();
            AutoItX.Sleep(1000);
            // wait 10 seconds to find element LOGIN
            wait.Until(driver => driver.FindElement(By.Id("login_field")));
            // set element login
            IWebElement elLogin = driver.FindElement(By.Id("login_field"));

            // sleep to wait the page load
            AutoItX.Sleep(1000);

            // wait 10 seconds to find element PASSWORD
            wait.Until(driver => driver.FindElement(By.Id("password")));
            //set element password
            IWebElement elPassword = driver.FindElement(By.Id("password"));

            // set button login
            IWebElement btnLogin = driver.FindElement(By.Name("commit"));
            elLogin.SendKeys(user);
            AutoItX.Sleep(1000);
            elPassword.SendKeys(pwd);
            AutoItX.Sleep(1000);
            // click on next/login
            btnLogin.Click();

            // if u want to close the driver
            //driver.Close();
        }


    }
}
