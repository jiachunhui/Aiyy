
namespace Aiyy.Entitys;
/// <summary>
/// 系统操作日志表
/// </summary>
[Table("aiyy_sys_log_op")]
public class SysLogOp : Entity
{
	/// <summary>
	/// 记录器类别名称
	/// </summary>
	[MaxLength(256)]
	public string LogName { get; set; }

	/// <summary>
	/// 日志级别
	/// </summary>
	[MaxLength(16)]
	public string LogLevel { get; set; }

	/// <summary>
	/// 事件Id
	/// </summary>
	public string EventId { get; set; }

	/// <summary>
	/// 日志消息
	/// </summary>
	public string Message { get; set; }

	/// <summary>
	/// 异常对象
	/// </summary>
	public string Exception { get; set; }

	/// <summary>
	/// 当前状态值
	/// </summary>
	public string State { get; set; }

	/// <summary>
	/// 日志记录时间
	/// </summary>
	public DateTime LogDateTime { get; set; }

	/// <summary>
	/// 线程Id
	/// </summary>
	public int ThreadId { get; set; }
}