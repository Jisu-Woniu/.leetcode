/*
 * @lc app=leetcode.cn id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution
{
	public double MyPow(double x, int n)
	{
		if (n == 1) return x;
		else if (n == -1) return 1 / x;
		else if (n == 0) return 1;
		double nextPow = MyPow(x, n >> 1);
		if ((n & 1) == 1)
			return nextPow * nextPow * x;
		else
			return nextPow * nextPow;
	}
}
// @lc code=end

