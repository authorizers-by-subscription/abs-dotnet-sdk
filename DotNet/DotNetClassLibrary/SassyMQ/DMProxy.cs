namespace EffortlessAPI.ABS.SassyMQ
{
    public class DMProxy
    {

        public string RoutingKey { get; set; }

        public DMProxy(string replyTo)
        {
            this.RoutingKey = replyTo;
        }
    }
}