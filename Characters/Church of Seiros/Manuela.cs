using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Manuela : Protagonist
    {
        public Manuela()
        {
            BaseHP = 26;
            BaseStr = 10;
            BaseMag = 8;
            BaseDex = 6;
            BaseSpd = 8;
            BaseLck = 6;
            BaseDef = 5;
            BaseRes = 4;
            BaseCha = 7;
            HPGrowth = 0.50;
            StrGrowth = 0.35;
            MagGrowth = 0.35;
            DexGrowth = 0.40;
            SpdGrowth = 0.60;
            LckGrowth = 0.35;
            DefGrowth = 0.30;
            ResGrowth = 0.25;
            ChaGrowth = 0.50;
            MaxHP = 91;
            MaxStr = 52;
            MaxMag = 65;
            MaxDex = 56;
            MaxSpd = 56;
            MaxLck = 56;
            MaxDef = 43;
            MaxRes = 60;
            MaxCha = 97;
        }
    }
}
