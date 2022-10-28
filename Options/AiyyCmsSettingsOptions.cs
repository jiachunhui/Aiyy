namespace Aiyy.Options;
/// <summary>
/// 系统选项
/// </summary>
public class AiyyCmsSettingsOptions : IConfigurableOptions
{
	/// <summary>
	/// 系统标题
	/// </summary>
	public string AdminTitle { get; set; }
	/// <summary>
	/// 版本号
	/// </summary>
	public string Version { get; set; } = "1.0.0";
	/// <summary>
	/// 版权
	/// </summary>
	public string Company { get; set; } = "ccxcn.com";
}

