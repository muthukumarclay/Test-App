using System;
using System.Net;
using System.IO;
using System.Text;
using Microsoft.CSharp;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestApp
{
	public static class Util
	{
		public const string ADMIN_API_URL = "http://localhost:8080/api";
		public const bool DEBUG = true;

		public static object api_request (dynamic webrequest_value, dynamic response)
		{
			try {
				string strBody = webrequest_value.toJson ();
				strBody = "{ \"data\": " + strBody + " }";

				if (DEBUG) {
					Console.WriteLine ("SENDING JSON");
					Console.WriteLine (strBody);
				}

				ASCIIEncoding encoding = new ASCIIEncoding ();
				Uri url = new Uri (ADMIN_API_URL);
				WebRequest webrequest = WebRequest.CreateDefault (url);
				webrequest.Method = "POST";
				byte[] arr = encoding.GetBytes (strBody);

				webrequest.ContentType = "application/json";
				webrequest.ContentLength = arr.Length;

				Stream dataStream = webrequest.GetRequestStream ();
				dataStream.Write (arr, 0, arr.Length);
				dataStream.Close ();

				WebResponse webresponse = webrequest.GetResponse ();
				StreamReader stream = new StreamReader (webresponse.GetResponseStream ());
				string json = stream.ReadToEnd ();

				if (DEBUG) {
					Console.WriteLine ("RECEIVED JSON");
					Console.WriteLine (json);
				}

				Dictionary<string, object> fields = JsonConvert.DeserializeObject<Dictionary<string, object>> (json);
				json = JsonConvert.SerializeObject (fields ["data"]);
				return response.parseJson (json);
			} catch (WebException ex) {
				Console.WriteLine ("http errror: " + ex.Message);
				StreamReader stream = new StreamReader (ex.Response.GetResponseStream ());
				Console.WriteLine (stream.ReadToEnd ());
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
			}

			return "";
		}
	}
}
