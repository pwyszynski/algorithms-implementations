using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalanNumbers.Methods;

namespace CatalanNumbers.Test
{
	[TestClass]
	public class CatalanNumsTests
	{
		[TestMethod]
		public void CatalanNumberOf5Is42()
		{
			Assert.AreEqual(42, CNums.CatalanDirect(5));
		}
	}
}
