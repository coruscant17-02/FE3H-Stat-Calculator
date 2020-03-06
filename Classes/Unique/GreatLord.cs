using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class GreatLord : Commoner
    {
        public GreatLord()
        {
            BaseHP = 35;
            BaseStr = 17;
            BaseMag = 8;
            BaseDex = 12;
            BaseSpd = 14;
            BaseLck = 10;
            BaseDef = 14;
            BaseRes = 10;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0.10;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0;
            ChaGrowth = 0.10;
            HPBoost = 5;
            StrBoost = 2;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 4;
            LckBoost = 1;
            DefBoost = 1;
            ResBoost = 0;
            ChaBoost = 2;
        }
    }
}
