using System.Collections.Generic;
using System.Linq;

namespace WebApplication
{
	public class Test : ITest
	{
		private readonly IEnumerable<string> _list;

		public Test()
		{
			this._list = new string[]{ "A", "B", "C", "D", "E", "F"};
		}

		#region Properties

		public virtual IEnumerable<string> GetList(string itemPrefix)
		{
			if(string.IsNullOrEmpty(itemPrefix))
				return this._list;

			return this._list.Select(item => itemPrefix + ": " + item);
		}

		#endregion
	}
}