﻿using System.Web.Mvc;
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
            string AuthToken = "{{ auth_token }}";
            var twilio = new TwilioRestClient(AccountSid, AuthToken);

            var options = new CallOptions();
            options.Url = "http://demo.twilio.com/docs/voice.xml";
            options.To = "+17202808698";
            options.From = "+17202591415";
            var call = twilio.InitiateOutboundCall(options);

            //Console.WriteLine(call.Sid);
            return View();
        }

    }
}