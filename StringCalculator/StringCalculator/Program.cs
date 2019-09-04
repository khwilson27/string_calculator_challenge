using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a comma-delimited/newline-delimited string! I will return the sum of the integers!");

			string input = Console.ReadLine();
			try
			{
				Console.WriteLine($"The sum of the valid integers is {Calculator.Add(input)}!");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadKey();
		}
	}
}
