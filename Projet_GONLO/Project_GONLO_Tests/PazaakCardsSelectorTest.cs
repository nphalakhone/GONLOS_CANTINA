using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet_GONLO;
namespace Project_GONLO_Tests
{
    [TestClass]
    public class PazaakCardsSelectorTest
    {



        [TestMethod]
        public void TestMethod1()
        {
            
            Player player = new Player();
            player.Name = "Test_Name";
            player.Credits = 500;
            player.PazaakGamesWon = 0;
            player.PazaakGamesLost = 0;
            player.DejarikGamesLost = 0;
            player.DejarikGamesWon = 0;
            PazaakCardsSelector pazaakCards = new PazaakCardsSelector();
            pazaakCards.= player;
        }
    }
}
