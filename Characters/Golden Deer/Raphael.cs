using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Raphael : Protagonist
    {
        public Raphael()
        {
            BaseHP = 30;
            BaseStr = 11;
            BaseMag = 3;
            BaseDex = 5;
            BaseSpd = 6;
            BaseLck = 6;
            BaseDef = 7;
            BaseRes = 1;
            BaseCha = 4;
            HPGrowth = 0.65;
            StrGrowth = 0.50;
            MagGrowth = 0.15;
            DexGrowth = 0.35;
            SpdGrowth = 0.15;
            LckGrowth = 0.35;
            DefGrowth = 0.45;
            ResGrowth = 0.10;
            ChaGrowth = 0.25;
            MaxHP = 114;
            MaxStr = 73;
            MaxMag = 31;
            MaxDex = 48;
            MaxSpd = 33;
            MaxLck = 49;
            MaxDef = 63;
            MaxRes = 36;
            MaxCha = 51;
        }
    }
}