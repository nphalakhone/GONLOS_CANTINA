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
        private PrivateObject dejarikTest;

        /// <summary>
        /// Test if the list of buttons is correclty initalized
        /// </summary>
        [TestMethod]
        public void InitializeListButtonsTest()
        {
            dejarikTest = new PrivateObject(new Dejarik(""));
            dejarikTest.Invoke("initalizeListButtons");//call method
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");//getObject
            Assert.AreEqual(26, listButtons.Count);
        }



    }
}
