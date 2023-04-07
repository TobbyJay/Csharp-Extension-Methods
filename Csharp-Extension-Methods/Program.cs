using System;
using Csharp_Extension_Methods;

public class Program
{
	public static void Main()
	{
		var word = "";

		var date1 = new DateTime(2023, 3, 15);
		var date2 = new DateTime(2023, 3, 31);
		var date3 = new DateTime(2023, 4, 15);

		var checkWordresponse = CheckWord(word);

		var checkDateresponse = CheckDateRange(date1, date2, date3);

		Console.WriteLine(checkWordresponse);

		Console.WriteLine(checkDateresponse);
	}

	static string CheckWord(string word)
	{
		if (word.IsMyStringNullOrEmpty())
		{
			return $"String is null or empty.";
		}
		else
		{
			return $"{word}";
		}
	}

	static string CheckDateRange(DateTime firstDate, DateTime secondDate, DateTime thirdDate) 
	{
		if (firstDate.IsDateInRange(secondDate, thirdDate))
		{
			return "The date is within the range.";
		}
		else
		{
			return "The date is not within the range.";
		}
	}


}