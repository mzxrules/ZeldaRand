//mzxrules 2017
namespace ZeldaRand
{
    static class TruthSpinner
    {
        /// <summary>
        /// Number of times Rand is called between generating the "NextFloat" for the checks
        /// </summary>
        const int RNG_PULLS = 2; 
        public static uint[] Solve()
        {
            uint[] result = new uint[3];
            Rand r = new Rand();

            for (long i = 0; i <= uint.MaxValue; i++)
            {
                //set seed
                r.SetSeed((uint)i);

                //pick random number between 0.0 and 3.0 exclusive
                float next = r.NextFloat() * 3;

                //first check
                if (next < 1)
                {
                    result[0]++;
                    continue;
                }
                //call intermediate rng
                for (int j = 0; j < RNG_PULLS; j++)
                    r.Next();

                next = r.NextFloat() * 3;

                //second check
                if (next < 2)
                {
                    result[1]++;
                    continue;
                }

                //final check, should always pass
                result[2]++;
            }
            return result;
        }
    }
}
