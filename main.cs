using System;
using System.Text;
using System.Net;
using System.Collections.Specialized;

public class Program
{	
	public static void Main()
	{
		using (var wb = new WebClient())
		{
			var data = new NameValueCollection();
			data["connection_id"] = "... My Connection ID ...";
			data["password"]      = "... My Connection Password ...";
			data["to"]            = "07xyzzzzzz";
			data["message"]       = "Test Message";
			
			var response = wb.UploadValues("https://secure.smslink.ro/sms/gateway/communicate/index.php", "POST", data);
			string responseInString = Encoding.UTF8.GetString(response);

			Console.WriteLine(responseInString);			
		}		
	}	
}