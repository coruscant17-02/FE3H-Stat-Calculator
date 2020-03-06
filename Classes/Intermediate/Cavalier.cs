using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Cavalier : Commoner
    {
        public Cavalier()
        {
            BaseHP = 25;
            BaseStr = 9;
            BaseMag = 6;
            BaseDex = 7;
            BaseSpd = 6;
            BaseLck = 8;
            BaseDef = 6;
            BaseRes = 2;
            BaseCha = 0;
            Movement = 7;
            HPGrowth = 0.20;
            StrGrowth = 0.05;
            MagGrowth = 0;
            DexGrowth = 0.05;
            SpdGrowth = -0.10;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 1;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 2;
            SpdBoost = -1;
            LckBoost = 0;
            DefBoost = 1;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
