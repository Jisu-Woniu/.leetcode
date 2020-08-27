/*
 * @lc app=leetcode.cn id=234 lang=csharp
 *
 * [234] 回文链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/*public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x) { val = x; }
}*/
public class Solution
{
	public bool IsPalindrome(ListNode head)
	{
		int length = 0;
		ListNode p = head;
		while (p != null)
		{
			p = p.next;
			length++;
		}
		if (length < 2) return true;
		int mid = length / 2;
		int[] vals = new int[mid];
		p = head;
		for (int i = 0; i < mid; ++i)
		{
			vals[i] = p.val;
			p = p.next;
		}
		if (length != 2 * mid) p = p.next;
		for (int i = mid - 1; i >= 0; --i)
		{
			if (vals[i] != p.val) return false;
			p = p.next;
		}
		return true;
	}
}
// @lc code=end