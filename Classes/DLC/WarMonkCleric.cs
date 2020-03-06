using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.DLC
{
    public class WarMonkCleric : Commoner
    {
        public WarMonkCleric()
        {
            BaseHP = 32;
            BaseStr = 17;
            BaseMag = 10;
            BaseDex = 10;
            BaseSpd = 10;
            BaseLck = 10;
            BaseDef = 14;
            BaseRes = 11;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.40;
            StrGrowth = 0.10;
            MagGrowth = 0.05;
            DexGrowth = 0.10;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0.05;
            ChaGrowth = 0.05;
            HPBoost = 3;
            StrBoost = 2;
            MagBoost = 0;
            DexBoost = 1;
            SpdBoost = 0;
            LckBoost = 0;
            DefBoost = 1;
            ResBoost = 1;
            ChaBoost = 0;
        }
    }
}
