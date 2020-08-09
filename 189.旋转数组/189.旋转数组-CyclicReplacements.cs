/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 */
using System;
// @lc code=start
public class Solution
{
	public int GreatestCommonDivisor(int a, int b)
	{
		if (b == 0) return a;
		return GreatestCommonDivisor(b, a % b);
	}

	public void Rotate(int[] nums, int k)
	{
		int n = nums.Length;
		k %= n;
		int gcd = GreatestCommonDivisor(n, k);
		for (int startIndex = 0; startIndex < gcd; ++startIndex)
		{
			int currentIndex = startIndex;
			int prevValue = nums[startIndex];
			do
			{
				int nextIndex = (currentIndex + k) % n;
				int temp = nums[nextIndex];
				nums[nextIndex] = prevValue;
				prevValue = temp;
				currentIndex = nextIndex;
			} 
			while (startIndex!=currentIndex);
		}
	}
}
// @lc code=end