using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet_GONLO;
using Projet_GONLO.Classes;

namespace Projet_GONLO_Tests
{
    [TestClass]
    public class DejarikTest
    {

        [TestMethod]
        public void InitializeListButtonsTest()
        {
            //dejarikTest = new PrivateObject(typeof(Dejarik), "");
            //dejarikTest.Invoke("initalizeListButtons");//call method
            //List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");//get the list
            //Assert.AreEqual(26, listButtons.Count);

            var DejarikTest = new Dejarik("");
            var privatedejarikTest = new PrivateObject(DejarikTest);
            privatedejarikTest.Invoke("initalizeListButtons");
            List<Button> listButtons = (List<Button>)privatedejarikTest.GetField("listButtons");
            Assert.AreEqual(26, listButtons.Count);
        }
    }
}
