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
    class Carte
    {

        private static Image[] TabPlusCards = new Image[6];
        private Image[] TabMinusCards = new Image[6];
        private Image[] TabPlusMinusCards = new Image[6];
        private Image[] TabNormalCards = new Image[10];


        public Carte()
        {
            RemplirTableauCartes();
        }

        private void RemplirTableauCartes()
        {
            //ResourceManager rm = Resources.ResourceManager;




            //Object rm = Properties.Resources.ResourceManager.GetObject("Card1");
            //TabPlusCards[0] = (Bitmap)rm;

            //TabPlusCards[0] = (Image)Properties.Resources.ResourceManager.GetObject("Card1");
            
            for (int i = 0; i < TabPlusCards.Length; i++)
            {
                TabPlusCards[i] = (Image)Properties.Resources.ResourceManager.GetObject("Carte" + "+" + (i+1));
            }
            for (int i = 0; i < TabMinusCards.Length; i++)
            {
                TabMinusCards[i] = (Image)Properties.Resources.ResourceManager.GetObject("Carte" + "-" + (i + 1));
            }
            for (int i = 0; i < TabPlusMinusCards.Length; i++)
            {
                TabPlusMinusCards[i] = (Image)Properties.Resources.ResourceManager.GetObject("Carte" + "+-" + (i + 1));
            }
            for (int i = 0; i < TabNormalCards.Length; i++)
            {
                TabNormalCards[i] = (Image)Properties.Resources.ResourceManager.GetObject("Carte" + (i + 1));
            }

            //TabPlusCards[0] = Resources.ResourceManager.GetObject("Resource_Image");
            //    for (int i = 0; i < 6; i++)
            //    {
            //        TabPlusCards[i] = (Bitmap)rm.GetObject("Card" + "+" + (i+1).ToString());
            //        TabMinusCards[i] = (Bitmap)rm.GetObject("Card" + "-" + (i + 1).ToString());
            //        TabPlusMinusCards[i] = (Bitmap)rm.GetObject("Card" + "+-" + (i + 1).ToString());
            //    }
            //    for (int i = 0; i < TabNormalCards.Length; i++)
            //    {
            //        TabNormalCards[i] = (Bitmap)rm.GetObject("Card" + (i + 1).ToString());
            //    }
            //}
        }

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
