using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using Winium.Elements.Desktop.Extensions;
using Winium.Pages;
using Winium.Utils;

namespace Winium
{
    public class Tests
    {
        GerenciadorDriver gerenciador = new GerenciadorDriver();
        WiniumDriver driver;
        [SetUp]
        public void Setup()
        {
            
         driver = gerenciador.AbrirDriver("C:\\Users\\RENEE\\source\\repos\\Winium\\LocadoraCarros\\BethesdaCarRental1.exe", "C:\\Users\\RENEE\\source\\repos\\Winium\\Winium.Desktop.Driver");
        
        }

        [Test]
        public void Locacao()
        {
            

            ProcessamentoLocacaoPage locacaopage = new ProcessamentoLocacaoPage(driver);
            MenuPrincipalPage menu = new MenuPrincipalPage(driver);
            
            menu.ClicarBotaoLocacao();
            /*locacaopage.DigitarNumero();
            locacaopage.DigitarNomeEmpregado();
            locacaopage.DigitarCNH();
            locacaopage.DigitarNomeCliente();
            locacaopage.DigitarEnderecoCliente();
            locacaopage.DigitarCidadeCliente();
            locacaopage.SelecionarUFCliente();
            locacaopage.DigitarCepCliente();
            locacaopage.DigitarTagNumber();
            locacaopage.DigitarFabricante();
            locacaopage.DigitarAnoFabricacao();
            locacaopage.DigitarKmInicial();
            locacaopage.SelecionarConservacaoCarro();
            locacaopage.DigitarModeloCarro();
            locacaopage.SelecionarStatusTanque();
            locacaopage.DigitarKmFinal();*/
            locacaopage.DigitarDataInicLoc();
            locacaopage.DigitarDataFimLoc();
            locacaopage.SelecionarStatusPedido();
            locacaopage.DigitarTaxaAplicada();
            locacaopage.ClicarBotaoCalcular();
            




            
           
        }

        [TearDown]
        public void After()
        {
            gerenciador.FecharDriver();
        }
    }
}