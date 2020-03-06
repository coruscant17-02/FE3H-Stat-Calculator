using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Ashe : Protagonist 
    {
        public Ashe()
        {
            BaseHP = 23;
            BaseStr = 8;
            BaseMag = 5;
            BaseDex = 8;
            BaseSpd = 9;
            BaseLck = 6;
            BaseDef = 5;
            BaseRes = 6;
            BaseCha = 5;
            HPGrowth = 0.35;
            StrGrowth = 0.35;
            MagGrowth = 0.25;
            DexGrowth = 0.55;
            SpdGrowth = 0.50;
            LckGrowth = 0.40;
            DefGrowth = 0.20;
            ResGrowth = 0.35;
            ChaGrowth = 0.25;
            MaxHP = 68;
            MaxStr = 51;
            MaxMag = 36;
            MaxDex = 76;
            MaxSpd = 71;
            MaxLck = 56;
            MaxDef = 43;
            MaxRes = 49;
            MaxCha = 36;
        }
    }
}
