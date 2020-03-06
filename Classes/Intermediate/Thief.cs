using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Thief : Commoner
    {
        public Thief()
        {
            BaseHP = 25;
            BaseStr = 9;
            BaseMag = 6;
            BaseDex = 11;
            BaseSpd = 11;
            BaseLck = 8;
            BaseDef = 6;
            BaseRes = 2;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.20;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0.10;
            SpdGrowth = 0.10;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 2;
            SpdBoost = 2;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
