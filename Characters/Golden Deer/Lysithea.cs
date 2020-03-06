using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Lysithea : Protagonist
    {
        public Lysithea()
        {
            BaseHP = 22;
            BaseStr = 4;
            BaseMag = 11;
            BaseDex = 7;
            BaseSpd = 7;
            BaseLck = 4;
            BaseDef = 3;
            BaseRes = 4;
            BaseCha = 5;
            HPGrowth = 0.20;
            StrGrowth = 0.15;
            MagGrowth = 0.60;
            DexGrowth = 0.60;
            SpdGrowth = 0.50;
            LckGrowth = 0.15;
            DefGrowth = 0.10;
            ResGrowth = 0.25;
            ChaGrowth = 0.25;
            MaxHP = 48;
            MaxStr = 30;
            MaxMag = 86;
            MaxDex = 82;
            MaxSpd = 69;
            MaxLck = 40;
            MaxDef = 36;
            MaxRes = 41;
            MaxCha = 44;
        }
    }
}
