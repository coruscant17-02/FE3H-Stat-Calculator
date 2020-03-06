using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Marianne : Protagonist
    {
        public Marianne()
        {
            BaseHP = 23;
            BaseStr = 5;
            BaseMag = 11;
            BaseDex = 6;
            BaseSpd = 7;
            BaseLck = 6;
            BaseDef = 4;
            BaseRes = 8;
            BaseCha = 7;
            HPGrowth = 0.35;
            StrGrowth = 0.20;
            MagGrowth = 0.50;
            DexGrowth = 0.40;
            SpdGrowth = 0.40;
            LckGrowth = 0.35;
            DefGrowth = 0.15;
            ResGrowth = 0.45;
            ChaGrowth = 0.40;
            MaxHP = 68;
            MaxStr = 30;
            MaxMag = 73;
            MaxDex = 56;
            MaxSpd = 57;
            MaxLck = 49;
            MaxDef = 39;
            MaxRes = 64;
            MaxCha = 57;
        }
    }
}