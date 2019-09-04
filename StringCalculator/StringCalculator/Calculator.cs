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
			string[] arrSplitByComma = input.Split(',');

			if (arrSplitByComma.Length > 2)
			{
				throw new Exception("Only supports a max of 2 values.");
			}

			foreach (var item in arrSplitByComma)
			{
				int valToAdd = 0;
				int.TryParse(item, out valToAdd);
				sum += valToAdd;
			}

			return sum;
		}
	}
}
