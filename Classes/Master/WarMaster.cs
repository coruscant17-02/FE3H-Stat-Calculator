using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h.Classes.Master
{
    public class WarMaster : Commoner
    {
        public WarMaster()
        {
            BaseHP = 33;
            BaseStr = 20;
            BaseMag = 10;
            BaseDex = 14;
            BaseSpd = 16;
            BaseLck = 12;
            BaseDef = 15;
            BaseRes = 10;
            BaseCha = 0;
            Movement = 6;
            HPGrowth = 0.40;
            StrGrowth = 0.15;
            MagGrowth = 0;
            DexGrowth = 0;
            SpdGrowth = 0.10;
            LckGrowth = 0;
            DefGrowth = 0;
            ResGrowth = 0;
            ChaGrowth = 0.05;
            HPBoost = 3;
            StrBoost = 5;
            MagBoost = 0;
            DexBoost = 0;
            SpdBoost = 2;
            LckBoost = 1;
            DefBoost = 1;
            ResBoost = 0;
            ChaBoost = 0;
        }
    }
}
