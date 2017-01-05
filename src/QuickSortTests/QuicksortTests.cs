using System;
using System.Collections.Generic;
using QuickSort;
using Xunit;

namespace QuickSortTests
{
	public class QuicksortTests
	{
		[Fact]
		public void QuickSort_GivenNull_ThrowsException()
		{
			int[] t = null;
			Assert.Throws<ArgumentException>(() => Quicksort.Sort(t));
		}

		[Fact]
		public void QuickSort_GivenEmpty_RemainsEmpty()
		{
			int[] t = {};
			Quicksort.Sort(t);
			Assert.True(t.Length == 0);
		}

		[Fact]
		public void QuickSort_OneElement_IsSorted()
		{
			int[] t = {1};
			Quicksort.Sort(t);
			Assert.True(IsSorted(t));
		}

		[Fact]
		public void QuickSort_GivenSorted_RemainsSorted()
		{
			int[] t = {1, 2, 3};
			Assert.True(IsSorted(t));
			Quicksort.Sort(t);
			Assert.True(IsSorted(t));
		}

		[Fact]
		public void QuickSort_WithDuplicates_ReturnsSorted()
		{
			int[] t = { 3, 5, 6, 3, 9, 0, 1, 3 };
			Assert.False(IsSorted(t));
			Quicksort.Sort(t);
			Assert.True(IsSorted(t));
		}

		public void QuickSort_WithoutDuplicates_ReturnsSorted()
		{
			int[] t = { 4, 2, 8, 5, 9, 0, 3, 7 };
			Assert.False(IsSorted(t));
			Quicksort.Sort(t);
			Assert.True(IsSorted(t));
		}

		private static bool IsSorted<T>(IList<T> items) where T : IComparable<T>
		{
			if (items == null)
			{
				throw new ArgumentException("The input array cannot be null.");
			}
			if (items.Count <= 1)
			{
				return true;
			}

			var last = items[0];
			for (int i = 1; i < items.Count; i++)
			{
				if (last.CompareTo(items[i]) > 0)
				{
					return false;
				}
				last = items[i];
			}
			return true;
		}
	}
}
