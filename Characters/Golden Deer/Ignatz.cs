using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Ignatz : Protagonist
    {
        public Ignatz()
        {
            BaseHP = 25;
            BaseStr = 8;
            BaseMag = 5;
            BaseDex = 7;
            BaseSpd = 8;
            BaseLck = 8;
            BaseDef = 4;
            BaseRes = 6;
            BaseCha = 4;
            HPGrowth = 0.35;
            StrGrowth = 0.35;
            MagGrowth = 0.30;
            DexGrowth = 0.50;
            SpdGrowth = 0.50;
            LckGrowth = 0.55;
            DefGrowth = 0.25;
            ResGrowth = 0.35;
            ChaGrowth = 0.25;
            MaxHP = 70;
            MaxStr = 51;
            MaxMag = 42;
            MaxDex = 69;
            MaxSpd = 70;
            MaxLck = 76;
            MaxDef = 43;
            MaxRes = 49;
            MaxCha = 45;
        }
    }
}
