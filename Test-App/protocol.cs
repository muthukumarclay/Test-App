using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Newtonsoft.Json;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json.Linq;


namespace test 
{


	/// <summary>
	/// RegisterAccount
	/// </summary>

	public class RegisterAccount : Request 
	{
		Double _initial_balance;
		public Double initial_balance {
			get {
				return this._initial_balance;
			}
			set {
				try {
					this._initial_balance = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field RegisterAccount.initial_balance error message: " + ex.Message);
				}
			}
		}
		string _account_holder_name;
		public string account_holder_name {
			get {
				return this._account_holder_name;
			}
			set {
				try {
					this._account_holder_name = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field RegisterAccount.account_holder_name error message: " + ex.Message);
				}
			}
		}

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// TransferAmount
	/// </summary>

	public class TransferAmount : Request 
	{
		UInt64 _from_account_id;
		public UInt64 from_account_id {
			get {
				return this._from_account_id;
			}
			set {
				try {
					this._from_account_id = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field TransferAmount.from_account_id error message: " + ex.Message);
				}
			}
		}
		UInt64 _to_account_id;
		public UInt64 to_account_id {
			get {
				return this._to_account_id;
			}
			set {
				try {
					this._to_account_id = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field TransferAmount.to_account_id error message: " + ex.Message);
				}
			}
		}
		Double _amount;
		public Double amount {
			get {
				return this._amount;
			}
			set {
				try {
					this._amount = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field TransferAmount.amount error message: " + ex.Message);
				}
			}
		}

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// LookupAccount
	/// </summary>

	public class LookupAccount : Request 
	{
		UInt64 _account_id;
		public UInt64 account_id {
			get {
				return this._account_id;
			}
			set {
				try {
					this._account_id = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field LookupAccount.account_id error message: " + ex.Message);
				}
			}
		}

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// TestEnum
	/// </summary>

	public enum TestEnum 
	{
		Test1 = 0,
		Test2 = 1
	}


	/// <summary>
	/// ListAllAccounts
	/// </summary>

	public class ListAllAccounts : Request 
	{

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// Dummy
	/// </summary>

