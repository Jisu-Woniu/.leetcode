/*
 * @lc app=leetcode.cn id=414 lang=csharp
 *
 * [414] 第三大的数
 */

// @lc code=start
public class Solution
{
	public int ThirdMax(int[] nums)
	{
		long first = long.MinValue,
			second = long.MinValue,
			third = long.MinValue;
		foreach (int num in nums)
			if (num > first)
			{
				third = second;
				second = first;
				first = num;
			}
			else if (num > second && num < first)
			{
				third = second;
				second = num;
			}
			else if (num > third && num < second)
				third = num;
		return third == long.MinValue ? (int)first : (int)third;
	}
}
// @lc code=end