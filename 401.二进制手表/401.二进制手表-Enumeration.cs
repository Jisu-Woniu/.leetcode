/*
 * @lc app=leetcode.cn id=401 lang=csharp
 *
 * [401] 二进制手表
 */
using System.Collections.Generic;
// @lc code=start
public class Solution
{
	public IList<string> ReadBinaryWatch(int num)//The maximum num is 3 + 5 = 8 (7:31)
	{
		List<string> l = new List<string>();
		if (num < 0 || num > 8) return l;
		List<List<int>> h = new List<List<int>>();
		h.Add(new List<int>() { 0 });
		h.Add(new List<int>() { 1, 2, 4, 8 });
		h.Add(new List<int>() { 3, 5, 6, 9, 10 });
		h.Add(new List<int>() { 7, 11 });
		List<List<int>> m = new List<List<int>>();
		m.Add(new List<int>() { 0 });
		m.Add(new List<int>() { 1, 2, 4, 8, 16, 32 });
		m.Add(new List<int>() { 3, 5, 6, 9, 10, 12, 17, 18, 20, 24, 33, 34, 36, 40, 48 });
		m.Add(new List<int>() { 7, 11, 13, 14, 19, 21, 22, 25, 26, 28, 35, 37, 38, 41, 42, 44, 49, 50, 52, 56 });
		m.Add(new List<int>() { 15, 23, 27, 29, 30, 39, 43, 45, 46, 51, 53, 54, 57, 58 });
		m.Add(new List<int>() { 31, 47, 55, 59 });
		int a = 0, b = 5;
		if (num <= 5) b = num;
		else a = num - 5;
		while (b >= 0 && a <= 3)
		{
			foreach (int hour in h[a])
				foreach (int minute in m[b])
					l.Add(hour.ToString() + ':' + minute.ToString("D2"));
			b--; a++;
		}
		return l;
	}
}
// @lc code=end