using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

// UtilityService.svc
using System.ServiceModel;
using System.Security.Permissions;
using System.ServiceModel.Activation;
using System.Security.Principal;

using System.ServiceModel.Channels;
using System.Net;
namespace ServiceEngineDll
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceEngine" in both code and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode =AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceEngine : IServiceEngine
    {
        public ServiceEngine()
        {
            string name = "biswajit";
        }
        [PrincipalPermission(SecurityAction.Demand, Role = "ADMIN")]
        public string YourName(string name)
        {
            return string.Format("Hi! {0}",name);
        }
    }
}
