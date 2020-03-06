using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class HolyKnight : Commoner
    {
        public HolyKnight()
        {
            BaseHP = 32;
            BaseStr = 8;
            BaseMag = 15;
            BaseDex = 14;
            BaseSpd = 16;
            BaseLck = 12;
            BaseDef = 13;
            BaseRes = 16;
            BaseCha = 0;
            Movement = 7;
            HPGrowth = 0.10;
            StrGrowth = 0;
            MagGrowth = 0.10;
            DexGrowth = 0;
            SpdGrowth = -0.05;
            LckGrowth = 0.10;
            DefGrowth = 0.05;
            ResGrowth = 0.10;
            ChaGrowth = 0.10;
            HPBoost = 2;
            StrBoost = 1;
            MagBoost = 1;
            DexBoost = 2;
            SpdBoost = -1;
            LckBoost = 0;
            DefBoost = 1;
            ResBoost = 4;
            ChaBoost = 0;
        }
    }
}
