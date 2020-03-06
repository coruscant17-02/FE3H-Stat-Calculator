using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Felix : Protagonist
    {
        public Felix()
        {
            BaseHP = 26;
            BaseStr = 10;
            BaseMag = 5;
            BaseDex = 6;
            BaseSpd = 9;
            BaseLck = 5;
            BaseDef = 5;
            BaseRes = 3;
            BaseCha = 5;
            HPGrowth = 0.45;
            StrGrowth = 0.55;
            MagGrowth = 0.30;
            DexGrowth = 0.45;
            SpdGrowth = 0.55;
            LckGrowth = 0.40;
            DefGrowth = 0.30;
            ResGrowth = 0.20;
            ChaGrowth = 0.30;
            MaxHP = 84;
            MaxStr = 78;
            MaxMag = 42;
            MaxDex = 62;
            MaxSpd = 77;
            MaxLck = 55;
            MaxDef = 51;
            MaxRes = 35;
            MaxCha = 42;
        }
    }
}
