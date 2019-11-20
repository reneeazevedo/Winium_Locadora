using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Winium.Pages
{
    class MenuPrincipalPage
    {
        private readonly WiniumDriver _driver;

        public MenuPrincipalPage(WiniumDriver driver)
        {
            _driver = driver;
        }

        public void ClicarBotaoLocacao()
        {
            _driver.FindElementById("btnRentalOrders").Click();
        }
        public void ClicarMenuCliente()
        {
            Actions actions = new Actions(_driver);
            var element = _driver.FindElementByName("Cadastro");
            element.Click();
            actions.MoveToElement(element.FindElement(By.Name("Clientes "))).Click().Build().Perform();
            actions.MoveToElement(element.FindElement(By.Name("Novo "))).Click().Build().Perform();
        }
        public void ClicarBotaoCarros()
        {
            _driver.FindElementById("btnCars").Click();
        }

    }
}
