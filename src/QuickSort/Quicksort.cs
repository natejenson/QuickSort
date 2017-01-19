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

			int wall = Partition(items, low, high);
			Sort(items, low, wall - 1);
			Sort(items, wall + 1, high);
		}

		/// <summary>
		/// Partitions the array around a pivot such that all elements to left left of the pivot
		/// are less than or equal to the pivot, and all elements to the right are greater than or equal
		/// to the pivot.
		/// </summary>
		/// <typeparam name="T">The type of the items being partitioned.</typeparam>
		/// <param name="items">The array to partition</param>
		/// <param name="low">The lower bound index (inclusive) of the partitioning.</param>
		/// <param name="high">The upper bound index (inclusive) of the partitioning.</param>
		/// <returns>The index of the pivot that was chosen.</returns>
		private static int Partition<T>(IList<T> items, int low, int high) where T : IComparable<T>
		{
			int wall = low;
			int cur = low;
			int mid = low + (high - low) / 2;
			T pivot = items[mid];
			Swap(items, mid, high);

			while (cur < high)
			{
				if (pivot.CompareTo(items[cur]) > 0)
				{
					Swap(items, cur, wall);
					wall++;
				}
				cur++;
			}
			Swap(items, high, wall);
			return wall;
		}

		private static void Swap<T>(IList<T> items, int indexA, int indexB)
		{
			var temp = items[indexA];
			items[indexA] = items[indexB];
			items[indexB] = temp;
		}
	}
}
