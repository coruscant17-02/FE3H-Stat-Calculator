using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class BowKnight : Commoner
    {
        public BowKnight()
        {
            BaseHP = 32;
            BaseStr = 17;
            BaseMag = 10;
            BaseDex = 14;
            BaseSpd = 16;
            BaseLck = 12;
            BaseDef = 14;
            BaseRes = 10;
            BaseCha = 0;
            Movement = 8;
            HPGrowth = 0.10;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = -0.05;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 2;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 3;
            SpdBoost = 1;
            LckBoost = 1;
            DefBoost = 1;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
