using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Emperor : Commoner
    {
        public Emperor()
        {
            BaseHP = 38;
            BaseStr = 17;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 6;
            BaseLck = 10;
            BaseDef = 17;
            BaseRes = 8;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = 0.10;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0.05;
            ChaGrowth = 0.10;
            HPBoost = 8;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = -4;
            LckBoost = 1;
            DefBoost = 8;
            ResBoost = 0;
            ChaBoost = 2;
        }
    }
}
