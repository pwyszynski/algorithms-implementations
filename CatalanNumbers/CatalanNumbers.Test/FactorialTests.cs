using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalanNumbers.Methods;

namespace CatalanNumbers.Test
{
	[TestClass]
	public class FactorialTests
	{
		[TestMethod]
		public void FactorialFrom1Is1()
		{
			Assert.AreEqual(1, CNums.Factorial(1));
		}

		[TestMethod]
		public void FactorialFrom0Is1()
		{
			Assert.AreEqual(1, CNums.Factorial(0));
		}

		[TestMethod]
		public void FactorialFrom5Is120()
		{
			Assert.AreEqual(120, CNums.Factorial(5));
		}

		[TestMethod]
		[ExpectedException(typeof(ArithmeticException))]
		public void FactorialFromMinus1ThrowsException()
		{
			CNums.Factorial(-2);
		}
	}
}
