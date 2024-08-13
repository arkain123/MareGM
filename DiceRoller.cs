using System;

namespace D_Dcharlist
{ 
    class Roller
    {
        public int Roll (int cubeType, int repeats)
        {
            Random rnd = new Random();
            int summ = 0;
            while(repeats != 0)
            {
                summ = summ + rnd.Next(0, cubeType);
                repeats--;
            }
            return summ;
        }

        public int Roll(int cubeType)
        {
            Random rnd = new Random();
            return rnd.Next(0, cubeType);
        }
    }
}