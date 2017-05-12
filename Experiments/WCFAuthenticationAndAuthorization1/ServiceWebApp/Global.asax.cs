using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

using System.ServiceModel.Channels;
using System.Net;
using System.ServiceModel;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace ServiceWebApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            System.Web.ApplicationServices.AuthenticationService.Authenticating +=
                new EventHandler<System.Web.ApplicationServices.AuthenticatingEventArgs>(
                AuthenticationService_Authenticating);

            ServicePointManager.ServerCertificateValidationCallback +=
            new RemoteCertificateValidationCallback(ValidateCertificate);


        }
        public static bool ValidateCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        private void AuthenticationService_Authenticating(object sender, System.Web.ApplicationServices.AuthenticatingEventArgs e)
        {
            //string roles = string.Empty;
            //e.Authenticated = new UserValidator().IsUserValid(e.UserName, e.Password, out roles);
            //e.AuthenticationIsComplete = true;

            //if (e.Authenticated)
            //{
            //    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
            //        1,
            //        e.UserName,
            //        DateTime.Now,
            //        DateTime.Now.AddHours(24),
            //        true,
            //        roles,
            //        FormsAuthentication.FormsCookiePath);

            //    // Encrypt the ticket using machine key
            //    string encryptedValue = FormsAuthentication.Encrypt(ticket);

            //    // Attach Cookie to Operation Context header
            //    HttpResponseMessageProperty response = new HttpResponseMessageProperty();
            //    response.Headers[HttpResponseHeader.SetCookie] = FormsAuthentication.FormsCookieName + "=" + encryptedValue;
            //    OperationContext.Current.OutgoingMessageProperties[HttpResponseMessageProperty.Name] = response;
                
            //}

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}