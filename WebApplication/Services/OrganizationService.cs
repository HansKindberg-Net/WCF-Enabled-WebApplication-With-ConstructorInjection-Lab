using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WebApplication.Services
{
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
	public class OrganizationService
	{
		#region Fields

		private readonly ITest _test;

		#endregion

		#region Constructors

		public OrganizationService(ITest test)
		{
			if(test == null)
				throw new ArgumentNullException("test");

			this._test = test;
		}

		#endregion

		#region Methods

		[WebGet(UriTemplate = "Find?CostCenterCriteria={costCenterCriteria}", ResponseFormat = WebMessageFormat.Json)]
		public virtual IEnumerable<string> Find(string costCenterCriteria)
		{
			if (costCenterCriteria == "WebFaultException")
				throw new WebFaultException<string>("Custom exception", HttpStatusCode.GatewayTimeout);

			if (costCenterCriteria == "FaultException")
				throw new FaultException("Default exception", FaultCode.CreateSenderFaultCode("hej", "hej"));

			return this._test.GetList(costCenterCriteria);
		}

		#endregion
	}
}