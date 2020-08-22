/*
 * @lc app=leetcode.cn id=204 lang=csharp
 *
 * [204] 计数质数
 */
using System;
// @lc code=start
// This solution has a time complexity of O(N^(3/2)).
public class Solution
{
	bool IsPrime(int m)
	{
		if (m == 2) return true;
		for (int i = 2; i * i <= m; i++)
			if (m % i == 0)
				return false;
		return true;
	}
	public int CountPrimes(int n)
	{
		int count = 0;
		for (int i = 2; i < n; i++)
			if (IsPrime(i))
				count++;
		return count;
	}
}
// @lc code=end