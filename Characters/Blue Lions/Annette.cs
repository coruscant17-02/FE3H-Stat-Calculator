using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Annette : Protagonist
    {
        public Annette()
        {
            BaseHP = 23;
            BaseStr = 6;
            BaseMag = 11;
            BaseDex = 7;
            BaseSpd = 7;
            BaseLck = 6;
            BaseDef = 5;
            BaseRes = 4;
            BaseCha = 6;
            HPGrowth = 0.25;
            StrGrowth = 0.30;
            MagGrowth = 0.50;
            DexGrowth = 0.50;
            SpdGrowth = 0.35;
            LckGrowth = 0.35;
            DefGrowth = 0.20;
            ResGrowth = 0.30;
            ChaGrowth = 0.35;
            MaxHP = 55;
            MaxStr = 43;
            MaxMag = 73;
            MaxDex = 69;
            MaxSpd = 50;
            MaxLck = 49;
            MaxDef = 40;
            MaxRes = 41;
            MaxCha = 49;
        }
    }
}
