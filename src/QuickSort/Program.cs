using System;
using System.Collections.Generic;

namespace QuickSort
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int[] sample = {4, 2, 8, 5, 9, 4, 0, 3, 7};
			Console.WriteLine($"Input:  {Stringify(sample)}");
			Quicksort.Sort(sample);
			Console.WriteLine($"Output: {Stringify(sample)}");
			Console.Read();
		}

		private static string Stringify<T>(IEnumerable<T> collection)
		{
			return string.Join(", ", collection);
		}
	}
}
