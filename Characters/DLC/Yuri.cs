using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Yuri : Protagonist 
    {
        public Yuri()
        {
            BaseHP = 24;
            BaseStr = 10;
            BaseMag = 6;
            BaseDex = 7;
            BaseSpd = 9;
            BaseLck = 7;
            BaseDef = 5;
            BaseRes = 7;
            BaseCha = 8;
            HPGrowth = 0.30;
            StrGrowth = 0.40;
            MagGrowth = 0.35;
            DexGrowth = 0.40;
            SpdGrowth = 0.65;
            LckGrowth = 0.45;
            DefGrowth = 0.30;
            ResGrowth = 0.35;
            ChaGrowth = 0.50;
            MaxHP = 64;
            MaxStr = 59;
            MaxMag = 55;
            MaxDex = 68;
            MaxSpd = 92;
            MaxLck = 77;
            MaxDef = 48;
            MaxRes = 51;
            MaxCha = 71;
        }
    }
}
