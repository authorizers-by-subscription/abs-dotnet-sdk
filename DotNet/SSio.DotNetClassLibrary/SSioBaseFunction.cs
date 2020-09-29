using ssio = EffortlessAPI.SSio.SassyMQ;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using System;
using System.Text;
using Amazon.Lambda.Core;
using System.Collections.Generic;

namespace SmartSubs.io.Lib
{
    public abstract class SSioBaseFunction<T> : BaseFunction<T, ssio.StandardPayload>
        where T : IStandardPayload, new()
    {
    }
}