using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace Hashing
{
	internal class Hash
	{
		public byte[] Key { get; set; }


		//public string GetHashValue(byte[] key)
		//{
		//	MD5CryptoServiceProvider md5 = MD5CryptoServiceProvider.Create();
		//	RandomNumberGenerator rnd = new RandomNumberGenerator();
		//}

		public static string GetHashedValue(HashAlgorithm hashAlgorithm, string keyInput)
		{
			
			var stringBuilder = new StringBuilder();
			byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(keyInput));
			for (int i = 0; i < data.Length; i++)
			{
				stringBuilder.Append(data[i].ToString("x2"));
			}
		
			return stringBuilder.ToString();
		}
	}
}
