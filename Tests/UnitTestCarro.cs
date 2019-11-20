using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using Winium.Elements.Desktop.Extensions;
using Winium.Pages;
using Winium.Utils;

namespace Winium
{
    class UnitTestCarro
    {
        GerenciadorDriver gerenciador = new GerenciadorDriver();
        WiniumDriver driver;
        [SetUp]
        public void Setup()
        {

            driver = gerenciador.AbrirDriver("C:\\Users\\RENEE\\source\\repos\\Winium\\LocadoraCarros\\BethesdaCarRental1.exe", "C:\\Users\\RENEE\\source\\repos\\Winium\\Winium.Desktop.Driver");

        }

        [Test]
        public void Carro()
        {
            MenuPrincipalPage menupage = new MenuPrincipalPage(driver);
            EditorCarroPage editorcarropage = new EditorCarroPage(driver);

            menupage.ClicarBotaoCarros();
            editorcarropage.DigitarNumPlaca();
            editorcarropage.DigitarMarca();
            editorcarropage.DigitarModelo();
            editorcarropage.DigitarAno();
            editorcarropage.SelecionarCategoria();
            editorcarropage.EscolherTipoAparelho();
            editorcarropage.MarcarVeicDisponível();
            editorcarropage.ClicarNaoPossuiAr();
            editorcarropage.ClicarPossuiAr();
            editorcarropage.ClicarBotãoSelImagem();
            editorcarropage.DigitarNomeArquivo();
            Thread.Sleep(1000);
            editorcarropage.ClicarBotaoAbrir();
            editorcarropage.ClicarBotãoSubmeter();


        }

        [TearDown]
        public void After()
        {
            gerenciador.FecharDriver();
        }
    }
}
