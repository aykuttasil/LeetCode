using System;

namespace jewels_and_stones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Input: J = "aA", S = "aAAbbbb"
             Output: 3   
             */

            var result = NumJewelsInStones("aA", "aAAbbbb");
            Console.WriteLine("Result: " + result);
        }

        static int NumJewelsInStones(string J, string S)
        {
            var count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                var charInS = S[i];
                for (int y = 0; y < J.Length; y++)
                {
                    var charInJ = J[y];
                    if (charInJ.Equals(charInS))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
