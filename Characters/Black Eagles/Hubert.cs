using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Hubert : Protagonist
    {
        public Hubert()
        {
            BaseHP = 22;
            BaseStr = 6;
            BaseMag = 12;
            BaseDex = 6;
            BaseSpd = 7;
            BaseLck = 6;
            BaseDef = 4;
            BaseRes = 7;
            BaseCha = 6;
            HPGrowth = 0.35;
            StrGrowth = 0.30;
            MagGrowth = 0.55;
            DexGrowth = 0.45;
            SpdGrowth = 0.45;
            LckGrowth = 0.35;
            DefGrowth = 0.25;
            ResGrowth = 0.40;
            ChaGrowth = 0.35;
            MaxHP = 67;
            MaxStr = 43;
            MaxMag = 80;
            MaxDex = 62;
            MaxSpd = 63;
            MaxLck = 51;
            MaxDef = 45;
            MaxRes = 57;
            MaxCha = 49;
        }
    }
}
