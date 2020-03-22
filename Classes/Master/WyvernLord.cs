using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class WyvernLord : Commoner
    {
        public WyvernLord()
        {
            BaseHP = 32;
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
            MagGrowth = -0.05;
            DexGrowth = 0;
            SpdGrowth = 0.20;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0.05;
            ChaGrowth = 0.10;
            HPBoost = 2;
            StrBoost = 4;
            MagBoost = 0;
            DexBoost = 1;
            SpdBoost = 4;
            LckBoost = 0;
            DefBoost = 3;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
