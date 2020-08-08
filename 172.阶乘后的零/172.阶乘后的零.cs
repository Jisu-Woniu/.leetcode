/*
 * @lc app=leetcode.cn id=172 lang=csharp
 *
 * [172] 阶乘后的零
 */

// @lc code=start
public class Solution
{
	public int TrailingZeroes(int n)
	{
		int res = 0;
		while (n >= 5)
		{
			n /= 5;
			res += n;
		}
		return res;
	}
}
// @lc code=end