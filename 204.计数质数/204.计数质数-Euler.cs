/*
 * @lc app=leetcode.cn id=204 lang=csharp
 *
 * [204] 计数质数
 */
using System.Collections;
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public int CountPrimes(int n)
	{
		if (n < 2) return 0;
		List<int> primes = new List<int>();
		BitArray prime = new BitArray(n, true);
		for (int i = 2; i < n; i++)
		{
			if (prime.Get(i)) primes.Add(i);
			foreach (int j in primes)
			{
				if (i * j >= n) break;
				prime.Set(i * j, false);
				if (i % j == 0) break;
			}
		}
		return primes.Count;
	}
}
// @lc code=end