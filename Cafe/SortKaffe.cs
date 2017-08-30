using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
	public class SortKaffe : Cafe
	{
		public override int pris()
		{
			int prismedrabat = 20 - Rabat;

			if (prismedrabat <= 0)
				throw new ArgumentException("Hovsa! For meget rabat, ingen gratis kaffe!");
			
			return prismedrabat;
		}

		public SortKaffe()
		{

		}

		public SortKaffe(int rabat) : base(rabat)
		{
			
		}
	}
}
