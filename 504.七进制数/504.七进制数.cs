/*
 * @lc app=leetcode.cn id=504 lang=csharp
 *
 * [504] 七进制数
 */

// @lc code=start
public class Solution
{
	public string ConvertToBase7(int num)
	{
		if (num == 0)
			return "0";
		if (num < 0)
			return "-" + ConvertToBase7(-num);
		string s = "";
		while (num > 0)
		{
			s = (char)(num % 7 + '0') + s;
			num /= 7;
		}
		return s;
	}
}
// @lc code=end