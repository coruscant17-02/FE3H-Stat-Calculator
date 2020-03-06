using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Dorothea : Protagonist
    {
        public Dorothea()
        {
            BaseHP = 24;
            BaseStr = 5;
            BaseMag = 11;
            BaseDex = 6;
            BaseSpd = 7;
            BaseLck = 6;
            BaseDef = 4;
            BaseRes = 7;
            BaseCha = 8;
            HPGrowth = 0.40;
            StrGrowth = 0.20;
            MagGrowth = 0.40;
            DexGrowth = 0.45;
            SpdGrowth = 0.40;
            LckGrowth = 0.35;
            DefGrowth = 0.15;
            ResGrowth = 0.35;
            ChaGrowth = 0.40;
            MaxHP = 76;
            MaxStr = 30;
            MaxMag = 61;
            MaxDex = 62;
            MaxSpd = 57;
            MaxLck = 49;
            MaxDef = 38;
            MaxRes = 50;
            MaxCha = 58;
        }
    }
}
