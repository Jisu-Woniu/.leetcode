/*
 * @lc app=leetcode.cn id=67 lang=csharp
 *
 * [67] 二进制求和
 */

// @lc code=start

public class Solution
{
	public string AddBinary(string a, string b)
	{
		int i = a.Length - 1;
		int j = b.Length - 1;
		List<int> c = new List<int>();
		int carrier = 0;
		while (i >= 0 && j >= 0)
		{
			int t = (a[i] - '0') + (b[j] - '0') + carrier;
			carrier = t / 2;
			c.Add(t % 2);
			i--;
			j--;
		}
		while (i >= 0)
		{
			int t = (a[i] - '0') + carrier;
			carrier = t / 2;
			c.Add(t % 2);
			i--;
		}
		while (j >= 0)
		{
			int t = (b[j] - '0') + carrier;
			carrier = t / 2;
			c.Add(t % 2);
			j--;
		}
		string r = "";
		if (carrier != 0)
			r = "1";
		for (int index = c.Count - 1; index >= 0; index--)
			r += c[index].ToString();
		return r;
	}
}
// @lc code=end