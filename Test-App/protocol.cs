using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Newtonsoft.Json;

namespace protocol.admin
{
	using AccountId = System.UInt32;

	public class Account
	{
		public AccountId id { get; set; }

		public string account_holder_name { get; set; }

		public double balance { get; set; }

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append ("Account ( ");
			strData.AppendFormat ("id: {0}, ", id);
			strData.AppendFormat ("account_holder_name: {0}, ", account_holder_name);
			strData.AppendFormat ("balance: {0} ", balance);
			strData.Append (")");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class Ping
	{
		public override string ToString ()
		{
			return String.Format ("Ping") + Environment.NewLine;
		}
	}

	public class RegisterAccount
	{
		public string account_holder_name { get; set; }

		public double initial_balance { get; set; }

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append ("RegisterAccount ( ");
			strData.AppendFormat ("account_holder_name: {0}, ", account_holder_name);
			strData.AppendFormat ("initial_balance: {0} ", account_holder_name);
			strData.Append (")");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class LookupAccount
	{
		public AccountId account_id { get; set; }

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append ("LookupAccount ( ");
			strData.AppendFormat ("account_id: {0} ", account_id);
			strData.Append (")");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class TransferAmount
	{
		public AccountId from_account_id { get; set; }

		public AccountId to_account_id { get; set; }

		public double amount { get; set; }

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append ("TransferAmount ( ");
			strData.AppendFormat ("from_account_id: {0}, ", from_account_id);
			strData.AppendFormat ("to_account_id: {0}, ", to_account_id);
			strData.AppendFormat ("amount: {0} ", amount);
			strData.Append (")");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class ListAllAccounts
	{
		public override string ToString ()
		{
			return String.Format ("ListAllAccounts") + Environment.NewLine;
		}
	}

	public class Pong
	{
		public override string ToString ()
		{
			return "Pong" + Environment.NewLine;
		}
	}

	public class Error
	{
		public string message { get; set; }

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append ("Error ( ");
			strData.AppendFormat ("message: {0} ", message);
			strData.Append (") ");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class AccountInfo
	{
		public Account account { get; set; }

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.AppendLine ("AccountInfo ( ");
			strData.AppendFormat ("account: {0}", account);
			strData.AppendLine (")");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class TransferSuccess
	{
		public override string ToString ()
		{
			return "TransferSuccess" + Environment.NewLine;
		}
	}

	public class TransferFailed
	{
		public string message { get; set; }

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append ("TransferFailed ( ");
			strData.AppendFormat ("message: {0} ", message);
			strData.Append (")");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class AllAccounts
	{
		public List<Account> accounts { get; set; }

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.AppendLine ("AllAccounts ( ");
			strData.AppendLine ("accounts: [");
			foreach (Account acc in accounts) {
				strData.AppendLine (acc.ToString ());
			}
			strData.AppendLine ("]");
			strData.AppendLine (")");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class Request
	{
		private ArrayList arrList;

		public Request ()
		{
			arrList = new ArrayList ();
			arrList.Add (null);
			arrList.Add (null);
		}

		public void setData (object obj)
		{ 
			switch (obj.GetType ().Name) {
			case "Ping":
				break;
			case "RegisterAccount":
				break;
			case "LookupAccount":
				break;
			case "TransferAmount":
				break;
			case "ListAllAccounts":
				break;
			default:
				throw new Exception ("invalid type");
			}

			arrList [0] = obj.GetType ().Name;
			arrList[1] = obj;
		}

		public Object getData () {
			return arrList [1];
		}

		public string toJSON (Object obj)
		{
			return "{ \"data\": " + JsonConvert.SerializeObject (arrList) + " }";
		}

		public object parseJSON (string json)
		{
			var data = Newtonsoft.Json.Linq.JObject.Parse (json);
			json = data ["data"] [1].ToString ();
			Object obj;

			switch (data ["data"] [0].ToString ()) {
			case "Ping":
				obj = JsonConvert.DeserializeObject <Ping> (json);
				break;
			case "RegisterAccount":
				obj = JsonConvert.DeserializeObject <RegisterAccount> (json);
				break;
			case "LookupAccount":
				obj = JsonConvert.DeserializeObject <LookupAccount> (json);
				break;
			case "TransferAmount":
				obj = JsonConvert.DeserializeObject <TransferAmount> (json);
				break;
			case "ListAllAccounts":
				obj = JsonConvert.DeserializeObject <ListAllAccounts> (json);
				break;
			default:
				throw new Exception ("invalid type");
			}

			return obj;
		}

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.AppendLine ("Request ( ");
			if (arrList [1] != null) {
				strData.AppendLine (arrList[1].ToString());
			}
			strData.AppendLine (")");
			return strData.ToString () + Environment.NewLine;
		}
	}

	public class Response
	{
		private ArrayList arrList;

		public Response ()
		{
			arrList = new ArrayList ();
			arrList.Add (null);
			arrList.Add (null);
		}

		public void setData (object obj)
		{ 
			switch (obj.GetType ().Name) {
			case "Pong":
				break;
			case "Error":
				break;
			case "AccountInfo":
				break;
			case "TransferSuccess":
				break;
			case "TransferFailed":
				break;
			case "AllAccounts":
				break;
			default:
				throw new Exception ("invalid type");
			}

			arrList [0] = obj.GetType ().Name;
			arrList[1] = obj;
		}

		public Object getData () {
			return arrList [1];
		}

		public string toJSON (Object obj)
		{
			return "{ \"data\": " + JsonConvert.SerializeObject (arrList) + " }";
		}

		public object parseJSON (string json)
		{
			var data = Newtonsoft.Json.Linq.JObject.Parse (json);
			json = data ["data"] [1].ToString ();
			Object obj;

			switch (data ["data"] [0].ToString ()) {
			case "Pong":
				obj = JsonConvert.DeserializeObject <Pong> (json);
				break;
			case "Error":
				obj = JsonConvert.DeserializeObject <Error> (json);
				break;
			case "AccountInfo":
				obj = JsonConvert.DeserializeObject <AccountInfo> (json);
				break;
			case "TransferSuccess":
				obj = JsonConvert.DeserializeObject <TransferSuccess> (json);
				break;
			case "TransferFailed":
				obj = JsonConvert.DeserializeObject <TransferFailed> (json);
				break;
			case "AllAccounts":
				obj = JsonConvert.DeserializeObject <AllAccounts> (json);
				break;
			default:
				throw new Exception ("invalid type");
			}

			return obj;
		}

		public override string ToString ()
		{
			StringBuilder strData = new StringBuilder ();
			strData.AppendLine ("Response ( ");
			if (arrList [1] != null) {
				strData.AppendLine (arrList[1].ToString());
			}
			strData.AppendLine (")");
			return strData.ToString () + Environment.NewLine;
		}
	}
}
