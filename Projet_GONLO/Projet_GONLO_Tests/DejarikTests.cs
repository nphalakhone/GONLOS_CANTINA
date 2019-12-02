﻿using System;
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
            dejarikTest = new PrivateObject(new Dejarik(""));
            dejarikTest.Invoke("initalizeListButtons");//call method
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");//getObject
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
            dejarikTest.Invoke("initalizeListButtons");
            List<Button> listButtons = (List<Button>)dejarikTest.GetField("listButtons");
            dejarikTest.SetField("players", players);
            dejarikTest.SetField("turn", 0);
            
            //Assert
            Assert.AreEqual(myMonster, dejarikTest.Invoke("getClickMonster", 12));
        }


        /// <summary>
        /// Test if a monster can move to an available position
        /// </summary>
        [TestMethod]
        public void MoveMonsterToAvailablePositionTest()
        {
            
        }

        /// <summary>
        /// Test if a monster moved correctly and if his position has changed
        /// </summary>
        [TestMethod]
        public void MonsterMovementTest()
        {

        }

        /// <summary>
        /// Test if the player's monsters positions are correctly set up
        /// </summary>
        [TestMethod]
        public void SetUpPlayerMonstersTest()
        {

        }

        /// <summary>
        /// Test if the monster's image is correctly displayed on the button (on board)
        /// </summary>
        [TestMethod]
        public void SetMonsterImgTest()
        {

        }

        /// <summary>
        /// Test if the monster's image and stats are correctly displayed on the right side of the board
        /// </summary>
        [TestMethod]
        public void SetInfoMonsters()
        {

        }

        /// <summary>
        /// Test if current player monsters are enabled
        /// </summary>
        [TestMethod]
        public void ActivateCurrPlayerTest()
        {

        }

        /// <summary>
        /// Test if the buttons are correctly disabled
        /// </summary>
        [TestMethod]
        public void ButtonsDisabledTest()
        {

        }

        /// <summary>
        /// Test if current player monsters are correctly colored according to turn
        /// </summary>
        [TestMethod]
        public void ActivateColorsTest()
        {

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

            Assert.AreEqual(0, players[0].ListMonsters.Count);
        }

        /// <summary>
        /// Test that when newAtk is greater than newDef by 1 to 3, the defender is pushed by the attacker
        /// </summary>
        [TestMethod]
        public void DefendAttPushTest()
        {
            //Arrange
            Monster attackingMonster = new Monster("The Ghhhk", 3, 2, 1, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("ghhhk"), typeMonster.Offensive, 0);
            Monster defendingMonster = new Monster("The Houjix", 3, 1, 2, (Image)Projet_GONLO.Properties.Resources.ResourceManager.GetObject("houjix"), typeMonster.Offensive, 0);
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
            dejarikTest.Invoke("defend", 8, 9);

            players = (List<Player>)dejarikTest.GetField("players");

            Assert.AreEqual(0, players[1].ListMonsters.Count);
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
