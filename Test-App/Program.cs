using System;
using System.Net;
using System.IO;
using System.Text;
using System.Collections;
using protocol.admin;

namespace TestApp
{
	using AccountId = System.UInt32;

	class MainClass
	{
		public static void Main (string[] args)
		{
			try {
				Request request = new Request();
				Response response = new Response();

				LookupAccount lk = new LookupAccount ();
				lk.account_id = 1;
				request.setData(lk);
				Console.WriteLine (request);

				response.setData(Util.api_request(request, response));
				AccountInfo account = (AccountInfo) response.getData();
				Console.WriteLine (response);

				ListAllAccounts list_all = new ListAllAccounts();
				request.setData(list_all);
				Console.WriteLine(request);

				response.setData(Util.api_request(request, response));
				Console.WriteLine(response);


				RegisterAccount register = new RegisterAccount();
				register.account_holder_name = "new_one";
				register.initial_balance = 100;
				request.setData(register);
				Console.WriteLine(request);

				response.setData(Util.api_request(request, response));
				Console.WriteLine (response);


				TransferAmount transfer = new TransferAmount();
				transfer.from_account_id = 0;
				transfer.to_account_id = 1;
				transfer.amount = 99;
				request.setData(transfer);
				Console.WriteLine(request);

				response.setData(Util.api_request(request, response));
				Console.WriteLine (response);
			} catch (WebException ex) {
				Console.WriteLine ("http errror: " + ex.Message);
			}

			Console.ReadLine ();
		}
	}
}
