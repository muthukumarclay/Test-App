using System;
using System.Text;

namespace core {

	using AccountId = System.UInt32;

	public class Account 
	{
		public AccountId id { get; set; }
		public string account_holder_name { get; set; }
		public double balance { get; set; }

		public override string ToString()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append("Account ( ");
			strData.AppendFormat("id: {0}, ", id);
			strData.AppendFormat ("account_holder_name: {0}, ", account_holder_name);
			strData.AppendFormat ("balance: {0} ", balance);
			strData.Append(")");
			return strData.ToString() + Environment.NewLine;
		}
	}

}
