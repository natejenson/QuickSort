using System;
using QuickSort;
using Xunit;

namespace QuickSortTests
{
	public class SorterTests
	{
		[Fact]
		public void QuickSort_GivenNull_ThrowsException()
		{
			int[] t = null;
			Assert.Throws<ArgumentException>(() => Sorter.QuickSort(t));
		}

		[Fact]
		public void QuickSort_GivenEmpty_RemainsEmpty()
		{
			int[] t = {};
			Sorter.QuickSort(t);
			Assert.True(t.Length == 0);
		}

		[Fact]
		public void QuickSort_OneElement_IsSorted()
		{
			int[] t = {1};
			Sorter.QuickSort(t);
			Assert.True(IsSorted(t));
		}

		[Fact]
		public void QuickSort_GivenSorted_RemainsSorted()
		{
			int[] t = {1, 2, 3};
			Assert.True(IsSorted(t));
			Sorter.QuickSort(t);
			Assert.True(IsSorted(t));
		}

		[Fact]
		public void QuickSort_WithDuplicates_ReturnsSorted()
		{
			int[] t = { 3, 5, 6, 3, 9, 0, 1, 3 };
			Assert.False(IsSorted(t));
			Sorter.QuickSort(t);
			Assert.True(IsSorted(t));
		}

		public void QuickSort_WithoutDuplicates_ReturnsSorted()
		{
			int[] t = { 4, 2, 8, 5, 9, 0, 3, 7 };
			Assert.False(IsSorted(t));
			Sorter.QuickSort(t);
			Assert.True(IsSorted(t));
		}

		private static bool IsSorted(int[] arr)
		{
			if (arr == null)
			{
				throw new ArgumentException("The input array cannot be null.");
			}
			if (arr.Length <= 1)
			{
				return true;
			}

			int last = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (last > arr[i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
