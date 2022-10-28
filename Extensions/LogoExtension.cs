using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiyy.Extensions;
/// <summary>
/// logo显示
/// </summary>
public static class LogoExtension
{
	public static void AddLogoDisplay(this IServiceCollection services)
	{
		Console.ForegroundColor = ConsoleColor.Blue;

		Console.WriteLine(@"AIYY.CMS 后台管理服务");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine(@"让.NET更简单、更通用、更流行！");
	}
}
