using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;

namespace Task3_2
{
    class WebDriverInitializer
    {
        enum Browsers{Firefox, Opera, Chrome, InternetExplorer, Safari}

        public IWebDriver Initialize()
        {
            IWebDriver driver = null;
            switch (int.Parse(ConfigurationManager.AppSettings["Browser"]))
            {
                case (int)Browsers.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case (int)Browsers.Opera:
                    driver = new OperaDriver();
                    break;
                case (int)Browsers.Chrome:
                    driver = new ChromeDriver();
                    break;
                case (int)Browsers.InternetExplorer:
                    driver = new InternetExplorerDriver();
                    break;
                case (int)Browsers.Safari:
                    driver = new SafariDriver();
                    break;
                default://??
                    driver = new FirefoxDriver();
                    break;
            }
            return driver;
        }
    }
}
