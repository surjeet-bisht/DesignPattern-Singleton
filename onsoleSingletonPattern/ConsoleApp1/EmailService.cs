using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class EmailService
	{
		private static EmailService _emailService;
		private static readonly object _lock = new object();
		private EmailService()
		{

		}
		public static EmailService getInstance
		{
			get
			{
				lock(_lock)
				{
					if (_emailService == null)
					{
						_emailService = new EmailService();
					}
					return _emailService;
				}
			
			}
		}
		private string getSMTPDetails()
		{
			return "smtp details";
		}
		public  void sendEmail()
		{
			Console.WriteLine(getSMTPDetails());
			Console.WriteLine("Email sent");
		}
	}
}
