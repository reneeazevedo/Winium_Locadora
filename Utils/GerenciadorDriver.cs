using OpenQA.Selenium.Winium;
using System;
using System.Diagnostics;

namespace Winium.Utils
{
    class GerenciadorDriver
    {
        DesktopOptions option;
        WiniumDriver driver = null;
        public WiniumDriver AbrirDriver(string caminhoapp, string caminhodriver)
        {
           
            option = new DesktopOptions();
            option.ApplicationPath = caminhoapp;

            driver = new WiniumDriver(caminhodriver, option, TimeSpan.FromSeconds(360));
            return driver;
        }
        public void FecharDriver()
        {
            Process[] appwiniumdriver = Process.GetProcessesByName("Winium.Desktop.Driver");

            foreach (Process process in appwiniumdriver)
            {
                process.Kill();
            }
            Process[] applocadora = Process.GetProcessesByName("BethesdaCarRental1");

            foreach (Process process in applocadora)
            {
                process.Kill();
            }

        }
    }
}
