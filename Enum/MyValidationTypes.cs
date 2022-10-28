using System.Text.RegularExpressions;

namespace Aiyy.Enum
{
	[ValidationType]
	public enum MyValidationTypes
	{
		/// <summary>
		/// 强密码类型
		/// </summary>
		[ValidationItemMetadata(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,10}$", "必须须包含大小写字母和数字的组合，不能使用特殊字符，长度在8-10之间")]
		StrongPassword,
		/// <summary>
		/// 以 Furion 字符串开头，忽略大小写
		/// </summary>
		[ValidationItemMetadata(@"^(qws).[0-9]{15}", "默认提示：必须以qwe字符串开头，忽略大小写,后加15位数字", RegexOptions.IgnoreCase)]
		StartWithQweString,
		/// <summary>
		/// 域名
		/// </summary>
		/// 
		[ValidationItemMetadata(@"^[a-zA-Z0-9][-a-zA-Z0-9]{0,62}(\.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+$", "默认提示：域名格式不对", RegexOptions.IgnoreCase)]
		DomainName,
	}
}
