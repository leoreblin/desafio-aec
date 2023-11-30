using DesafioAeC.Automation.Domain.Entities;
using DesafioAeC.Automation.Domain.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAeC.Automation.Services
{
    public class SearchService : ISearchService
    {
        public async Task<List<SearchResult>> SearchAsync(string query)
        {
            var results = new List<SearchResult>();

            using var driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://www.alura.com.br");

            var searchBox = driver.FindElement(By.XPath("//*[@id=\"header-barraBusca-form-campoBusca\"]"));
            searchBox.SendKeys(query);
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/main/section[1]/header/div/nav/div[2]/form/button")).Click();
            Thread.Sleep(5000);

            var liElements = driver.FindElements(By.XPath("/html/body/div[2]/div[2]/section/ul/li"));

            foreach (var li in liElements)
            {

            }

            throw new NotImplementedException();
        }
    }
}
