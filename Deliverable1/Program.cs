using System;

namespace Deliverable1
{
	class Program
	{
		static void Main(string[] args)
		{
			int lowerFlag = 0;
			int upperFlag = 0;
			int expFlag = 0;

			Console.WriteLine("Please enter a password: ");
			String password = Console.ReadLine();

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

			for (int i = 0; i < password.Length; i++) 
			{
				if (Char.IsLower(password[i]) == true)
					lowerFlag += 1;
				if (Char.IsUpper(password[i]) == true)
					upperFlag += 1;
				if (password[i].Equals('!') == true)
					expFlag += 1;
			}

			if ((lowerFlag == 0) || (upperFlag == 0) || (expFlag == 0)) 
			{
				Console.WriteLine("Error");
				Environment.Exit(2);
			}

			Console.WriteLine("Password valid and accepted");
		}
	}
}
