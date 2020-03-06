using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Priest : Commoner
    {
        public Priest()
        {
            BaseHP = 25;
            BaseStr = 4;
            BaseMag = 9;
            BaseDex = 7;
            BaseSpd = 6;
            BaseLck = 8;
            BaseDef = 3;
            BaseRes = 5;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0.05;
            StrGrowth = -0.05;
            MagGrowth = 0.05;
            DexGrowth = 0.05;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = -0.05;
            ResGrowth = 0.10;
            ChaGrowth = 0.10;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 1;
            SpdBoost = 0;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 3;
            ChaBoost = 0;
        }
    }
}
