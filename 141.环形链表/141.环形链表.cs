/*
 * @lc app=leetcode.cn id=141 lang=csharp
 *
 * [141] 环形链表
 */

// @lc code=start

using System.Collections.Generic;
/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int x) {
*         val = x;
*         next = null;
*     }
* }
*/
//public class ListNode
//{
//	public int val;
//	public ListNode next;
//	public ListNode(int x)
//	{
//		val = x;
//		next = null;
//	}
//}
public class Solution
{
	public bool HasCycle(ListNode head)
	{
		ListNode ptr = head;
		HashSet<ListNode> nodes = new HashSet<ListNode>();
		while (ptr != null && !nodes.Contains(ptr))
		{
			nodes.Add(ptr);
			ptr = ptr.next;
		}
		return ptr != null;
	}
}
// @lc code=end