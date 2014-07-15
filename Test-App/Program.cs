using System;
using System.Net;
using System.IO;
using System.Text;

using protocol.admin;

namespace TestApp
{
	using AccountId = System.UInt32;

	class MainClass
	{
		public static void Main (string[] args)
		{
			try {
				LookupAccount lk = new LookupAccount ();
				lk.account_id = 1;
				Console.WriteLine("Request");
				Console.WriteLine (lk);

				AccountInfo account = (AccountInfo) Util.api_request(lk);
				Console.WriteLine("Response");
				Console.WriteLine (account);

				ListAllAccounts list_all = new ListAllAccounts();
				Console.WriteLine("Request");
				Console.WriteLine(list_all);

				AllAccounts allaccounts = (AllAccounts) Util.api_request(list_all);
				Console.WriteLine("Response");
				Console.WriteLine(allaccounts);


				RegisterAccount register = new RegisterAccount();
				register.account_holder_name = "new_one";
				register.initial_balance = 100;
				Console.WriteLine("Request");
				Console.WriteLine(register);

				AccountInfo accountinfo = (AccountInfo) Util.api_request(register);
				Console.WriteLine("Response");
				Console.WriteLine (accountinfo);


				TransferAmount transfer = new TransferAmount();
				transfer.from_account_id = 0;
				transfer.to_account_id = 1;
				transfer.amount = 99;
				Console.WriteLine("Request");
				Console.WriteLine(register);

				Object obj = Util.api_request(transfer);
				Console.WriteLine("Response");
				Console.WriteLine (obj);
			} catch (WebException ex) {
				Console.WriteLine ("http errror: " + ex.Message);
			}

			Console.ReadLine ();
		}
	}
}
