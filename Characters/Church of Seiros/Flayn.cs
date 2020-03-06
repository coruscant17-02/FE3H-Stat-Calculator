using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Flayn : Protagonist 
    {
        public Flayn()
        {
            BaseHP = 24;
            BaseStr = 6;
            BaseMag = 9;
            BaseDex = 6;
            BaseSpd = 5;
            BaseLck = 4;
            BaseDef = 5;
            BaseRes = 10;
            BaseCha = 9;
            HPGrowth = 0.25;
            StrGrowth = 0.25;
            MagGrowth = 0.55;
            DexGrowth = 0.45;
            SpdGrowth = 0.35;
            LckGrowth = 0.15;
            DefGrowth = 0.25;
            ResGrowth = 0.50;
            ChaGrowth = 0.45;
            MaxHP = 56;
            MaxStr = 37;
            MaxMag = 77;
            MaxDex = 62;
            MaxSpd = 48;
            MaxLck = 46;
            MaxDef = 36;
            MaxRes = 72;
            MaxCha = 65;
        }
    }
}