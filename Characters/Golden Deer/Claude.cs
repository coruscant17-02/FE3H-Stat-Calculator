using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Claude : Protagonist
    {
        public Claude()
        {
            BaseHP = 26;
            BaseStr = 11;
            BaseMag = 5;
            BaseDex = 8;
            BaseSpd = 8;
            BaseLck = 7;
            BaseDef = 6;
            BaseRes = 4;
            BaseCha = 8;
            HPGrowth = 0.35;
            StrGrowth = 0.40;
            MagGrowth = 0.25;
            DexGrowth = 0.60;
            SpdGrowth = 0.55;
            LckGrowth = 0.45;
            DefGrowth = 0.30;
            ResGrowth = 0.25;
            ChaGrowth = 0.55;
            MaxHP = 71;
            MaxStr = 61;
            MaxMag = 40;
            MaxDex = 89;
            MaxSpd = 76;
            MaxLck = 63;
            MaxDef = 50;
            MaxRes = 42;
            MaxCha = 76;
        }
    }
}
