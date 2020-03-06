using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Petra : Protagonist
    {
        public Petra()
        {
            BaseHP = 25;
            BaseStr = 9;
            BaseMag = 3;
            BaseDex = 7;
            BaseSpd = 10;
            BaseLck = 7;
            BaseDef = 5;
            BaseRes = 2;
            BaseCha = 6;
            HPGrowth = 0.45;
            StrGrowth = 0.40;
            MagGrowth = 0.25;
            DexGrowth = 0.50;
            SpdGrowth = 0.60;
            LckGrowth = 0.45;
            DefGrowth = 0.30;
            ResGrowth = 0.15;
            ChaGrowth = 0.20;
            MaxHP = 83;
            MaxStr = 59;
            MaxMag = 36;
            MaxDex = 69;
            MaxSpd = 85;
            MaxLck = 63;
            MaxDef = 42;
            MaxRes = 35;
            MaxCha = 63;
        }
    }
}
