using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Swordmaster : Commoner
    {
        public Swordmaster()
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
            Movement = 5;
            HPGrowth = 0.25;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0.20;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = -0.05;
            ChaGrowth = 0.05;
            HPBoost = 1;
            StrBoost = 2;
            MagBoost = 0;
            DexBoost = 1;
            SpdBoost = 4;
            LckBoost = 0;
            DefBoost = 1;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
