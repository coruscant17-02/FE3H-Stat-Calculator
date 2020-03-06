using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class DarkBishop : Commoner
    {
        public DarkBishop()
        {
            BaseHP = 30;
            BaseStr = 8;
            BaseMag = 17;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 12;
            BaseRes = 15;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0.10;
            StrGrowth = 0;
            MagGrowth = 0.10;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = -0.05;
            ResGrowth = 0.05;
            ChaGrowth = 0;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 4;
            DexBoost = 2;
            SpdBoost = 0;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 3;
            ChaBoost = 0;
        }
    }
}
