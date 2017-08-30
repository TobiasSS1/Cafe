using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Tests
{
	[TestClass()]
	public class CafeTests
	{
		[TestMethod()]

		public void prisTestKaffe()
		{
			var kaffe = new SortKaffe();
			int pris = kaffe.pris();
			Assert.AreEqual(20, pris);
		}

		

		[TestMethod()]
		public void styrkeTest()
		{
			var kaffe = new SortKaffe();
			string styrke = kaffe.styrke();
			Assert.AreEqual("stærk", styrke);
		}
	}
}