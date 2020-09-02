/*
 * @lc app=leetcode.cn id=299 lang=csharp
 *
 * [299] 猜数字游戏
 */

// @lc code=start
public class Solution
{
	public string GetHint(string secret, string guess)
	{
		int bulls = 0, cows = 0;
		int[] match = new int[10];
		for (int i = 0; i < secret.Length; ++i)
		{
			if (secret[i] == guess[i]) bulls++;
			else
			{
				if (match[secret[i] - '0']++ < 0) cows++;
				if (match[guess[i] - '0']-- > 0) cows++;
			}
		}
		return bulls.ToString() + "A" + cows + "B";
	}
}
// @lc code=end