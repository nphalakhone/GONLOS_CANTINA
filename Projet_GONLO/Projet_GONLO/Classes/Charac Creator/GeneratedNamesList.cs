using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_GONLO
{
    class GeneratedNamesList
    {
        private Random rand = new Random();

        public List<string> listNameMandalorianM = new List<string>();
        public List<string> listNameMandalorianF = new List<string>();
        public List<string> listNameZabrakM = new List<string>();
        public List<string> listNameZabrakF = new List<string>();
        public List<string> listNameSPB_M = new List<string>();
        public List<string> listNameSPB_F = new List<string>();
        public List<string> listNameTwilekM = new List<string>();
        public List<string> listNameTwilekF = new List<string>();
        public List<string> listNameCatharM = new List<string>();
        public List<string> listNameCatharF = new List<string>();
        public List<string> listNameHumanM = new List<string>();
        public List<string> listNameHumanF = new List<string>();

        private List<string> FillListNameMand_M()
        {
            listNameMandalorianM.Add("Par Wruuc");
            listNameMandalorianM.Add("Drick Wrarkard");
            listNameMandalorianM.Add("Pad Zahl");
            listNameMandalorianM.Add("Juk Daxagg");
            listNameMandalorianM.Add("Lliyiod Tunch");
            listNameMandalorianM.Add("Xideank Drachorr");
            listNameMandalorianM.Add("Iopoe Fyrs");
            listNameMandalorianM.Add("Anno Rasuard");
            listNameMandalorianM.Add("Rhiidebeenx Krungh");
            listNameMandalorianM.Add("Kroesulu Zulgai");
            listNameMandalorianM.Add("Xean Guas");
            listNameMandalorianM.Add("Murk Strunygg");
            listNameMandalorianM.Add("Throng Wit");
            listNameMandalorianM.Add("Grej Walgoc");
            listNameMandalorianM.Add("Kriikruk Blill");
            listNameMandalorianM.Add("Gokku Stretod");
            listNameMandalorianM.Add("Rasoegg Kuun");
            listNameMandalorianM.Add("Njoraild Paurvun");
            listNameMandalorianM.Add("Orosan Qugg");
            listNameMandalorianM.Add("Vraidavoe Foobbest");

            return listNameMandalorianM;
        }

        private List<string> FillListNameMand_F()
        {
            listNameMandalorianF.Add("Fi Tros");
            listNameMandalorianF.Add("Va Ikkatt");
            listNameMandalorianF.Add("Sham Wran");
            listNameMandalorianF.Add("Shialk Blaso");
            listNameMandalorianF.Add("Aodesh Troord");
            listNameMandalorianF.Add("Haymnalk Ulyll");
            listNameMandalorianF.Add("Kaytai Sywr");
            listNameMandalorianF.Add("Bonnoo Cyyos");
            listNameMandalorianF.Add("Ikaiba Veg");
            listNameMandalorianF.Add("Risilo Dreli");
            listNameMandalorianF.Add("Khin Suwr");
            listNameMandalorianF.Add("Zha Wapmyt");
            listNameMandalorianF.Add("Rilk Skegg");
            listNameMandalorianF.Add("Bi Ydu");
            listNameMandalorianF.Add("Phobbial Blunch");
            listNameMandalorianF.Add("Huskish Qaurhout");
            listNameMandalorianF.Add("Uyias Cral");
            listNameMandalorianF.Add("Nemsaith Tarvhic");
            listNameMandalorianF.Add("Aviddes Nud");
            listNameMandalorianF.Add("Bhekkiggath Dakko");

            return listNameMandalorianF;
        }

        public string getListNameMand_M()
        {
            FillListNameMand_M();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameMandalorianM.ElementAt(listIndex);
            return name;
        }

        public string getListNameMand_F()
        {
            FillListNameMand_F();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameMandalorianF.ElementAt(listIndex);
            return name;
        }



        private List<string> FillListNameZab_M()
        {
            listNameZabrakM.Add("Kradroo");
            listNameZabrakM.Add("Vratropa");
            listNameZabrakM.Add("Vukraru");
            listNameZabrakM.Add("Kuprar");
            listNameZabrakM.Add("Reprura");
            listNameZabrakM.Add("Aekror");
            listNameZabrakM.Add("Vrutas");
            listNameZabrakM.Add("Stavrag");
            listNameZabrakM.Add("Storga");
            listNameZabrakM.Add("Drasuu");
            listNameZabrakM.Add("Retae");
            listNameZabrakM.Add("Povue");
            listNameZabrakM.Add("Sogrok");
            listNameZabrakM.Add("Mosa");
            listNameZabrakM.Add("Duvao");
            listNameZabrakM.Add("Audo");
            listNameZabrakM.Add("Gexam");
            listNameZabrakM.Add("Grebromu");
            listNameZabrakM.Add("Kagoma");
            listNameZabrakM.Add("Peta");

            return listNameZabrakM;
        }

        private List<string> FillListNameZab_F()
        {
            listNameZabrakF.Add("Stomati");
            listNameZabrakF.Add("Buqa");
            listNameZabrakF.Add("Ausake");
            listNameZabrakF.Add("Gedrio");
            listNameZabrakF.Add("Nokrido");
            listNameZabrakF.Add("Blunes");
            listNameZabrakF.Add("Oovreda");
            listNameZabrakF.Add("Xokrose");
            listNameZabrakF.Add("Kugei");
            listNameZabrakF.Add("Reme");
            listNameZabrakF.Add("Blavax");
            listNameZabrakF.Add("Gumok");
            listNameZabrakF.Add("Gedama");
            listNameZabrakF.Add("Lokrao");
            listNameZabrakF.Add("Eaveku");
            listNameZabrakF.Add("Aosri");
            listNameZabrakF.Add("Hage");
            listNameZabrakF.Add("Aosrou");
            listNameZabrakF.Add("Eesaxo");
            listNameZabrakF.Add("Qado");

            return listNameZabrakF;
        }

        public string getListNameZab_M()
        {
            FillListNameZab_M();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameZabrakM.ElementAt(listIndex);
            return name;
        }

        public string getListNameZab_F()
        {
            FillListNameZab_F();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameZabrakF.ElementAt(listIndex);
            return name;
        }



        private List<string> FillListNameSPB_M()
        {
            listNameSPB_M.Add("Krâmshan");
            listNameSPB_M.Add("Yuhshat");
            listNameSPB_M.Add("Sralos");
            listNameSPB_M.Add("Rhilzos");
            listNameSPB_M.Add("Kaidhis");
            listNameSPB_M.Add("Zroshwû");
            listNameSPB_M.Add("Hotsais");
            listNameSPB_M.Add("Dona");
            listNameSPB_M.Add("Tishdû");
            listNameSPB_M.Add("Rhûrji");
            listNameSPB_M.Add("Nikwum");
            listNameSPB_M.Add("Nuykaits");
            listNameSPB_M.Add("Lajliw");
            listNameSPB_M.Add("Chotûsh");
            listNameSPB_M.Add("Whâdkuz");
            listNameSPB_M.Add("Ûlowyi");
            listNameSPB_M.Add("Wrushow");
            listNameSPB_M.Add("Hiljûm");
            listNameSPB_M.Add("Tsoikâ");
            listNameSPB_M.Add("Wrojim");

            return listNameSPB_M;
        }

        private List<string> FillListNameSPB_F()
        {
            listNameSPB_F.Add("Zarua");
            listNameSPB_F.Add("Ekheniu");
            listNameSPB_F.Add("Wiqul");
            listNameSPB_F.Add("Eqoleath");
            listNameSPB_F.Add("Dhulua");
            listNameSPB_F.Add("Ruglea");
            listNameSPB_F.Add("Xukeath");
            listNameSPB_F.Add("Ixikam");
            listNameSPB_F.Add("Zhigriux");
            listNameSPB_F.Add("Namrualyr");
            listNameSPB_F.Add("Isopuasy");
            listNameSPB_F.Add("Bhahi");
            listNameSPB_F.Add("Awexviash");
            listNameSPB_F.Add("Ipleqaeth");
            listNameSPB_F.Add("Gheaxduatiur");
            listNameSPB_F.Add("Vrokwa");
            listNameSPB_F.Add("Udragbe");
            listNameSPB_F.Add("Uwraqias");
            listNameSPB_F.Add("Komla");
            listNameSPB_F.Add("Uxuhia");

            return listNameSPB_F;
        }

        public string getListNameSPB_M()
        {
            FillListNameSPB_M();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameSPB_M.ElementAt(listIndex);
            return name;
        }

        public string getListNameSPB_F()
        {
            FillListNameSPB_F();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameSPB_F.ElementAt(listIndex);
            return name;
        }



        private List<string> FillListNameTwilek_M()
        {
            listNameTwilekM.Add("Bumbacri");
            listNameTwilekM.Add("Audopfaru");
            listNameTwilekM.Add("Hekkile");
            listNameTwilekM.Add("Uumibcidus");
            listNameTwilekM.Add("Criswajif");
            listNameTwilekM.Add("Hig'fowim");
            listNameTwilekM.Add("Ajobzacru");
            listNameTwilekM.Add("Aulewnabik");
            listNameTwilekM.Add("Okumhahag");
            listNameTwilekM.Add("Gitzuci");
            listNameTwilekM.Add("Iciwdogiq");
            listNameTwilekM.Add("Aubihhisew");
            listNameTwilekM.Add("Aeluh'haja");
            listNameTwilekM.Add("Gat'cenu");
            listNameTwilekM.Add("Gegbacis");
            listNameTwilekM.Add("Omamhuse");
            listNameTwilekM.Add("Aerebtukal");
            listNameTwilekM.Add("Ekozfela");
            listNameTwilekM.Add("Ietitnaro");
            listNameTwilekM.Add("Oosritlace");

            return listNameTwilekM;
        }

        private List<string> FillListNameTwilek_F()
        {
            listNameTwilekF.Add("Ipastabu");
            listNameTwilekF.Add("Esagtupi");
            listNameTwilekF.Add("Aawummedo");
            listNameTwilekF.Add("Oeyodsomo");
            listNameTwilekF.Add("Iopor'niwul");
            listNameTwilekF.Add("Ianer'bine");
            listNameTwilekF.Add("Ojippifof");
            listNameTwilekF.Add("Ubomvetah");
            listNameTwilekF.Add("Cumbira");
            listNameTwilekF.Add("Azuzcoda");
            listNameTwilekF.Add("Ocobhemon");
            listNameTwilekF.Add("Iatudlove");
            listNameTwilekF.Add("Uhit'hiwiy");
            listNameTwilekF.Add("Augip'rutir");
            listNameTwilekF.Add("Obitpikum");
            listNameTwilekF.Add("Omiwlacri");
            listNameTwilekF.Add("Alumhakem");
            listNameTwilekF.Add("Ifulcoje");
            listNameTwilekF.Add("Uayuwbome");
            listNameTwilekF.Add("Yarwafug");

            return listNameTwilekF;
        }

        public string getListNameTwilek_M()
        {
            FillListNameTwilek_M();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameTwilekM.ElementAt(listIndex);
            return name;
        }

        public string getListNameTwilek_F()
        {
            FillListNameTwilek_F();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameTwilekF.ElementAt(listIndex);
            return name;
        }



        private List<string> FillListNameCathar_M()
        {
            listNameCatharM.Add("Cronu Jhido");
            listNameCatharM.Add("Musu Tamol");
            listNameCatharM.Add("Cido Korgor");
            listNameCatharM.Add("Criso Lhudul");
            listNameCatharM.Add("Harby Josa");
            listNameCatharM.Add("Ixihr Mun");
            listNameCatharM.Add("Si Nhi");
            listNameCatharM.Add("Ty Sit");
            listNameCatharM.Add("Ric Kuk");
            listNameCatharM.Add("Nurr No");
            listNameCatharM.Add("Crundi Kirgon");
            listNameCatharM.Add("Horam Tudir");
            listNameCatharM.Add("Tirbo Mhoshuk");
            listNameCatharM.Add("Suda Torgor");
            listNameCatharM.Add("Ruso Phalon");
            listNameCatharM.Add("Usi Phu");
            listNameCatharM.Add("Ixi Rul");
            listNameCatharM.Add("Akhun La");
            listNameCatharM.Add("Asy So");
            listNameCatharM.Add("Isam Lhu");

            return listNameCatharM;
        }

        private List<string> FillListNameCathar_F()
        {
            listNameCatharF.Add("Jalvyn Khamu");
            listNameCatharF.Add("Mimoz Pozun");
            listNameCatharF.Add("Churoxi Tado");
            listNameCatharF.Add("Calyr Runam");
            listNameCatharF.Add("Manihr Lusal");
            listNameCatharF.Add("Choryn Mar");
            listNameCatharF.Add("Cuwusha Pot");
            listNameCatharF.Add("Monish Ko");
            listNameCatharF.Add("Sothiza Mu");
            listNameCatharF.Add("Jusuhi Lum");
            listNameCatharF.Add("Covazy Lurgo");
            listNameCatharF.Add("Nirisa Jazik");
            listNameCatharF.Add("Ralvohy Sashun");
            listNameCatharF.Add("Rovyr Nhosu");
            listNameCatharF.Add("Mimuna Sorgik");
            listNameCatharF.Add("Daliny Jo");
            listNameCatharF.Add("Naryz Mhag");
            listNameCatharF.Add("Sulvisy Lus");
            listNameCatharF.Add("Siluxa Ril");
            listNameCatharF.Add("Sovos Par");

            return listNameCatharF;
        }

        public string getListNameCathar_M()
        {
            FillListNameCathar_M();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameCatharM.ElementAt(listIndex);
            return name;
        }

        public string getListNameCathar_F()
        {
            FillListNameCathar_F();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameCatharF.ElementAt(listIndex);
            return name;
        }

        private List<string> FillListNameHum_M()
        {
            listNameHumanM.Add("Jetraf Hyndbal");
            listNameHumanM.Add("Khatann Freeappl");
            listNameHumanM.Add("Remalex Sarsib");
            listNameHumanM.Add("Jespeyt Smaher");
            listNameHumanM.Add("Alaade Edgegedn");
            listNameHumanM.Add("Jamagar Sevhum");
            listNameHumanM.Add("Dillash Whijohn");
            listNameHumanM.Add("Logakyl Searud");
            listNameHumanM.Add("Mavandy Oxefent");
            listNameHumanM.Add("Jonabarr Braedd");
            listNameHumanM.Add("Trolond Stacri");
            listNameHumanM.Add("Nasgid Denlcrib");
            listNameHumanM.Add("Antoosc Spibond");
            listNameHumanM.Add("Omartodd Daviyar");
            listNameHumanM.Add("Philjea Meacruff");
            listNameHumanM.Add("Guicurt Angmabr");
            listNameHumanM.Add("Jakelev Fulpix");
            listNameHumanM.Add("Andrbra Druisa");
            listNameHumanM.Add("Irvitoby Colcoz");
            listNameHumanM.Add("Markev Hurpic");

            return listNameHumanM;
        }

        private List<string> FillListNameHum_F()
        {
            listNameHumanF.Add("Brekour Beckmake");
            listNameHumanF.Add("Fioale Dauwal");
            listNameHumanF.Add("Jayvivi Domefair");
            listNameHumanF.Add("Jacalex Coasher");
            listNameHumanF.Add("Briyvon Ralpil");
            listNameHumanF.Add("Jeweesth Cockpet");
            listNameHumanF.Add("Keylnor Rickrail");
            listNameHumanF.Add("Makjos Sadpop");
            listNameHumanF.Add("Taneric Chancha");
            listNameHumanF.Add("Fabfra Passta");
            listNameHumanF.Add("Joreliz Hallevat");
            listNameHumanF.Add("Lauanne Talbpay");
            listNameHumanF.Add("Ciemar Whilang");
            listNameHumanF.Add("Jewpris Rickrou");
            listNameHumanF.Add("Heatjayd Dalebee");
            listNameHumanF.Add("Leahkas Holldurn");
            listNameHumanF.Add("Daryas Bealsirm");
            listNameHumanF.Add("Valana Cruhab");
            listNameHumanF.Add("Lyndali Turrawl");
            listNameHumanF.Add("Julizoe Decktrap");

            return listNameHumanF;
        }

        public string getListNameHum_M()
        {
            FillListNameHum_M();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameHumanM.ElementAt(listIndex);
            return name;
        }

        public string getListNameHum_F()
        {
            FillListNameHum_F();
            string name;
            int listIndex = rand.Next(0, 20);
            name = listNameHumanF.ElementAt(listIndex);
            return name;
        }
    }
}
