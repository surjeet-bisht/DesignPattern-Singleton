using SimpleFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Implementation
{
	public class MoneyBackCredit : ICreditCard
	{
		public int creditCardLimit()
		{
			return 100000;
		}

		public int getAnnualCharges()
		{
			return 500;
		}

		public string getCreditCardType()
		{
			return "MoneyBack";
		}
	}
}
