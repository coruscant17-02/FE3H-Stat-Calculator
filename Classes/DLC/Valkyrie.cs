using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.DLC
{
    public class Valkyrie : Commoner
    {
        public Valkyrie()
        {
            BaseHP = 20;
            BaseStr = 5;
            BaseMag = 10;
            BaseDex = 10;
            BaseSpd = 9;
            BaseLck = 9;
            BaseDef = 9;
            BaseRes = 13;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.05;
            StrGrowth = 0;
            MagGrowth = 0.05;
            DexGrowth = 0;
            SpdGrowth = -0.05;
            LckGrowth = 0;
            DefGrowth = 0.05;
            ResGrowth = 0.05;
            ChaGrowth = 0;
            HPBoost = 1;
            StrBoost = 0;
            MagBoost = 4;
            DexBoost = 0;
            SpdBoost = -2;
            LckBoost = 0;
            DefBoost = 0;
            ResBoost = 2;
            ChaBoost = 2;
        }
    }
}
