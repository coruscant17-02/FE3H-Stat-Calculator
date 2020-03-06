using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Ferdinand : Protagonist
    {
        public Ferdinand()
        {
            BaseHP = 28;
            BaseStr = 8;
            BaseMag = 5;
            BaseDex = 6;
            BaseSpd = 8;
            BaseLck = 6;
            BaseDef = 6;
            BaseRes = 2;
            BaseCha = 7;
            HPGrowth = 0.50;
            StrGrowth = 0.45;
            MagGrowth = 0.20;
            DexGrowth = 0.40;
            SpdGrowth = 0.50;
            LckGrowth = 0.40;
            DefGrowth = 0.35;
            ResGrowth = 0.20;
            ChaGrowth = 0.40;
            MaxHP = 93;
            MaxStr = 64;
            MaxMag = 40;
            MaxDex = 56;
            MaxSpd = 70;
            MaxLck = 56;
            MaxDef = 49;
            MaxRes = 36;
            MaxCha = 57;
        }
    }
}
