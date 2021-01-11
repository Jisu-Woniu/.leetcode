/*
 * @lc app=leetcode.cn id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution {
    public double MyPow(double x, int n)
	{
		if (n == 1) return x;
		else if (n == -1) return 1 / x;
		else if (n == 0) return 1;
		double p;
		while (n != 0)
		{
			if ((n & 1) == 1)
				p *= x;
			x *= x;
			n >>= 1;
		}
	}
}
// @lc code=end

