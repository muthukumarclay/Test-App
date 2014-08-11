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
	namespace tt {
		class Ping {
		}
	}

	class MainClass
	{

//		public enum TESTE
//		{
//			TT,
//			TT1
//		}

//		public static Dummy getDummy() {
//			Dummy src = new Dummy();
//			var lst = new List<List<byte[]>>();
//
//			for (int i =0; i <5; i++) {
//				lst.Add(new List<byte[]>());
//				for (int j =0; j <5; j++) {
//					lst[i].Add(System.Text.UTF8Encoding.UTF8.GetBytes("test_bytes"));
//				}
//			}
//			List<string> lst_14 = new List<string> ();
//			for (int i = 0; i < 5; i++) {
//				lst_14.Add (i.ToString ());
//			}
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
//			src.account_holder_name = "mk";
//			src.balance = 100;
////			src.id = 123;
////			src.test1 = 1;
////			src.test2 = 2;
////			src.test3 = 3;
////			src.test4 = 4;
////			src.test5 = 5;
////			src.test6 = 6;
////			src.test7 = 7;
////			src.test8 = 8;
////			src.test9 = false;
////			src.test99 = (float)9.9;
////			src.test11 = UTF8Encoding.UTF8.GetBytes ("ttt");
////			src.test13 = "test_string";
////			src.test14 = lst_14;
////			src.test15 = Tuple.Create ("test", (long)100, (short)1);
////			src.test16 = new List<double>();
////			src.test16.Add(101);
////			src.test17 = new HashSet<double>();
////			src.test17.Add(102);
////			src.test17.Add(102);
////			src.test17.Add(108);
////			src.test18 = new Dictionary<long, string>();
////			src.test18.Add(103, "test18_balue");
////			src.test19 = TestEnum.Test1;
//
//			src.test1 = null;
//			src.test2 = null;
//			src.test3 = null;
//			src.test4 = null;
//			src.test5 = null;
//			src.test6 = null;
//			src.test7 = null;
//			src.test8 = null;
//			src.test9 = null;
//			src.test99 = null;
//			src.test11 = null;
//			src.test13 = null;
//			src.test14 = null;
//			src.test15 = null;
//			src.test16 = null;
//			src.test17 = null;
//			src.test18 = null;
//			src.test19 = null;
//			src.test20 = new List<Request> ();
//			RegisterAccount rr = new RegisterAccount ();
//			rr.account_holder_name = "muthu";
//			rr.initial_balance = 123;
//			src.test20.Add (rr);
//			src.test20.Add (rr);
//
//			return src;
//		}



		public static void Main (string[] args)
		{
			try {
//				string json = JSON.toJson( getDummy());
//				Console.WriteLine(json);
//				json = "{ \"data\": " + json + " }";
//				Dummy test = JSON.parseJson<Dummy>(json);
//				Console.WriteLine(test);

				Response response;
				ListAllAccounts list_all = new ListAllAccounts();
				response = JSON.parseJson<Response>(Util.api_request(list_all));
				Console.WriteLine(response);

				RegisterAccount register = new RegisterAccount();
				register.account_holder_name = null;
				register.initial_balance = 100;
				response = JSON.parseJson<Response>(Util.api_request(register));
				Console.WriteLine(response);

				LookupAccount lk = new LookupAccount ();
				lk.account_id = ((AccountInfo)response).account.id;
				response = JSON.parseJson<Response>(Util.api_request(lk));
				Console.WriteLine(response);
			} catch (WebException ex) {
				Console.WriteLine ("http errror: " + ex.Message);
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
				Console.WriteLine (ex.StackTrace);
			}

			Console.ReadLine ();
		}
	}
}