	public class Dummy 
	{
		UInt64 _id;
		public UInt64 id {
			get {
				return this._id;
			}
			set {
				try {
					this._id = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.id error message: " + ex.Message);
				}
			}
		}
		string _account_holder_name;
		public string account_holder_name {
			get {
				return this._account_holder_name;
			}
			set {
				try {
					this._account_holder_name = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.account_holder_name error message: " + ex.Message);
				}
			}
		}
		Double? _balance;
		public Double? balance {
			get {
				return this._balance;
			}
			set {
				try {
					this._balance = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.balance error message: " + ex.Message);
				}
			}
		}
		SByte? _test1;
		public SByte? test1 {
			get {
				return this._test1;
			}
			set {
				try {
					this._test1 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test1 error message: " + ex.Message);
				}
			}
		}
		Int16? _test2;
		public Int16? test2 {
			get {
				return this._test2;
			}
			set {
				try {
					this._test2 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test2 error message: " + ex.Message);
				}
			}
		}
		Int32? _test3;
		public Int32? test3 {
			get {
				return this._test3;
			}
			set {
				try {
					this._test3 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test3 error message: " + ex.Message);
				}
			}
		}
		Int64? _test4;
		public Int64? test4 {
			get {
				return this._test4;
			}
			set {
				try {
					this._test4 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test4 error message: " + ex.Message);
				}
			}
		}
		Byte? _test5;
		public Byte? test5 {
			get {
				return this._test5;
			}
			set {
				try {
					this._test5 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test5 error message: " + ex.Message);
				}
			}
		}
		UInt16? _test6;
		public UInt16? test6 {
			get {
				return this._test6;
			}
			set {
				try {
					this._test6 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test6 error message: " + ex.Message);
				}
			}
		}
		UInt32? _test7;
		public UInt32? test7 {
			get {
				return this._test7;
			}
			set {
				try {
					this._test7 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test7 error message: " + ex.Message);
				}
			}
		}
		UInt64? _test8;
		public UInt64? test8 {
			get {
				return this._test8;
			}
			set {
				try {
					this._test8 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test8 error message: " + ex.Message);
				}
			}
		}
		bool? _test9;
		public bool? test9 {
			get {
				return this._test9;
			}
			set {
				try {
					this._test9 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test9 error message: " + ex.Message);
				}
			}
		}
		Single? _test99;
		public Single? test99 {
			get {
				return this._test99;
			}
			set {
				try {
					this._test99 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test99 error message: " + ex.Message);
				}
			}
		}
		byte[] _test11;
		public byte[] test11 {
			get {
				return this._test11;
			}
			set {
				try {
					this._test11 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test11 error message: " + ex.Message);
				}
			}
		}
		string _test13;
		public string test13 {
			get {
				return this._test13;
			}
			set {
				try {
					this._test13 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test13 error message: " + ex.Message);
				}
			}
		}
		List<string> _test14 = new List<string>();
		public List<string> test14 {
			get {
				return this._test14;
			}
			set {
				try {
					if (value != null) {
						Util.check_size(value, 5);
						foreach(var value_2 in value) {
							Util.check_for_null(value_2);
						}
					}
					this._test14 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test14 error message: " + ex.Message);
				}
			}
		}
		Tuple<string, Int64, Int16> _test15;
		public Tuple<string, Int64, Int16> test15 {
			get {
				return this._test15;
			}
			set {
				try {
					if (value != null) {
						string value_inner_item1;
						value_inner_item1 =(string)value.Item1;
						Util.check_for_null(value_inner_item1);
						Int64 value_inner_item2;
						value_inner_item2 =(Int64)value.Item2;
						Util.check_for_null(value_inner_item2);
						Int16 value_inner_item3;
						value_inner_item3 =(Int16)value.Item3;
						Util.check_for_null(value_inner_item3);
					}
					this._test15 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test15 error message: " + ex.Message);
				}
			}
		}
		List<Double> _test16 = new List<Double>();
		public List<Double> test16 {
			get {
				return this._test16;
			}
			set {
				try {
					if (value != null) {
						foreach(var value_2 in value) {
							Util.check_for_null(value_2);
						}
					}
					this._test16 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test16 error message: " + ex.Message);
				}
			}
		}
		HashSet<Double> _test17 = new HashSet<Double>();
		public HashSet<Double> test17 {
			get {
				return this._test17;
			}
			set {
				try {
					if (value != null) {
						foreach(var value_2 in value) {
							Util.check_for_null(value_2);
						}
					}
					this._test17 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test17 error message: " + ex.Message);
				}
			}
		}
		Dictionary<Int64, string> _test18 = new Dictionary<Int64, string>();
		public Dictionary<Int64, string> test18 {
			get {
				return this._test18;
			}
			set {
				try {
					if (value != null) {
						foreach(var value_2 in value) {
							Util.check_for_null(value_2.Key);
							Util.check_for_null(value_2.Value);
						}
					}
					this._test18 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test18 error message: " + ex.Message);
				}
			}
		}
		TestEnum? _test19;
		public TestEnum? test19 {
			get {
				return this._test19;
			}
			set {
				try {
					this._test19 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test19 error message: " + ex.Message);
				}
			}
		}
		List<Request> _test20 = new List<Request>();
		public List<Request> test20 {
			get {
				return this._test20;
			}
			set {
				try {
					foreach(var value_1 in value) {
						Util.check_for_null(value_1);
					}
					this._test20 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test20 error message: " + ex.Message);
				}
			}
		}

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// Request
	/// </summary>

	public class Request 
	{
	}


	/// <summary>
	/// Ping
	/// </summary>

	public class Ping : Request 
	{

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// JSON
	/// </summary>

	public static class JSON
	{
		public static string toJson (dynamic value)
		{
			Object structure = toStructure (value);
			return JsonConvert.SerializeObject (structure, Formatting.Indented);
		}

		public static T parseJson<T> (string json)
		{
			Dictionary<string, object> fields = JsonConvert.DeserializeObject<Dictionary<string, object>> (json);
			Object data = fields ["data"];
			return (T)parseStructure (typeof(T), data);
		}

