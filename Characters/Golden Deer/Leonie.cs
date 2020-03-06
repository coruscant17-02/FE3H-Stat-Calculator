using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Leonie : Protagonist
    {
        public Leonie()
        {
            BaseHP = 26;
            BaseStr = 9;
            BaseMag = 5;
            BaseDex = 8;
            BaseSpd = 9;
            BaseLck = 6;
            BaseDef = 7;
            BaseRes = 2;
            BaseCha = 7;
            HPGrowth = 0.40;
            StrGrowth = 0.40;
            MagGrowth = 0.20;
            DexGrowth = 0.55;
            SpdGrowth = 0.60;
            LckGrowth = 0.40;
            DefGrowth = 0.40;
            ResGrowth = 0.15;
            ChaGrowth = 0.40;
            MaxHP = 78;
            MaxStr = 59;
            MaxMag = 38;
            MaxDex = 76;
            MaxSpd = 84;
            MaxLck = 56;
            MaxDef = 57;
            MaxRes = 36;
            MaxCha = 57;
        }
    }
}
