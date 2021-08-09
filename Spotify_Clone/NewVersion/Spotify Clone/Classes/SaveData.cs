using System;using System.IO;using System.Security.Cryptography;using System.Text;public class EncryptADeDecrypt{public static string EncryptOther(string input){try{byte[]inputArray=UTF8Encoding.UTF8.GetBytes(input);TripleDESCryptoServiceProvider tripleDES=new TripleDESCryptoServiceProvider();tripleDES.Key=UTF8Encoding.UTF8.GetBytes("sblw-3hn8-sqoy19");tripleDES.Mode=CipherMode.ECB;tripleDES.Padding=PaddingMode.PKCS7;ICryptoTransform cTransform=tripleDES.CreateEncryptor();byte[]resultArray=cTransform.TransformFinalBlock(inputArray,0,inputArray.Length);tripleDES.Clear();return EncryptString(Spotify_Clone.Properties.Resources.Key,Convert.ToBase64String(resultArray,0,resultArray.Length));}catch (Exception ex){return ex.Message;}}
	public static string DecryptOther(string input)
	{
		try
		{
			byte[]inputArray=Convert.FromBase64String(input);
			TripleDESCryptoServiceProvider tripleDES=new TripleDESCryptoServiceProvider();
			tripleDES.Key=UTF8Encoding.UTF8.GetBytes("sblw-3hn8-sqoy19");
			tripleDES.Mode=CipherMode.ECB;
			tripleDES.Padding=PaddingMode.PKCS7;
			ICryptoTransform cTransform=tripleDES.CreateDecryptor();
			byte[]resultArray=cTransform.TransformFinalBlock(inputArray,0,inputArray.Length);
			tripleDES.Clear();
			return UTF8Encoding.UTF8.GetString(resultArray);
		}
		catch (Exception ex)
		{
			return "ERRO 404!! \n" + ex.Message;
		}
	}
	public static string EncryptString(string key,string plainInput){byte[]iv=new byte[16];byte[]array;using (Aes aes=Aes.Create()){aes.Key=Encoding.UTF8.GetBytes(key);aes.IV=iv;ICryptoTransform encryptor=aes.CreateEncryptor(aes.Key,aes.IV);using (MemoryStream memoryStream=new MemoryStream()){using (CryptoStream cryptoStream=new CryptoStream((Stream)memoryStream,encryptor,CryptoStreamMode.Write)){using (StreamWriter streamWriter=new StreamWriter((Stream)cryptoStream)){streamWriter.Write(plainInput);}array=memoryStream.ToArray();}}}return Convert.ToBase64String(array);}public static string DecryptString(string key,string cipherText){byte[]iv=new byte[16];byte[]buffer=Convert.FromBase64String(cipherText);using (Aes aes=Aes.Create()){aes.Key=Encoding.UTF8.GetBytes(key);aes.IV=iv;ICryptoTransform decryptor=aes.CreateDecryptor(aes.Key,aes.IV);using (MemoryStream memoryStream=new MemoryStream(buffer)){using (CryptoStream cryptoStream=new CryptoStream((Stream)memoryStream,decryptor,CryptoStreamMode.Read)){using (StreamReader streamReader=new StreamReader((Stream)cryptoStream)){return DecryptOther((streamReader.ReadToEnd()));}}}}}}