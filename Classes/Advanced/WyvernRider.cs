using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class WyvernRider : Commoner
    {
        public WyvernRider()
        {
            BaseHP = 30;
            BaseStr = 18;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 12;
            BaseRes = 8;
            BaseCha = 0;
            Movement = 7;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = -0.05;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = -0.05;
            ChaGrowth = 0.05;
            HPBoost = 1;
            StrBoost = 3;
            MagBoost = 0;
            DexBoost = 1;
            SpdBoost = 3;
            LckBoost = 0;
            DefBoost = 2;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
