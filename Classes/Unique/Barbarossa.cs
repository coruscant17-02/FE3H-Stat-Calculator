using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes
{
    public class Barbarossa : Commoner
    {
        public Barbarossa()
        {
            BaseHP = 35;
            BaseStr = 18;
            BaseMag = 10;
            BaseDex = 14;
            BaseSpd = 20;
            BaseLck = 12;
            BaseDef = 15;
            BaseRes = 12;
            BaseCha = 0;
            Movement = 8;
            HPGrowth = 0.30;
            StrGrowth = 0.15;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0.10;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0;
            ChaGrowth = 0.10;
            HPBoost = 3;
            StrBoost = 3;
            MagBoost = 0;
            DexBoost = 5;
            SpdBoost = 2;
            LckBoost = 0;
            DefBoost = 2;
            ResBoost = 0;
            ChaBoost = 2;
        }
    }
}
