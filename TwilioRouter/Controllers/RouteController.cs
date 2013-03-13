using System.Web;
using System.Web.Mvc;
using Twilio;
namespace TwilioRouter.Controllers
{
    public class RouteController : Controller
    {
        //
        // GET: /Route/

        public ActionResult SMS()
        {
            string AccountSid = "AC466fd9c5fb1ec783e26fd56c3b25970b";
            string AuthToken = "896c359e5a927cbddc2a38d36f1a264c";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            var options = new CallOptions();
            options.Url = "http://twiliorouter.apphb.com/Route/SMSInstructions?Message=" + HttpUtility.UrlEncode(Request["Body"]);
            //options.To = "+17202808698";
            options.To = Request["From"];
            options.From = "+17202591415";
            var call = twilio.InitiateOutboundCall(options);
            //Response.Write(options.Url);
            //Console.WriteLine(call.Sid);
            return View();
        }

        public ActionResult SMSInstructions()
        {
            ViewBag.Message = HttpUtility.UrlDecode(Request["Message"]);
            return View();
        }
    }
}
