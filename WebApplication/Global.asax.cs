using System;
using System.ServiceModel.Activation;
using System.Web.Routing;
using WebApplication.Services;

namespace WebApplication
{
	public class Global : System.Web.HttpApplication
	{
		#region Methods

		protected void Application_Start(object sender, EventArgs e)
		{
			Bootstrapper.Bootstrap();
			RouteTable.Routes.Add(new ServiceRoute("Services/OrganizationService", new WebServiceHostFactory(), typeof(OrganizationService)));
		}

		#endregion
	}
}