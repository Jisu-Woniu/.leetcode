/*
 * @lc app=leetcode.cn id=155 lang=csharp
 *
 * [155] 最小栈
 */
using System;
using System.Collection.Generic;
// @lc code=start
public class MinStack
{
	/** initialize your data structure here. */
	Stack<int> stk;
	Stack<int> min;
	public MinStack()
	{
		stk = new Stack<int>();
		min = new Stack<int>();
	}

	public void Push(int x)
	{
		stk.Push(x);
		if (min.Count == 0 || x <= min.Peek())
			min.Push(x);
	}

	public void Pop()
	{
		if (stk.Pop() == min.Peek())
			min.Pop();
	}

	public int Top() => stk.Peek();

	public int GetMin() => min.Peek();
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end