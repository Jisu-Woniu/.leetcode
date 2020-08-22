using System;

namespace _27Demo
{
	class Program
	{
		static int RemoveElement(int[] nums, int val)
		{
			if (nums.Length == 0) return 0;
			int l = 0, r = nums.Length - 1;
			while (l <= r)
			{
				while (l < nums.Length && nums[l] != val) ++l;
				while (r >= 0 && nums[r] == val) --r;
				if (l > r)
					return r + 1;
				else
					nums[l] = nums[r--];
			}
			return r + 1;
		}

		static void Main()
		{
			int[] demonums = new int[] { 2, 2 };
			int output = RemoveElement(demonums, 3);
			Console.WriteLine(output);
			for (int i = 0; i < output; i++)
				Console.Write(demonums[i].ToString() + " ");
		}
	}
}