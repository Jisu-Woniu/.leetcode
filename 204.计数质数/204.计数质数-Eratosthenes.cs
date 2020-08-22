/*
 * @lc app=leetcode.cn id=204 lang=csharp
 *
 * [204] 计数质数
 */

// @lc code=start
using System.Collections;
public class Solution
{
	public int CountPrimes(int n)
	{
		if (n <= 2) return 0;
		BitArray prime = new BitArray(n, true);
		prime.Set(0, false);
		prime.Set(1, false);
		for (int i = 2; i * i < n; i++)
			if (prime.Get(i))
				for (int j = i; i * j < n; j++)
					//if (prime.Get(j))
					prime.Set(i * j, false);
		int count = 0;
		for (int i = 2; i < n; i++)
			if (prime.Get(i))
				count++;
		return count;
	}
}
// @lc code=end