using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace capitulo06.ExemploLivro
{
    public class TesteDoCadastro
    {
        private IWebDriver driver;

        public TesteDoCadastro(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void PreencheFormulario(string nome, string email)
        {
            driver.FindElement(By.Id("nome")).SendKeys(nome);
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("btnCadastrar")).Click();
        }
    }
}
