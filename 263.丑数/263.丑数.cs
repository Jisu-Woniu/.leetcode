/*
 * @lc app=leetcode.cn id=263 lang=csharp
 *
 * [263] 丑数
 */

// @lc code=start
public class Solution
{
	public bool IsUgly(int num)
	{
		if (num <= 0)
			return false;
		while ((num & 1) == 0)
			num >>= 1;
		while (num % 3 == 0)
			num /= 3;
		while (num % 5 == 0)
			num /= 5;
		return num == 1;
	}
}
// @lc code=end