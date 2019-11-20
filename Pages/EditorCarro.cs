using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Text;
using Winium.Elements.Desktop.Extensions;

namespace Winium.Pages
{
    class EditorCarroPage
    {
        private readonly WiniumDriver _driver;

        public EditorCarroPage(WiniumDriver driver)
        {
            _driver = driver;
        }
        public void DigitarNumPlaca()
        {
            _driver.FindElementById("txtTagNumber").SendKeys("3149");
        }
        public void DigitarMarca()
        {
            _driver.FindElementById("txtMake").SendKeys("VOLKSWAGEM");
        }
        public void DigitarModelo()
        {
            _driver.FindElementById("txtModel").SendKeys("Voyage");
        }
        public void DigitarAno()
        {
            _driver.FindElementById("txtYear").SendKeys("2011");
        }
        public void SelecionarCategoria()
        {
            var cbCategorias = _driver.FindElementById("cbxCategories");
            var listacbCategorias = cbCategorias.ToComboBox();
            listacbCategorias.Expand();
            _driver.FindElementByName("Padrão").Click();

        }
        public void EscolherTipoAparelho()
        {
            _driver.FindElementById("chkDVDPlayer").Click();

        }
        public void MarcarVeicDisponível()
        {
            _driver.FindElementById("chkAvailable").Click();

        }
        public void ClicarPossuiAr()
        {
            _driver.FindElementById("radioButton1").Click();

        }
        public void ClicarNaoPossuiAr()
        {
            _driver.FindElementById("radioButton2").Click();

        }
        public void ClicarBotãoSelImagem()
        {
            _driver.FindElementById("btnSelectPicture").Click();

        }
        public void ClicarBotãoSubmeter()
        {
            _driver.FindElementById("btnSubmit").Click();

        }
        public void ClicarBotãoFechar()
        {
            _driver.FindElementById("btnClose").Click();

        }
        public void DigitarNomeArquivo()
        {
            string caminho = "C:\\Users\\RENEE\\source\\repos\\Winium\\Imagens\\voyage2011.jpg";
            _driver.FindElementById("1148").SendKeys(caminho);
        }
        public void ClicarBotaoAbrir()
        {
            //_driver.FindElementByName("Abrir").Click();
            _driver.FindElementByName("Abrir").SendKeys(Keys.Alt + "N");
        }

    }
}
