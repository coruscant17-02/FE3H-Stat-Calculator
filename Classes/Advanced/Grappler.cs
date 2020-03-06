using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Grappler : Commoner
    {
        public Grappler()
        {
            BaseHP = 32;
            BaseStr = 17;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 14;
            BaseRes = 7;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.40;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0.10;
            SpdGrowth = 0.10;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 2;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 3;
            SpdBoost = 3;
            LckBoost = 0;
            DefBoost = 1;
            ResBoost = -1;
            ChaBoost = 0;
        }
    }
}
