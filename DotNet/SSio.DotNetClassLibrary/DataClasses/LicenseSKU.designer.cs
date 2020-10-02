using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class LicenseSKU
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKUId")]
        public String LicenseSKUId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicense")]
        [RemoteIsCollection]
        public String BrandLicense { get; set; }
    
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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Brand")]
        [RemoteIsCollection]
        public String Brand { get; set; }
    
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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode")]
        [RemoteIsCollection]
        public String LicensorSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseSKU")]
        [RemoteIsCollection]
        public String BrandLicenseSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> PaymentProcessorPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorFee")]
        public Nullable<decimal> PaymentProcessorFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketFees")]
        public Nullable<decimal> TotalMarketFees { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorPayment")]
        public Nullable<decimal> LicensorPayment { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenses")]
        [RemoteIsCollection]
        public String[] ProductLicenses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultSKUForBrandLicense")]
        [RemoteIsCollection]
        public String DefaultSKUForBrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorFee")]
        public Nullable<decimal> LicensorFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandName")]
        [RemoteIsCollection]
        public String BrandName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsHidden")]
        public Nullable<Boolean> IsHidden { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedTime")]
        public Nullable<DateTime> CreatedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ModifiedTime")]
        public Nullable<DateTime> ModifiedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseName")]
        [RemoteIsCollection]
        public String BrandLicenseName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DaysIncluded")]
        public Nullable<Int32> DaysIncluded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseLicenseType")]
        [RemoteIsCollection]
        public String BrandLicenseLicenseType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandIsPublic")]
        [RemoteIsCollection]
        public Nullable<Boolean> BrandIsPublic { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnology")]
        [RemoteIsCollection]
        public String SSioTechnology { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologySKUCode")]
        [RemoteIsCollection]
        public String SSioTechnologySKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> SSioTechnologyPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyFee")]
        public Nullable<decimal> SSioTechnologyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> SSioPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioFee")]
        public Nullable<decimal> SSioFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyName")]
        [RemoteIsCollection]
        public String SSioTechnologyName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "QuantityIncluded")]
        public Nullable<Int32> QuantityIncluded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentRecurringFee")]
        [RemoteIsCollection]
        public Nullable<decimal> ParentRecurringFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RecurringFee")]
        public Nullable<decimal> RecurringFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CalculatedRecurringFee")]
        public Nullable<decimal> CalculatedRecurringFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseTypePrimaryTrackingField")]
        [RemoteIsCollection]
        public String LicenseTypePrimaryTrackingField { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CalculatedInitialFee")]
        public Nullable<decimal> CalculatedInitialFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ChosenSKUCode")]
        public String ChosenSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustments")]
        [RemoteIsCollection]
        public String[] SKUMeterAdjustments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForBrand")]
        [RemoteIsCollection]
        public String PluralNameForBrand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForBrandLicense")]
        [RemoteIsCollection]
        public String NameForBrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForBrandLicense")]
        [RemoteIsCollection]
        public String PluralNameForBrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForMeter")]
        [RemoteIsCollection]
        public String NameForMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForMeter")]
        [RemoteIsCollection]
        public String PluralNameForMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForSKU")]
        [RemoteIsCollection]
        public String NameForSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForSKU")]
        [RemoteIsCollection]
        public String PluralNameForSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForBrand")]
        [RemoteIsCollection]
        public String NameForBrand { get; set; }
    

        
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
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RenewalSKUSKU_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> RenewalSKUSKU_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultSKUMeterAdjustments_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> DefaultSKUMeterAdjustments_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKU_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> BundleSKU_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundle_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> ProductBundle_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleMonthsIncluded_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> BundleMonthsIncluded_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> LicensorEmailAddress_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicense_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> BrandLicense_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKU_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> BundleSKU_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleMonthsIncluded_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> BundleMonthsIncluded_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> LicensorEmailAddress_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKUs_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> BundleSKUs_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultBundleSKU_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> DefaultBundleSKU_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultTerm_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> DefaultTerm_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalFee_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> DefaultRenewalFee_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultBundleSKUSKU_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> DefaultBundleSKUSKU_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultTermDays_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> DefaultTermDays_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKUs_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> LicenseSKUs_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKU_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> DefaultRenewalSKU_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentSKU_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> ParentSKU_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentInitialFee_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> ParentInitialFee_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentMonthlyFee_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> ParentMonthlyFee_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ParentRecurringFee_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> ParentRecurringFee_LicenseSKUsExpanded { get; set; }
            

        
        
        private static string CreateLicenseSKUWhere(IEnumerable<LicenseSKU> licenseSKUs, String forignKeyFieldName = "LicenseSKUId")
        {
            if (!licenseSKUs.Any()) return "1=1";
            else 
            {
                var idList = licenseSKUs.Select(selectLicenseSKU => String.Format("'{0}'", selectLicenseSKU.LicenseSKUId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
