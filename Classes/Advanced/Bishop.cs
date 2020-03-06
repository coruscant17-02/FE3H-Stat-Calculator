using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Bishop : Commoner
    {
        public Bishop()
        {
            BaseHP = 30;
            BaseStr = 8;
            BaseMag = 15;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 12;
            BaseRes = 15;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0.10;
            StrGrowth = 0;
            MagGrowth = 0.10;
            DexGrowth = 0;
            SpdGrowth = 0;
            LckGrowth = 0.10;
            DefGrowth = -0.05;
            ResGrowth = 0.05;
            ChaGrowth = 0.10;
            HPBoost = 1;
            StrBoost = 0;
            MagBoost = 2;
            DexBoost = 1;
            SpdBoost = 0;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 5;
            ChaBoost = 0;
        }
    }
}
