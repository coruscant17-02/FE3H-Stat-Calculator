using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class FalconKnight : Commoner
    {
        public FalconKnight()
        {
            BaseHP = 32;
            BaseStr = 18;
            BaseMag = 10;
            BaseDex = 14;
            BaseSpd = 20;
            BaseLck = 12;
            BaseDef = 13;
            BaseRes = 14;
            BaseCha = 0;
            Movement = 8;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0.20;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0.05;
            ChaGrowth = 0.10;
            HPBoost = 0;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 4;
            SpdBoost = 5;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 4;
            ChaBoost = 0;
        }
    }
}
