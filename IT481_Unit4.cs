using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IT481_TyMcCombs_Unit4
{
	public class IT481_Unit4
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Working on unit test.");
		}
		public int Example1(int[] y, int z)
		{
			int currmin = 100;
			for (int i = 0; i < z; i++)
			{
				if (y[i] == currmin)
					currmin = y[i];
			}
			return currmin;
		}
		public void Example2(int[] a)
		{
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine(a[i]);
			}
		}
		public bool Example3(int[] foo)
		{
			int a = 10;
			int b = 5;
			bool found = false;

			for (int i = 0; i < foo.Length; i++)
			{
				if (a == foo[i])
				{
					Console.WriteLine("The value of a was found in int array.");
					found = true;
				}
				else if (b == foo[i])
				{
					Console.WriteLine("The value of b was found in int array.");
					found = true;
				}
			}
			if (found == false)
			{
				Console.WriteLine("None of the search values were found.");
			}
			return found;
		}
	}
}
