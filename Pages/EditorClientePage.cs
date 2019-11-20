using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Text;
using Winium.Elements.Desktop.Extensions;

namespace Winium.Pages
{
    class EditorClientePage
    {
        private readonly WiniumDriver _driver;

        public EditorClientePage(WiniumDriver driver)
        {
            _driver = driver;
        }
        public void DigitarCNH()
        {
            _driver.FindElementById("txtDrvLicNbr").SendKeys("145789956541");
        }
        public void SelecionarUF()
        {
            var cbUF = _driver.FindElementById("cbxStates");
            var itensUF = cbUF.ToComboBox();
            itensUF.Expand();
            itensUF.FindElementByName("MG 	").Click();
        }
        public void DigitarNomeCompleto()
        {
            _driver.FindElementById("txtFullName").SendKeys("Antônio Fonseca2");
        }
        public void DigitarEndereco()
        {
            _driver.FindElementById("txtAddress").SendKeys("Rua São Paulo");
        }
        public void DigitarCidade()
        {
            _driver.FindElementById("txtCity").SendKeys("Divinópolis");
        }
        public void DigitarCEP()
        {
            _driver.FindElementById("txtZIPCode").SendKeys("35501287");
        }
        public void ClicarBotaoOK()
        {
            _driver.FindElementById("btnOK").Click();
        }
        public void ClicarBotãoCancelar()
        {
            _driver.FindElementById("btnCancel").Click(); 
        }

        
        
    }

}