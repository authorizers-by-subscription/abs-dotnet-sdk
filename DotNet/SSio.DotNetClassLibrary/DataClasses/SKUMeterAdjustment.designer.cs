using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class SKUMeterAdjustment
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustmentId")]
        public String SKUMeterAdjustmentId { get; set; }
    
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
        public String ProductLicenseMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LimitSKU")]
        public String LimitSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKU")]
        [RemoteIsCollection]
        public String LicenseSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeter")]
        [RemoteIsCollection]
        public String LicenseMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicense")]
        [RemoteIsCollection]
        public String BrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Adjustment")]
        public Nullable<decimal> Adjustment { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AdjustmentDescription")]
        public String AdjustmentDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AdjustmentType")]
        public String AdjustmentType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Source")]
        public String Source { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions")]
        [RemoteIsCollection]
        public String[] MeterTransactions { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterUnitOfMeasurement")]
        [RemoteIsCollection]
        public String LicenseMeterUnitOfMeasurement { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimit_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> SKULimit_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimitSKU_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> SKULimitSKU_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InitialMeterLimit_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> InitialMeterLimit_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustments_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> SKUMeterAdjustments_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Adjustment_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> Adjustment_MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AdjustmentType_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> AdjustmentType_MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimits_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> SKULimits_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustments_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> SKUMeterAdjustments_LicenseSKUsExpanded { get; set; }
            

        
        
        private static string CreateSKUMeterAdjustmentWhere(IEnumerable<SKUMeterAdjustment> sKUMeterAdjustments, String forignKeyFieldName = "SKUMeterAdjustmentId")
        {
            if (!sKUMeterAdjustments.Any()) return "1=1";
            else 
            {
                var idList = sKUMeterAdjustments.Select(selectSKUMeterAdjustment => String.Format("'{0}'", selectSKUMeterAdjustment.SKUMeterAdjustmentId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
