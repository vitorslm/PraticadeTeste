using NUnit.Framework;
using TesteUnit;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Internal;
using NUnitTestClosedXML;

namespace TesteUnit
{
    public class AoAcessarLoja
    {
        ClassNavegador pagina = new ClassNavegador();
        String test_url = "http://www.americanas.com.br";
        IWebDriver driver;
        

        [SetUp]
        public void start_Browser()
        {
            pagina.Init_Browser();
        }

        [Test]
        public void ProcurarPorMotorolaOneVision()
        {
            pagina.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = pagina.getDriver;

            /* Usando busca pelo Id */
            IWebElement element = driver.FindElement(By.Id("h_search-input"));

            element.SendKeys("Smartphone Motorola One Vision");

            /* Efetua Busca */
            element.Submit();

            System.Threading.Thread.Sleep(4000);

            /* Usando busca pelo Xpath */
            IWebElement element2 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[3]/div/div[1]/div/div[3]/div[2]/div/div/section/div/div/div/div[2]/div/div/div/div/div/div[1]/div/div/div"));

            /* Acessa Produto */
            element2.Click();

            IWebElement valorDoProduto = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[2]/span"));
            IWebElement nomeDaLoja = driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[2]/div/div[1]/h3/a"));
            IWebElement valorDoCashback = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[2]/div/div/div[2]/div/div[1]/div/span/span/span[3]"));
            IWebElement nomeDoProduto = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[1]/div[2]/div[1]/div[1]/h1"));

            Produto produto = new Produto();
            produto.Valor = valorDoProduto.Text;
            produto.Loja = nomeDaLoja.Text;
            produto.Cashback = valorDoCashback.Text;
            produto.Nome = nomeDoProduto.Text;
            GerenciaProduto.PreencheLista(produto);

            /* Pausa para verificar saída */
            System.Threading.Thread.Sleep(2000);
        }

        [Test]
        public void ProcurarPorSamsungA71()
        {
            pagina.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = pagina.getDriver;

            /* Usando busca pelo Id */
            IWebElement caixaDeBusca = driver.FindElement(By.Id("h_search-input"));

            caixaDeBusca.SendKeys("Smartphone Samsung Galaxy A71");

            /* Efetua Busca */
            caixaDeBusca.Submit();

            System.Threading.Thread.Sleep(4000);

            /* Usando busca pelo Xpath */
            IWebElement botaoBuscar = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[3]/div/div[1]/div/div[2]/div[6]/div/div/div/div[1]/div[4]/div"));

            /* Acessa Produto */
            botaoBuscar.Click();

            IWebElement valorDoProduto = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[2]/div/div[1]/div[1]/div/div[1]/div[1]/div/span"));
            IWebElement nomeDaLoja = driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[2]/div/div[1]/h3/a"));
            IWebElement valorDoCashback = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[2]/div/div[1]/div[1]/div/div[1]/div[1]/span/span/span[3]"));
            IWebElement nomeDoProduto = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[1]/div[2]/div[1]/div[1]/h1"));

            Produto produto = new Produto();
            produto.Valor = valorDoProduto.Text;
            produto.Loja = nomeDaLoja.Text;
            produto.Cashback = valorDoCashback.Text;
            produto.Nome = nomeDoProduto.Text;
            GerenciaProduto.PreencheLista(produto);

            /* Pausa para verificar saída */
            System.Threading.Thread.Sleep(2000);
        }

        [Test]
        public void ProcurarPorXiaomiRedmiNote7()
        {
            pagina.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = pagina.getDriver;

            /* Usando busca pelo Id */
            IWebElement element = driver.FindElement(By.Id("h_search-input"));

            element.SendKeys("Smartphone Xiaomi Redmi Note 7");

            /* Efetua Busca */
            element.Submit();

            System.Threading.Thread.Sleep(4000);

            /* Usando busca pelo Xpath */
            IWebElement element2 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[3]/div/div[1]/div/div[2]/div[6]/div/div/div/div[1]/div[2]/div"));

            /* Acessa Produto */
            element2.Click();

            IWebElement valorDoProduto = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[2]/div/div[1]/div[1]/div/div[1]/div[1]/div/span"));
            IWebElement nomeDaLoja = driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[2]/div/div[1]/h3/a"));
            IWebElement valorDoCashback = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[2]/div/div[1]/div[1]/div/div[1]/div[1]/span/span/span[3]"));
            IWebElement nomeDoProduto = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div/section/div/div[2]/div[1]/div[2]/div[1]/div[1]/h1"));

            Produto produto = new Produto();
            produto.Valor = valorDoProduto.Text;
            produto.Loja = nomeDaLoja.Text;
            produto.Cashback = valorDoCashback.Text;
            produto.Nome = nomeDoProduto.Text;
            GerenciaProduto.PreencheLista(produto);

            GerenciaProduto.PopulaExcel();

            /* Pausa para verificar saída */
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void close_Browser()
        {
            pagina.Close();
        }

    }
}

