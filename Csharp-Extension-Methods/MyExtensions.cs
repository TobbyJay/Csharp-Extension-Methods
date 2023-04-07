
namespace Csharp_Extension_Methods
{
	public static class MyExtensions
	{
		public static bool IsMyStringNullOrEmpty(this string input)
		{
			return string.IsNullOrEmpty(input);
		}

		public static bool IsDateInRange(this DateTime input, DateTime startDate, DateTime endDate)
		{
			return input >= startDate && input <= endDate;
		}
	}

}
