using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Linhardt : Protagonist
    {
        public Linhardt()
        {
            BaseHP = 24;
            BaseStr = 5;
            BaseMag = 10;
            BaseDex = 6;
            BaseSpd = 5;
            BaseLck = 7;
            BaseDef = 5;
            BaseRes = 9;
            BaseCha = 3;
            HPGrowth = 0.30;
            StrGrowth = 0.30;
            MagGrowth = 0.45;
            DexGrowth = 0.40;
            SpdGrowth = 0.40;
            LckGrowth = 0.45;
            DefGrowth = 0.30;
            ResGrowth = 0.45;
            ChaGrowth = 0.20;
            MaxHP = 63;
            MaxStr = 42;
            MaxMag = 66;
            MaxDex = 56;
            MaxSpd = 55;
            MaxLck = 63;
            MaxDef = 48;
            MaxRes = 65;
            MaxCha = 43;
        }
    }
}
