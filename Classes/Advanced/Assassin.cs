using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Assassin : Commoner
    {
        public Assassin()
        {
            BaseHP = 30;
            BaseStr = 17;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 12;
            BaseRes = 8;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.20;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0.20;
            SpdGrowth = 0.20;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 3;
            SpdBoost = 5;
            LckBoost = 1;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
