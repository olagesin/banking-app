﻿using System;

namespace Banking_App
{
    public class BankOperations
	{
		public void LandingPage()
		{
			Console.WriteLine("Hello, welcome to the Best Bank");
			Console.WriteLine("what would you like to do?");
			Console.WriteLine("1. Login");
			Console.WriteLine("2. Sign Up");
			string user_input = Console.ReadLine();
			switch (user_input)
			{
				case "1":
					AccessPage.Login();
					break;
				case "2":
					var signupDetails = AccessPage.SignUp();
					break;
			}
		}


}
}
	
