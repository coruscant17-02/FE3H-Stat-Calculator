using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class ArmoredKnight : Commoner
    {
        public ArmoredKnight()
        {
            BaseHP = 30;
            BaseStr = 9;
            BaseMag = 6;
            BaseDex = 7;
            BaseSpd = 4;
            BaseLck = 8;
            BaseDef = 12;
            BaseRes = 1;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0.20;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = -0.10;
            LckGrowth = 0;
            DefGrowth = 0.10;
            ResGrowth = -0.05;
            ChaGrowth = 0.05;
            HPBoost = 3;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = -2;
            LckBoost = 0;
            DefBoost = 4;
            ResBoost = -1;
            ChaBoost = 0;
        }
    }
}
