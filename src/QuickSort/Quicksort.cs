using System;

namespace QuickSort
{
	public class Quicksort
	{
		public static void Sort(int[] arr)
		{
			if (arr == null)
			{
				throw new ArgumentException("The input array cannot be null");
			}
			if (arr.Length <= 1)
			{
				return;
			}
			Sort(arr, 0, arr.Length - 1);
		}

		private static void Sort(int[] arr, int low, int high)
		{
			if (low >= high) { return; }

			int wall = low;
			int cur = low;
			int pivot = high;

			while (pivot > cur)
			{
				if (arr[pivot] > arr[cur])
				{
					Swap(arr, cur, wall);
					wall++;
				}
				cur++;
			}
			Swap(arr, pivot, wall);

			Sort(arr, low, wall - 1);
			Sort(arr, wall + 1, high);
		}

		private static void Swap(int[] arr, int indexA, int indexB)
		{
			var temp = arr[indexA];
			arr[indexA] = arr[indexB];
			arr[indexB] = temp;
		}
	}
}
