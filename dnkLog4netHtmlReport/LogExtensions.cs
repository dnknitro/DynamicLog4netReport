﻿using System;
using System.Reflection;
using log4net;

namespace dnkLog4netHtmlReport
{
	public static class LogExtensions
	{
		public const string ScreenshotPathPropertyName = "ScreenshotPath";
		public const string BrowserPropertyName = "Browser";

		public static void Pass(this ILog log, string message, Exception ex = null)
		{
			log.Logger.Log(MethodBase.GetCurrentMethod().DeclaringType, LogLevel.Pass, message, ex);
		}

		public static void Fail(this ILog log, string message, Exception ex = null)
		{
			log.Logger.Log(MethodBase.GetCurrentMethod().DeclaringType, LogLevel.Fail, message, ex);
		}
	}
}