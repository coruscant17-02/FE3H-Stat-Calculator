using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Sniper : Commoner
    {
        public Sniper()
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
            HPGrowth = 0.10;
            StrGrowth = 0.05;
            MagGrowth = 0;
            DexGrowth = 0.20;
            SpdGrowth = 0;
            LckGrowth = 0.10;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 0;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 5;
            SpdBoost = 0;
            LckBoost = 3;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
