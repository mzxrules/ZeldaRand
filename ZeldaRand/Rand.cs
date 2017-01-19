//mzxrules 2017
using System;
using SeedType = System.UInt32;

namespace ZeldaRand
{
    class Rand
    {
        SeedType seed;

        public Rand()
        {
            seed = 0;
        }
        public Rand(SeedType s)
        {
            seed = s;
        }

        public void SetSeed(SeedType s)
        {
            seed = s;
        }

        public SeedType Next()
        {
            SeedType temp = seed * 1664525;
            temp += 1013904223;
            seed = temp;
            return seed;
        }

        public float NextFloat()
        {
            SeedType st = Next() & 0x7FFFFF; //23 bit mantissa
            var temp = BitConverter.ToUInt32(BitConverter.GetBytes(1.0f), 0);
            temp |= st;
            float result = BitConverter.ToSingle(BitConverter.GetBytes(temp), 0);
            return result - 1;
        }
    }
}
