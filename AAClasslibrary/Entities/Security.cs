﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
	public class Security
	{
		private const int keySize = 64;
		private const int iterations = 350000;
		private readonly static HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

		public string CreateSalt()
		{
			byte[] salt_bytes = RandomNumberGenerator.GetBytes(keySize);
			string salt = Convert.ToHexString(salt_bytes);
			return salt;
		}

		public string CreateHash(string salt, string password)
		{
			byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
				Encoding.UTF8.GetBytes(password),
				Convert.FromHexString(salt),
				iterations,
				hashAlgorithm,
				keySize);
			return Convert.ToHexString(hash);
		}
	}
}
