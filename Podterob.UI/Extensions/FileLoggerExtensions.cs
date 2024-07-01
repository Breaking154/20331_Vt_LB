using Podterob.UI.Middleware;

namespace Podterob.UI.Extensions
{
	public static class FileLoggerExtensions
	{
		public static IApplicationBuilder UseFileLogger(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<FileLogger>();
		}
	}
}
