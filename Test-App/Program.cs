﻿using System;
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

	class Test {
		private List<Int16> _int_test;
		public List<Int16> int_test {
			get {
				return this._int_test;
			}
			set {
					this._int_test = value;
			}
		}

	}

	class MainClass
	{

//		public enum TESTE
//		{
//			TT,
//			TT1
//		}

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

		public static void printInt(int x) {
			try {
				Console.WriteLine (x);
			}
			catch(Exception ex) {
				throw new Exception ("error setting printInt error:" + ex.Message);
			}
		}

		public static void Main (string[] args)
		{
			try {
//				Ping pg = new Ping();
//				Console.WriteLine(pg.GetType().ToString());
//				Console.WriteLine(pg.GetType().BaseType.ToString());
//				Account acc = new Account();
//				Console.WriteLine(acc.GetType().ToString());
//				Console.WriteLine(acc.GetType().BaseType.ToString());
//
//				if (acc.GetType().BaseType == typeof(Request)) {
//					Console.WriteLine("acc yes it is ");
//				} else {
//					Console.WriteLine("acc no it is ");
//				}
//
//				if (pg.GetType().BaseType == typeof(Request)) {
//					Console.WriteLine("pg yes ");
//				}
//				else {
//					Console.WriteLine("pg no ");
//				}
//				int? i = null;
//				bool? bln = null;
//				Tuple<int> tup = null;

//				Request request = new Request();
//				Response response = new Response();
//
//				ListAllAccounts list_all = new ListAllAccounts();
//				request.set_option(list_all);
//				response.set_option((Response)Util.api_request(request, response));
//				Console.WriteLine(response.toJson());
//
//				RegisterAccount register = new RegisterAccount();
//				register.account_holder_name = null;
//				register.initial_balance = 100;
//				request.set_option(register);
//				response.set_option((Response)Util.api_request(request, response));
//				Console.WriteLine(response.toJson());
//
//				LookupAccount lk = new LookupAccount ();
//				lk.account_id = ((AccountInfo)response.get_option()).account.id;
//				request.set_option(lk);
//				response.set_option((Response)Util.api_request(request, response));
//				Console.WriteLine(response.toJson());
			} catch (WebException ex) {
				Console.WriteLine ("http errror: " + ex.Message);
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}

			Console.ReadLine ();
		}
	}
}
