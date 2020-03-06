using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Monk : Commoner
    {
        public Monk()
        {
            BaseHP = 20;
            BaseStr = 4;
            BaseMag = 8;
            BaseDex = 6;
            BaseSpd = 6;
            BaseLck = 4;
            BaseDef = 3;
            BaseRes = 4;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0.05;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0.05;
            ChaGrowth = 0.05;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 0;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 1;
            ChaBoost = 0;
        }
    }
}
