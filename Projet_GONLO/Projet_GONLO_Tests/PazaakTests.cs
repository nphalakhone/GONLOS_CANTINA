using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet_GONLO;
using Projet_GONLO.Classes;
using System.ComponentModel;


namespace Projet_GONLO_Tests
{
    [TestClass]
    public class PazaakTests
    {
        private PrivateObject pazaakTest;


        [TestMethod]
        public void SetupAiDeckTest()
        {
            //Arrange
            pazaakTest = new PrivateObject(new Pazaak(null, null));

            //Act
            pazaakTest.Invoke("SetupAiDeck");//call method
            List<Panel> TabPnlAiDeck = (List<Panel>)pazaakTest.GetField("TabPnlAiDeck");//getObject
            int compteur = 0;
            for (int i = 0; i < TabPnlAiDeck.Count; i++)
            {
                if (TabPnlAiDeck[i].BackgroundImage != null && 
                    TabPnlAiDeck[i].BackgroundImageLayout == ImageLayout.Stretch)
                {
                    compteur++;
                }
            }

            //Assert
            Assert.AreEqual(4, compteur);


        }

        [TestMethod]
        public void TabToListTest()
        {
            //Arrange
            pazaakTest = new PrivateObject(new Pazaak(null, null));

            //Act
            int[] carteIntEnvoye =
            {
                3,3,3,3
            };
            
            //Assert
            Assert.AreEqual(carteIntEnvoye, pazaakTest.Invoke("TabToList", carteIntEnvoye));
        }

        [TestMethod]
        public void SetupBoardTest()
        {
            //Arrange
            pazaakTest = new PrivateObject(new Pazaak(null, null));

            //Act
            pazaakTest.Invoke("SetupBoard");//call method
            List<Panel> TabPanelLeft = (List<Panel>)pazaakTest.GetField("TabPanelLeft");//getObject
            List<Panel> TabPanelRight = (List<Panel>)pazaakTest.GetField("TabPanelRight");//getObject
            int compteurLeft = 0;
            int compteurRight = 0;
            for (int i = 0; i < TabPanelLeft.Count; i++)
            {
                 if (TabPanelLeft[i] != null)
                  {
                    compteurLeft++;
                  }
                 if (TabPanelRight[i] != null)
                {
                    compteurRight++;
                }
            }

            //Assert
            Assert.AreEqual(TabPanelLeft.Count, compteurLeft);
            Assert.AreEqual(TabPanelRight.Count, compteurRight);
        }


        [TestMethod]
        public void setupPlayerdeckTest()
        {
            //Arrange
            pazaakTest = new PrivateObject(new Pazaak(null, null));

            //Act
            pazaakTest.Invoke("SetupPlayerdeck");//call method
            List<Panel> panelPlayerDeck = (List<Panel>)pazaakTest.GetField("panelPlayerDeck");//getObject
            int[] AiDeck = (int[])pazaakTest.GetField("AiDeck");//getObject
            int compteur = 0;
            for (int i = 0; i < AiDeck.Length; i++)
            {
                if (AiDeck[i] > -7 && AiDeck[i] < 13)
                {
                    compteur++;
                }
            }

            //Assert
            Assert.AreEqual(AiDeck.Length, compteur);
        }


        [TestMethod]
        public void SelectCardsForDeckTest()
        {
            //Arrange
            pazaakTest = new PrivateObject(new Pazaak(null, null));

            //Act
            pazaakTest.Invoke("SelectCardsForDeck");//call method
            List<Panel> panelPlayerDeck = (List<Panel>)pazaakTest.GetField("panelPlayerDeck");//getObject
            int[] AiDeck = (int[])pazaakTest.GetField("AiDeck");//getObject
            int compteur = 0;
            for (int i = 0; i < AiDeck.Length; i++)
            {
                if (AiDeck[i] > -7 && AiDeck[i] < 13)
                {
                    compteur++;
                }
            }

            //Assert
            Assert.AreEqual(AiDeck.Length, compteur);
        }










    }
}
