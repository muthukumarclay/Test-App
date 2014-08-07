using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Newtonsoft.Json;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json.Linq;


namespace test {


	/// <summary>
	/// TestEnum
	/// </summary>

	public enum TestEnum {
		Test1 = 0,
		Test2 = 1
	}


	/// <summary>
	/// Dummy
	/// </summary>

	public class Dummy {
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
		List<byte[]> _test14 = new List<byte[]>();
		public List<byte[]> test14 {
			get {
				return this._test14;
			}
			set {
				try {
					if (value != null) {
						if (value.Count() != 5) {
							throw new Exception(String.Format("expected size 5 but received {0}", value.Count));
						}
						foreach(var value_2 in value) {
							if (value_2 == null) {
								throw new Exception("null not allowed");
							}
						}
					}
					this._test14 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test14 error message: " + ex.Message);
				}
			}
		}
		Tuple<List<byte[]>, Int64, Int16> _test15;
		public Tuple<List<byte[]>, Int64, Int16> test15 {
			get {
				return this._test15;
			}
			set {
				try {
					if (value != null) {
						List<byte[]> value_inner_item1 = new List<byte[]>();
						value_inner_item1 =(List<byte[]>)value.Item1;
						if (value_inner_item1 == null) {
							throw new Exception("null not allowed");
						}
						if (value_inner_item1.Count() != 5) {
							throw new Exception(String.Format("expected size 5 but received {0}", value_inner_item1.Count));
						}
						foreach(var value_3 in value_inner_item1) {
							if (value_3 == null) {
								throw new Exception("null not allowed");
							}
						}
						Int64 value_inner_item2;
						value_inner_item2 =(Int64)value.Item2;
						if (value_inner_item2 == null) {
							throw new Exception("null not allowed");
						}
						Int16 value_inner_item3;
						value_inner_item3 =(Int16)value.Item3;
						if (value_inner_item3 == null) {
							throw new Exception("null not allowed");
						}
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
					foreach(var value_1 in value) {
						if (value_1 == null) {
							throw new Exception("null not allowed");
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
					foreach(var value_1 in value) {
						if (value_1 == null) {
							throw new Exception("null not allowed");
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
					foreach(var value_1 in value) {
						if (value_1.Key == null) {
							throw new Exception("null not allowed");
						}
						if (value_1.Value == null) {
							throw new Exception("null not allowed");
						}
					}
					this._test18 = value;
				} catch (Exception ex) {
					throw new Exception ("error setting field Dummy.test18 error message: " + ex.Message);
				}
			}
		}
		TestEnum _test19;
		public TestEnum test19 {
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

		public string toJson() {
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("id", JSON.toStructure(this.id));
			fields.Add("account_holder_name", JSON.toStructure(this.account_holder_name));
			fields.Add("balance", JSON.toStructure(this.balance));
			fields.Add("test1", JSON.toStructure(this.test1));
			fields.Add("test2", JSON.toStructure(this.test2));
			fields.Add("test3", JSON.toStructure(this.test3));
			fields.Add("test4", JSON.toStructure(this.test4));
			fields.Add("test5", JSON.toStructure(this.test5));
			fields.Add("test6", JSON.toStructure(this.test6));
			fields.Add("test7", JSON.toStructure(this.test7));
			fields.Add("test8", JSON.toStructure(this.test8));
			fields.Add("test9", JSON.toStructure(this.test9));
			fields.Add("test99", JSON.toStructure(this.test99));
			fields.Add("test11", JSON.toStructure(this.test11));
			fields.Add("test13", JSON.toStructure(this.test13));
			fields.Add("test14", JSON.toStructure(this.test14));
			fields.Add("test15", JSON.toStructure(this.test15));
			fields.Add("test16", JSON.toStructure(this.test16));
			fields.Add("test17", JSON.toStructure(this.test17));
			fields.Add("test18", JSON.toStructure(this.test18));
			fields.Add("test19", JSON.toStructure(this.test19));
			return JsonConvert.SerializeObject(fields, Formatting.Indented);
		}

		public Dummy parseJson(string json) {
			Dictionary<string, object> fields = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			UInt64 field_1;
			field_1 = (UInt64)JSON.parseStructure(fields["id"]);
			this.id = field_1;
			string field_2;
			field_2 = (string)JSON.parseStructure(fields["account_holder_name"]);
			this.account_holder_name = field_2;
			Double? field_4;
			field_4 = (Double)JSON.parseStructure(fields["balance"]);
			this.balance = field_4;
			SByte? field_6;
			field_6 = (SByte)JSON.parseStructure(fields["test1"]);
			this.test1 = field_6;
			Int16? field_8;
			field_8 = (Int16)JSON.parseStructure(fields["test2"]);
			this.test2 = field_8;
			Int32? field_10;
			field_10 = (Int32)JSON.parseStructure(fields["test3"]);
			this.test3 = field_10;
			Int64? field_12;
			field_12 = (Int64)JSON.parseStructure(fields["test4"]);
			this.test4 = field_12;
			Byte? field_14;
			field_14 = (Byte)JSON.parseStructure(fields["test5"]);
			this.test5 = field_14;
			UInt16? field_16;
			field_16 = (UInt16)JSON.parseStructure(fields["test6"]);
			this.test6 = field_16;
			UInt32? field_18;
			field_18 = (UInt32)JSON.parseStructure(fields["test7"]);
			this.test7 = field_18;
			UInt64? field_20;
			field_20 = (UInt64)JSON.parseStructure(fields["test8"]);
			this.test8 = field_20;
			bool? field_22;
			field_22 = (bool)JSON.parseStructure(fields["test9"]);
			this.test9 = field_22;
			Single? field_24;
			field_24 = (Single)JSON.parseStructure(fields["test99"]);
			this.test99 = field_24;
			byte[] field_26;
			field_26 = UTF8Encoding.UTF8.GetBytes((string)JSON.parseStructure(fields["test11"]));
			this.test11 = field_26;
			string field_28;
			field_28 = (string)JSON.parseStructure(fields["test13"]);
			this.test13 = field_28;
			List<byte[]> field_30 = new List<byte[]>();
			foreach(var value_32 in JSON.parseStructure(fields["test14"])) {
				byte[] value_32_32;
				value_32_32 = UTF8Encoding.UTF8.GetBytes((string)JSON.parseStructure(value_32));
				field_30.Add(value_32_32);
			}
			this.test14 = field_30;
			Tuple<List<byte[]>, Int64, Int16> field_33;
			List<object> value_35 = JSON.parseStructure(fields["test15"]);
			if(value_35.Count() != 3) {
				throw new Exception(String.Format("expected length {0} but received {1}", 3, value_35.Count()));
			}
			List<byte[]> value_35_0 = new List<byte[]>();
			foreach(var value_36 in JSON.parseStructure(value_35[0])) {
				byte[] value_36_36;
				value_36_36 = UTF8Encoding.UTF8.GetBytes((string)JSON.parseStructure(value_36));
				value_35_0.Add(value_36_36);
			}
			Int64 value_35_1;
			value_35_1 = (Int64)JSON.parseStructure(value_35[1]);
			Int16 value_35_2;
			value_35_2 = (Int16)JSON.parseStructure(value_35[2]);
			field_33 = Tuple.Create(value_35_0,value_35_1,value_35_2);
			this.test15 = field_33;
			List<Double> field_39 = new List<Double>();
			foreach(var value_40 in JSON.parseStructure(fields["test16"])) {
				Double value_40_40;
				value_40_40 = (Double)JSON.parseStructure(value_40);
				field_39.Add(value_40_40);
			}
			this.test16 = field_39;
			HashSet<Double> field_41 = new HashSet<Double>();
			foreach(var value_42 in JSON.parseStructure(fields["test17"])) {
				Double value_42_42;
				value_42_42 = (Double)JSON.parseStructure(value_42);
				field_41.Add(value_42_42);
			}
			this.test17 = field_41;
			Dictionary<Int64, string> field_43 = new Dictionary<Int64, string>();
			List<object> value_44_dictionary = JSON.parseStructure(fields["test18"]);
			foreach(JArray value_44 in value_44_dictionary) {
				if(value_44.Count() != 2) {
					throw new Exception(String.Format("expected length 2 but received {0}", value_44.Count()));
				}
				Int64 value_44_0;
				string value_44_1;
				value_44_0 = (Int64)JSON.parseStructure(value_44[0]);
				value_44_1 = (string)JSON.parseStructure(value_44[1]);
				field_43.Add(value_44_0, value_44_1);
			}
			this.test18 = field_43;
			TestEnum field_46;
			field_46 =(TestEnum) Enum.Parse(typeof(TestEnum), fields["test19"].ToString());
			this.test19 = field_46;
			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}


	/// <summary>
	/// JSON
	/// </summary>

	public static class JSON {
		public static Object toStructure(dynamic obj) {
			if (obj == null) { return null; }
			if (obj.GetType ().BaseType == typeof(System.ValueType)) {
				return obj;
			} else if (obj.GetType ().BaseType == typeof(System.Object)) {
				if (obj.GetType ().ToString ().StartsWith ("System.String")) {
					return obj;
				}
				else if (obj.GetType ().ToString ().StartsWith ("System.Collections.Generic.List")) {
					List<object> lst = new List<object> ();
					for (int i = 0; i < obj.Count; i++) {
						lst.Add (toStructure (obj [i]));
					}
					return lst;
				} else if (obj.GetType ().ToString ().StartsWith ("System.Collections.Generic.Dictionary")) {
					List<object> dict_items = new List<object> ();
					foreach (var key in obj.Keys) {
						List<object> lst_de = new List<object> ();
						lst_de.Add (toStructure (key));
						lst_de.Add (toStructure (obj[key]));
						dict_items.Add (lst_de);
					}
					return dict_items;
				} else if (obj.GetType ().ToString ().StartsWith ("System.Collections.Generic.HashSet")) {
					List<object> set_items = new List<object> ();
					foreach(var x in obj) {
						set_items.Add(toStructure(x));
					}
					return set_items;
				} else if (obj.GetType ().ToString ().StartsWith ("System.Tuple")) {
					List<object> tup_items = new List<object> ();
					foreach (PropertyInfo prp in obj.GetType().GetProperties()) {
						tup_items.Add (toStructure (prp.GetValue (obj, null)));
					}
					return tup_items;
				} else {
					Dictionary<string, object> fields = new Dictionary<string, object>();
					foreach (PropertyInfo prp in obj.GetType().GetProperties()) {
						fields.Add(prp.Name, JSON.toStructure(prp.GetValue(obj, null)));
					}
					return fields;
				}
			} else if (obj.GetType ().BaseType == typeof(System.Enum)) {
				return obj.ToString ();
			} else if (obj.GetType ().BaseType == typeof(System.Array)) {
				return Encoding.UTF8.GetString ((byte[])obj);
			}

			throw new Exception (String.Format ("not supported type {0}, base type {1}", obj.GetType ().ToString (), obj.GetType ().BaseType.ToString ()));
		}

		public static dynamic parseStructure(dynamic obj) {
			if (obj.GetType ().ToString () == "Newtonsoft.Json.Linq.JValue") {
				return obj;
			} else if  (obj.GetType ().ToString () == "Newtonsoft.Json.Linq.JArray") {
				return obj.ToObject<List<object>>();
			} else if (obj.GetType ().BaseType == typeof(System.ValueType)) {
				return obj;
			} else if (obj.GetType ().BaseType == typeof(System.Object)) {
				if (obj.GetType ().ToString ().StartsWith ("System.String")) {
					return obj;
				}
			}

			throw new Exception (String.Format ("invalid type in parseStructure got type {0} base type {1}", obj.GetType ().ToString (), obj.GetType ().BaseType.ToString ()));
		}
	}


}
