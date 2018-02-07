using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SilkTest.Ntf;
using SilkTest.Ntf.Mobile;

namespace Mobile_Legado
{
    [SilkTestClass]
    public class CT_MOB_0001
    {
        private readonly Desktop _desktop = Agent.Desktop;

        [TestInitialize]
        public void Initialize()
        {
            MobileBaseState baseState = new MobileBaseState();
            baseState.Execute();
        }

        [TestMethod]
        public void TestMethod1()
        {
            MobileDevice device = _desktop.MobileDevice("Device");
            device.WaitForObject("tour_continue",4);
            device.MobileButton("tour_continue").Click();
            device.MobileButton("tour_next").Click();
            device.MobileButton("tour_next").Click();
            device.MobileButton("tour_next").Click();
            device.MobileObject("action_menu_icon").Click();
            device.MobileObject("Fazer login").Click();
            device.MobileTextField("fragment_login_edittext_login").SetText("29942851703");
            device.MobileTextField("fragment_login_edittext_senha").SetText("123456");
            device.MobileButton("fragment_login_btn_entrar").Click();
            Assert.AreEqual("Login ou senha incorretos", device.MobileObject("message").Text);
            Silk4NET.VerifyAsset("Botão OK Azul");
            device.MobileButton("button1").Click();
            Assert.AreEqual("FAZER LOGIN", device.MobileButton("fragment_login_btn_entrar").GetProperty("caption"));
        }
    }
}