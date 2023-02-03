// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class FluentCalculator
{
	private Stack<int> _numbers = new();

	public FluentCalculator Zero
	{
		get
		{
			SetValue(0);
			return this;
		}
	}

	public FluentCalculator One
	{
		get
		{
			SetValue(1);
			return this;
		}
	}

	public FluentCalculator Two
	{
		get
		{
			SetValue(2);
			return this;
		}
	}

	public FluentCalculator Three
	{
		get
		{
			SetValue(3);
			return this;
		}
	}

	public FluentCalculator Four
	{
		get
		{
			SetValue(4);
			return this;
		}
	}

	public FluentCalculator Five
	{
		get
		{
			SetValue(5);
			return this;
		}
	}

	public FluentCalculator Six
	{
		get
		{
			SetValue(6);
			return this;
		}
	}

	public FluentCalculator Seven
	{
		get
		{
			SetValue(7);
			return this;
		}
	}

	public FluentCalculator Eight
	{
		get
		{
			SetValue(8);
			return this;
		}
	}

	public FluentCalculator Nine
	{
		get
		{
			SetValue(9);
			return this;
		}
	}

	public FluentCalculator Ten
	{
		get
		{
			SetValue(10);
			return this;
		}
	}

	private void SetValue(int value)
	{
		if (_numbers.Count > 0)
		{
			Console.WriteLine("Error! After value should be operation...");
		}
		_numbers.Push(value);
	}
}
