using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class WyvernMaster : Commoner
    {
        public WyvernMaster()
        {
            BaseHP = 30;
            BaseStr = 17;
            BaseMag = 9;
            BaseDex = 13;
            BaseSpd = 19;
            BaseLck = 11;
            BaseDef = 14;
            BaseRes = 11;
            BaseCha = 0;
            Movement = 7;
            HPGrowth = 0.20;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0.05;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0;
            ChaGrowth = 0.10;
            HPBoost = 2;
            StrBoost = 2;
            MagBoost = 0;
            DexBoost = 3;
            SpdBoost = 1;
            LckBoost = 0;
            DefBoost = 1;
            ResBoost = 0;
            ChaBoost = 2;
        }
    }
}
