/*
 * @lc app=leetcode.cn id=167 lang=csharp
 *
 * [167] 两数之和 II - 输入有序数组
 */
using System;
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int[] TwoSum(int[] numbers, int target)
	{
		int mid = target < 0 ? (target - 1) / 2 : target / 2,
			midLength = Array.BinarySearch<int>(numbers, mid);
		while (midLength > 0 && numbers[midLength - 1] == numbers[midLength]) --midLength;
		midLength = midLength >= 0 ? midLength + 1 : ~midLength;
		int searchRange = midLength;
		for (int i = midLength; i < numbers.Length; i++)
		{
			int index = Array.BinarySearch<int>(numbers, 0, searchRange, target - numbers[i]);
			if (index >= 0) return new int[] { index + 1, i + 1 };
			else searchRange = ~index;
		}
		return new int[] { -1 };
	}
}
// @lc code=end