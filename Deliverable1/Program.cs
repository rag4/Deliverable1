//Deliverable 1; 11/26/2020; Ramon Guarnes
using System;

namespace Deliverable1
{
	class Program
	{
		static void Main(string[] args)
		{
			// flags to keep track for existance of lowercase, uppercase, and exclamation point
			int lowerFlag = 0;
			int upperFlag = 0;
			int expFlag = 0;

			// read password from user input
			Console.WriteLine("Please enter a password: ");
			String password = Console.ReadLine();

			// check if password has minimum of 7 char and maximum of 12 char
			if (password.Length < 7) 
			{
				Console.WriteLine("Error");
				Environment.Exit(2);
			}
			if (password.Length > 12)
			{
				Console.WriteLine("Error");
				Environment.Exit(2);
			}

			// check for existance of lowercase, uppercase, and exclamation point
			for (int i = 0; i < password.Length; i++) 
			{
				if (Char.IsLower(password[i]) == true)
					lowerFlag += 1;
				if (Char.IsUpper(password[i]) == true)
					upperFlag += 1;
				if (password[i].Equals('!') == true)
					expFlag += 1;
			}

			// error if any flag equals 0
			if ((lowerFlag == 0) || (upperFlag == 0) || (expFlag == 0)) 
			{
				Console.WriteLine("Error");
				Environment.Exit(2);
			}

			//success
			Console.WriteLine("Password valid and accepted");
		}
	}
}
