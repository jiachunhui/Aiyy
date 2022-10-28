namespace Aiyy.Utils
{
	public static class TranslateUtils
	{
		/// <summary>
		/// 加密
		/// </summary>
		/// <param name="inputString"></param>
		/// <param name="secretKey"></param>
		/// <returns></returns>
		public static string EncryptStringBySecretKey(string inputString, string secretKey)
		{
			if (string.IsNullOrEmpty(inputString)) return string.Empty;

			try
			{
				var encryptor = new DesEncryptor
				{
					InputString = inputString,
					EncryptKey = secretKey
				};
				encryptor.DesEncrypt();

				var retVal = encryptor.OutString;
				retVal = retVal.Replace("+", "0add0").Replace("=", "0equals0").Replace("&", "0and0").Replace("?", "0question0").Replace("'", "0quote0").Replace("/", "0slash0");

				return retVal + Constants.EncryptStingIndicator;
			}
			catch
			{
				// ignored
			}

			return string.Empty;
		}
		/// <summary>
		/// 解密
		/// </summary>
		/// <param name="inputString"></param>
		/// <param name="secretKey"></param>
		/// <returns></returns>
		public static string DecryptStringBySecretKey(string inputString, string secretKey)
		{
			if (string.IsNullOrEmpty(inputString)) return string.Empty;

			try
			{
				inputString = inputString.Replace(Constants.EncryptStingIndicator, string.Empty).Replace("0add0", "+")
					.Replace("0equals0", "=").Replace("0and0", "&").Replace("0question0", "?").Replace("0quote0", "'")
					.Replace("0slash0", "/");

				var encryptor = new DesEncryptor
				{
					InputString = inputString,
					DecryptKey = secretKey
				};
				encryptor.DesDecrypt();

				return encryptor.OutString;
			}
			catch
			{
				// ignored
			}

			return string.Empty;
		}
	}
}
