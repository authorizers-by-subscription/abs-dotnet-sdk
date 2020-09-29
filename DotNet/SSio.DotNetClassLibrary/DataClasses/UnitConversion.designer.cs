using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class UnitConversion
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitConversionId")]
        public String UnitConversionId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToUnit")]
        [RemoteIsCollection]
        public String ToUnit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromUnit")]
        [RemoteIsCollection]
        public String FromUnit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ConversionRatio")]
        public Nullable<decimal> ConversionRatio { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions")]
        [RemoteIsCollection]
        public String[] MeterTransactions { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitConversionValue_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> UnitConversionValue_MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ConversionRatio_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> ConversionRatio_MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitConversions_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> UnitConversions_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitConversions2_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> UnitConversions2_UnitOfMeasurementsExpanded { get; set; }
            

        
        
        private static string CreateUnitConversionWhere(IEnumerable<UnitConversion> unitConversions, String forignKeyFieldName = "UnitConversionId")
        {
            if (!unitConversions.Any()) return "1=1";
            else 
            {
                var idList = unitConversions.Select(selectUnitConversion => String.Format("'{0}'", selectUnitConversion.UnitConversionId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
