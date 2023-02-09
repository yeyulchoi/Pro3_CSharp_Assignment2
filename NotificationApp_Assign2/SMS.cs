using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApp_Assign2
{
	public class SMS
	{
		private string sms;

		public string Sms
		{
			get
			{
				return sms;
			}
			set
			{
				sms = value;
			}
		}
		public SMS()
		{
			this.sms = " ";
		}
		public SMS(string sms)
		{
			this.sms = sms;	
		}	
	}
}
