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

		[TestMethod()]

		public void prisTestKaffeLatte()
		{
			var kaffe = new Latte();
			int pris = kaffe.pris();
			Assert.AreEqual(10, pris);
		}

		[TestMethod()]
		public void styrkeTestLatte()
		{
			var kaffe = new Latte();
			string styrke = kaffe.styrke();
			Assert.AreEqual("stærk", styrke);
		}

		[TestMethod()]

		public void prisTestKaffeCortado()
		{
			var kaffe = new Cortado();
			int pris = kaffe.pris();
			Assert.AreEqual(30, pris);
		}

		[TestMethod()]
		public void styrkeTestCortado()
		{
			var kaffe = new Cortado();
			string styrke = kaffe.styrke();
			Assert.AreEqual("stærk", styrke);
		}



	}
}