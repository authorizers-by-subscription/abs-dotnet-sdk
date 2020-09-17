using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class LicenseBundle
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundleId")]
        public String LicenseBundleId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseGroupId")]
        public String LicenseGroupId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor")]
        [RemoteIsCollection]
        public String Licensor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanName")]
        public String PlanName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyFee")]
        public Nullable<decimal> MonthlyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeSubscriptions")]
        public String[] LicenseeSubscriptions { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "QuarterlyDiscount")]
        public Nullable<decimal> QuarterlyDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SemiAnnualDiscount")]
        public Nullable<decimal> SemiAnnualDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AnnualDiscount")]
        public Nullable<decimal> AnnualDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenses")]
        [RemoteIsCollection]
        public String[] ProductLicenses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CostFor1KUses")]
        public Nullable<decimal> CostFor1KUses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddresss")]
        [RemoteIsCollection]
        public String LicensorEmailAddresss { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName")]
        [RemoteIsCollection]
        public String LicensorScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseType")]
        public String LicenseType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddresses")]
        [RemoteIsCollection]
        public String[] LicenseeEmailAddresses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Createdtime")]
        public Nullable<DateTime> Createdtime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnology")]
        [RemoteIsCollection]
        public String ABSTechnology { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InitialFee")]
        public Nullable<decimal> InitialFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MaxUses")]
        public Nullable<Int32> MaxUses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyCostPer1KUses")]
        public Nullable<decimal> MonthlyCostPer1KUses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundleName")]
        public String LicenseBundleName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> ABSTechnologyPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKUs")]
        [RemoteIsCollection]
        public String[] BundleSKUs { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundle")]
        [RemoteIsCollection]
        public String ProductBundle { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologySKUCode")]
        [RemoteIsCollection]
        public String ABSTechnologySKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode")]
        [RemoteIsCollection]
        public String LicensorSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundleSKU")]
        [RemoteIsCollection]
        public String ProductBundleSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUCode")]
        public String SKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKU")]
        public String SKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> ABSPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> PaymentProcessorPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> TotalMarketPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundleName")]
        [RemoteIsCollection]
        public String ProductBundleName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultBundleSKU")]
        [RemoteIsCollection]
        public String DefaultBundleSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsExpired")]
        public Nullable<Boolean> IsExpired { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultTerm")]
        [RemoteIsCollection]
        public Nullable<Int32> DefaultTerm { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalFee")]
        [RemoteIsCollection]
        public Nullable<decimal> DefaultRenewalFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyName")]
        [RemoteIsCollection]
        public String ABSTechnologyName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ModifiedTime")]
        public Nullable<DateTime> ModifiedTime { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundles_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> LicenseBundles_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundles_ABSTechnologiesesExpanded")]
        public BindingList<ABSTechnology> LicenseBundles_ABSTechnologiesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseGroup_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> LicenseGroup_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanMonthyFee_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> PlanMonthyFee_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanQuarterlyDiscount_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> PlanQuarterlyDiscount_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanSemiAnnualDiscount_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> PlanSemiAnnualDiscount_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanAnnualDiscount_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> PlanAnnualDiscount_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> Licensor_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicensesesExpanded")]
        public BindingList<ProductLicense> ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> LicensorEmailAddress_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanName_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> PlanName_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnology_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> ABSTechnology_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundleName_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> LicenseBundleName_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundleSKU_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> LicenseBundleSKU_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKU_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> DefaultRenewalSKU_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKUsesExpanded")]
        public BindingList<BundleSKU> BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleLicensor_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> BundleLicensor_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> LicensorEmailAddress_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanName_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> PlanName_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundle_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ProductBundle_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnology_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ABSTechnology_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologySKUCode_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ABSTechnologySKUCode_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> LicensorSKUCode_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundleSKU_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> LicenseBundleSKU_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyPercent_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ABSTechnologyPercent_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSPercent_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ABSPercent_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> PaymentProcessorPercent_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultSKUForLicenseBundle_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> DefaultSKUForLicenseBundle_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyName_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ABSTechnologyName_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundleName_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ProductBundleName_BundleSKUsExpanded { get; set; }
            

        
        
        private static string CreateLicenseBundleWhere(IEnumerable<LicenseBundle> licenseBundles, String forignKeyFieldName = "LicenseBundleId")
        {
            if (!licenseBundles.Any()) return "1=1";
            else 
            {
                var idList = licenseBundles.Select(selectLicenseBundle => String.Format("'{0}'", selectLicenseBundle.LicenseBundleId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
