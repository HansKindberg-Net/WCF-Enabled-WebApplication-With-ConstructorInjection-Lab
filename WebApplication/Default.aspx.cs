using System;
using System.Collections.Generic;
using System.Globalization;

namespace WebApplication
{
	public partial class Default : System.Web.UI.Page
	{
		#region Fields

		private const int _numberOfItems = 100;
		private IDictionary<string, string> _options;

		#endregion

		#region Properties

		protected virtual IDictionary<string, string> Options
		{
			get
			{
				if (this._options == null)
				{
					this._options = new Dictionary<string, string> { { string.Empty, string.Empty } };

					for (int i = 1; i <= _numberOfItems; i++)
					{
						this._options.Add(i.ToString(CultureInfo.InvariantCulture), "Item " + i.ToString(CultureInfo.InvariantCulture));
					}
				}

				return this._options;
			}
		}

		#endregion

		#region Eventhandlers

		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender(e);

			if (!this.IsPostBack)
				this.optionRepeater.DataBind();
		}

		#endregion
	}
}