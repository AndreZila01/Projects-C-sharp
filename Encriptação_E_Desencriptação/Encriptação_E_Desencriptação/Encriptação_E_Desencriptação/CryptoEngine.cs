using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptação_E_Desencriptação
{
	public class CryptoEngineC
	{
		public static string Encrypt(string input, string key)
		{
			try
			{
				byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
				TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
				tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
				tripleDES.Mode = CipherMode.ECB;
				tripleDES.Padding = PaddingMode.PKCS7;
				ICryptoTransform cTransform = tripleDES.CreateEncryptor();
				byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
				tripleDES.Clear();
				return Convert.ToBase64String(resultArray, 0, resultArray.Length);
			}
			catch (Exception ex)
			{
				return "ERRO 404!! \n" + ex.Message;
			}

		}
		public static string Decrypt(string input, string key)
		{
			try
			{
				byte[] inputArray = Convert.FromBase64String(input);
				TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
				tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
				tripleDES.Mode = CipherMode.ECB;
				tripleDES.Padding = PaddingMode.PKCS7;
				ICryptoTransform cTransform = tripleDES.CreateDecryptor();
				byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
				tripleDES.Clear();
				return UTF8Encoding.UTF8.GetString(resultArray);
			}
			catch (Exception ex)
			{
				return "ERRO 404!! \n" + ex.Message;
			}
		}
	}

	public class CrytoEngineB
	{
		public static string Encrypt(string input)
		{
			try
			{
				int BlockSize = 128;
				byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

				byte[] bytes = Encoding.Unicode.GetBytes(input);
				//Encrypt
				SymmetricAlgorithm crypt = Aes.Create();
				HashAlgorithm hash = MD5.Create();
				crypt.BlockSize = BlockSize;
				//crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(textBoxPassword.Text));
				crypt.IV = IV;

				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytes, 0, bytes.Length);
					}

					return Convert.ToBase64String(memoryStream.ToArray());
				}
			}
			catch (Exception ex)
			{
				return "ERRO 404!! \n" + ex.Message;
			}

		}
		public static string Decrypt(string input)
		{
			try
			{
				byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
				byte[] bytes = Convert.FromBase64String(input);

				SymmetricAlgorithm crypt = Aes.Create();
				HashAlgorithm hash = MD5.Create();
				//crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(textBoxPassword.Text));
				crypt.IV = IV;

				using (MemoryStream memoryStream = new MemoryStream(bytes))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
					{
						byte[] decryptedBytes = new byte[bytes.Length];
						cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
						return Encoding.Unicode.GetString(decryptedBytes);
					}
				}
			}
			catch (Exception ex)
			{
				return "ERRO 404!! \n" + ex.Message;
			}
		}
	}
}
