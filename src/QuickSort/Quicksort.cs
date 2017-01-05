using System;
using System.Collections.Generic;

namespace QuickSort
{
	public static class Quicksort
	{
		public static void Sort<T>(IList<T> items) where T : IComparable<T>
		{
			if (items == null)
			{
				throw new ArgumentException("The input array cannot be null");
			}
			if (items.Count <= 1)
			{
				return;
			}
			Sort(items, 0, items.Count - 1);
		}

		private static void Sort<T>(IList<T> items, int low, int high) where T : IComparable<T>
		{
			if (low >= high) { return; }

			int wall = low;
			int cur = low;
			int pivot = high;

			while (pivot > cur)
			{
				if (items[pivot].CompareTo(items[cur]) > 0)
				{
					Swap(items, cur, wall);
					wall++;
				}
				cur++;
			}
			Swap(items, pivot, wall);

			Sort(items, low, wall - 1);
			Sort(items, wall + 1, high);
		}

		private static void Swap<T>(IList<T> items, int indexA, int indexB)
		{
			var temp = items[indexA];
			items[indexA] = items[indexB];
			items[indexB] = temp;
		}
	}
}
