using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Archer : Commoner
    {
        public Archer()
        {
            BaseHP = 25;
            BaseStr = 8;
            BaseMag = 6;
            BaseDex = 8;
            BaseSpd = 7;
            BaseLck = 8;
            BaseDef = 5;
            BaseRes = 2;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.05;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0.10;
            SpdGrowth = 0;
            LckGrowth = 0.05;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 2;
            SpdBoost = 0;
            LckBoost = 2;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
