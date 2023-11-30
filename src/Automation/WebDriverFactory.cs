using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace DesafioAeC.Automation
{
    public class WebDriverFactory
    {
        public static IWebDriver? Create(Browser browser)
        {
            if (browser == Browser.Firefox)
            {
                var options = new FirefoxOptions();
                options.AddArgument("--ignore-certificate-errors");
                var driver = new FirefoxDriver(options);
                return driver;
            }

            if (browser == Browser.Chrome)
            {
                var options = new ChromeOptions();
                options.AddArgument("--ignore-certificate-errors");
                var driver = new ChromeDriver(Environment.CurrentDirectory, options);
                return driver;
            }

            return null;
        }
    }
}
