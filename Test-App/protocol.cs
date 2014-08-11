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
	/// Pong
	/// </summary>

	public class Pong : Response 
	{

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// TransferSuccess
	/// </summary>

	public class TransferSuccess : Response 
	{

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// Error
	/// </summary>

	public class Error : Response 
	{
		string _message;
		public string message {
			get {
				return this._message;
			}
			set {
				try {
					this._message = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Error.message error message: " + ex.Message);
				}
			}
		}

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// Response
	/// </summary>

	public class Response 
	{
	}


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
	/// AllAccounts
	/// </summary>

	public class AllAccounts : Response 
	{
		List<Account> _accounts = new List<Account>();
		public List<Account> accounts {
			get {
				return this._accounts;
			}
			set {
				try {
					foreach(var value_1 in value) {
						Util.check_for_null(value_1);
					}
					this._accounts = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field AllAccounts.accounts error message: " + ex.Message);
				}
			}
		}

		public override string ToString () 
		{
			return JSON.toJson(this);
		}

	}


	/// <summary>
	/// AccountInfo
	/// </summary>

	public class AccountInfo : Response 
	{
		Account _account = new Account();
		public Account account {
			get {
				return this._account;
			}
			set {
				try {
					this._account = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field AccountInfo.account error message: " + ex.Message);
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
	/// TransferFailed
	/// </summary>

	public class TransferFailed : Response 
	{
		string _message;
		public string message {
			get {
				return this._message;
			}
			set {
				try {
					this._message = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field TransferFailed.message error message: " + ex.Message);
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
	/// Account
	/// </summary>

	public class Account 
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
					throw new Exception ("error setting field Account.id error message: " + ex.Message);
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
					throw new Exception ("error setting field Account.account_holder_name error message: " + ex.Message);
				}
			}
		}
		Double _balance;
		public Double balance {
			get {
				return this._balance;
			}
			set {
				try {
					this._balance = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Account.balance error message: " + ex.Message);
				}
			}
		}

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
