using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var browser = new ChromeDriver(".");
            browser.Manage().Window.Maximize();

            Console.WriteLine("Acessando o mercado livre");

            browser.Navigate().GoToUrl("https://www.mercadolivre.com.br");

            Console.WriteLine("Acessando tela de cadastro");

            Thread.Sleep(5000);

            browser.FindElement(By.LinkText("Crie a sua conta")).Click();

            Thread.Sleep(5000);

            var inputName = browser.FindElementById("firstName");
            inputName.SendKeys("Marlon");

            var inputLastName = browser.FindElementById("lastName");
            inputLastName.SendKeys("Moreno De Melo");

            var inputCpf = browser.FindElementById("identification");
            inputCpf.SendKeys("046.192.630-01");

            var inputEmail = browser.FindElementById("email");
            inputEmail.SendKeys("marlon.moreno-melo@gmail.com");

            var inputPassword = browser.FindElementById("password");
            inputPassword.SendKeys("mmm4601@");

            var checkTermo = browser.FindElementById("tyc_checkbox");
            checkTermo.Click();

            browser.Close();
        }
    }
}
