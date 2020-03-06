using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Lord : Commoner
    {
        public Lord()
        {
            BaseHP = 25;
            BaseStr = 9;
            BaseMag = 6;
            BaseDex = 10;
            BaseSpd = 10;
            BaseLck = 8;
            BaseDef = 6;
            BaseRes = 3;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.20;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0.10;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.10;
            HPBoost = 1;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 1;
            LckBoost = 1;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 2;
        }
    }
}
