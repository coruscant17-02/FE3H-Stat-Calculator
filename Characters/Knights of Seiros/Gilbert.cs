using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Gilbert : Protagonist 
    {
        public Gilbert()
        {
            BaseHP = 30;
            BaseStr = 9;
            BaseMag = 4;
            BaseDex = 6;
            BaseSpd = 5;
            BaseLck = 4;
            BaseDef = 5;
            BaseRes = 2;
            BaseCha = 6;
            HPGrowth = 0.55;
            StrGrowth = 0.45;
            MagGrowth = 0.20;
            DexGrowth = 0.45;
            SpdGrowth = 0.30;
            LckGrowth = 0.15;
            DefGrowth = 0.45;
            ResGrowth = 0.10;
            ChaGrowth = 0.35;
            MaxHP = 101;
            MaxStr = 65;
            MaxMag = 35;
            MaxDex = 62;
            MaxSpd = 42;
            MaxLck = 40;
            MaxDef = 61;
            MaxRes = 35;
            MaxCha = 49;
        }
    }
}
