using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Unique
{
    public class DeathKnight : Commoner
    {
        public DeathKnight()
        {
            BaseHP = 32;
            BaseStr = 10;
            BaseMag = 17;
            BaseDex = 14;
            BaseSpd = 16;
            BaseLck = 12;
            BaseDef = 13;
            BaseRes = 15;
            BaseCha = 0;
            Movement = 7;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = 0.10;
            DexGrowth = 0;
            SpdGrowth = -0.05;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0.05;
            ChaGrowth = 0;
            HPBoost = 5;
            StrBoost = 4;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 1;
            LckBoost = 0;
            DefBoost = 3;
            ResBoost = 3;
            ChaBoost = 0;
        }
    }
}
