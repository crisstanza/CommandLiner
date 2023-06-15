using System;

namespace io.github.crisstanza.commandliner
{
	[AttributeUsage(System.AttributeTargets.Property)]
	public class CommandLineArgumentAttribute : Attribute
	{
		public object DefaultValue { get; set; }
		public string EnvironmentVariable { get; set; }
	}
}
