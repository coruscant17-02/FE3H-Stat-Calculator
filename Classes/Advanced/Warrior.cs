using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Warrior : Commoner
    {
        public Warrior()
        {
            BaseHP = 32;
            BaseStr = 19;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 13;
            BaseRes = 8;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.40;
            StrGrowth = 0.15;
            MagGrowth = -0.05;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 3;
            StrBoost = 3;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 1;
            LckBoost = 1;
            DefBoost = 1;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
