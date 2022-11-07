using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge01
{
    internal class Reverse
    {
        public static void rev(int[] ray)
        {
            int[] revray = new int[ray.Length];
            int counter = 0;

            for (int i = ray.Length - 1; i >= 0; i--)
            {
                revray[counter] = ray[i];
                counter++;
                
                
            }

            foreach (int i in revray)
            {
                Console.Write(i);
            }
        }
    }
}
