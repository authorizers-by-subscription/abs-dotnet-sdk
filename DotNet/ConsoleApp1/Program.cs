using EffortlessAPI.SSio.SassyMQ;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var amqps = "amqps://smqPublic:smqPublic@effortlessapi-rmq.ssot.me/ej-authorizersbysubscription";
            var guest = new SMQGuest(amqps);
            var payload = guest.CreatePayload();
            payload.EmailAddress = "nathaniel@nholder.com";
            payload.DemoPassword = "2c4057a18b0834e59a38e1890c09503e2f29ef0019159fc76a9a43427d42d754";
            var waiting = false;
            guest.ValidateTemporaryAccessToken(payload, (reply, bdea) =>
            {
                if (!String.IsNullOrEmpty(reply.ErrorMessage)) throw new Exception("Invalid username/password");
                var user = new SMQSSioUser (amqps);
                user.AccessToken = reply.AccessToken;
                payload = user.CreatePayload();

                user.GetLicenseBundles(payload, (nsReply, nsBdea) =>
                {
                    Console.WriteLine(JsonConvert.SerializeObject(nsReply.LicenseBundles, Formatting.Indented));
                    waiting = false;
                }, (error, ebdea) =>
                {
                    Console.WriteLine("ERROR: {0}", error.ErrorMessage);
                    waiting = false;
                });
            }, (error, ebdea) =>
            {
                Console.WriteLine("ERROR: {0}", error.ErrorMessage);
                    waiting = false;
            });
            Task.Factory.StartNew(() =>
            {
                while (waiting)
                {
                    Thread.Sleep(10);
                }
            }).Wait();
        }
    }
}
