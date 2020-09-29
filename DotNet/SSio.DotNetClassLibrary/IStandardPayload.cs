using System;

namespace SmartSubs.io.Lib
{
    public interface IStandardPayload
    {
        String ErrorMessage { get; set; }
        String AccessToken { get; set; }
    }
}