		public static Object toStructure (dynamic obj)
		{
			if (obj == null) {
				return null;
			}
			if (obj.GetType ().BaseType == typeof(System.ValueType)) {
				return obj;
			} else if (obj.GetType () == typeof(System.String)) {
				return obj;
			} else if (obj.GetType ().BaseType == typeof(System.Object)) {
				if (obj.GetType ().ToString ().StartsWith ("System.Collections.Generic.List")) {
					List<object> lst = new List<object> ();
					for (int i = 0; i < obj.Count; i++) {
						lst.Add (toStructure (obj [i]));
					}
					return lst;
				} else if (obj.GetType ().ToString ().StartsWith("System.Collections.Generic.Dictionary")) {
					List<object> dict_items = new List<object> ();
					foreach (var key in obj.Keys) {
						List<object> lst_de = new List<object> ();
						lst_de.Add (toStructure (key));
						lst_de.Add (toStructure (obj [key]));
						dict_items.Add (lst_de);
					}
					return dict_items;
				} else if (obj.GetType ().ToString ().StartsWith("System.Collections.Generic.HashSet")) {
					List<object> set_items = new List<object> ();
					foreach (var x in obj) {
						set_items.Add (toStructure (x));
					}
					return set_items;
				} else if (obj.GetType ().ToString ().StartsWith ("System.Tuple")) {
					List<object> tup_items = new List<object> ();
					int i = 1;
					foreach (PropertyInfo prp in obj.GetType().GetProperties()) {
						if (i == 8) {
							var lst = toStructure (prp.GetValue (obj, null));
							foreach (var x in lst) {
								tup_items.Add (x);
							}
						} else {
							tup_items.Add (toStructure (prp.GetValue (obj, null)));
						}
						i += 1;
					}
					return tup_items;
				} else {
					Dictionary<string, object> fields = new Dictionary<string, object> ();
					foreach (PropertyInfo prp in obj.GetType().GetProperties()) {
						fields.Add (prp.Name, JSON.toStructure (prp.GetValue (obj, null)));
					}
					return fields;
				}
			} else if (obj.GetType ().BaseType == typeof(System.Enum)) {
				return obj.ToString ();
			} else if (obj.GetType ().BaseType == typeof(System.Array)) {
				return Encoding.UTF8.GetString ((byte[])obj);
			} else {
				List<object> variant = new List<object> ();
				variant.Add (obj.GetType ().Name);
				Dictionary<string, object> fields = new Dictionary<string, object> ();
				foreach (PropertyInfo prp in obj.GetType().GetProperties()) {
					fields.Add (prp.Name, JSON.toStructure (prp.GetValue (obj, null)));
				}
				variant.Add (fields);
				return variant;
			}

			throw new Exception (String.Format("not supported type {0}, base type {1}", obj.GetType ().ToString (), obj.GetType ().BaseType.ToString ()));
		}

