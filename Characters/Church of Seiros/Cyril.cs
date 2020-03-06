using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Cyril : Protagonist
    {
        public Cyril()
        {
            BaseHP = 24;
            BaseStr = 7;
            BaseMag = 4;
            BaseDex = 6;
            BaseSpd = 6;
            BaseLck = 6;
            BaseDef = 5;
            BaseRes = 2;
            BaseCha = 4;
            HPGrowth = 0.35;
            StrGrowth = 0.20;
            MagGrowth = 0.15;
            DexGrowth = 0.40;
            SpdGrowth = 0.40;
            LckGrowth = 0.30;
            DefGrowth = 0.10;
            ResGrowth = 0.10;
            ChaGrowth = 0.15;
            MaxHP = 85;
            MaxStr = 55;
            MaxMag = 48;
            MaxDex = 78;
            MaxSpd = 76;
            MaxLck = 66;
            MaxDef = 45;
            MaxRes = 41;
            MaxCha = 48;
        }
    }
}
