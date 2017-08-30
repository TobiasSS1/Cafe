using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public abstract class Cafe	
    {
		public abstract int pris();
		

		public virtual string styrke()
		{
			return "stærk";
		}


		/// <summary>
		/// Rabat på kaffe
		/// </summary>
		public int Rabat { get; set; }

		public Cafe()
		{
			this.Rabat = 0;
		}

		public Cafe(int rabat)
		{
			Rabat = rabat;
		}
	}
}
