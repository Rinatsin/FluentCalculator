namespace FluentCalculator
{
	internal class SomeValue
	{
		private bool _value = false;

		public static implicit operator bool(SomeValue obj)
		{
			return obj._value = !obj._value;
		}
	}
}
