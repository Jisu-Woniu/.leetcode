/*
 * @lc app=leetcode.cn id=232 lang=csharp
 *
 * [232] 用栈实现队列
 */
using System.Collections.Generic;
// @lc code=start
public class MyQueue
{
	Stack<int> s1, s2;
	int head;
	/** Initialize your data structure here. */
	public MyQueue()
	{
		s1 = new Stack<int>();
		s2 = new Stack<int>();
		head = 0;
	}

	/** Push element x to the back of queue. */
	public void Push(int x)
	{
		s1.Push(x);
		if (s1.Count == 1)
			head = x;
	}

	/** Removes the element from in front of queue and returns that element. */
	public int Pop()
	{
		while (s1.Count > 1)
			s2.Push(s1.Pop());
		int x = s1.Pop();
		if (s2.Count > 0)
		{
			head = s2.Pop();
			s1.Push(head);
		}
		while (s2.Count > 0)
			s1.Push(s2.Pop());
		return x;
	}

	/** Get the front element. */
	public int Peek() => head;

	/** Returns whether the queue is empty. */
	public bool Empty() => s1.Count == 0;
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
// @lc code=end