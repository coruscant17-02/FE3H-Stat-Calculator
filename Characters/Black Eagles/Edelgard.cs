using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Edelgard : Protagonist
    {
        public Edelgard()
        {
            BaseHP = 29;
            BaseStr = 13;
            BaseMag = 6;
            BaseDex = 5;
            BaseSpd = 8;
            BaseLck = 5;
            BaseDef = 6;
            BaseRes = 4;
            BaseCha = 10;
            HPGrowth = 0.40;
            StrGrowth = 0.55;
            MagGrowth = 0.45;
            DexGrowth = 0.45;
            SpdGrowth = 0.40;
            LckGrowth = 0.30;
            DefGrowth = 0.35;
            ResGrowth = 0.35;
            ChaGrowth = 0.60;
            MaxHP = 81;
            MaxStr = 81;
            MaxMag = 72;
            MaxDex = 61;
            MaxSpd = 57;
            MaxLck = 42;
            MaxDef = 61;
            MaxRes = 47;
            MaxCha = 85;
        }
    }
}
