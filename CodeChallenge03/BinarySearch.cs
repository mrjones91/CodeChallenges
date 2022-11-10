using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge03
{
	public class BinarySearch
	{
		public static void Search(int[] ray, int target) 
		{
			int divider = 0, mid = 0;
			int min = 0, max = ray.Length;

			//if (ray.Length % 2 != 0)
			//	divider = 1;
			//mid = (ray.Length / 2) + divider;

			mid = (max + min) / 2;

			Console.WriteLine("Checking for " + target + " at [" + mid + "] from ray[" + min + "] to ray[" + max + "]");
			for (int r = 0; r < max; r++) {
				Console.WriteLine("[" + r + "]: " + ray[r]);
			}
			
			Console.WriteLine("");

			if (target == ray[mid]) {
				Console.WriteLine("Woot!");
				Console.WriteLine("Target: " + target + " found at ray[" + mid + "]\n\n");
				return;
			} else if (target > ray[mid]) {
				min = mid;
				
				Console.WriteLine("Target is higher than middle value");
				
			}
			else { //target < ray[mid]
				max = mid;
				
				Console.WriteLine("Target is lower than middle value");
			}

			int[] newRay = new int[max - min];
			Array.Copy(ray, min, newRay, 0, newRay.Length );

			
			Console.WriteLine("\n------------\n");
			Search(newRay, target);
		}
	}
}
