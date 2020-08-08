/*
 * @lc app=leetcode.cn id=160 lang=csharp
 *
 * [160] 相交链表
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
public class Solution
{
	public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
	{
		ListNode p1 = headA, p2 = headB;
		while (p1 != null && p2 != null)
		{
			if (p1 == p2) return p1;
			else if (p1.next == null && p2.next == null) return null;
			/*if (p1.next == null)
				p1 = headB;
			else
				p1 = p1.next;*/
			p1 = p1.next ?? headB;
			/*if (p2.next == null)
				p2 = headA;
			else
				p2 = p2.next;*/
			p2 = p2.next ?? headA;
		}
		return null;
	}
}
// @lc code=end