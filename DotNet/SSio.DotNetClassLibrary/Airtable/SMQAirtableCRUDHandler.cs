using dc = SmartSubs.io.Lib.DataClasses;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using EffortlessAPI.SSio.SassyMQ;
using System.Configuration;
using System.Threading.Tasks;
using System.Threading;

namespace SassyMQ.AirtableCRUD
{
    public partial class SMQAirtableCRUDHandler
    {
        public List<String> Roles { get; }
        public SMQCRUDCoordinator CRUDCoordinator { get; }
        public string IPAddress { get; set; }
        public DateTime OnlineSince { get; private set; }

        internal void Start()
        {
            this.CRUDCoordinator.WaitForComplete();
        }

        private DirectoryInfo BasePath { get; }
        
        public SMQAirtableCRUDHandler(string connectionString, String key, String baseId, String rootPath)
        {
            this.OnlineSince = DateTime.UtcNow;
            this.BasePath = new DirectoryInfo(rootPath);
            this.Roles = "Guest,LicenseCoordinator,SSioUser,Admin,CRUDCoordinator".Split(",".ToCharArray()).ToList();

            this.CRUDCoordinator = new SMQCRUDCoordinator(connectionString);
            this.InitActions();
        }
 
   }
}


namespace SSoT.me.AirtableToDotNetLib
{
    public static class HelpExtensions
    {
        public static String SafeToString(this object val)
        {
            if (val is null) return String.Empty;
            else return val.ToString();
        }
    }
}