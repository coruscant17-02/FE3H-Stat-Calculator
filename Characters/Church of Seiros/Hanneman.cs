using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Hanneman : Protagonist 
    {
        public Hanneman()
        {
            BaseHP = 25;
            BaseStr = 6;
            BaseMag = 10;
            BaseDex = 6;
            BaseSpd = 6;
            BaseLck = 4;
            BaseDef = 5;
            BaseRes = 7;
            BaseCha = 5;
            HPGrowth = 0.40;
            StrGrowth = 0.30;
            MagGrowth = 0.55;
            DexGrowth = 0.45;
            SpdGrowth = 0.20;
            LckGrowth = 0.35;
            DefGrowth = 0.25;
            ResGrowth = 0.40;
            ChaGrowth = 0.35;
            MaxHP = 77;
            MaxStr = 43;
            MaxMag = 78;
            MaxDex = 62;
            MaxSpd = 35;
            MaxLck = 49;
            MaxDef = 36;
            MaxRes = 57;
            MaxCha = 48;
        }
    }
}
