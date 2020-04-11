using System;
using System.Collections.Generic;
using fe3h.Classes;
using fe3h.Classes.DLC;
using fe3h.Classes.Master;
using fe3h.Classes.Unique;

namespace fe3h
{
    class Program
    {
        #region Characters
        Bernadetta bernadetta = new Bernadetta();
        Caspar caspar = new Caspar();
        Dorothea dorothea = new Dorothea();
        Edelgard edelgard = new Edelgard();
        Ferdinand ferdinand = new Ferdinand();
        Hubert hubert = new Hubert();
        Linhardt linhardt = new Linhardt();
        Petra petra = new Petra();
        Annette annette = new Annette();
        Ashe ashe = new Ashe();
        Dedue dedue = new Dedue();
        Dimitri dimitri = new Dimitri();
        Felix felix = new Felix();
        Ingrid ingrid = new Ingrid();
        Mercedes mercedes = new Mercedes();
        Sylvain sylvain = new Sylvain();
        Cyril cyril = new Cyril();
        Flayn flayn = new Flayn();
        Hanneman hanneman = new Hanneman();
        Manuela manuela = new Manuela();
        Seteth seteth = new Seteth();
        Anna anna = new Anna();
        Balthus balthus = new Balthus();
        Constance constance = new Constance();
        Hapi hapi = new Hapi();
        Jeritza jeritza = new Jeritza();
        Yuri yuri = new Yuri();
        Claude claude = new Claude();
        Hilda hilda = new Hilda();
        Ignatz ignatz = new Ignatz();
        Leonie leonie = new Leonie();
        Lorenz lorenz = new Lorenz();
        Lysithea lysithea = new Lysithea();
        Marianne marianne = new Marianne();
        Raphael raphael = new Raphael();
        Alois alois = new Alois();
        Catherine catherine = new Catherine();
        Gilbert gilbert = new Gilbert();
        Shamir shamir = new Shamir();
        Protagonist protagonist = new Protagonist();
        #endregion Characters

        #region Classes
        Assassin assassin = new Assassin();
        Bishop bishop = new Bishop();
        DarkBishop darkBishop = new DarkBishop();
        FortressKnight fortressKnight = new FortressKnight();
        Grappler grappler = new Grappler();
        Hero hero = new Hero();
        Paladin paladin = new Paladin();
        Sniper sniper = new Sniper();
        Swordmaster swordmaster = new Swordmaster();
        Warlock warlock = new Warlock();
        Warrior warrior = new Warrior();
        WyvernRider wyvernRider = new WyvernRider();
        Fighter fighter = new Fighter();
        Monk monk = new Monk();
        Myrmidon myrmidon = new Myrmidon();
        Soldier soldier = new Soldier();
        DarkFlier darkFlier = new DarkFlier();
        Trickster trickster = new Trickster();
        Valkyrie valkyrie = new Valkyrie();
        WarMonkCleric warMonkCleric = new WarMonkCleric();
        Archer archer = new Archer();
        ArmoredKnight armoredKnight = new ArmoredKnight();
        Brawler brawler = new Brawler();
        Brigand brigand = new Brigand();
        Cavalier cavalier = new Cavalier();
        DarkMage darkMage = new DarkMage();
        Lord lord = new Lord();
        Mage mage = new Mage();
        Mercenary mercenary = new Mercenary();
        PegasusKnight pegasusKnight = new PegasusKnight();
        Priest priest = new Priest();
        Thief thief = new Thief();
        BowKnight bowKnight = new BowKnight();
        DarkKnight darkKnight = new DarkKnight();
        FalconKnight falconKnight = new FalconKnight();
        GreatKnight greatKnight = new GreatKnight();
        Gremory gremory = new Gremory();
        HolyKnight holyKnight = new HolyKnight();
        MortalSavant mortalSavant = new MortalSavant();
        WarMaster warMaster = new WarMaster();
        WyvernLord wyvernLord = new WyvernLord();
        ArmoredLord armoredLord = new ArmoredLord();
        Barbarossa barbarossa = new Barbarossa();
        Commoner commoner = new Commoner();
        Dancer dancer = new Dancer();
        DeathKnight deathKnight = new DeathKnight();
        Emperor emperor = new Emperor();
        EnemyDeathKnight enemyDeathKnight = new EnemyDeathKnight();
        EnlightenedOne enlightenedOne = new EnlightenedOne();
        GreatLord greatLord = new GreatLord();
        HighLord highLord = new HighLord();
        Noble noble = new Noble();
        WyvernMaster wyvernMaster = new WyvernMaster();
        #endregion Classes

