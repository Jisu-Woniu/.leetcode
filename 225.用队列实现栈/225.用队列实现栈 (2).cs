/*
 * @lc app=leetcode.cn id=225 lang=csharp
 *
 * [225] 用队列实现栈
 */
using System.Collections.Generic;
// @lc code=start
public class MyStack
{
	Queue<int> q1;
	Queue<int> q2;
	/** Initialize your data structure here. */
	public MyStack()
	{
		q1 = new Queue<int>();
		q2 = new Queue<int>();
	}

	/** Push element x onto stack. */
	public void Push(int x)
	{
		q2.Enqueue(x);
		while (q1.Count > 0)
			q2.Enqueue(q1.Dequeue());
		Queue<int> qt = q2;
		q2 = q1;
		q1 = qt;
	}

	/** Removes the element on top of the stack and returns that element. */
	public int Pop() => q1.Dequeue();

	/** Get the top element. */
	public int Top() => q1.Peek();

	/** Returns whether the stack is empty. */
	public bool Empty() => q1.Count == 0;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end