using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo06.Refatorando
{
    public class TesteComSelenium
    {
        protected IWebDriver driver;
        public TesteComSelenium(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void preenche(String id, String valor)
        {
            driver.FindElement(By.Id("id")).SendKeys(valor);
        }

        public void submete(String id, String valor)
        {
            driver.FindElement(By.Id("id")).Click();
        }

        public void conteudo(String id, String valor)
        {
            driver.FindElement(By.Id("id")).Click();
        }

    }
}
