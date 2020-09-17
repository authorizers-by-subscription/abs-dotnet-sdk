using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class BundleSKULimit
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKULimitId")]
        public String BundleSKULimitId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimitId")]
        public String SKULimitId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKU")]
        [RemoteIsCollection]
        public String BundleSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyMeter")]
        [RemoteIsCollection]
        public String TechnologyMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundle")]
        [RemoteIsCollection]
        public String ProductBundle { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyMeterLimit")]
        public Nullable<decimal> MonthlyMeterLimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalSKUMeterLimit")]
        public Nullable<Int32> TotalSKUMeterLimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleMonthsIncluded")]
        [RemoteIsCollection]
        public Nullable<Int32> BundleMonthsIncluded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTypeSKUCode")]
        [RemoteIsCollection]
        public String MeterTypeSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMeters")]
        [RemoteIsCollection]
        public String[] ProductLicenseMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LimitSKU")]
        public String LimitSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimit_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> SKULimit_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimitSKU_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> SKULimitSKU_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InitialMeterLimit_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> InitialMeterLimit_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimit_TechnologyMetersesExpanded")]
        public BindingList<TechnologyMeter> SKULimit_TechnologyMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimits_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> SKULimits_BundleSKUsExpanded { get; set; }
            

        
        
        private static string CreateBundleSKULimitWhere(IEnumerable<BundleSKULimit> bundleSKULimits, String forignKeyFieldName = "BundleSKULimitId")
        {
            if (!bundleSKULimits.Any()) return "1=1";
            else 
            {
                var idList = bundleSKULimits.Select(selectBundleSKULimit => String.Format("'{0}'", selectBundleSKULimit.BundleSKULimitId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
