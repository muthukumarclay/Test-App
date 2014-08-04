using System;
using System.Net;
using System.IO;
using System.Text;
using System.Collections;
using test;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace TestApp
{
	using AccountId = System.UInt32;

	class MainClass
	{
		public void init_array (Array arr, int size)
		{

		}

		public enum TESTE
		{
			TT,
			TT1
		}

//		public static Account getAccount() {
//			Account src = new Account();
//			src.account_holder_name = "mk";
//			src.balance = 100;
//			src.id = 123;
//			src.test1 = 1;
//			src.test10 = 2;
//			src.test11 = System.Text.UTF8Encoding.UTF8.GetBytes("test_bytes");
//			src.test12 = "test12_strings";
//			src.test13 = "test13_strings";
//			var lst = new List<List<byte[]>>();
//
//			for (int i =0; i <5; i++) {
//				lst.Add(new List<byte[]>());
//				for (int j =0; j <5; j++) {
//					lst[i].Add(System.Text.UTF8Encoding.UTF8.GetBytes("test_bytes"));
//				}
//			}
//
//			src.test14 = lst;
//
//			List<string> item1 = new List<string>();
//			for (int i =0; i <5; i++) {
//				item1.Add("item1_item");
//			}
//
//			List<string> item2 = new List<string>();
//			item2.Add("item2_item");
//
//			Dictionary<long, string> item3 = new Dictionary<long, string>();
//			item3.Add(100, "mk_value");
//
//			src.test15 = Tuple.Create<List<string>, List<string>, Dictionary<long, string>>(item1, item2, item3);
//			src.test16 = new List<double>();
//			src.test16.Add(101);
//			src.test17 = new HashSet<double>();
//			src.test17.Add(102);
//			src.test17.Add(102);
//			src.test17.Add(108);
//			src.test18 = new Dictionary<long, string>();
//			src.test18.Add(103, "test18_balue");
//			src.test19 = TestEnum.Test1;
//			src.test20 = new List<string>();
//			src.test20.Add("test20_string");
//			return src;
//		}

		public static void Main (string[] args)
		{
			try {
				Request request = new Request();
				Response response = new Response();

				LookupAccount lk = new LookupAccount ();
				lk.account_id = 1;
				request.set_option(lk);
				Console.WriteLine (request);

				response.set_option(Util.api_request(request, response));
				AccountInfo account = (AccountInfo) response.get_option();
				Console.WriteLine (response);

				ListAllAccounts list_all = new ListAllAccounts();
				request.set_option(list_all);
				Console.WriteLine(request);

				response.set_option(Util.api_request(request, response));
				Console.WriteLine(response);


				RegisterAccount register = new RegisterAccount();
				register.account_holder_name = "new_one";
				register.initial_balance = 100;
				request.set_option(register);
				Console.WriteLine(request);

			} catch (WebException ex) {
				Console.WriteLine ("http errror: " + ex.Message);
			}

			Console.ReadLine ();
		}
	}
}
