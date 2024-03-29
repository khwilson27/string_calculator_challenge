﻿using System;
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

		[TestMethod]
		public void MultipleValuesWithNewlineDelimiterPass()
		{
			var res = Calculator.Add("1\r2,3\n4" + Environment.NewLine + "5");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 15);
		}

		[TestMethod]
		public void NegativeNumbersFail()
		{
			try
			{
				Calculator.Add("1,2,-3,-4,-5,6");
			}
			catch (Exception ex)
			{
				Assert.IsNotNull(ex);
				Assert.AreEqual(ex.Message, "Negative values not supported! Offending inputs: -3, -4, -5");
			}
		}

		[TestMethod]
		public void IgnoreValuesOverThousandPass()
		{
			var res = Calculator.Add("1,2,3,1000,1001");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 1006);
		}

		[TestMethod]
		public void CustomSingleCharDelimiterPass()
		{
			var res = Calculator.Add("//;\\n2;5");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 7);
		}

		[TestMethod]
		public void CustomSingleDelimiterAnyLengthPass()
		{
			var res = Calculator.Add("//[***]\\n2***5");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 7);
		}

		[TestMethod]
		public void CustomMultiDelimiterAnyLengthPass()
		{
			var res = Calculator.Add("//[*][!!][rrr]\\n1rrr2*3!!4");
			Assert.IsNotNull(res);
			Assert.AreEqual(res, 10);
		}
	}
}
