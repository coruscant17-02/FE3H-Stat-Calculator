using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Paladin : Commoner
    {
        public Paladin()
        {
            BaseHP = 32;
            BaseStr = 17;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 12;
            BaseRes = 8;
            BaseCha = 0;
            Movement = 8;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0.05;
            SpdGrowth = -0.10;
            LckGrowth = 0.05;
            DefGrowth = 0.05;
            ResGrowth = 0.05;
            ChaGrowth = 0.05;
            HPBoost = 2;
            StrBoost = 2;
            MagBoost = 0;
            DexBoost = 2;
            SpdBoost = -1;
            LckBoost = 0;
            DefBoost = 2;
            ResBoost = 2;
            ChaBoost = 0;
        }
    }
}
