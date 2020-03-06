using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Bernadetta : Protagonist
    {
        public Bernadetta()
        {
            BaseHP = 25;
            BaseStr = 8;
            BaseMag = 5;
            BaseDex = 7;
            BaseSpd = 7;
            BaseLck = 5;
            BaseDef = 4;
            BaseRes = 2;
            BaseCha = 6;
            HPGrowth = 0.35;
            StrGrowth = 0.35;
            MagGrowth = 0.20;
            DexGrowth = 0.55;
            SpdGrowth = 0.50;
            LckGrowth = 0.25;
            DefGrowth = 0.20;
            ResGrowth = 0.30;
            ChaGrowth = 0.35;
            MaxHP = 70;
            MaxStr = 51;
            MaxMag = 40;
            MaxDex = 75;
            MaxSpd = 69;
            MaxLck = 41;
            MaxDef = 41;
            MaxRes = 39;
            MaxCha = 49;
        }
    }
}
