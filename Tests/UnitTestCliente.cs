using NUnit.Framework;
using OpenQA.Selenium.Winium;
using Winium.Pages;
using Winium.Utils;

namespace Winium
{
    public class UnitTestCliente
    {
        GerenciadorDriver gerenciador = new GerenciadorDriver();
        WiniumDriver driver;
        [SetUp]
        public void Setup()
        {

            driver = gerenciador.AbrirDriver("C:\\Users\\RENEE\\source\\repos\\Winium\\LocadoraCarros\\BethesdaCarRental1.exe", "C:\\Users\\RENEE\\source\\repos\\Winium\\Winium.Desktop.Driver");

        }

        [Test]
        public void Cliente()
        {
            MenuPrincipalPage menupage = new MenuPrincipalPage(driver);
            ClientePage clientepage = new ClientePage(driver);
            EditorClientePage editorClientePage = new EditorClientePage(driver);
            //Steps
            menupage.ClicarMenuCliente();
            clientepage.ClicarBotaoNovoCliente();
            editorClientePage.DigitarCNH();
            editorClientePage.SelecionarUF();
            editorClientePage.DigitarNomeCompleto();
            editorClientePage.DigitarEndereco();
            editorClientePage.DigitarCEP();
            editorClientePage.DigitarCidade();
            editorClientePage.ClicarBotaoOK();
            //Validações
            clientepage.ValidarValores();
            
        }

        [TearDown]
        public void After()
        {
            gerenciador.FecharDriver();
        }
    }
}