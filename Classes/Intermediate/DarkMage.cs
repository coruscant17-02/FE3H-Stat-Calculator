using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class DarkMage : Commoner
    {
        public DarkMage()
        {
            BaseHP = 25;
            BaseStr = 4;
            BaseMag = 10;
            BaseDex = 7;
            BaseSpd = 6;
            BaseLck = 8;
            BaseDef = 3;
            BaseRes = 5;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0.05;
            StrGrowth = -0.05;
            MagGrowth = 0.10;
            DexGrowth = 0.05;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = -0.05;
            ResGrowth = 0.05;
            ChaGrowth = 0;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 2;
            DexBoost = 1;
            SpdBoost = 0;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 1;
            ChaBoost = 0;
        }
    }
}
