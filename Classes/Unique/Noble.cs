using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Noble : Commoner
    {
        public Noble()
        {
            BaseHP = 0;
            BaseStr = 0;
            BaseMag = 0;
            BaseDex = 0;
            BaseSpd = 0;
            BaseLck = 0;
            BaseDef = 0;
            BaseRes = 0;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 0;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
