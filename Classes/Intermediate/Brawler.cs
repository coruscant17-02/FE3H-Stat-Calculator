using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Brawler : Commoner
    {
        public Brawler()
        {
            BaseHP = 28;
            BaseStr = 9;
            BaseMag = 6;
            BaseDex = 7;
            BaseSpd = 8;
            BaseLck = 8;
            BaseDef = 6;
            BaseRes = 1;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.30;
            StrGrowth = 0;
            MagGrowth = -0.10;
            DexGrowth = 0.10;
            SpdGrowth = 0.10;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = -0.10;
            ChaGrowth = 0.05;
            HPBoost = 1;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 2;
            SpdBoost = 2;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = -1;
            ChaBoost = 0;
        }
    }
}
