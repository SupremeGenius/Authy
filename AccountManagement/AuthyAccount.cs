﻿using System;
namespace Authy.AccountManagement
{
	public class AuthyAccount
	{
		string _value;
		public AuthyAccount(string sth)
		{
			_value = sth;
		}

		public override string ToString()
		{
			return _value;
		}
	}
}
