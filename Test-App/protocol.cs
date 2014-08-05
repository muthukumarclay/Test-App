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
	/// Request
	/// </summary>

	public class Request {
		public Request option = null;

		public void set_option(Request obj) {
			this.option = obj;
		}

		public Request get_option() {
			return this.option;
		}

		public virtual string toJson() {
			if (this.option == null) {
				throw new Exception ("null not allowed");
			}
			return this.option.toJson ();
		}

		public virtual Request parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);
			switch (lst [0].ToString ()) {
			case "Ping":
				set_option (new Ping());
				break;
			case "RegisterAccount":
				set_option (new RegisterAccount());
				break;
			case "LookupAccount":
				set_option (new LookupAccount());
				break;
			case "TransferAmount":
				set_option (new TransferAmount());
				break;
			case "ListAllAccounts":
				set_option (new ListAllAccounts());
				break;
			default :
				throw new Exception ("invalid type");
			}
			this.option.parseJson (json);
			return get_option ();
		}

		public override string ToString () {
			if (this.get_option () == null) {
				return "Request";
			} else {
				return this.get_option ().toJson ();
			}
		}
	}

	/// <summary>
	/// Ping
	/// </summary>

	public class Ping : Request {

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("Ping");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Request parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// RegisterAccount
	/// </summary>

	public class RegisterAccount : Request {
		System.Double _initial_balance;
		public System.Double initial_balance {
			get {
				return this._initial_balance;
			}
			set {
				this._initial_balance = value;
			}
		}
		string _account_holder_name;
		public string account_holder_name {
			get {
				return this._account_holder_name;
			}
			set {
				if (value == null) {
					value = "";
				}
				this._account_holder_name = value;
			}
		}

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("RegisterAccount");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("initial_balance", JSON.toStructure(this.initial_balance));
			fields.Add("account_holder_name", JSON.toStructure(this.account_holder_name));
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Request parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			System.Double field_1;
			field_1 = (System.Double)JSON.parseStructure(fields["initial_balance"]);
			this.initial_balance = field_1;
			string field_2;
			field_2 = (string)JSON.parseStructure(fields["account_holder_name"]);
			this.account_holder_name = field_2;
			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// LookupAccount
	/// </summary>

	public class LookupAccount : Request {
		System.UInt64 _account_id;
		public System.UInt64 account_id {
			get {
				return this._account_id;
			}
			set {
				this._account_id = value;
			}
		}

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("LookupAccount");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("account_id", JSON.toStructure(this.account_id));
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Request parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			System.UInt64 field_1;
			field_1 = (System.UInt64)JSON.parseStructure(fields["account_id"]);
			this.account_id = field_1;
			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// TransferAmount
	/// </summary>

	public class TransferAmount : Request {
		System.UInt64 _from_account_id;
		public System.UInt64 from_account_id {
			get {
				return this._from_account_id;
			}
			set {
				this._from_account_id = value;
			}
		}
		System.UInt64 _to_account_id;
		public System.UInt64 to_account_id {
			get {
				return this._to_account_id;
			}
			set {
				this._to_account_id = value;
			}
		}
		System.Double _amount;
		public System.Double amount {
			get {
				return this._amount;
			}
			set {
				this._amount = value;
			}
		}

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("TransferAmount");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("from_account_id", JSON.toStructure(this.from_account_id));
			fields.Add("to_account_id", JSON.toStructure(this.to_account_id));
			fields.Add("amount", JSON.toStructure(this.amount));
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Request parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			System.UInt64 field_1;
			field_1 = (System.UInt64)JSON.parseStructure(fields["from_account_id"]);
			this.from_account_id = field_1;
			System.UInt64 field_2;
			field_2 = (System.UInt64)JSON.parseStructure(fields["to_account_id"]);
			this.to_account_id = field_2;
			System.Double field_3;
			field_3 = (System.Double)JSON.parseStructure(fields["amount"]);
			this.amount = field_3;
			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// ListAllAccounts
	/// </summary>

	public class ListAllAccounts : Request {

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("ListAllAccounts");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Request parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// Account
	/// </summary>

	public class Account {
		System.UInt64 _id;
		public System.UInt64 id {
			get {
				return this._id;
			}
			set {
				this._id = value;
			}
		}
		string _account_holder_name;
		public string account_holder_name {
			get {
				return this._account_holder_name;
			}
			set {
				if (value == null) {
					throw new Exception("null not allowed");
				}
				else {
				}
				this._account_holder_name = value;
			}
		}
		System.Double _balance;
		public System.Double balance {
			get {
				return this._balance;
			}
			set {
				this._balance = value;
			}
		}

		public string toJson() {
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("id", JSON.toStructure(this.id));
			fields.Add("account_holder_name", JSON.toStructure(this.account_holder_name));
			fields.Add("balance", JSON.toStructure(this.balance));
			return JsonConvert.SerializeObject(fields, Formatting.Indented);
		}

		public Account parseJson(string json) {
			Dictionary<string, object> fields = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			System.UInt64 field_1;
			field_1 = (System.UInt64)JSON.parseStructure(fields["id"]);
			this.id = field_1;
			string field_2;
			field_2 = (string)JSON.parseStructure(fields["account_holder_name"]);
			this.account_holder_name = field_2;
			System.Double field_3;
			field_3 = (System.Double)JSON.parseStructure(fields["balance"]);
			this.balance = field_3;
			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// Response
	/// </summary>

	public class Response {
		public Response option = null;

		public void set_option(Response obj) {
			this.option = obj;
		}

		public Response get_option() {
			return this.option;
		}

		public virtual string toJson() {
			if (this.option == null) {
				throw new Exception ("null not allowed");
			}
			return this.option.toJson ();
		}

		public virtual Response parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);
			switch (lst [0].ToString ()) {
			case "Pong":
				set_option (new Pong());
				break;
			case "Error":
				set_option (new Error());
				break;
			case "AccountInfo":
				set_option (new AccountInfo());
				break;
			case "TransferSuccess":
				set_option (new TransferSuccess());
				break;
			case "TransferFailed":
				set_option (new TransferFailed());
				break;
			case "AllAccounts":
				set_option (new AllAccounts());
				break;
			default :
				throw new Exception ("invalid type");
			}
			this.option.parseJson (json);
			return get_option ();
		}

		public override string ToString () {
			if (this.get_option () == null) {
				return "Response";
			} else {
				return this.get_option ().toJson ();
			}
		}
	}

	/// <summary>
	/// Pong
	/// </summary>

	public class Pong : Response {

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("Pong");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Response parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// Error
	/// </summary>

	public class Error : Response {
		string _message;
		public string message {
			get {
				return this._message;
			}
			set {
				if (value == null) {
					throw new Exception("null not allowed");
				}
				else {
				}
				this._message = value;
			}
		}

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("Error");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("message", JSON.toStructure(this.message));
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Response parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			string field_1;
			field_1 = (string)JSON.parseStructure(fields["message"]);
			this.message = field_1;
			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// AccountInfo
	/// </summary>

	public class AccountInfo : Response {
		Account _account = new Account();
		public Account account {
			get {
				return this._account;
			}
			set {
				if (value == null) {
					throw new Exception("null not allowed");
				}
				else {
				}
				this._account = value;
			}
		}

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("AccountInfo");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("account", JSON.toStructure(this.account));
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Response parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			Account field_1 = new Account();
			Dictionary<string, object> value_2 = ((JObject)fields["account"]).ToObject<Dictionary<string, object>>();
			Account value_2_1 = new Account();
			System.UInt64 inner_value_2_id;
			inner_value_2_id = (System.UInt64)JSON.parseStructure(value_2["id"]);
			value_2_1.id = inner_value_2_id;
			string inner_value_2_account_holder_name;
			inner_value_2_account_holder_name = (string)JSON.parseStructure(value_2["account_holder_name"]);
			value_2_1.account_holder_name = inner_value_2_account_holder_name;
			System.Double inner_value_2_balance;
			inner_value_2_balance = (System.Double)JSON.parseStructure(value_2["balance"]);
			value_2_1.balance = inner_value_2_balance;
			field_1 = value_2_1;
			this.account = field_1;
			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// TransferSuccess
	/// </summary>

	public class TransferSuccess : Response {

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("TransferSuccess");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Response parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// TransferFailed
	/// </summary>

	public class TransferFailed : Response {
		string _message;
		public string message {
			get {
				return this._message;
			}
			set {
				if (value == null) {
					throw new Exception("null not allowed");
				}
				else {
				}
				this._message = value;
			}
		}

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("TransferFailed");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("message", JSON.toStructure(this.message));
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Response parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			string field_1;
			field_1 = (string)JSON.parseStructure(fields["message"]);
			this.message = field_1;
			return this;
		}

		public override string ToString () {
			return this.toJson();
		}

	}

	/// <summary>
	/// AllAccounts
	/// </summary>

	public class AllAccounts : Response {
		List<Account> _accounts = new List<Account>();
		public List<Account> accounts {
			get {
				return this._accounts;
			}
			set {
				if (value == null) {
					throw new Exception("null not allowed");
				}
				else {
					foreach(var value_1 in value) {
						if (value_1 == null) {
							throw new Exception("null not allowed");
						}
						else {
						}
					}
				}
				this._accounts = value;
			}
		}

		public override string toJson() {
			List<object> variant = new List<object>();
			variant.Add("AllAccounts");
			Dictionary<string, object> fields = new Dictionary<string, object>();
			fields.Add("accounts", JSON.toStructure(this.accounts));
			variant.Add(fields);
			return JsonConvert.SerializeObject(variant, Formatting.Indented);
		}

		public override Response parseJson(string json) {
			JArray lst = (JArray)JsonConvert.DeserializeObject(json);

			if (lst.Count() != 2) {
				throw new Exception (String.Format ("expected the list with the length {0} but got {1}", 2, lst.Count()));
			}

			if (lst[0].ToString() != this.GetType().Name) {
				throw new Exception(String.Format("expected the class identifier {0} but got {1}", this.GetType ().ToString (), lst [0].ToString ()));
			}

			Dictionary<string, object> fields = lst[1].ToObject<Dictionary<string, object>>();


			if (this.GetType ().GetProperties ().Count() != fields.Count()) {
				throw new Exception (String.Format ("fields count not matching. expected {0} but got {1}", this.GetType ().GetProperties ().Count (), fields.Count()));
			}

			foreach (PropertyInfo property in this.GetType().GetProperties()){
				if (fields.ContainsKey(property.Name) == false) {
					throw new Exception (String.Format ("expected field name {0} not found", property.Name));
				}
			}

			List<Account> field_1 = new List<Account>();
			foreach(var value_2 in JSON.parseStructure(fields["accounts"])) {
				Account value_2_2 = new Account();
				Dictionary<string, object> value_3 = ((JObject)value_2).ToObject<Dictionary<string, object>>();
				Account value_3_1 = new Account();
				System.UInt64 inner_value_3_id;
				inner_value_3_id = (System.UInt64)JSON.parseStructure(value_3["id"]);
				value_3_1.id = inner_value_3_id;
				string inner_value_3_account_holder_name;
				inner_value_3_account_holder_name = (string)JSON.parseStructure(value_3["account_holder_name"]);
				value_3_1.account_holder_name = inner_value_3_account_holder_name;
				System.Double inner_value_3_balance;
				inner_value_3_balance = (System.Double)JSON.parseStructure(value_3["balance"]);
				value_3_1.balance = inner_value_3_balance;
				value_2_2 = value_3_1;
				field_1.Add(value_2_2);
			}
			this.accounts = field_1;
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
			List<string> variant_record_types = new List<string> ();
			variant_record_types.Add("Account");
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
			} else if (variant_record_types.Contains(obj.GetType (). BaseType.ToString())){
				Dictionary<string, object> fields = new Dictionary<string, object>();
				foreach (PropertyInfo prp in obj.GetType().GetProperties()) {
					fields.Add(prp.Name, JSON.toStructure(prp.GetValue(obj, null)));
				}
				return fields;
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
