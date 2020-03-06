using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Alois : Protagonist 
    {
        public Alois()
        {
            BaseHP = 28;
            BaseStr = 9;
            BaseMag = 4;
            BaseDex = 5;
            BaseSpd = 6;
            BaseLck = 5;
            BaseDef = 5;
            BaseRes = 2;
            BaseCha = 7;
            HPGrowth = 0.45;
            StrGrowth = 0.45;
            MagGrowth = 0.20;
            DexGrowth = 0.35;
            SpdGrowth = 0.40;
            LckGrowth = 0.30;
            DefGrowth = 0.40;
            ResGrowth = 0.20;
            ChaGrowth = 0.40;
            MaxHP = 86;
            MaxStr = 71;
            MaxMag = 33;
            MaxDex = 48;
            MaxSpd = 56;
            MaxLck = 42;
            MaxDef = 55;
            MaxRes = 37;
            MaxCha = 57;
        }
    }
}
