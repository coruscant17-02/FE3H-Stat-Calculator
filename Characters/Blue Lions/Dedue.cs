using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Dedue : Protagonist
    {
        public Dedue()
        {
            BaseHP = 30;
            BaseStr = 12;
            BaseMag = 2;
            BaseDex = 5;
            BaseSpd = 7;
            BaseLck = 5;
            BaseDef = 8;
            BaseRes = 1;
            BaseCha = 4;
            HPGrowth = 0.60;
            StrGrowth = 0.50;
            MagGrowth = 0.15;
            DexGrowth = 0.30;
            SpdGrowth = 0.20;
            LckGrowth = 0.25;
            DefGrowth = 0.50;
            ResGrowth = 0.10;
            ChaGrowth = 0.30;
            MaxHP = 108;
            MaxStr = 74;
            MaxMag = 30;
            MaxDex = 42;
            MaxSpd = 35;
            MaxLck = 44;
            MaxDef = 70;
            MaxRes = 35;
            MaxCha = 41;
        }
    }
}
