/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */
//using System;
// @lc code=start
public class Solution
{
	public int ClimbStairs(int n)
	{
		int[] r = new int[] { 1, 1, 2, 3, 5 };
		if (n < 5) return r[n];
		
		double phi = (Math.Sqrt(5.0) + 1.0) / 2.0;
		double c = (Math.Sqrt(5.0) + 5.0) / 10.0;
		int a = Convert.ToInt32(c * Math.Pow(phi, n));
		return a;
	}
}
// @lc code=end