using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class PegasusKnight : Commoner
    {
        public PegasusKnight()
        {
            BaseHP = 25;
            BaseStr = 8;
            BaseMag = 6;
            BaseDex = 7;
            BaseSpd = 8;
            BaseLck = 8;
            BaseDef = 5;
            BaseRes = 4;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.15;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0.10;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0.05;
            ChaGrowth = 0.10;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 2;
            SpdBoost = 3;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 2;
            ChaBoost = 0;
        }
    }
}
