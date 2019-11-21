using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System;
using Winium.Elements.Desktop.Extensions;

namespace Winium.Pages
{
    class ProcessamentoLocacaoPage
    {
        private readonly WiniumDriver _driver;

        public ProcessamentoLocacaoPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarBotaoLocacao()
        {
            _driver.FindElementById("btnRentalOrders").Click();
        }
        public void DigitarNumero()
        {
            _driver.FindElementByName("Número # :").SendKeys("12345");
        }
        public void DigitarNomeEmpregado()
        {
            _driver.FindElementById("txtNomeEmpregado").SendKeys("Renée Moura Azevedo");
        }
        public void DigitarCNH()
        {
            _driver.FindElementById("txtNumeroRegistroCNH").SendKeys("10292");
        }

        public void DigitarNomeCliente()
        {
            _driver.FindElementById("txtNomeCliente").SendKeys("Maria de Lourdes Moura Azevedo");
        }
        public void DigitarEnderecoCliente()
        {
            _driver.FindElementById("txtEnderecoCliente").SendKeys("Rua 1");
        }
        
        public void DigitarCidadeCliente()
        {
            _driver.FindElementById("txtCidadeCliente").SendKeys("Divinópolis");
        }
        //interação com combobox
        public void SelecionarUFCliente()
        {
            var cbUf = _driver.FindElementById("cboClientesEstados");
            var cbItens = cbUf.ToComboBox();
            cbItens.Expand();
            cbItens.FindElementByName("SC 	").Click();
        }
        
        public void DigitarCepCliente()
        {
            _driver.FindElementById("txtCepCliente").SendKeys("35510-287");
        }

        public void DigitarTagNumber()
        {
            _driver.FindElementById("txtTagNumber").SendKeys("123");
        }
        public void DigitarFabricante()
        {
            _driver.FindElementById("txtMake").SendKeys("FIAT");
        }
        
        public void DigitarAnoFabricacao()
        {
            _driver.FindElementById("txtCarYear").SendKeys("2011");
        }
        public void DigitarKmInicial()
        {
            _driver.FindElementById("txtMileageStart").SendKeys("20000");
        }

        
        
        public void SelecionarConservacaoCarro()
        {
            var cbEstadoCarro = _driver.FindElementById("cbxCarConditions");
            var cbItensEstadoCarro = cbEstadoCarro.ToComboBox();
            cbItensEstadoCarro.Expand();
            cbItensEstadoCarro.FindElementByName("Excelente").Click();
        }
        
        public void DigitarModeloCarro()
        {
            _driver.FindElementById("txtModel").SendKeys("Fusca");
        }
        
        public void SelecionarStatusTanque()
        {
            var listTanque = _driver.FindElementById("cbxTankLevels");
            var itensList = listTanque.ToComboBox();
            itensList.Expand();
            itensList.FindElementByName("1/2 Cheio").Click();


        }
        public void DigitarKmFinal()
        {
            _driver.FindElementById("txtMileageEnd").SendKeys("31000");
        }

        public void DigitarDataInicLoc()
        {
            _driver.FindElementById("dtpStartDate").SendKeys("25");
        }
        public void DigitarDataFimLoc()
        {
            _driver.FindElementById("dtpEndDate").SendKeys("28");
        }
        public void SelecionarStatusPedido()
        {
            var listOrders = _driver.FindElementById("cbxOrderStatus");
            var itensOrders = listOrders.ToComboBox();
            itensOrders.Expand();
            itensOrders.FindElementByName("Carro Alugado").Click();
            
        }
        public void DigitarTaxaAplicada()
        {
            _driver.FindElementById("txtRateApplied").SendKeys("38,95");
        }
        public void ClicarBotaoCalcular()
        {
            
            _driver.FindElementById("btnCalculate").Click();
            var taxaCalculada = _driver.FindElement(By.Id("txtOrderTotal")).Text;
            
            Assert.AreEqual("1022,44", taxaCalculada);
            
            
        }
    }



    //Interação com elemento date_time_picker
    /*var date_time_picker = driver.FindElementById("dtpStartDate");
    driver.ExecuteScript("automation: ValuePattern.SetValue", date_time_picker, "24/10/2019 00:00:00");*/

}
