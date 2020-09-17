using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class TechnologyMeter
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyMeterId")]
        public String TechnologyMeterId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnology")]
        [RemoteIsCollection]
        public String ABSTechnology { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterType")]
        [RemoteIsCollection]
        public String MeterType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKUs")]
        public String BundleSKUs { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimit")]
        [RemoteIsCollection]
        public String[] SKULimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTypeSKUCode")]
        [RemoteIsCollection]
        public String MeterTypeSKUCode { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyMeters_MeterTypesesExpanded")]
        public BindingList<MeterType> TechnologyMeters_MeterTypesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyMeters_ABSTechnologiesesExpanded")]
        public BindingList<ABSTechnology> TechnologyMeters_ABSTechnologiesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKULimitsesExpanded")]
        public BindingList<BundleSKULimit> BundleSKULimitsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTypeSKUCode_BundleSKULimitsesExpanded")]
        public BindingList<BundleSKULimit> MeterTypeSKUCode_BundleSKULimitsExpanded { get; set; }
            

        
        
        private static string CreateTechnologyMeterWhere(IEnumerable<TechnologyMeter> technologyMeters, String forignKeyFieldName = "TechnologyMeterId")
        {
            if (!technologyMeters.Any()) return "1=1";
            else 
            {
                var idList = technologyMeters.Select(selectTechnologyMeter => String.Format("'{0}'", selectTechnologyMeter.TechnologyMeterId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
