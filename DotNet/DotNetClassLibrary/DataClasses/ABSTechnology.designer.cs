using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class ABSTechnology
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyId")]
        public String ABSTechnologyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTCode")]
        public String ABSTCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundles")]
        [RemoteIsCollection]
        public String LicenseBundles { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTOwner")]
        [RemoteIsCollection]
        public String ABSTOwner { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyPercentage")]
        public Nullable<decimal> TechnologyPercentage { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSPercent")]
        public Nullable<decimal> ABSPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent")]
        public Nullable<decimal> PaymentProcessorPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent")]
        public Nullable<decimal> TotalMarketPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyMeters")]
        [RemoteIsCollection]
        public String[] TechnologyMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUCode")]
        public String SKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundles")]
        [RemoteIsCollection]
        public String[] ProductBundles { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundlesesExpanded")]
        public BindingList<ProductBundle> ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologySKUCode_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> ABSTechnologySKUCode_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyPercent_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> ABSTechnologyPercent_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSPercent_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> ABSPercent_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> PaymentProcessorPercent_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> TotalMarketPercent_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyName_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> ABSTechnologyName_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologies_ABSUsersesExpanded")]
        public BindingList<ABSUser> ABSTechnologies_ABSUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyMetersesExpanded")]
        public BindingList<TechnologyMeter> TechnologyMetersExpanded { get; set; }
            

        
        
        private static string CreateABSTechnologyWhere(IEnumerable<ABSTechnology> aBSTechnologies, String forignKeyFieldName = "ABSTechnologyId")
        {
            if (!aBSTechnologies.Any()) return "1=1";
            else 
            {
                var idList = aBSTechnologies.Select(selectABSTechnology => String.Format("'{0}'", selectABSTechnology.ABSTechnologyId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
