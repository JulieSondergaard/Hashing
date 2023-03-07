using Hashing;
using System.Security.Cryptography;

internal class Program
{

	private static void Main(string[] args)
	{
		Program program = new Program();
		bool repeat = true;
		string error = "";

		while (repeat)
		{
			int menuInput = program.GetMenu();
			// Console.Clear();

			if (menuInput > 0 && menuInput < 6)
			{
				Console.WriteLine("Enter key:");
				string keyInput = Console.ReadLine();

			
				if (keyInput != null)
				{
					switch (menuInput)
					{
						case 1:
							Console.WriteLine("MD5");
							using (MD5 md5 = MD5.Create())
							{
								Console.WriteLine(Hash.GetHashedValue(md5, keyInput));
							}
							break;
						case 2:
							Console.WriteLine("SHA1");
							using (SHA1 sha1 = SHA1.Create())
							{
								Console.WriteLine(Hash.GetHashedValue(sha1, keyInput));
							}
							break;
						case 3:
							Console.WriteLine("SHA256");
							using (SHA256 sha256 = SHA256.Create())
							{
								Console.WriteLine(Hash.GetHashedValue(sha256, keyInput));
							}
							break;
						case 4:
							Console.WriteLine("SHA384");
							using (SHA384 sha384 = SHA384.Create())
							{
								Console.WriteLine(Hash.GetHashedValue(sha384, keyInput));
							}
							break;
						case 5:
							Console.WriteLine("SHA512");
							using (SHA512 sha512 = SHA512.Create())
							{
								Console.WriteLine(Hash.GetHashedValue(sha512, keyInput));
							}
							break;
						default: Console.WriteLine("Something went wrong.");
							break;
					}


				}
				else
				{
					Console.Clear();
					error = program.ErrorMessage();
				}
			}
			else
			{
				Console.Clear();
				error = program.ErrorMessage();
			}
			Console.WriteLine(error);
			Thread.Sleep(2000);
			
		}

	}
	public string ErrorMessage()
	{
		string text = "Something went wrong. Try again.";

		return text;
	}
	public int GetMenu()
	{
		Console.WriteLine($"Choose algorithm:\n" +
				"1: MD5\n" +
				"2: SHA1\n" +
				"3: SHA256\n" +
				"4: SHA384\n" +
				"5: SHA512\n");
		int input = int.Parse(Console.ReadLine());

		return input;
	}



}