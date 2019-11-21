using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;

namespace Winium.Pages
{
    class ClientePage
    {
        private readonly WiniumDriver _driver;

        public ClientePage(WiniumDriver driver)
        {
            _driver = driver;
        }
        public void ClicarBotaoNovoCliente()
        {
            _driver.FindElementById("btnNewCustomer").Click();
        }
        public void ValidarValores()
        {
            Actions actions = new Actions(_driver);


            //Validações das informações da grid
            var cnhElement = _driver.FindElement(By.XPath("//*[contains(@Name,'1457899')]"));
            string cnh = cnhElement.GetAttribute("Name");
            Assert.AreEqual("145789956541", cnh);

            var nomeElement = _driver.FindElement(By.XPath("//*[contains(@Name,'Fonseca2')]"));
            string nome = nomeElement.GetAttribute("Name");
            Assert.AreEqual("Antônio Fonseca2", nome);

            var enderecoElement = _driver.FindElement(By.XPath("//*[contains(@Name,'São Paulo')]"));
            string endereco = enderecoElement.GetAttribute("Name");
            Assert.AreEqual("Rua São Paulo", endereco);

            var cidadeElement = _driver.FindElement(By.XPath("//*[contains(@Name,'Divin')]"));
            string cidade = cidadeElement.GetAttribute("Name");
            Assert.AreEqual("Divinópolis", cidade);

            var ufElement = _driver.FindElement(By.XPath("//*[contains(@Name,'MG')]"));
            string uf = ufElement.GetAttribute("Name");
            Assert.AreEqual("MG 	", uf);

            var cepElement = _driver.FindElement(By.XPath("//*[contains(@Name,'287')]"));
            string cep = cepElement.GetAttribute("Name");
            Assert.AreEqual("35501287", cep);


            var itensgrid = _driver.FindElementsByXPath("//*[@LocalizedControlType='item']");
            var qtd = itensgrid.Count;
            for (int i = 0; i < qtd; i++)
            {
                
                
                string elcnh = _driver.FindElementByName("CNH Linha "+i).Text;
                string elnome = _driver.FindElementByName("Nome Linha "+i).Text;
                string elendereco = _driver.FindElementByName("Endereço Linha "+i).Text;
            }


            /*
             * Não funciona aberto bug 2gis
             * var dataGrid = _driver.FindElementByName("DataGridView");
             * var itensdataGrid = element.ToDataGrid();
             * var quantItens = itensdataGrid.RowCount;
                
                var cell = itensdataGrid.Find(1,2);
                Assert.AreEqual("expected cell text", cell.Text);
                
            }*/


        }
        public void ClicarBotaoFechar()
        {
            _driver.FindElementById("btnClose").Click();
        }
    }
}
