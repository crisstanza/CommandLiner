using System;

namespace io.github.crisstanza.arguments
{
	[System.AttributeUsage(System.AttributeTargets.Property)]
	public class CommandLineArgumentAttribute : Attribute
	{
		public object DefaultValue { get; set; }
	}
}
