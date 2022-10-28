namespace Aiyy.Entitys;
/// <summary>
/// Microsoft IIS Administration API 服务器
/// </summary>
[Table("aiyy_webserver")]
public class WebServer : Entity
{
	/// <summary>
	/// 名称
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	/// 备注说明
	/// </summary>
	public string Note { get; set; }
	/// <summary>
	/// 是否启用
	/// </summary>
	public bool IsEnable { get; set; } = true;
	/// <summary>
	/// 协议 http https
	/// </summary>
	public string Protocols { get; set; }
	/// <summary>
	/// 服务器Ip
	/// </summary>
	public string IP { get; set; }
	/// <summary>
	/// 端口 55539
	/// </summary>
	public string Port { get; set; }
	/// <summary>
	/// AccessKeyName
	/// </summary>
	public string AccessKeyName { get; set; }
	/// <summary>
	/// AccessKey 到期
	/// </summary>
	public DateTime AccessKeyExpiresTime { get; set; }
	/// <summary>
	/// AccessKey 加密后的内容
	/// </summary>
	public string AccessKeys { get; set; }
}
