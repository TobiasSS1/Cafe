﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
	public class Cortado : Cafe
	{
		/// <summary>
		/// Prisen på Cortado
		/// </summary>
		/// <returns></returns>
		public override int pris()
		{
			return 30;
		}
	}
}
