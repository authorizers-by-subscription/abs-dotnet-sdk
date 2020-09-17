using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class ProductLicenseMeter
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMeterId")]
        public String ProductLicenseMeterId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicense")]
        [RemoteIsCollection]
        public String ProductLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeters")]
        [RemoteIsCollection]
        public String LicenseMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKULimits")]
        [RemoteIsCollection]
        public String DefaultRenewalSKULimits { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimit")]
        [RemoteIsCollection]
        public String SKULimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RenewalSKU")]
        [RemoteIsCollection]
        public String RenewalSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimitSKU")]
        [RemoteIsCollection]
        public String SKULimitSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InitialMeterLimit")]
        [RemoteIsCollection]
        public Nullable<Int32> InitialMeterLimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions")]
        [RemoteIsCollection]
        public String[] MeterTransactions { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActiveMeterTransactionBalance")]
        [RemoteIsCollection]
        public Nullable<Int32> ActiveMeterTransactionBalance { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Limit")]
        public Nullable<decimal> Limit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterRemaining")]
        public Nullable<Int32> MeterRemaining { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterInWarning")]
        public Nullable<Int32> MeterInWarning { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterOffset")]
        public Nullable<decimal> MeterOffset { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Balance")]
        public Nullable<Int32> Balance { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterPercent")]
        public Nullable<decimal> MeterPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterExceeded")]
        public Nullable<Int32> MeterExceeded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransactionResetDate")]
        public Nullable<DateTime> TransactionResetDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress")]
        [RemoteIsCollection]
        public String LicenseeEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMeters_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> ProductLicenseMeters_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MetersInWarning_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> MetersInWarning_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MetersExceeded_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> MetersExceeded_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMeters_BundleSKULimitsesExpanded")]
        public BindingList<BundleSKULimit> ProductLicenseMeters_BundleSKULimitsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransactionResetDate_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> TransactionResetDate_MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> LicenseeEmailAddress_MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailaddress_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> LicensorEmailaddress_MeterTransactionsExpanded { get; set; }
            

        
        
        private static string CreateProductLicenseMeterWhere(IEnumerable<ProductLicenseMeter> productLicenseMeters, String forignKeyFieldName = "ProductLicenseMeterId")
        {
            if (!productLicenseMeters.Any()) return "1=1";
            else 
            {
                var idList = productLicenseMeters.Select(selectProductLicenseMeter => String.Format("'{0}'", selectProductLicenseMeter.ProductLicenseMeterId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}