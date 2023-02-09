using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp_Assign2
{
	public class Email
	{
		private string clientEmail;
		public string ClientEmail
		{
			get { return clientEmail; }
			set { clientEmail = value; }
		}

		public Email()
		{
			clientEmail = "";
		}
		public Email(string clientEmail)
		{
			this.clientEmail = clientEmail;
		}

	}
}
