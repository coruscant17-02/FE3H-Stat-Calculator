using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class FortressKnight : Commoner
    {
        public FortressKnight()
        {
            BaseHP = 35;
            BaseStr = 17;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 8;
            BaseLck = 10;
            BaseDef = 17;
            BaseRes = 7;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = -0.10;
            LckGrowth = 0;
            DefGrowth = 0.15;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 5;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = -6;
            LckBoost = 0;
            DefBoost = 10;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
