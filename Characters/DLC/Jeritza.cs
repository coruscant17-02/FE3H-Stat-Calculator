using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Jeritza : Protagonist 
    {
        public Jeritza()
        {
            BaseHP = 30;
            BaseStr = 8;
            BaseMag = 6;
            BaseDex = 6;
            BaseSpd = 8;
            BaseLck = 4;
            BaseDef = 7;
            BaseRes = 5;
            BaseCha = 3;
            HPGrowth = 0.50;
            StrGrowth = 0.50;
            MagGrowth = 0.35;
            DexGrowth = 0.35;
            SpdGrowth = 0.60;
            LckGrowth = 0.30;
            DefGrowth = 0.40;
            ResGrowth = 0.25;
            ChaGrowth = 0.25;
            MaxHP = 79;
            MaxStr = 74;
            MaxMag = 42;
            MaxDex = 49;
            MaxSpd = 78;
            MaxLck = 41;
            MaxDef = 63;
            MaxRes = 42;
            MaxCha = 42;
        }
    }
}
