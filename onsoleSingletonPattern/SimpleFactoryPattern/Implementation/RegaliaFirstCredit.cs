using SimpleFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Implementation
{
	public class RegaliaFirstCredit : ICreditCard
	{
		public int creditCardLimit()
		{
			return 250000;
		}

		public int getAnnualCharges()
		{
			return 1500;
		}

		public string getCreditCardType()
		{
			return "Regalia First";
		}
	}
}
