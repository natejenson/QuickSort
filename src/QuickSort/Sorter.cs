using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort
{
	public class Sorter
	{
		public static void QuickSort(int[] arr)
		{
			if (arr == null)
			{
				throw new ArgumentException("The input array cannot be null");
			}
			if (arr.Length <= 1)
			{
				return;
			}
			QuickSort(arr, 0, arr.Length - 1);
		}

		private static void QuickSort(int[] arr, int low, int high)
		{
			int partition = Partition(arr, low, high);
			if (low < partition - 1)
			{
				QuickSort(arr, low, partition - 1);
			}
			if ( high > partition)
			{
				QuickSort(arr, partition, high);
			}
		}

		private static int Partition(int[] arr, int low, int high)
		{
			int pivot = arr[low];
			int left = low;
			int right = high;
			while (left <= right)
			{
				while (arr[left] < pivot)
				{
					left++;
				}

				while (arr[right] > pivot)
				{
					right--;
				}

				if (left <= right)
				{
					Swap(arr, left, right);
					left++;
					right--;
				}
			}
			return left;
		}

		private static void Swap(int[] arr, int indexA, int indexB)
		{
			var temp = arr[indexA];
			arr[indexA] = arr[indexB];
			arr[indexB] = temp;
		}
	}
}
