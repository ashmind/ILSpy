using System;

namespace ICSharpCode.Decompiler.Tests.TestCases.Correctness
{
	static class OperatorOverloading
	{
		class ExplicitCastSource
		{
			public static explicit operator uint? (ExplicitCastSource foo)
			{
				return 1;
			}
		}

		static void Main()
		{
			ExplicitCast();
		}

		static void ExplicitCast()
		{
			var x = (uint?)((ExplicitCastSource)null);
			Console.WriteLine("ExplicitCast(" + x + ")");
		}
	}
}
