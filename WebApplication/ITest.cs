using System.Collections.Generic;

namespace WebApplication
{
	public interface ITest
	{
		#region Properties

		IEnumerable<string> GetList(string itemPrefix);

		#endregion
	}
}