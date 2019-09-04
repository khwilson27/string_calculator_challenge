using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
	public static class Calculator
	{
		public static int Add(string input)
		{
			if (input.Length < 1)
			{
				throw new Exception("Invalid input.");
			}

			int sum = 0;
			var negativeNumbers = new List<int>();
			string[] arrSplitByDelimiter = input.Split(new string[] { ",", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries); // split string with comma/newline as delimiters

			foreach (var item in arrSplitByDelimiter)
			{
				int valToAdd = 0;
				int.TryParse(item, out valToAdd);

				if (valToAdd < 0) // build list of negative numbers to later return in Exception
				{
					negativeNumbers.Add(valToAdd);
				}
				else if (valToAdd > 1000) // ignore any value greater than 1000
				{
					valToAdd = 0;
				}

				sum += valToAdd;
			}

			if (negativeNumbers.Count > 0)
			{
				throw new Exception("Negative values not supported! Offending inputs: " + String.Join(", ", negativeNumbers));
			}

			return sum;
		}
	}
}
