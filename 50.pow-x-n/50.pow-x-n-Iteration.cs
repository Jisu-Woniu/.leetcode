/*
 * @lc app=leetcode.cn id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution {
    public double MyPow(double x, int n)
	{
		if(n == int.MinValue) return MyPow(1 / x / x, -(n >> 1));
		else if (n < 0) return MyPow(1 / x, -n);
		else if (n == 0) return 1;
		double p = 1;
		while (n != 0)
		{
			if ((n & 1) == 1)
				p *= x;
			x *= x;
			n >>= 1;
		}
		return p;
	}
}
// @lc code=end

