using System;
using StructureMap.Configuration.DSL;

namespace WebApplication
{
	[CLSCompliant(false)]
	public class IoCRegistry : Registry
	{
		#region Constructors

		public IoCRegistry()
		{
			this.For<ITest>().Singleton().Use<Test>();
		}

		#endregion
	}
}