        static List<string> characterGroupList;
        static List<string> classCategoryList;
        static List<string> begginerClassList;
        static List<string> intermediateClassList;
        static List<string> advancedClassList;
        static List<string> masterClassList;
        static List<string> uniqueClassList;
        static List<string> dlcClassList;
        static Dictionary<string, double> growthDictionary;

        static void Main(string[] args)
        {
            SettingLists();
            ChooseGroup();
            //ChooseYouself();
            //ChooseBlackEagles();
            //ChooseBlueLions();
            //ChooseGoldenDeers();
            //ChooseChurchofSeiros();
            //ChooseKnightsofSeiros();
            //ChooseDlc();
        }

        static void SettingLists()
        {
            characterGroupList = new List<string>();
            characterGroupList.Add("youself(Avatar)");
            characterGroupList.Add("Black Eagles");
            characterGroupList.Add("Blue Lions");
            characterGroupList.Add("Golden Deers");
            characterGroupList.Add("Church of Seiros");
            characterGroupList.Add("Knights of Seiros");
            characterGroupList.Add("DLC");

            classCategoryList = new List<string>();
            classCategoryList.Add("Begginer");
            classCategoryList.Add("Intermediate");
            classCategoryList.Add("Advanced");
            classCategoryList.Add("Master");
            classCategoryList.Add("Unique");
            classCategoryList.Add("DLC");

            begginerClassList = new List<string>();
            begginerClassList.Add("Fighter");
            begginerClassList.Add("Monk");
            begginerClassList.Add("Myrmidon");
            begginerClassList.Add("Soldier");

            intermediateClassList = new List<string>();
            intermediateClassList.Add("Archer");
            intermediateClassList.Add("ArmoredKnight");
            intermediateClassList.Add("Brawler");
            intermediateClassList.Add("Brigand");
            intermediateClassList.Add("Cavalier");
            intermediateClassList.Add("DarkMage");
            intermediateClassList.Add("Lord");
            intermediateClassList.Add("Mage");
            intermediateClassList.Add("Mercenary");
            intermediateClassList.Add("PegasusKnight");
            intermediateClassList.Add("Priest");
            intermediateClassList.Add("Thief");

            advancedClassList = new List<string>();
            advancedClassList.Add("Assassin");
            advancedClassList.Add("Bishop");
            advancedClassList.Add("DarkBishop");
            advancedClassList.Add("FortressKnight");
            advancedClassList.Add("Grappler");
            advancedClassList.Add("Hero");
            advancedClassList.Add("Paladin");
            advancedClassList.Add("Sniper");
            advancedClassList.Add("Swordmaster");
            advancedClassList.Add("Warlock");
            advancedClassList.Add("Warrior");
            advancedClassList.Add("WyvernRider");

            masterClassList = new List<string>();
            masterClassList.Add("BowKnight");
            masterClassList.Add("DarkKnight");
            masterClassList.Add("FalconKnight");
            masterClassList.Add("GreatKnight");
            masterClassList.Add("Gremory");
            masterClassList.Add("HolyKnight");
            masterClassList.Add("MortalSavant");
            masterClassList.Add("WarMaster");
            masterClassList.Add("WyvernLord");

            uniqueClassList = new List<string>();
            uniqueClassList.Add("ArmoredLord");
            uniqueClassList.Add("Barbarossa");
            uniqueClassList.Add("Commoner");
            uniqueClassList.Add("Dancer");
            uniqueClassList.Add("DeathKnight");
            uniqueClassList.Add("Emperor");
            uniqueClassList.Add("EnemyDeathKnight");
            uniqueClassList.Add("EnlightenedOne");
            uniqueClassList.Add("GreatLord");
            uniqueClassList.Add("HighLord");
            uniqueClassList.Add("Noble");
            uniqueClassList.Add("WyvernMaster");

            dlcClassList = new List<string>();
            dlcClassList.Add("DarkFlier");
            dlcClassList.Add("Trickster");
            dlcClassList.Add("Valkyrie");
            dlcClassList.Add("WarMonkCleric");

            growthDictionary = new Dictionary<string, double>();
            growthDictionary.Add("HP", 0.0);
            growthDictionary.Add("Str", 0.0);
            growthDictionary.Add("Mag", 0.0);
            growthDictionary.Add("Dex", 0.0);
            growthDictionary.Add("Spd", 0.0);
            growthDictionary.Add("Lck", 0.0);
            growthDictionary.Add("Def", 0.0);
            growthDictionary.Add("Res", 0.0);
            growthDictionary.Add("Cha", 0.0);
        }

        static void ChooseGroup()
        {
            Console.WriteLine("Please choose your character's group or youself(Avatar).");

            ExtentionList(characterGroupList);

            int groupId = ReadAndCheckNumber(0, 6);

            switch(groupId)
            {
                case 0:
                    ChooseYouself();
                    break;
            }
        }

