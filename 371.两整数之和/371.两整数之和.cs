/*
 * @lc app=leetcode.cn id=371 lang=csharp
 *
 * [371] 两整数之和
 */

// @lc code=start
public class Solution
{
	public int GetSum(int a, int b)
	{
		while (b != 0)
		{
			int c = (a & b) << 1;
			a ^= b;
			b = c;
		}
		return a;
	}
}
// @lc code=end