using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.DLC
{
    public class Trickster : Commoner
    {
        public Trickster()
        {
            BaseHP = 28;
            BaseStr = 14;
            BaseMag = 12;
            BaseDex = 10;
            BaseSpd = 14;
            BaseLck = 12;
            BaseDef = 10;
            BaseRes = 10;
            BaseCha = 0;
            Movement = 5;
            HPGrowth = 0.20;
            StrGrowth = 0;
            MagGrowth = 0;
            DexGrowth = 0.15;
            SpdGrowth = 0.20;
            LckGrowth = 0.10;
            DefGrowth = 0;
            ResGrowth = 0.05;
            ChaGrowth = 0;
            HPBoost = 0;
            StrBoost = 0;
            MagBoost = 0;
            DexBoost = 3;
            SpdBoost = 4;
            LckBoost = 3;
            DefBoost = 0;
            ResBoost = 1;
            ChaBoost = 0;
        }
    }
}
