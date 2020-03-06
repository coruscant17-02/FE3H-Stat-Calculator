using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Brigand : Commoner
    {
        public Brigand()
        {
            BaseHP = 28;
            BaseStr = 10;
            BaseMag = 6;
            BaseDex = 7;
            BaseSpd = 7;
            BaseLck = 8;
            BaseDef = 6;
            BaseRes = 2;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = -0.05;
            ChaGrowth = 0.05;
            HPBoost = 2;
            StrBoost = 2;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 0;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
