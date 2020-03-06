using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Dancer : Commoner
    {
        public Dancer()
        {
            BaseHP = 0;
            BaseStr = 0;
            BaseMag = 0;
            BaseDex = 0;
            BaseSpd = 0;
            BaseLck = 0;
            BaseDef = 0;
            BaseRes = 0;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.20;
            StrGrowth = -0.05;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = -0.05;
            ResGrowth = -0.05;
            ChaGrowth = 0.10;
            HPBoost = 0;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 3;
            SpdBoost = 3;
            LckBoost = 0;
            DefBoost = 2;
            ResBoost = 1;
            ChaBoost = 2;
        }
    }
}
