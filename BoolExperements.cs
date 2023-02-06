namespace FluentCalculator
{
	internal class BoolExperements
	{
		private bool _value = true;

		public static implicit operator bool(BoolExperements obj)
		{
			return obj._value = !obj._value;
		}
	}
}
