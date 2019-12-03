using Projet_GONLO.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO
{
    /// <summary>
    /// Class card, necessary for the Pazaak Card Game
    /// </summary>
    class Cards
    {
        /// <summary>
        /// Different arrays of each type of card
        /// </summary>
        private Image[] TabPlusCards = new Image[6];
        private Image[] TabMinusCards = new Image[6];
        private Image[] TabPlusMinusCards = new Image[6];
        private Image[] TabNormalCards = new Image[10];

        /// <summary>
        /// Default constructor
        /// </summary>
        public Cards()
        {
            FillCardArrays();
        }

        /// <summary>
        /// Fill the different arrays with the correct cards
        /// </summary>
        private void FillCardArrays()
        {           
            for (int i = 0; i < TabPlusCards.Length; i++)
            {
                TabPlusCards[i] = (Image)Properties.Resources.ResourceManager.GetObject("Carte" + "Plus" + (i+1));
            }
            for (int i = 0; i < TabMinusCards.Length; i++)
            {
                TabMinusCards[i] = (Image)Properties.Resources.ResourceManager.GetObject("Carte" + "Minus" + (i + 1));
            }
            for (int i = 0; i < TabPlusMinusCards.Length; i++)
            {
                TabPlusMinusCards[i] = (Image)Properties.Resources.ResourceManager.GetObject("Carte" + "PlusMinus" + (i + 1));
            }
            for (int i = 0; i < TabNormalCards.Length; i++)
            {
                TabNormalCards[i] = (Image)Properties.Resources.ResourceManager.GetObject("Carte" + (i + 1));
            }
        }

        /// <summary>
        /// Getters and setters for each type of card
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public Image getCartePlus(int num)
        {
            return TabPlusCards[num-1];
        }
        public Image getCarteMinus(int num)
        {
            return TabMinusCards[num - 1];
        }
        public Image getCartePlusMinus(int num)
        {
            return TabPlusMinusCards[num - 1];
        }
        public Image getCarteNormal(int num)
        {
            return TabNormalCards[num - 1];
        }

    }
}
