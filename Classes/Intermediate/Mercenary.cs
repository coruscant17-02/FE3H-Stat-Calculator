using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Mercenary : Commoner
    {
        public Mercenary()
        {
            BaseHP = 25;
            BaseStr = 9;
            BaseMag = 6;
            BaseDex = 10;
            BaseSpd = 10;
            BaseLck = 8;
            BaseDef = 6;
            BaseRes = 2;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.20;
            StrGrowth = 0.05;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0.05;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = -0.05;
            ChaGrowth = 0.05;
            HPBoost = 1;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 1;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
