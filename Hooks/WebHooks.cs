using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace PracticeProject.Hooks
{
    [Binding]
    public sealed class WebHooks
    {
        //Declare your IWebDriver
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //Initialise and Instantiate your driver
            //driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            Kill("chromedriver");
        }
        public static void Kill(string processName)
        {
            try
            {
                Process[] runingProcesses = Process.GetProcesses();
                foreach (var process in runingProcesses)
                {
                    if (process.ProcessName.Contains(processName))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}