﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Interfaces
{
	public interface ICreditCard
	{
		string getCreditCardType();
		int creditCardLimit();
		int getAnnualCharges();
	}
}