        static void ChooseYouself()
        {
            Console.WriteLine("Please choose your gender.");
            Console.WriteLine("0:Male, 1:Female");

            int genderId = ReadAndCheckNumber(0, 1);

            Console.WriteLine("Please choose class category.");
            ExtentionList(classCategoryList);

            int classCategoryId = ReadAndCheckNumber(0, 5);

            Console.WriteLine("Please choose class.");

            Protagonist protagonist = new Protagonist();

            switch ( classCategoryId ) {
                case 0:
                    ChooseBegginerClass(protagonist);

                    break;

                case 1:
                    ChooseIntermediateClass(protagonist);
                    break;

            }
        }

        static void ChooseBegginerClass(Protagonist character)
        {
            ExtentionList(begginerClassList);

            int classId = ReadAndCheckNumber(0, 3);

            switch (classId)
            {
                case 0:

                    Fighter fighter = new Fighter();

                    CalcGrowth(character, fighter);

                    break;

                case 1:

                    Monk monk = new Monk();

                    CalcGrowth(character, monk);

                    break;

                case 2:

                    Myrmidon myrmidon = new Myrmidon();

                    CalcGrowth(character, myrmidon);

                    break;

                case 3:

                    Soldier soldier = new Soldier();

                    CalcGrowth(character, soldier);

                    break;
            }
        }

        static void ChooseIntermediateClass(Protagonist character)
        {
            ExtentionList(intermediateClassList);

            int classId = ReadAndCheckNumber(0, 11);

            switch (classId)
            {
                case 0:

                    Archer archer = new Archer();

                    CalcGrowth(character, archer);

                    break;

                case 1:

                    ArmoredKnight armoredKnight = new ArmoredKnight();

                    CalcGrowth(character, armoredKnight);

                    break;

                case 2:

                    Brawler brawler = new Brawler();

                    CalcGrowth(character, brawler);

                    break;

                case 3:

                    Brigand brigand = new Brigand();

                    CalcGrowth(character, brigand);

                    break;

                case 4:

                    Cavalier cavalier = new Cavalier();

                    CalcGrowth(character, cavalier);

                    break;

                case 5:

                    DarkMage darkMage = new DarkMage();

                    CalcGrowth(character, darkMage);

                    break;

                case 6:

                    Lord lord = new Lord();

                    CalcGrowth(character, lord);

                    break;

                case 7:

                    Mage mage = new Mage();

                    CalcGrowth(character, mage);

                    break;

                case 8:

                    Mercenary mercenary = new Mercenary();

                    CalcGrowth(character, mercenary);

                    break;

                case 9:

                    PegasusKnight pegasusKnight = new PegasusKnight();

                    CalcGrowth(character, pegasusKnight);

                    break;

                case 10:

                    Priest priest = new Priest();

                    CalcGrowth(character, priest);

                    break;

                case 11:

                    Thief thief = new Thief();

                    CalcGrowth(character, thief);

                    break;

            }
        }

        static void CalcGrowth(Protagonist character, Commoner characterClass)
        {
            Console.WriteLine("Growth");

            growthDictionary["HP"] = character.HPGrowth + characterClass.HPGrowth;
            growthDictionary["Str"] = character.StrGrowth + characterClass.StrGrowth;
            growthDictionary["Mag"] = character.MagGrowth + characterClass.MagGrowth;
            growthDictionary["Dex"] = character.DexGrowth + characterClass.DexGrowth;
            growthDictionary["Spd"] = character.SpdGrowth + characterClass.SpdGrowth;
            growthDictionary["Lck"] = character.LckGrowth + characterClass.LckGrowth;
            growthDictionary["Def"] = character.DefGrowth + characterClass.DefGrowth;
            growthDictionary["Res"] = character.ResGrowth + characterClass.ResGrowth;
            growthDictionary["Cha"] = character.ChaGrowth + characterClass.ChaGrowth;

            foreach (KeyValuePair<string, double> growth in growthDictionary)
            {
                Console.WriteLine(growth.Key + ":" + Math.Round(growth.Value * 100, 1) + "%");

            }
        }

        static void ExtentionList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ":" + list[i]);
            }
        }

        static int ReadAndCheckNumber(int firstNumber, int endNumber)
        {
            int targetNumber = 999;
            bool isNumber;
            isNumber = false;

            while (false == isNumber)
            {
                string targetLine = Console.ReadLine();

                if (true == int.TryParse(targetLine, out targetNumber))
                {
                    if(targetNumber >= firstNumber && targetNumber <= endNumber)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter correct number.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter number.");
                }
            }

            return targetNumber;
        }

    }
}
