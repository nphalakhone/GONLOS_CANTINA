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

        /// <summary>
        /// Test if the clicked monster is the right one with the right stats
        /// </summary>
        [TestMethod]
        public void ClickedMonsterIsRightMonster()
        {

        }


        /// <summary>
        /// Test if a monster can move to an available position
        /// </summary>
        [TestMethod]
        public void MoveMonsterToAvailablePositionTest()
        {
            
        }


        /// <summary>
        /// Test if the player action end when the monster cannot move anymore
        /// </summary>
        [TestMethod]
        public void EndActionWhenMonsterCantMoveTest()
        {

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

    }
}
