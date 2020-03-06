using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Anna : Protagonist 
    {
        public Anna()
        {
            BaseHP = 26;
            BaseStr = 7;
            BaseMag = 7;
            BaseDex = 7;
            BaseSpd = 7;
            BaseLck = 7;
            BaseDef = 5;
            BaseRes = 7;
            BaseCha = 7;
            HPGrowth = 0.35;
            StrGrowth = 0.35;
            MagGrowth = 0.35;
            DexGrowth = 0.45;
            SpdGrowth = 0.55;
            LckGrowth = 0.45;
            DefGrowth = 0.30;
            ResGrowth = 0.40;
            ChaGrowth = 0.50;
            MaxHP = 68;
            MaxStr = 55;
            MaxMag = 49;
            MaxDex = 76;
            MaxSpd = 65;
            MaxLck = 75;
            MaxDef = 44;
            MaxRes = 49;
            MaxCha = 60;
        }
    }
}
