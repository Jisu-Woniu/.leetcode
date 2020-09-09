/*
 * @lc app=leetcode.cn id=401 lang=csharp
 *
 * [401] 二进制手表
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	int HammingWeight(int n)
	{
		int hw = 0;
		while (n != 0)
		{
			hw += (int)(n & 1u);
			n >>= 1;
		}
		return hw;
	}
	
	public IList<string> ReadBinaryWatch(int num)//The maximum num is 3 + 5 = 8 (7:31)
	{
		List<string> l = new List<string>();
		if (num < 0 || num > 8) return l;
		for (int h = 0; h <= 11; ++h)
			for (int m = 0; m <= 59; ++m)
				if (HammingWeight(h) + HammingWeight(m) == num)
					l.Add(h.ToString() + ':' + m.ToString("D2"));
		return l;
	}
}
// @lc code=end