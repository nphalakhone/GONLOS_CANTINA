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
            
            int[] carteIntEnvoye = { 1,2,3,4,5,6,7,8,9,10};
            List<Image> playerDeckPazaak = new List<Image>();
            for (int i = 0; i < 10; i++)
            {
                //Projet_GONLO.Properties.Resources.Carte4;
                playerDeckPazaak.Add(Projet_GONLO.Properties.Resources.Carte4);
            }
            

            //Arrange
            pazaakTest = new PrivateObject(new Pazaak(playerDeckPazaak, carteIntEnvoye));

            //Act
            pazaakTest.Invoke("SetupAiDeck");//call method
            Panel[] TabPnlAiDeck = (Panel[])pazaakTest.GetField("TabPnlAiDeck");//getObject
            int compteur = 0;
            for (int i = 0; i < TabPnlAiDeck.Length; i++)
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
            int[] carteIntEnvoye = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4};
            List<Image> playerDeckPazaak = new List<Image>();
            for (int i = 0; i < 10; i++)
            {
                
                playerDeckPazaak.Add(Projet_GONLO.Properties.Resources.Carte4);
            }
            pazaakTest = new PrivateObject(new Pazaak(playerDeckPazaak, carteIntEnvoye));

            //Act
            List<int> listeTest = (List<int>) pazaakTest.Invoke("TabToList", carteIntEnvoye);
            bool pareil = true;
            for (int i = 0; i < listeTest.Count; i++)
            {
                if (listeTest[i] != carteIntEnvoye[i])
                {
                    pareil = false;
                }
            }

            //Assert
           Assert.AreEqual(true, pareil);
        }

        [TestMethod]
        public void SetupBoardTest()
        {
            //Arrange
            int[] carteIntEnvoye = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            List<Image> playerDeckPazaak = new List<Image>();
            for (int i = 0; i < 10; i++)
            {

                playerDeckPazaak.Add(Projet_GONLO.Properties.Resources.Carte4);
            }
            pazaakTest = new PrivateObject(new Pazaak(playerDeckPazaak, carteIntEnvoye));

            //Act
            pazaakTest.Invoke("SetupBoard");//call method
            Panel[] TabPanelLeft = (Panel[])pazaakTest.GetField("TabPanelLeft");//getObject
            Panel[] TabPanelRight = (Panel[])pazaakTest.GetField("TabPanelRight");//getObject
            int compteurLeft = 0;
            int compteurRight = 0;
            for (int i = 0; i < TabPanelLeft.Length; i++)
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
            Assert.AreEqual(TabPanelLeft.Length, compteurLeft);
            Assert.AreEqual(TabPanelRight.Length, compteurRight);
        }


        [TestMethod]
        public void SetupPlayerdeckTest()
        {

            //Arrange
            int[] carteIntEnvoye = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            List<Image> playerDeckPazaak = new List<Image>();
            for (int i = 0; i < 10; i++)
            {

                playerDeckPazaak.Add(Projet_GONLO.Properties.Resources.Carte4);
            }
            pazaakTest = new PrivateObject(new Pazaak(playerDeckPazaak, carteIntEnvoye));

            //Act
            pazaakTest.Invoke("SetupPlayerdeck");//call method
            Panel[] panelPlayerDeck = (Panel[])pazaakTest.GetField("panelPlayerDeck");//getObject
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
            int[] carteIntEnvoye = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            List<Image> playerDeckPazaak = new List<Image>();
            for (int i = 0; i < 10; i++)
            {

                playerDeckPazaak.Add(Projet_GONLO.Properties.Resources.Carte4);
            }
            pazaakTest = new PrivateObject(new Pazaak(playerDeckPazaak, carteIntEnvoye));

            //Act
            pazaakTest.Invoke("SelectCardsForDeck");//call method
            List<int> ListIntSelectionne = (List<int>)pazaakTest.GetField("ListIntSelectionne");//getObject
            int compteur = 0;
            for (int i = 0; i < ListIntSelectionne.Count; i++)
            {
                if (ListIntSelectionne[i] > -7 && ListIntSelectionne[i] < 13)
                {
                    compteur++;
                }
            }

            //Assert
            Assert.AreEqual(ListIntSelectionne.Count, compteur);
        }


        [TestMethod]
        public void AddAICardToBoardTest()
        {
            //Arrange
            int[] carteIntEnvoye = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            List<Image> playerDeckPazaak = new List<Image>();
            for (int i = 0; i < 10; i++)
            {

                playerDeckPazaak.Add(Projet_GONLO.Properties.Resources.Carte4);
            }
            pazaakTest = new PrivateObject(new Pazaak(playerDeckPazaak, carteIntEnvoye));

            //Act
            pazaakTest.Invoke("AddAICardToBoard",1);//call method
            Panel[] TabPanelRight = (Panel[])pazaakTest.GetField("TabPanelRight");//getObject
            Player player = (Player)pazaakTest.GetField("ai");
            bool cardAdded = false;
            if (TabPanelRight[player.NbCards-1].BackgroundImage != null)
            {
                cardAdded = true;
            }

            //Assert
            Assert.AreEqual(true, cardAdded);
        }

        [TestMethod]
        public void AddCardTest()
        {
            //Arrange
            int[] carteIntEnvoye = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            List<Image> playerDeckPazaak = new List<Image>();
            for (int i = 0; i < 10; i++)
            {

                playerDeckPazaak.Add(Projet_GONLO.Properties.Resources.Carte4);
            }
            pazaakTest = new PrivateObject(new Pazaak(playerDeckPazaak, carteIntEnvoye));

            //Act
            pazaakTest.Invoke("AddCard", Move.AddCard1);//call method
            Panel[] TabPanelRight = (Panel[])pazaakTest.GetField("TabPanelRight");//getObject
            Player ai = (Player)pazaakTest.GetField("ai");
            bool cardAdded = false;
            if (TabPanelRight[ai.NbCards - 1].BackgroundImage != null)
            {
                cardAdded = true;
            }

            //Assert
            Assert.AreEqual(true, cardAdded);
        }

        [TestMethod]
        public void DetermineMoveTest()
        {
            //Arrange
            int[] carteIntEnvoye = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            List<Image> playerDeckPazaak = new List<Image>();
            for (int i = 0; i < 10; i++)
            {

                playerDeckPazaak.Add(Projet_GONLO.Properties.Resources.Carte4);
            }
            pazaakTest = new PrivateObject(new Pazaak(playerDeckPazaak, carteIntEnvoye));

            //Act
            Player player = (Player)pazaakTest.GetField("ai");
            player.Points = 20;
            Move move = (Move)pazaakTest.Invoke("DetermineMove");//call method
            bool correctMove = false;
            if (move == Move.Stand)
            {
                correctMove = true;
            }

            //Assert
            Assert.AreEqual(true, correctMove);
        }
















    }
}
