/*
 * @lc app=leetcode.cn id=278 lang=csharp
 *
 * [278] 第一个错误的版本
 */
using System;
// @lc code=start
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
public class Solution : VersionControl
{
	public int FirstBadVersion(int n)
	{
		if (IsBadVersion(1))
			return 1;
		long l = 1, r = n;
		while (r - l > 1)
		{
			long mid = (l + r) / 2;
			if (IsBadVersion(Convert.ToInt32(mid)))
				r = mid;
			else
				l = mid;
		}
		return Convert.ToInt32(r);
	}
}
// @lc code=end