using System;

namespace Projects
{
	public class Program
	{
		public const string MsgKeyFound = "L'element es troba a la posició: {0}";
		public const string MsgKeyNotFound = "L'element no s'ha trobat.";
		
		public static int BinarySearch(int[] arr, int first, int last, int key)
		{
			if (last >= first)
			{
				int mid = first + (last - first) / 2;
				if (arr[mid] == key)
				{
					return mid;
				}
				if (arr[mid] > key)
				{
					return BinarySearch(arr, first, mid - 1, key);//cerca en el subarray esquerre
				}
				else
				{
					return BinarySearch(arr, mid + 1, last, key);//cerca en el subarray dret
				}
			}
			return -1;
		}
		public static void Main()
		{
			int[] arr = { 10, 20, 30, 40, 50 };
			int key = 30;
			int last = arr.Length - 1;
			int result = BinarySearch(arr, 0, last, key);
			if (result == -1)
				Console.WriteLine(MsgKeyNotFound);
			else
				Console.WriteLine(MsgKeyFound, result);
		}
	}
}

