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
			string[] arrSplitByDelimiter = input.Split(new string[] { ",", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var item in arrSplitByDelimiter)
			{
				int valToAdd = 0;
				int.TryParse(item, out valToAdd);
				sum += valToAdd;
			}

			return sum;
		}
	}
}