		public static dynamic parseStructure (Type t_type, dynamic obj)
		{
			if (obj.GetType () == typeof(JValue)) {
				JValue j_value = obj;
				if (j_value.Value == null) {
					return null;
				}
			}
			if (t_type.ToString().StartsWith("System.Nullable")) {
				t_type = t_type.GetGenericArguments () [0];
				JValue j_value = obj;
				return parseStructure (t_type, j_value.Value);
			} else if (t_type == typeof(System.SByte)) {
				return (System.SByte)obj;
			} else if (t_type == typeof(System.Int16)) {
				return (System.Int16)obj;
			} else if (t_type == typeof(System.Int32)) {
				return (System.Int32)obj;
			} else if (t_type == typeof(System.Int64)) {
				return (System.Int64)obj;
			} else if (t_type == typeof(System.Byte)) {
				return (System.Byte)obj;
			} else if (t_type == typeof(System.UInt16)) {
				return (System.UInt16)obj;
			} else if (t_type == typeof(System.UInt32)) {
				return (System.UInt32)obj;
			} else if (t_type == typeof(System.UInt64)) {
				return (System.UInt64)obj;
			} else if (t_type == typeof(System.Double)) {
				return (System.Double)obj;
			} else if (t_type == typeof(System.Single)) {
				return (System.Single)obj;
			} else if (t_type == typeof(System.Boolean)) {
				return (System.Boolean)obj;
			} else if (t_type == typeof(System.String)) {
				return Convert.ToString (obj);
			} else if (t_type.ToString ().StartsWith ("System.Tuple")) {
				List<dynamic> lst_tuple = new List<dynamic> ();
				int length = t_type.GetGenericArguments ().Length;
				for (int i = 0; i < length; i++) {
					if (i > 6) {
						break;
					} else {
						lst_tuple.Add (parseStructure (t_type.GetGenericArguments () [i], obj [i]));
					}
				}
				if (length > 7) {
					length = t_type.GetGenericArguments()[7].GetGenericArguments().Length;
					dynamic[] arr = new dynamic[length];
					for (int i = 0; i < length; i++) {
						arr [i] = obj[i + 7];
					}
					lst_tuple.Add (parseStructure (t_type.GetGenericArguments () [7], arr));
				}
				if (lst_tuple.Count == 1) {
					return Tuple.Create (lst_tuple [0]);
				} else if (lst_tuple.Count == 2) {
					return Tuple.Create (lst_tuple [0], lst_tuple [1]);
				} else if (lst_tuple.Count == 3) {
					return Tuple.Create (lst_tuple [0], lst_tuple [1], lst_tuple [2]);
				} else if (lst_tuple.Count == 4) {
					return Tuple.Create (lst_tuple [0], lst_tuple [1], lst_tuple [2], lst_tuple [3]);
				} else if (lst_tuple.Count == 5) {
					return Tuple.Create (lst_tuple [0], lst_tuple [1],lst_tuple [2], lst_tuple [3], lst_tuple [4]);
				} else if (lst_tuple.Count == 6) {
					return Tuple.Create (lst_tuple [0], lst_tuple [1], lst_tuple [2], lst_tuple [3], lst_tuple [4], lst_tuple [5]);
				} else if (lst_tuple.Count == 7) {
					return Tuple.Create (lst_tuple [0], lst_tuple [1], lst_tuple [2], lst_tuple [3], lst_tuple [4], lst_tuple [5], lst_tuple [6]);
				} else if (lst_tuple.Count > 7) {
					return Tuple.Create (lst_tuple [0], lst_tuple [1], lst_tuple [2],lst_tuple [3], lst_tuple [4], lst_tuple [5], lst_tuple [6], lst_tuple [7]);
				}
			} else if (t_type.ToString ().StartsWith("System.Collections.Generic.List")) {
				dynamic lst = Activator.CreateInstance (t_type, false);
				foreach (var item in obj) {
					lst.Add (parseStructure (t_type.GetGenericArguments () [0], item));
				}
				return lst;
			} else if (t_type.ToString ().StartsWith ("System.Collections.Generic.HashSet")) {
				dynamic hash = Activator.CreateInstance (t_type, false);
				for (int j = 0; j < obj.Count; j++) {
					hash.Add (parseStructure (t_type.GetGenericArguments () [0], obj [j]));
				}
				return hash;
			} else if (t_type.ToString ().StartsWith ("System.Collections.Generic.Dictionary")) {
				dynamic dict = Activator.CreateInstance (t_type, false);
				foreach(var item in obj) {
					dynamic key = parseStructure (t_type.GetGenericArguments()[0], item[0]);
					dynamic value = parseStructure (t_type.GetGenericArguments()[1], item[1]);
					dict.Add (key, value);
				}
				return dict;
			} else if (t_type.ToString ().StartsWith ("System.Byte[]")) {
				byte[] value = System.Text.UTF8Encoding.UTF8.GetBytes(Convert.ToString (obj));
				return value;
			} else if (t_type.BaseType == typeof(System.Enum)) {
				return Enum.Parse (t_type, Convert.ToString (obj));
			} else {
				dynamic cls;
				if (obj.GetType ().ToString ().StartsWith ("Newtonsoft.Json.Linq.JArray")) {
					string option_class_name = t_type.Namespace + "." + obj [0];
					t_type = Type.GetType (option_class_name);
					cls = Activator.CreateInstance (t_type, false);
					obj = obj [1];
				} else {
					cls = Activator.CreateInstance (t_type, false);
				}
				foreach (PropertyInfo property in t_type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)) {
					property.SetValue (cls, parseStructure (property.PropertyType, obj [property.Name]), null);
				}

				return cls;
			}

			throw new Exception ("invalid type");
		}
	}

	/// <summary>
	/// Util
	/// </summary>

	public static class Util
	{
		public static void check_for_null (object obj)
		{
			if (obj == null) {
				throw new Exception ("null not allowed");
			}
		}

		public static void check_size (dynamic value, int size)
		{
			if (value.Count != size) {
				throw new Exception (String.Format ("expected size {0} but received {1}", size, value.Count));
			}
		}
	}


}
