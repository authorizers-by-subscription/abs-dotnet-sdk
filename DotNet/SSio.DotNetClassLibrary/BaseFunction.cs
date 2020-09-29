using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using System;
using System.Text;
using Amazon.Lambda.Core;
using System.Collections.Generic;

namespace SmartSubs.io.Lib
{
    public abstract class BaseFunction<T, Y>
        where T : IStandardPayload, new()
        where Y : IStandardPayload, new()
    {
        private bool _clearAccessToken = true;

        public bool ClearAccessToken { get => _clearAccessToken; set => _clearAccessToken = value; }

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input, ILambdaContext context)
        {
            var payload = default(Y);
            try
            {
                String body = input.IsBase64Encoded ? Encoding.UTF8.GetString(Convert.FromBase64String(input.Body)) : input.Body;
                if (body is null) body = "{}";
                var appPayload = JsonConvert.DeserializeObject<T>(body);
                payload = this.ExecuteFunction(appPayload, input, context);
                Console.WriteLine(JsonConvert.SerializeObject(payload));
            }
            catch (Exception ex)
            {
                payload = new Y();
                payload.ErrorMessage = ex.Message;
            }
            if (this.ClearAccessToken) payload.AccessToken = null;
            var headers = new Dictionary<String, String>();
            headers["Access-Control-Allow-Origin"] = "*";

            return new APIGatewayProxyResponse()
            {
                StatusCode = 200,
                Headers = headers,
                Body = JsonConvert.SerializeObject(payload, Formatting.Indented, new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore
                })
            };
        }

        protected abstract Y ExecuteFunction(T appPayload, APIGatewayProxyRequest input, ILambdaContext context);
    }
}