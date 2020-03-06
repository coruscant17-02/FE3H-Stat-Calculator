using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class EnlightenedOne : Commoner
    {
        public EnlightenedOne()
        {
            BaseHP = 28;
            BaseStr = 17;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 12;
            BaseRes = 10;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.20;
            StrGrowth = 0.10;
            MagGrowth = 0.10;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 1;
            StrBoost = 2;
            MagBoost = 3;
            DexBoost = 1;
            SpdBoost = 1;
            LckBoost = 1;
            DefBoost = 2;
            ResBoost = 2;
            ChaBoost = 1;
        }
    }
}
