/*
 * @lc app=leetcode.cn id=203 lang=csharp
 *
 * [203] 移除链表元素
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
	public ListNode RemoveElements(ListNode head, int val)
	{
		if (head == null) return head;
		while (head != null && head.val == val) head = head.next;
		if (head == null) return head;
		ListNode p = head;
		while (p.next != null)
		{
			while (p.next != null && p.next.val != val) p = p.next;
			while (p.next != null && p.next.val == val) p.next = p.next.next;
		}
		return head;
	}
}
// @lc code=end