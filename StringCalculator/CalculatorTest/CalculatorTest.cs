using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace CalculatorTest
{
	[TestClass]
	public class CalculatorTest
	{
		[TestMethod]
		public void NoInputFail()
		{
			try
			{
				Calculator.Add("");
			}
			catch (Exception ex)
			{
				Assert.IsNotNull(ex);
				Assert.AreEqual(ex.Message, "Invalid input.");
			}
		}

		[TestMethod]
		public void SingleValuePass()
		{
			var res = Calculator.Add("1");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 1);
		}

		[TestMethod]
		public void SingleValueNonNumberPass()
		{
			var res = Calculator.Add("shouldBeZero");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 0);
		}

		[TestMethod]
		public void MultipleValuesPass()
		{
			var res = Calculator.Add("1,2,3,4,5");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 15);
		}

		[TestMethod]
		public void MultipleValuesWithNonNumbersPass()
		{
			var res = Calculator.Add("1,2,3,4,5,shouldBeZero");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 15);
		}


	}
}
