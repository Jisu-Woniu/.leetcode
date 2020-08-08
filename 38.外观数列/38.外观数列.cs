/*
 * @lc app=leetcode.cn id=38 lang=csharp
 *
 * [38] 外观数列
 */

// @lc code=start
public class Solution
{
	public string CountAndSay(int n)
	{
		if (n == 1) return "1";
		List<string> seq = new List<string>() { "", "1" };
		for (int i = 1; i < n; i++)
		{
			string next = "";
			char prev = seq[i][0];
			int count = 1;
			for (int j = 1; j < seq[i].Length; j++)
				if (seq[i][j] == prev)
					count++;
				else
				{
					next = next + count.ToString() + prev;
					prev = seq[i][j];
					count = 1;
				}
			next = next + count.ToString() + prev;
			seq.Add(next);
		}
		return seq[n];
	}
}
// @lc code=end

