using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class GreatKnight : Commoner
    {
        public GreatKnight()
        {
            BaseHP = 34;
            BaseStr = 18;
            BaseMag = 10;
            BaseDex = 14;
            BaseSpd = 10;
            BaseLck = 12;
            BaseDef = 17;
            BaseRes = 10;
            BaseCha = 0;
            Movement = 7;
            HPGrowth = 0.30;
            StrGrowth = 0.10;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = -0.10;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = -0.05;
            ChaGrowth = 0.05;
            HPBoost = 5;
            StrBoost = 1;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = -4;
            LckBoost = 0;
            DefBoost = 8;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
