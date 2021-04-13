/*
 * @lc app=leetcode.cn id=1114 lang=csharp
 *
 * [1114] 按序打印
 */

// @lc code=start
public class Foo
{
	int step = 0;

	public Foo()
	{
	}

	public void First(Action printFirst)
	{
		// printFirst() outputs "first". Do not change or remove this line.
		printFirst();
		step = 1;
	}

	public void Second(Action printSecond)
	{
		while (step < 1)
		{
			System.Threading.Thread.Sleep(1);
		}
		// printSecond() outputs "second". Do not change or remove this line.
		printSecond();
		step = 2;
	}

	public void Third(Action printThird)
	{
		while (step < 2)
		{
			System.Threading.Thread.Sleep(1);
		}
		// printThird() outputs "third". Do not change or remove this line.
		printThird();
	}
}
// @lc code=end