using SimpleFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Implementation
{
	public class PlatinumCredit : ICreditCard
	{
		public int creditCardLimit()
		{
			return 150000;
		}

		public int getAnnualCharges()
		{
			return 1000;
		}

		public string getCreditCardType()
		{
			return "Platinum";
		}
	}
}
