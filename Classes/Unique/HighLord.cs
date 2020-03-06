using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class HighLord : Commoner
    {
        public HighLord()
        {
            BaseHP = 30;
            BaseStr = 16;
            BaseMag = 7;
            BaseDex = 11;
            BaseSpd = 13;
            BaseLck = 9;
            BaseDef = 13;
            BaseRes = 9;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.20;
            StrGrowth = 0.05;
            MagGrowth = 0;
            DexGrowth = 0.05;
            SpdGrowth = 0;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0;
            ChaGrowth = 0.10;
            HPBoost = 3;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 3;
            LckBoost = 0;
            DefBoost = 1;
            ResBoost = 0;
            ChaBoost = 2;
        }
    }
}
