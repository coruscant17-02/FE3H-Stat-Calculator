using System;
using System.Collections.Generic;
using System.Text;

namespace fe3h
{
    public class Protagonist
    {
        public Protagonist()
        {
            BaseHP = 27;
            BaseStr = 13;
            BaseMag = 6;
            BaseDex = 9;
            BaseSpd = 8;
            BaseLck = 8;
            BaseDef = 6;
            BaseRes = 6;
            BaseCha = 7;
            HPGrowth = 0.45;
            StrGrowth = 0.45;
            MagGrowth = 0.35;
            DexGrowth = 0.45;
            SpdGrowth = 0.45;
            LckGrowth = 0.45;
            DefGrowth = 0.35;
            ResGrowth = 0.30;
            ChaGrowth = 0.45;
            MaxHP = 88;
            MaxStr = 77;
            MaxMag = 55;
            MaxDex = 66;
            MaxSpd = 66;
            MaxLck = 66;
            MaxDef = 55;
            MaxRes = 55;
            MaxCha = 99;
        }
        public int BaseHP;
        public int BaseStr;
        public int BaseMag;
        public int BaseDex;
        public int BaseSpd;
        public int BaseLck;
        public int BaseDef;
        public int BaseRes;
        public int BaseCha;
        public double HPGrowth;
        public double StrGrowth;
        public double MagGrowth;
        public double DexGrowth;
        public double SpdGrowth;
        public double LckGrowth;
        public double DefGrowth;
        public double ResGrowth;
        public double ChaGrowth;
        public int MaxHP;
        public int MaxStr;
        public int MaxMag;
        public int MaxDex;
        public int MaxSpd;
        public int MaxLck;
        public int MaxDef;
        public int MaxRes;
        public int MaxCha;
    }
}
