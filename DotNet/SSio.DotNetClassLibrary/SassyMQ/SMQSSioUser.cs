using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Framing;
using RabbitMQ.Client.MessagePatterns;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace EffortlessAPI.SSio.SassyMQ
{                   
    public partial class SMQSSioUser
    {
        private static string C_AMQPS = "amqps://smqPublic:smqPublic@effortlessapi-rmq.ssot.me/ej-authorizersbysubscription";

        public static SMQSSioUser GetDemoABSUser(string emailAddress, string demoPassword)
        {
            var guest = new SMQGuest(C_AMQPS);
            var payload = guest.CreatePayload();
            payload.EmailAddress = emailAddress;
            payload.DemoPassword = demoPassword;
            SMQSSioUser smqABSUser = ValidateTemporaryAccessToken(guest, payload);
            return smqABSUser;
        }

        private static SMQSSioUser ValidateTemporaryAccessToken(SMQGuest guest, StandardPayload payload)
        {
            var smqABSUser = default(SMQSSioUser);
            guest.ValidateTemporaryAccessToken(payload, (reply, bdea) =>
            {
                if (reply.HasNoError(bdea))
                {
                    smqABSUser = FromAccessToken(reply.AccessToken);
                }
            }).Wait(30000);
            return smqABSUser;
        }

        public static SMQSSioUser FromAccessToken(string accessToken)
        {
            var smqABSUser = new SMQSSioUser(C_AMQPS);
            smqABSUser.AccessToken = accessToken;
            return smqABSUser;
        }

    }
}
                    
