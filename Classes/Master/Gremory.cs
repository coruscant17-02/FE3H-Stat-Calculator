using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class Gremory : Commoner
    {
        public Gremory()
        {
            BaseHP = 32;
            BaseStr = 8;
            BaseMag = 17;
            BaseDex = 14;
            BaseSpd = 16;
            BaseLck = 12;
            BaseDef = 13;
            BaseRes = 16;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.10;
            StrGrowth = 0;
            MagGrowth = 0.10;
            DexGrowth = 0.10;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0.05;
            ChaGrowth = 0.10;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 5;
            DexBoost = 2;
            SpdBoost = 1;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 4;
            ChaBoost = 2;
        }
    }
}
