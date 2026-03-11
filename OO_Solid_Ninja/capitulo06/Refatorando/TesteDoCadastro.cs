using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace capitulo06.Refatorando
{
    public class TesteDoCadastro : TesteComSelenium
    {
        public TesteDoCadastro(IWebDriver driver) : base(driver)
        {
        }
        public void TelaCadastro()
        {
            preenche("nome", "João");
            submete("nome", "João");

        }
    }
}
