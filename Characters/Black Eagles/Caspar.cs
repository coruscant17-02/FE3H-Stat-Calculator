using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Caspar : Protagonist
    {
        public Caspar()
        {
            BaseHP = 26;
            BaseStr = 9;
            BaseMag = 3;
            BaseDex = 5;
            BaseSpd = 6;
            BaseLck = 8;
            BaseDef = 6;
            BaseRes = 2;
            BaseCha = 4;
            HPGrowth = 0.55;
            StrGrowth = 0.45;
            MagGrowth = 0.25;
            DexGrowth = 0.45;
            SpdGrowth = 0.45;
            LckGrowth = 0.40;
            DefGrowth = 0.30;
            ResGrowth = 0.20;
            ChaGrowth = 0.25;
            MaxHP = 97;
            MaxStr = 65;
            MaxMag = 41;
            MaxDex = 61;
            MaxSpd = 62;
            MaxLck = 58;
            MaxDef = 51;
            MaxRes = 35;
            MaxCha = 46;
        }
    }
}
