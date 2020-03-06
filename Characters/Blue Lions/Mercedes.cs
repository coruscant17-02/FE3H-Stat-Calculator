using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Mercedes : Protagonist
    {
        public Mercedes()
        {
            BaseHP = 25;
            BaseStr = 6;
            BaseMag = 10;
            BaseDex = 6;
            BaseSpd = 8;
            BaseLck = 5;
            BaseDef = 5;
            BaseRes = 9;
            BaseCha = 8;
            HPGrowth = 0.30;
            StrGrowth = 0.25;
            MagGrowth = 0.50;
            DexGrowth = 0.45;
            SpdGrowth = 0.40;
            LckGrowth = 0.30;
            DefGrowth = 0.25;
            ResGrowth = 0.45;
            ChaGrowth = 0.40;
            MaxHP = 64;
            MaxStr = 37;
            MaxMag = 72;
            MaxDex = 62;
            MaxSpd = 58;
            MaxLck = 54;
            MaxDef = 44;
            MaxRes = 65;
            MaxCha = 58;
        }
    }
}
