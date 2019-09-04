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
			Console.WriteLine("Please enter a comma-delimited string! I will return the sum!");

			string input = Console.ReadLine();
			try
			{
				Console.WriteLine($"The sum is {Calculator.Add(input)}!");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadKey();
		}
	}
}
