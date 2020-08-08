/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
public class Solution
{
	public int[] PlusOne(int[] digits)
	{
		bool newArray = true;
		foreach (int i in digits)
			if (i != 9)
			{
				newArray = false;
				break;
			}
		if (newArray)
		{
			int[] newArr = new int[digits.Length + 1];
			for (int i = 0; i < newArr.Length; i++)
			{
				newArr[i] = 0;
			}

			newArr[0] = 1;
			return newArr;
		}
		for (int i = digits.Length - 1; i >= 0; i--)
		{
			if (digits[i] < 9)
			{
				digits[i]++;
				return digits;
			}
			else
				digits[i] = 0;
		}
		return digits;
	}
}
// @lc code=end