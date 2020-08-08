/*
 * @lc app=leetcode.cn id=167 lang=csharp
 *
 * [167] 两数之和 II - 输入有序数组
 */
using System;
// @lc code=start
public class Solution
{
	public int[] TwoSum(int[] numbers, int target)
	{
//		int mid = target / 2;
		bool firstHalf = true;
		Dictionary<int, int> indexes = new Dictionary<int, int>();
		for (int i = 0; i < numbers.Length; i++)
			if (numbers[i] * 2 < target && !indexes.ContainsKey(numbers[i])) indexes.Add(numbers[i], i);
			else if (numbers[i] * 2 == target && firstHalf)
			{
				firstHalf = false;
				indexes.Add(numbers[i], i);
			}
			else if (indexes.ContainsKey(target - numbers[i]))
				return new int[] { indexes[target - numbers[i]] + 1, i + 1 };
		return new int[] { -1 };
	}
}
// @lc code=end