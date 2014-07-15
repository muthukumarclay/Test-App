using System;
using System.Net;
using System.IO;
using System.Text;
using protocol.admin;

namespace TestApp
{
	public static class Util
	{
		public const string ADMIN_API_URL = "http://localhost:8080/api";

		public static object api_request (object webrequest_value)
		{
			try {
				Request request = new Request();
				string strBody = request.toJSON (webrequest_value);

				ASCIIEncoding encoding = new ASCIIEncoding ();
				Uri url = new Uri (ADMIN_API_URL);
				WebRequest webrequest = WebRequest.CreateDefault (url);
				webrequest.Method = "POST";
				byte[] arr = encoding.GetBytes (strBody);

				webrequest.ContentType = "application/json";
				webrequest.ContentLength = arr.Length;

				Stream dataStream = webrequest.GetRequestStream();
				dataStream.Write (arr, 0, arr.Length);
				dataStream.Close ();

				WebResponse webresponse = webrequest.GetResponse ();
				StreamReader stream = new StreamReader (webresponse.GetResponseStream ());
				string json = stream.ReadToEnd ();

				Response response = new Response();
				return response.parseJSON(json);
			} catch (WebException ex) {
				Console.WriteLine ("http errror: " + ex.Message);
			}

			return "";
		}
		
	}
}
