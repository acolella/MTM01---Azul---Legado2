using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SilkTest.Ntf;
using SilkTest.Ntf.XBrowser;

namespace Regressivo___Legado.Keyword_Driven_Tests
{
    [SilkTestClass]
    public class CT___RG___0001
    {
        private readonly Desktop _desktop = Agent.Desktop;

        [TestInitialize]
        public void Initialize()
        {
            // Go to web page 'www.voeazul.com.br'
            BrowserBaseState baseState = new BrowserBaseState();
            baseState.Execute();
        }

        [TestMethod]
        public void TestMethod1()
        {
            BrowserApplication webBrowser = _desktop.BrowserApplication("voeazul_com_br");

            BrowserWindow browserWindow = webBrowser.BrowserWindow("BrowserWindow");
            browserWindow.DomTextField("login-username").SetText("29942912574");
            browserWindow.DomTextField("password").SetText("123456");
            browserWindow.DomButton("OK2").Click();
            Silk4NET.VerifyAsset("Exclamação Vermelho");
            Assert.AreEqual(true, browserWindow.DomElement("icon icon-alert").Visible);
            Assert.AreEqual("", browserWindow.DomElement("icon icon-alert").Text);
            Assert.AreEqual("icon icon-alert", browserWindow.DomElement("icon icon-alert").GetProperty("class"));
            Assert.AreEqual(true, browserWindow.DomElement("Atenção!").Visible);
            Assert.AreEqual("Atenção!", browserWindow.DomElement("Atenção!").Text);
            Assert.AreEqual("dialog-0003__title", browserWindow.DomElement("Atenção!").GetProperty("class"));
            Assert.AreEqual(true, browserWindow.DomElement("Se o seu login usual").Visible);
            Assert.AreEqual("Se o seu login usual não funcionar, por favor tente usar o seu CPF (somente números, sem hífen ou pontos) ou verifique a digitação da sua senha.Persistindo o problema entre em contato com o TudoAzul: 11 – 4003 1141 ou pelo email: tudoazul@voeazul.com.br", browserWindow.DomElement("Se o seu login usual").Text);
            Assert.AreEqual("dialog-0003__message dialog-0003__message--small", browserWindow.DomElement("Se o seu login usual").GetProperty("class"));
            /*Silk4NET.VerifyAsset("Botão OK Vermelho");*/
            browserWindow.DomButton("OK").Click();
            Assert.AreEqual("login-username", browserWindow.DomTextField("login-username").GetProperty("id"));
        }
    }
}