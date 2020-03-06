using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Lorenz : Protagonist
    {
        public Lorenz()
        {
            BaseHP = 28;
            BaseStr = 8;
            BaseMag = 7;
            BaseDex = 6;
            BaseSpd = 7;
            BaseLck = 5;
            BaseDef = 6;
            BaseRes = 6;
            BaseCha = 3;
            HPGrowth = 0.55;
            StrGrowth = 0.40;
            MagGrowth = 0.40;
            DexGrowth = 0.45;
            SpdGrowth = 0.40;
            LckGrowth = 0.25;
            DefGrowth = 0.30;
            ResGrowth = 0.40;
            ChaGrowth = 0.35;
            MaxHP = 99;
            MaxStr = 58;
            MaxMag = 57;
            MaxDex = 62;
            MaxSpd = 57;
            MaxLck = 48;
            MaxDef = 55;
            MaxRes = 56;
            MaxCha = 46;
        }
    }
}
