using System.Web;
using BrockAllen.MembershipReboot;
using BrockAllen.MembershipReboot.WebHost;

namespace IdSrv3.Models
{
    public class AspNetApplicationInformation : RelativePathApplicationInformation
    {
        public AspNetApplicationInformation(
          string appName,
          string emailSig,
          string relativeLoginUrl,
          string relativeConfirmChangeEmailUrl,
          string relativeCancelVerificationUrl,
          string relativeConfirmPasswordResetUrl
      )
        {
            this.ApplicationName = appName;
            this.EmailSignature = emailSig;
            this.RelativeLoginUrl = relativeLoginUrl;
            this.RelativeConfirmChangeEmailUrl = relativeConfirmChangeEmailUrl;
            this.RelativeCancelVerificationUrl = relativeCancelVerificationUrl;
            this.RelativeConfirmPasswordResetUrl = relativeConfirmPasswordResetUrl;
        }
        protected override string GetApplicationBaseUrl()
        {
            //This extension method binds the URL to the Membershipreboot config, so
            //the host URL can be retrieved after start up.
            return HttpContext.Current.GetApplicationUrl();
        }
    }
}