using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class DarkKnight : Commoner
    {
        public DarkKnight()
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
            HPGrowth = 0.10;
            StrGrowth = 0.05;
            MagGrowth = 0.10;
            DexGrowth = 0;
            SpdGrowth = -0.05;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0.10;
            ChaGrowth = 0.05;
            HPBoost = 1;
            StrBoost = 1;
            MagBoost = 2;
            DexBoost = 2;
            SpdBoost = -1;
            LckBoost = 0;
            DefBoost = 2;
            ResBoost = 3;
            ChaBoost = 0;
        }
    }
}
