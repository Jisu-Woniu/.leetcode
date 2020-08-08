/*
 * @lc app=leetcode.cn id=19 lang=csharp
 *
 * [19] 删除链表的倒数第N个节点
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
	public ListNode RemoveNthFromEnd(ListNode head, int n)
	{
		ListNode newHead = new ListNode(0);
		newHead.next = head;
		ListNode pointerf = newHead, pointerb = newHead;
		for (int i = 0; i <= n; i++)
		{
			pointerf = pointerf.next;
		}
		while (pointerf != null)
		{
			pointerf = pointerf.next;
			pointerb = pointerb.next;
		}
		pointerb.next = pointerb.next.next;
		return newHead.next;
	}
}
// @lc code=end