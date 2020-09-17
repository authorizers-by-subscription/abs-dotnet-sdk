using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class BundleSKU
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKUId")]
        public String BundleSKUId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundle")]
        [RemoteIsCollection]
        public String LicenseBundle { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InitialFee")]
        public Nullable<decimal> InitialFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthsIncluded")]
        public Nullable<Int32> MonthsIncluded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleLicensor")]
        [RemoteIsCollection]
        public String BundleLicensor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentSKU")]
        [RemoteIsCollection]
        public String ParentSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUCode")]
        public String SKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUDescription")]
        public String SKUDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKU")]
        public String SKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanName")]
        [RemoteIsCollection]
        public String PlanName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUType")]
        public String SKUType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUTypeCode")]
        public String SKUTypeCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimits")]
        [RemoteIsCollection]
        public String[] SKULimits { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundle")]
        [RemoteIsCollection]
        public String ProductBundle { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentInitialFee")]
        [RemoteIsCollection]
        public Nullable<decimal> ParentInitialFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentMonthlyFee")]
        [RemoteIsCollection]
        public Nullable<decimal> ParentMonthlyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomMonthlyFee")]
        public Nullable<decimal> CustomMonthlyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentRelativeFee")]
        public Nullable<decimal> ParentRelativeFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DiscountPercent")]
        public Nullable<decimal> DiscountPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyFee")]
        public Nullable<decimal> MonthlyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CalculatedMonthlyFee")]
        public Nullable<decimal> CalculatedMonthlyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKURenewalFee")]
        public Nullable<decimal> SKURenewalFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnology")]
        [RemoteIsCollection]
        public String ABSTechnology { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologySKUCode")]
        [RemoteIsCollection]
        public String ABSTechnologySKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode")]
        [RemoteIsCollection]
        public String LicensorSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundleSKU")]
        [RemoteIsCollection]
        public String LicenseBundleSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> ABSTechnologyPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyFee")]
        public Nullable<decimal> ABSTechnologyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> ABSPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> PaymentProcessorPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSFee")]
        public Nullable<decimal> ABSFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorFee")]
        public Nullable<decimal> PaymentProcessorFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketFees")]
        public Nullable<decimal> TotalMarketFees { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorPayment")]
        public Nullable<decimal> LicensorPayment { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenses")]
        [RemoteIsCollection]
        public String[] ProductLicenses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundle copy")]
        public String[] LicenseBundlecopy { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultSKUForLicenseBundle")]
        [RemoteIsCollection]
        public String DefaultSKUForLicenseBundle { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorFee")]
        public Nullable<decimal> LicensorFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyName")]
        [RemoteIsCollection]
        public String ABSTechnologyName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundleName")]
        [RemoteIsCollection]
        public String ProductBundleName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsHidden")]
        public Nullable<Boolean> IsHidden { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedTime")]
        public Nullable<DateTime> CreatedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ModifiedTime")]
        public Nullable<DateTime> ModifiedTime { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyFee_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> MonthlyFee_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Term_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> Term_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RenewalFee_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> RenewalFee_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RenewalSKU_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> RenewalSKU_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ContractTerm_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> ContractTerm_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ContractDiscount_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> ContractDiscount_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKULimits_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> DefaultRenewalSKULimits_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKULimitsesExpanded")]
        public BindingList<BundleSKULimit> BundleSKULimitsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundle_BundleSKULimitsesExpanded")]
        public BindingList<BundleSKULimit> ProductBundle_BundleSKULimitsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleMonthsIncluded_BundleSKULimitsesExpanded")]
        public BindingList<BundleSKULimit> BundleMonthsIncluded_BundleSKULimitsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_BundleSKULimitsesExpanded")]
        public BindingList<BundleSKULimit> LicensorEmailAddress_BundleSKULimitsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKUs_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> BundleSKUs_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultBundleSKU_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> DefaultBundleSKU_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultTerm_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> DefaultTerm_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalFee_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> DefaultRenewalFee_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentSKU_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ParentSKU_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentInitialFee_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ParentInitialFee_BundleSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentMonthlyFee_BundleSKUsesExpanded")]
        public BindingList<BundleSKU> ParentMonthlyFee_BundleSKUsExpanded { get; set; }
            

        
        
        private static string CreateBundleSKUWhere(IEnumerable<BundleSKU> bundleSKUs, String forignKeyFieldName = "BundleSKUId")
        {
            if (!bundleSKUs.Any()) return "1=1";
            else 
            {
                var idList = bundleSKUs.Select(selectBundleSKU => String.Format("'{0}'", selectBundleSKU.BundleSKUId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
