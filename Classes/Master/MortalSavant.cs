using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class MortalSavant : Commoner
    {
        public MortalSavant()
        {
            BaseHP = 32;
            BaseStr = 17;
            BaseMag = 17;
            BaseDex = 14;
            BaseSpd = 16;
            BaseLck = 12;
            BaseDef = 14;
            BaseRes = 12;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.20;
            StrGrowth = 0.10;
            MagGrowth = 0.10;
            DexGrowth = 0;
            SpdGrowth = -0.10;
            LckGrowth = 0.10;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 1;
            StrBoost = 1;
            MagBoost = 2;
            DexBoost = 1;
            SpdBoost = 1;
            LckBoost = 0;
            DefBoost = 2;
            ResBoost = 2;
            ChaBoost = 0;
        }
    }
}
