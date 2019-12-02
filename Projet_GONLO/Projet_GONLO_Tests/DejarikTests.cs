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
    public class DejarikTest
    {
        private PrivateObject dejarikTest;
        private Player player1;
        private Player player2;

        /// <summary>
        /// Test if the list of buttons is correclty initalized
        /// </summary>
        [TestMethod]
        public void InitializeListButtonsTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));

            //Act
            dejarikTest.Invoke("initalizeListButtons");//call method
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");//getObject

            //Assert
            Assert.AreEqual(26, listButtons.Count);
        }

        /// <summary>
        /// Test if the clicked monster is the right one with the right stats
        /// </summary>
        [TestMethod]
        public void ClickedMonsterIsRightMonster()
        {
            //Arrange
            Monster myMonster = new Monster("The Mantellian Savrip",2, 3, 2,(Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Mantellian_Savrip"), typeMonster.Power, 12);
            dejarikTest = new PrivateObject(new Dejarik(""));
            player1 = new Player();
            player1.DefMonster = myMonster;
            player1.ListMonsters = new List<Monster> {player1.DefMonster};
            List<Player> players = new List<Player>();
            players.Add(player1);

            //Act
            dejarikTest.SetField("players", players);
            dejarikTest.SetField("turn", 0);
            
            //Assert
            Assert.AreEqual(myMonster, dejarikTest.Invoke("getClickMonster", 12));
        }


        /// <summary>
        /// Test if monster available moving positions are correct in normal condition
        /// </summary>
        [TestMethod]
        public void MoveAvailablePositionTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));
            List<int> accessibleButtons = new List<int>() {1,3,13,15};

            //Act and assert
            CollectionAssert.AreEqual(accessibleButtons, (List<int>)dejarikTest.Invoke("getMovAccessibleButtons", 2));
        }


        /// <summary>
        /// Test if monster available moving positions are correct when the monster has a neighbour
        /// </summary>
        [TestMethod]
        public void MoveToAvailablePositionNeighbourTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");
            listButtons[3].BackgroundImage = (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Mantellian_Savrip");//Place a neighbour at position 3
            List<int> accessibleButtons = new List<int>() { 1, 13, 15 };
            
            //Act (Monster at position 3)
            dejarikTest.SetField("listButtons", listButtons);

            //Assert After
            CollectionAssert.AreEqual(accessibleButtons, (List<int>)dejarikTest.Invoke("getMovAccessibleButtons", 2));
        }

        /// <summary>
        /// Test if a monster moved correctly and if his position has changed
        /// </summary>
        [TestMethod]
        public void MonsterMovementTest()
        {
            //Arrange
            Monster myMonster = new Monster("The Mantellian Savrip", 2, 3, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Mantellian_Savrip"), typeMonster.Power, 12);
            dejarikTest = new PrivateObject(new Dejarik(""));
            int nextPosition = 25;

            //Act
            dejarikTest.Invoke("movement", nextPosition, myMonster);
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");

            //Assert
            Assert.AreEqual(null,listButtons[12].BackgroundImage);
            Assert.AreEqual(myMonster.Position, 25);
            Assert.AreEqual(myMonster.Picture, listButtons[25].BackgroundImage);
        }

        /// <summary>
        /// Test if the player's monsters positions are correctly set up
        /// </summary>
        [TestMethod]
        public void SetUpPlayerMonstersTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));
            player1 = new Player();            
            player1.AttMonster = new Monster("The Ghhhk", 3, 2, 1, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 0);
            player1.DefMonster = new Monster("The Kintan Strider", 1, 3, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Kintan_Strider"), typeMonster.Defensive, 0);
            player1.MovMonster = new Monster("The K'lor'slug", 2, 1, 3, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("klorslaug"), typeMonster.Mobile, 0);
            player1.PowMonster = new Monster("The Monnok", 3, 2, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Monnok"), typeMonster.Power, 0);

            //Act
            dejarikTest.Invoke("setUpPlayersMonster", player1, 16, 17, 18, 19);
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");

            //Assert
            Assert.AreEqual(player1.AttMonster.Position, 16);
            Assert.AreEqual(player1.DefMonster.Position, 17);
            Assert.AreEqual(player1.MovMonster.Position, 18);
            Assert.AreEqual(player1.PowMonster.Position, 19);
            Assert.AreEqual(player1.AttMonster.Picture, listButtons[16].BackgroundImage);
            Assert.AreEqual(player1.DefMonster.Picture, listButtons[17].BackgroundImage);
            Assert.AreEqual(player1.MovMonster.Picture, listButtons[18].BackgroundImage);
            Assert.AreEqual(player1.PowMonster.Picture, listButtons[19].BackgroundImage);
        }

        /// <summary>
        /// Test if the monster's image is correctly displayed on the button (on board)
        /// </summary>
        [TestMethod]
        public void SetMonsterImgTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));
            Monster myMonster = new Monster("The Mantellian Savrip", 2, 3, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Mantellian_Savrip"), typeMonster.Power, 12);

            //Act
            dejarikTest.Invoke("setMonsterImg", myMonster.Position, myMonster.Picture);
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");

            //Assert
            Assert.AreEqual(myMonster.Picture, listButtons[12].BackgroundImage);
        }

        /// <summary>
        /// Test if the monster's image and stats are correctly displayed on the right side of the board
        /// </summary>
        [TestMethod]
        public void SetInfoMonstersTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));
            Monster myMonster = new Monster("The Mantellian Savrip", 2, 3, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Mantellian_Savrip"), typeMonster.Power, 12);

            //Act
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");
            PictureBox p = (PictureBox)dejarikTest.GetField("imgP1MonsterAtk");
            Label atk = (Label)dejarikTest.GetField("LblAtkMonsterAtk1");
            Label def = (Label)dejarikTest.GetField("LblDefMonsterAtk1");
            Label mov = (Label)dejarikTest.GetField("LblMovMonsterAtk1");
            dejarikTest.Invoke("setInfoMonsters", p, atk,def, mov, myMonster);

            //Assert
            Assert.AreEqual(myMonster.Picture, p.Image);
            Assert.AreEqual(myMonster.Attack.ToString(), atk.Text.ToString());
            Assert.AreEqual(myMonster.Defense.ToString(), def.Text.ToString());
            Assert.AreEqual(myMonster.Movement.ToString(), mov.Text.ToString());
        }

        /// <summary>
        /// Test if current player monsters are enabled
        /// </summary>
        [TestMethod]
        public void ActivateCurrPlayerTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));
            player1 = new Player();
            player1.AttMonster = new Monster("The Ghhhk", 3, 2, 1, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 13);
            player1.DefMonster = new Monster("The Kintan Strider", 1, 3, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Kintan_Strider"), typeMonster.Defensive, 14);
            player1.MovMonster = new Monster("The K'lor'slug", 2, 1, 3, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("klorslaug"), typeMonster.Mobile, 19);
            player1.PowMonster = new Monster("The Monnok", 3, 2, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Monnok"), typeMonster.Power, 25);
            player1.ListMonsters = new List<Monster> { player1.AttMonster, player1.DefMonster, player1.MovMonster, player1.PowMonster };
            List<Player> players = new List<Player>();
            players.Add(player1);

            //Act
            dejarikTest.SetField("players", players);
            dejarikTest.SetField("turn", 0);
            dejarikTest.Invoke("activateCurrPlayer");
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");

            //Assert
            Assert.IsTrue(listButtons[13].Enabled);
            Assert.IsTrue(listButtons[14].Enabled);
            Assert.IsTrue(listButtons[19].Enabled);
            Assert.IsTrue(listButtons[25].Enabled);
        }

        /// <summary>
        /// Test if the buttons are correctly disabled
        /// </summary>
        [TestMethod]
        public void ButtonsDisabledTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));
            ActivateColorsTest();

            //Act
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");
            dejarikTest.Invoke("disableAllButtons");

            //Assert
            for (int i = 0; i < listButtons.Count; i++)
            {
                Assert.IsFalse(listButtons[i].Enabled);
            }
        }

        /// <summary>
        /// Test if current player monsters are correctly colored according to turn
        /// </summary>
        [TestMethod]
        public void ActivateColorsTest()
        {
            //Arrange
            dejarikTest = new PrivateObject(new Dejarik(""));
            player1 = new Player();
            player1.AttMonster = new Monster("The Ghhhk", 3, 2, 1, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 13);
            player1.DefMonster = new Monster("The Kintan Strider", 1, 3, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Kintan_Strider"), typeMonster.Defensive, 14);
            player1.MovMonster = new Monster("The K'lor'slug", 2, 1, 3, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("klorslaug"), typeMonster.Mobile, 19);
            player1.PowMonster = new Monster("The Monnok", 3, 2, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("Monnok"), typeMonster.Power, 25);
            player1.ListMonsters = new List<Monster> { player1.AttMonster, player1.DefMonster, player1.MovMonster, player1.PowMonster };
            List<Player> players = new List<Player>();
            players.Add(player1);

            //Act
            dejarikTest.SetField("players", players);
            dejarikTest.SetField("turn", 0);
            dejarikTest.Invoke("activateColors");
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");

            //Assert
            Assert.IsTrue(listButtons[13].BackColor == Color.FromArgb(80, Color.Gold));
            Assert.IsTrue(listButtons[14].BackColor == Color.FromArgb(80, Color.Gold));
            Assert.IsTrue(listButtons[19].BackColor == Color.FromArgb(80, Color.Gold));
            Assert.IsTrue(listButtons[25].BackColor == Color.FromArgb(80, Color.Gold));
        }

        /// <summary>
        /// Test that when newAtk is greater than newDef by 4 or more, the defender is killed by the attacker
        /// </summary>
        [TestMethod]
        public void DefendAttKillP1Test()
        {
            //Arrange
            Monster attackingMonster =  new Monster("The Ghhhk", 3, 2, 1, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 0);
            Monster defendingMonster =  new Monster("The Houjix", 3, 1, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("houjix"), typeMonster.Offensive, 0);
            dejarikTest = new PrivateObject(new Dejarik(""));
            player1 = new Player();
            player2 = new Player();
            player1.AttMonster = attackingMonster;
            player2.AttMonster = defendingMonster;
            player1.ListMonsters = new List<Monster> { player1.AttMonster };
            player2.ListMonsters = new List<Monster> { player2.AttMonster };
            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);

            //Act
            dejarikTest.SetField("players", players);
            dejarikTest.SetField("attackingMonster", attackingMonster);
            dejarikTest.SetField("defendingMonster", defendingMonster);
            dejarikTest.Invoke("defend", 1, 9);
            players = (List<Player>)dejarikTest.GetField("players");

            //Assert
            Assert.AreEqual(0, players[1].ListMonsters.Count);
        }

        /// <summary>
        /// Test that when newAtk is greater than newDef by 4 or more, the defender is killed by the attacker
        /// </summary>
        [TestMethod]
        public void DefendAttKillP2Test()
        {
            //Arrange
            Monster attackingMonster = new Monster("The Ghhhk", 3, 2, 1, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 0);
            Monster defendingMonster = new Monster("The Houjix", 3, 1, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("houjix"), typeMonster.Offensive, 0);
            dejarikTest = new PrivateObject(new Dejarik(""));
            player1 = new Player();
            player2 = new Player();
            player1.AttMonster = defendingMonster;
            player2.AttMonster = attackingMonster;
            player1.ListMonsters = new List<Monster> { player1.AttMonster };
            player2.ListMonsters = new List<Monster> { player2.AttMonster };
            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);

            //Act
            dejarikTest.SetField("turn", 1);
            dejarikTest.SetField("players", players);
            dejarikTest.SetField("attackingMonster", attackingMonster);
            dejarikTest.SetField("defendingMonster", defendingMonster);
            dejarikTest.Invoke("defend", 1, 9);
            players = (List<Player>)dejarikTest.GetField("players");

            //Assert
            Assert.AreEqual(0, players[0].ListMonsters.Count);
        }

        /// <summary>
        /// Test that when newAtk is greater than newDef by 1 to 3, the defender is pushed by the attacker (Player 1's turn)
        /// </summary>
        [TestMethod]
        public void DefendAttPushP1Test()
        {
            //Arrange
            Monster attackingMonster = new Monster("The Ghhhk", 3, 2, 1, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 0);
            Monster defendingMonster = new Monster("The Houjix", 3, 1, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("houjix"), typeMonster.Offensive, 0);
            dejarikTest = new PrivateObject(new Dejarik(""));
            player1 = new Player();
            player2 = new Player();
            player1.AttMonster = attackingMonster;
            player2.AttMonster = defendingMonster;
            player2.AttMonster.Position = 14;
            player1.ListMonsters = new List<Monster> { player1.AttMonster };
            player2.ListMonsters = new List<Monster> { player2.AttMonster };
            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);

            //Act
            dejarikTest.Invoke("initalizeListButtons");   
            dejarikTest.SetField("players", players);
            dejarikTest.SetField("attackingMonster", attackingMonster);
            dejarikTest.SetField("defendingMonster", defendingMonster);
            dejarikTest.Invoke("defend", 7, 9);
            players = (List<Player>)dejarikTest.GetField("players");

            //Assert
            Assert.AreEqual(1, players[1].ListMonsters.Count);
            Assert.AreNotEqual(14, players[1].AttMonster.Position);
        }


        /// <summary>
        /// Test that when newAtk is greater than newDef by 1 to 3, the defender is pushed by the attacker (PLayer 2's turn)
        /// </summary>
        [TestMethod]
        public void DefendAttPushP2Test()
        {
            //Arrange
            Monster attackingMonster = new Monster("The Ghhhk", 3, 2, 1, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 0);
            Monster defendingMonster = new Monster("The Houjix", 3, 1, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("houjix"), typeMonster.Offensive, 0);
            dejarikTest = new PrivateObject(new Dejarik(""));
            player1 = new Player();
            player2 = new Player();
            player1.AttMonster = defendingMonster;
            player2.AttMonster = attackingMonster;
            player1.AttMonster.Position = 14;
            player1.ListMonsters = new List<Monster> { player1.AttMonster };
            player2.ListMonsters = new List<Monster> { player2.AttMonster };
            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);


            //Act           
            dejarikTest.Invoke("initalizeListButtons");
            dejarikTest.SetField("turn", 1);
            dejarikTest.SetField("players", players);
            dejarikTest.SetField("attackingMonster", attackingMonster);
            dejarikTest.SetField("defendingMonster", defendingMonster);
            dejarikTest.Invoke("defend", 7, 9);


            players = (List<Player>)dejarikTest.GetField("players");
            Assert.AreNotEqual(14, players[0].AttMonster.Position);
        }

        /// <summary>
        /// Test that when newAtk is equal to newDef, the defender is pushed by the attacker
        /// </summary>
        [TestMethod]
        public void DefendEqualsTest()
        {

        }

        /// <summary>
        /// Test that when newDef is greater than newAtk by 4 or more, the attacker is killed by the defender
        /// </summary>
        [TestMethod]
        public void DefendDefKillTest()
        {

        }

        /// <summary>
        /// Test that when newDef is greater than newAtk by 1 to 3, the attacker is pushed by the defender
        /// </summary>
        [TestMethod]
        public void DefendDefPushTest()
        {

        }

        /// <summary>
        /// Test if the monster is correctly pushed and if his position has changed
        /// </summary>
        [TestMethod]
        public void PushMonsterTest()
        {

        }

        /// <summary>
        /// Test that if the monster has any place to be pushed, he is killed
        /// </summary>
        [TestMethod]
        public void PushMonsterKilledTest()
        {

        }

        /// <summary>
        /// Test if the monster is correctly killed and removed from the map and listMonsters
        /// </summary>
        [TestMethod]
        public void KillMonsterTest()
        {

        }

        /// <summary>
        /// Test if the variables tmpAtk and tmpDef are correctly modified according to turn
        /// </summary>
        [TestMethod]
        public void SetAtkDefTest()
        {

        }


        /// <summary>
        /// Test if the player action end when the monster cannot move anymore
        /// </summary>
        [TestMethod]
        public void EndActionWhenMonsterCantMoveTest()
        {
            //dernier test de guillaume
        }


        /// <summary>
        /// Test if the action end when the monster has no more movement
        /// </summary>
        [TestMethod]
        public void EndActionWhenMonsterFinishMovementTest()
        {

        }



        /// <summary>
        /// Test if a monster cannot move on the same tile as another monster
        /// </summary>
        [TestMethod]
        public void MonsterNoSamePosition()
        {

        }

        /// <summary>
        /// Test if the log display the movement of the monster
        /// </summary>
        [TestMethod]
        public void MonsterMoveLogTest()
        {

        }


        /// <summary>
        /// Test if the monster has the right atk after rolling the dice
        /// </summary>
        [TestMethod]
        public void MonsterRollNewAtk()
        {

        }


        /// <summary>
        /// Test if the monster has the right def after rolling the dice
        /// </summary>
        [TestMethod]
        public void MonsterRollNewDef()
        {

        }


        /// <summary>
        /// Test if the attack monster is the one that the player clicked
        /// </summary>
        [TestMethod]
        public void VerifyAttackMonster()
        {

        }

        /// <summary>
        /// Test if the defense monster is the one that the player attacked
        /// </summary>
        [TestMethod]
        public void VerifyDefenseMonster()
        {

        }

        /// <summary>
        /// Test if the log return the correct value for the dice
        /// </summary>
        [TestMethod]
        public void RollDiceLogTest()
        {

        }


        /// <summary>
        /// Test if the log return the correct test when the attacker win the push
        /// </summary>
        [TestMethod]
        public void PushAttackerWinLogTest()
        {

        }


        /// <summary>
        /// Test if the log return the correct test when the defender win the push
        /// </summary>
        [TestMethod]
        public void PushDefenderWinLogTest()
        {

        }


        /// <summary>
        /// Test if the log return the correct test when the attacker win the kill
        /// </summary>
        [TestMethod]
        public void kilattackerWinLogTest()
        {

        }


        /// <summary>
        /// Test if the log return the correct test when the defender win the kill
        /// </summary>
        [TestMethod]
        public void killDefenderWinLogTest()
        {

        }
    }
}
