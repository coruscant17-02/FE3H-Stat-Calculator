using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Myrmidon : Commoner
    {
        public Myrmidon()
        {
            BaseHP = 20;
            BaseStr = 7;
            BaseMag = 3;
            BaseDex = 6;
            BaseSpd = 6;
            BaseLck = 4;
            BaseDef = 5;
            BaseRes = 2;
            BaseCha = 0;
            Movement = 4;
            HPGrowth = 0.10;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0.05;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = -0.05;
            ChaGrowth = 0.05;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 1;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
