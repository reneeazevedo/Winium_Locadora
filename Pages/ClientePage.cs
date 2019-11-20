using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Winium;
using System.Diagnostics;
using System.IO;
using System;
using System.Threading;
using Winium.Elements.Desktop.Extensions;

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

            //var lista = _driver.FindElementByName("dadadad").Text;
            //Assert.AreEqual("Rua São Paulo", lista);


            //Validações das informações da grid
            /*var cnhElement = _driver.FindElement(By.XPath("//*[contains(@Name,'1457899')]"));
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


            //var e = _driver.FindElement(By.XPath("//*[contains(@Name,'Endereço Linha 0')]"));
            //var e = _driver.FindElementByName("Endereço Linha 0");*/


            /*
            var e = _driver.FindElement(By.XPath("//*[contains(@Name,'Endereço Linha 0')]"));
            var item1 = _driver.FindElement(By.XPath("//*[contains(@Value.Value, 'MARIA')]"));
            //var item=grid.FindElement(By.Name("Nome Linha 0")).GetAttribute("Value.Value");
            Console.WriteLine(e.Text);

            */
            /*var list = grid.ToListBox();
            var datagrid = list.ToDataGrid();
            int quant = datagrid.RowCount;
            */

            var itensgrid = _driver.FindElementsByXPath("//*[@LocalizedControlType='item']");
            var qtd = itensgrid.Count;
            for (int i = 0; i < qtd; i++)
            {
                
                
                string elcnh = _driver.FindElementByName("CNH Linha "+i).Text;
                string elnome = _driver.FindElementByName("Nome Linha "+i).Text;
                string elendereco = _driver.FindElementByName("Endereço Linha "+i).Text;

 

            }
            var enum2 = itensgrid.GetEnumerator();
            enum2.MoveNext();
            var valorcorrente = enum2.Current;
            var ab = valorcorrente.GetAttribute("Name");

            Console.WriteLine(ab);
            enum2.MoveNext();
            valorcorrente = enum2.Current;
            ab = valorcorrente.GetAttribute("Name");

            Console.WriteLine(ab);



            var element1 = _driver.FindElementByName("CNH Linha ").Text;
            //var atrib = itensgrid.GetAttribute("Name");
            var element2 = _driver.FindElementByName("Endereço Linha 0").Text;
            Console.WriteLine(element1);
            Console.WriteLine(element2);
            Assert.AreEqual("123456789;Maria;Rua São Paulo", element1);

            string a = "123456789;Maria;Rua São Paulo";
            string [] aux = a.Split(";");
            foreach (string aaa in aux)
                Console.WriteLine(aaa);


            /*var quantItens = listItens.RowCount;
            var element = _driver.FindElementByName("DataGridView");
                var dataGrid = element.ToDataGrid();
                var cell = dataGrid.Find(1,2);
                Assert.AreEqual("expected cell text", cell.Text);
                
            }*/


        }
        public void ClicarBotaoFechar()
        {
            _driver.FindElementById("btnClose").Click();
        }
    }
}
