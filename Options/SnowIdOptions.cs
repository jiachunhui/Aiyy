namespace Aiyy.Options;
/// <summary>
///  雪花Id配置选项
/// </summary>
public class SnowIdOptions : IConfigurableOptions
{
	/// <summary>
	/// 机器码
	/// </summary>
	public ushort WorkerId { get; set; }
}
