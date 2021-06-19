using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VesteBem_Admin.Class
{
	public class EncryptADeDecrypt
	{
        public static string EncryptRSA(string strText)
        {
            var publicKey = "<RSAKeyValue><Modulus>21wEnTU+mcD2w0Lfo1Gv4rtcSWsQJQTNa6gio05AOkV/Er9w3Y13Ddo5wGtjJ19402S71HUeN0vbKILLJdRSES5MHSdJPSVrOqdrll/vLXxDxWs/U0UT1c8u6k/Ogx9hTtZxYwoeYqdhDblof3E75d9n2F0Zvf6iTb4cI7j6fMs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

            var testData = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    // client encrypting data with public key issued by server                    
                    rsa.FromXmlString(publicKey.ToString());

                    var encryptedData = rsa.Encrypt(testData, true);

                    var base64Encrypted = Convert.ToBase64String(encryptedData);

                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static string DecryptRSA(string strText)
        {
            var privateKey = "<RSAKeyValue><Modulus>21wEnTU+mcD2w0Lfo1Gv4rtcSWsQJQTNa6gio05AOkV/Er9w3Y13Ddo5wGtjJ19402S71HUeN0vbKILLJdRSES5MHSdJPSVrOqdrll/vLXxDxWs/U0UT1c8u6k/Ogx9hTtZxYwoeYqdhDblof3E75d9n2F0Zvf6iTb4cI7j6fMs=</Modulus><Exponent>AQAB</Exponent><P>/aULPE6jd5IkwtWXmReyMUhmI/nfwfkQSyl7tsg2PKdpcxk4mpPZUdEQhHQLvE84w2DhTyYkPHCtq/mMKE3MHw==</P><Q>3WV46X9Arg2l9cxb67KVlNVXyCqc/w+LWt/tbhLJvV2xCF/0rWKPsBJ9MC6cquaqNPxWWEav8RAVbmmGrJt51Q==</Q><DP>8TuZFgBMpBoQcGUoS2goB4st6aVq1FcG0hVgHhUI0GMAfYFNPmbDV3cY2IBt8Oj/uYJYhyhlaj5YTqmGTYbATQ==</DP><DQ>FIoVbZQgrAUYIHWVEYi/187zFd7eMct/Yi7kGBImJStMATrluDAspGkStCWe4zwDDmdam1XzfKnBUzz3AYxrAQ==</DQ><InverseQ>QPU3Tmt8nznSgYZ+5jUo9E0SfjiTu435ihANiHqqjasaUNvOHKumqzuBZ8NRtkUhS6dsOEb8A2ODvy7KswUxyA==</InverseQ><D>cgoRoAUpSVfHMdYXW9nA3dfX75dIamZnwPtFHq80ttagbIe4ToYYCcyUz5NElhiNQSESgS5uCgNWqWXt5PnPu4XmCXx6utco1UVH8HGLahzbAnSy6Cj3iUIQ7Gj+9gQ7PkC434HTtHazmxVgIR5l56ZjoQ8yGNCPZnsdYEmhJWk=</D></RSAKeyValue>";

            var testData = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    var base64Encrypted = strText;

                    // server decrypting data with private key                    
                    rsa.FromXmlString(privateKey);

                    var resultBytes = Convert.FromBase64String(base64Encrypted);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
				catch
				{
                    return "Error ao converter a password";
				}
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

   //     public static string EncryptOther(string input)
   //     {
   //         string key = "sblw-3hn8-sqoy19";
   //         try
   //         {
   //             //byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);//string to bytes
   //             //TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
   //             //tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);//inserir a chave na variavel de encryptacao
   //             //tripleDES.Mode = CipherMode.CBC;//modo de encrytação?!?
   //             //tripleDES.Padding = PaddingMode.Zeros;//modo de encrytação?!?
   //             //ICryptoTransform cTransform = tripleDES.CreateEncryptor();
   //             //byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
   //             //tripleDES.Clear();
   //             //return Convert.ToBase64String(resultArray, 0, resultArray.Length);
   //             byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
   //             TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
   //             tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
   //             tripleDES.Mode = CipherMode.ECB;
   //             tripleDES.Padding = PaddingMode.PKCS7;
   //             ICryptoTransform cTransform = tripleDES.CreateEncryptor();
   //             byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
   //             tripleDES.Clear();
   //             return Convert.ToBase64String(resultArray, 0, resultArray.Length);
   //         }
   //         catch (Exception ex)
   //         {
   //             return "ERRO 404!! \n" + ex.Message;
   //         }

   //     }
   //     public static string DecryptOther(string input)
   //     {
   //         string key = "sblw-3hn8-sqoy19";
			//try
   //         {
   //             byte[] inputArray = Convert.FromBase64String(input);
   //             TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
   //             tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
   //             tripleDES.Mode = CipherMode.ECB;
   //             tripleDES.Padding = PaddingMode.PKCS7;
   //             ICryptoTransform cTransform = tripleDES.CreateDecryptor();
   //             byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
   //             tripleDES.Clear();
   //             return UTF8Encoding.UTF8.GetString(resultArray);
   //         }
   //         catch (Exception ex)
   //         {
   //             return "ERRO 404!! \n" + ex.Message;
   //         }
   //     }

    }

}
