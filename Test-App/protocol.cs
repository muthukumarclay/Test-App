using System;
using core;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace protocol.admin
{
	using AccountId = System.UInt32;

	public class Ping
	{
		public override string ToString()
		{
			return String.Format("Ping") + Environment.NewLine;
		}
	}

	public class RegisterAccount
	{
		public string account_holder_name { get; set; }

		public double initial_balance { get; set; }

		public override string ToString()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append("RegisterAccount ( ");
			strData.AppendFormat ("account_holder_name: {0}, ", account_holder_name);
			strData.AppendFormat ("initial_balance: {0} ", account_holder_name);
			strData.Append(")");
			return strData.ToString() + Environment.NewLine;
		}
	}

	public class LookupAccount
	{
		public AccountId account_id { get; set; }

		public override string ToString()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append("LookupAccount ( ");
			strData.AppendFormat ("account_id: {0} ", account_id);
			strData.Append(")");
			return strData.ToString()  + Environment.NewLine;
		}
	}

	public class TransferAmount
	{
		public AccountId from_account_id { get; set; }

		public AccountId to_account_id { get; set; }

		public double amount { get; set; }

		public override string ToString()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append("TransferAmount ( ");
			strData.AppendFormat("from_account_id: {0}, ", from_account_id);
			strData.AppendFormat ("to_account_id: {0}, ", to_account_id);
			strData.AppendFormat ("amount: {0} ", amount);
			strData.Append(")");
			return strData.ToString() + Environment.NewLine;
		}
	}

	public class ListAllAccounts
	{
		public override string ToString()
		{
			return String.Format("ListAllAccounts") + Environment.NewLine;
		}
	}

	public class Request
	{
		public string toJSON (Object obj)
		{
			return "{ \"data\": [ \"" + obj.GetType ().Name + "\", " + JsonConvert.SerializeObject (obj) + "] }";
		}

		public object parseJSON (string json)
		{
			var data = Newtonsoft.Json.Linq.JObject.Parse (json);
			json = data ["data"] [1].ToString ();
			Object obj;

			switch (data ["data"] [0].ToString ()) {
			case "Ping":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <Ping> (json);
				break;
			case "RegisterAccount":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <RegisterAccount> (json);
				break;
			case "LookupAccount":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <LookupAccount> (json);
				break;
			case "TransferAmount":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <TransferAmount> (json);
				break;
			case "ListAllAccounts":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <ListAllAccounts> (json);
				break;
			default:
				throw new Exception ("invalid type");
			}

			return obj;
		}
	}

	public class Pong
	{
		public override string ToString()
		{
			return "Pong" + Environment.NewLine;
		}
	}

	public class Error
	{
		public string message { get; set; }

		public override string ToString()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append("Error ( ");
			strData.AppendFormat ("message: {0} ", message);
			strData.Append(") ");
			return strData.ToString() + Environment.NewLine;
		}
	}

	public class AccountInfo
	{
		public core.Account account { get; set; }

		public override string ToString()
		{
			StringBuilder strData = new StringBuilder ();
			strData.AppendLine("AccountInfo ( ");
			strData.AppendFormat ("account: {0}", account);
			strData.AppendLine(")");
			return strData.ToString() + Environment.NewLine;
		}
	}

	public class TransferSuccess
	{
		public override string ToString()
		{
			return "TransferSuccess" + Environment.NewLine;
		}
	}

	public class TransferFailed
	{
		public string message { get; set; }

		public override string ToString()
		{
			StringBuilder strData = new StringBuilder ();
			strData.Append("TransferFailed ( ");
			strData.AppendFormat ("message: {0} ", message);
			strData.Append(")");
			return strData.ToString() + Environment.NewLine;
		}
	}

	public class AllAccounts
	{
		public List<core.Account> accounts { get; set; }

		public override string ToString()
		{
			StringBuilder strData = new StringBuilder ();
			strData.AppendLine("AllAccounts ( ");
			strData.AppendLine ("accounts: [");
			foreach (Account acc in accounts) {
				strData.AppendLine (acc.ToString());
			}
			strData.AppendLine("]");
			strData.AppendLine(")");
			return strData.ToString() + Environment.NewLine;
		}
	}

	public class Response
	{
		public string toJSON (Object obj)
		{
			return "{ data: [ \"" + obj.GetType ().Name + "\", " + JsonConvert.SerializeObject (obj) + "] }";
		}

		public object parseJSON (string json)
		{
			var data = Newtonsoft.Json.Linq.JObject.Parse (json);
			json = data ["data"] [1].ToString ();

			Object obj;

			switch (data ["data"] [0].ToString ()) {
			case "Pong":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <Pong> (json);
				break;
			case "Error":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <Error> (json);
				break;
			case "AccountInfo":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <AccountInfo> (json);
				break;
			case "TransferSuccess":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <TransferSuccess> (json);
				break;
			case "TransferFailed":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <TransferFailed> (json);
				break;
			case "AllAccounts":
				obj = Newtonsoft.Json.JsonConvert.DeserializeObject <AllAccounts> (json);
				break;
			default:

				throw new Exception ("invalid type");
			}

			return obj;
		}
	}
}
