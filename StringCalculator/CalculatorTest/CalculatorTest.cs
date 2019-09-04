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
		public void MaximumTwoValuesFail()
		{
			try
			{
				Calculator.Add("1,2,3");
			}
			catch (Exception ex)
			{
				Assert.IsNotNull(ex);
				Assert.AreEqual(ex.Message, "Only supports a max of 2 values.");
			}
		}

		[TestMethod]
		public void MaximumTwoValuesPass()
		{
			var res = Calculator.Add("1,2");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 3);
		}
	}
}
