using SimpleFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Implementation
{
	public class CreditCardSelection : ICreditCardSelection
	{
		public ICreditCard SelectCreditCard(CreditCardType type)
		{
			if (type == CreditCardType.MB)
				return new MoneyBackCredit();
			if(type==CreditCardType.RF)
				return new RegaliaFirstCredit();
			if (type==CreditCardType.PP)
				return new PlatinumCredit();

			throw new NotImplementedException();
		}
	}
}
