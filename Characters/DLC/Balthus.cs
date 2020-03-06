using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Balthus : Protagonist 
    {
        public Balthus()
        {
            BaseHP = 28;
            BaseStr = 11;
            BaseMag = 5;
            BaseDex = 4;
            BaseSpd = 7;
            BaseLck = 3;
            BaseDef = 7;
            BaseRes = 4;
            BaseCha = 4;
            HPGrowth = 0.50;
            StrGrowth = 0.50;
            MagGrowth = 0.30;
            DexGrowth = 0.25;
            SpdGrowth = 0.30;
            LckGrowth = 0.20;
            DefGrowth = 0.45;
            ResGrowth = 0.30;
            ChaGrowth = 0.30;
            MaxHP = 100;
            MaxStr = 71;
            MaxMag = 48;
            MaxDex = 39;
            MaxSpd = 46;
            MaxLck = 35;
            MaxDef = 69;
            MaxRes = 43;
            MaxCha = 46;
        }
    }
}
