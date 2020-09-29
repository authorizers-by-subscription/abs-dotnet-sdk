using EffortlessAPI.SSio.ssio;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using SmartSubs.io.Lib;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace EffortlessAPI.SSio.SassyMQ
{
    public partial class StandardPayload : IStandardPayload
    {
        public const int DEFAULT_TIMEOUT = 30;

        public StandardPayload()
            : this(default(SMQActorBase))
        {

        }

        public StandardPayload(SMQActorBase actor)
            : this(actor, String.Empty)
        {

        }
        
        public StandardPayload(SMQActorBase actor, string content)
            : this(actor, content, true)
        {
        }
        
        public string PayloadId { get; set; }
        public string SenderId { get; set; }
        public string SenderName { get; set; }

        internal bool HasNoError(BasicDeliverEventArgs bdea)
        {
            if (!String.IsNullOrEmpty(this.ErrorMessage)) throw new Exception(this.ErrorMessage);
            else return true;
        }

        public string AccessToken { get; set; }
        public string Content { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsHandled { get; set; }
        

        private SMQActorBase __Actor { get; set; }
        private bool TimedOutWaiting { get; set; }
        private StandardPayload ReplyPayload { get; set; }
        private BasicDeliverEventArgs ReplyBDEA { get; set; }
        private bool ReplyRecieved { get; set; }
        
        public DateTime OnlineSince { get; set; }
        public string EmailAddress { get; set; }
        public string DemoPassword { get; set; }
        public string AirtableWhere { get; set; }
        public void SetActor(SMQActorBase actor) 
        {
            this.__Actor = actor;
        }

        public bool HasNoErrors(BasicDeliverEventArgs bdea)
        {
            if (String.IsNullOrEmpty(this.ErrorMessage)) return true;
            else throw new Exception(this.ErrorMessage);
        }
    }
}