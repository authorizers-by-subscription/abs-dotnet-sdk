using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class BrandLicense
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseId")]
        public String BrandLicenseId { get; set; }
    
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
        [RemoteIsCollection]
        public String LicenseType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddresses")]
        [RemoteIsCollection]
        public String[] LicenseeEmailAddresses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Createdtime")]
        public Nullable<DateTime> Createdtime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InitialFee")]
        public Nullable<decimal> InitialFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MaxUses")]
        public Nullable<Int32> MaxUses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyCostPer1KUses")]
        public Nullable<decimal> MonthlyCostPer1KUses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseName")]
        public String BrandLicenseName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKUs")]
        [RemoteIsCollection]
        public String[] BundleSKUs { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Brand")]
        [RemoteIsCollection]
        public String Brand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode")]
        [RemoteIsCollection]
        public String LicensorSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandSKU")]
        [RemoteIsCollection]
        public String BrandSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUCode")]
        public String SKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKU")]
        public String SKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> PaymentProcessorPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> TotalMarketPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandName")]
        [RemoteIsCollection]
        public String BrandName { get; set; }
    
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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ModifiedTime")]
        public Nullable<DateTime> ModifiedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OwnerIsVerified")]
        [RemoteIsCollection]
        public Nullable<Boolean> OwnerIsVerified { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultBundleSKUSKU")]
        [RemoteIsCollection]
        public String DefaultBundleSKUSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandIsPublic")]
        [RemoteIsCollection]
        public Nullable<Boolean> BrandIsPublic { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultTermDays")]
        [RemoteIsCollection]
        public Nullable<Int32> DefaultTermDays { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnology")]
        [RemoteIsCollection]
        public String SSioTechnology { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> SSioTechnologyPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologySKUCode")]
        [RemoteIsCollection]
        public String SSioTechnologySKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> SSioPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyName")]
        [RemoteIsCollection]
        public String SSioTechnologyName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseTypePrimaryTrackingField")]
        [RemoteIsCollection]
        public String LicenseTypePrimaryTrackingField { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeters")]
        [RemoteIsCollection]
        public String[] LicenseMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKUs")]
        [RemoteIsCollection]
        public String[] LicenseSKUs { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKU")]
        [RemoteIsCollection]
        public String DefaultRenewalSKU { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenses_BrandsesExpanded")]
        public BindingList<Brand> BrandLicenses_BrandsExpanded { get; set; }
            
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
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseName_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> BrandLicenseName_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseSKU_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> BrandLicenseSKU_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKU_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> DefaultRenewalSKU_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandName_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> BrandName_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnology_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> SSioTechnology_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundleName_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> LicenseBundleName_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseName_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> BrandLicenseName_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseSKU_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> BrandLicenseSKU_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundles_LicenseTypesesExpanded")]
        public BindingList<LicenseType> LicenseBundles_LicenseTypesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleLicensor_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> BundleLicensor_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> LicensorEmailAddress_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanName_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> PlanName_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Brand_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> Brand_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> LicensorSKUCode_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseSKU_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> BrandLicenseSKU_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> PaymentProcessorPercent_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultSKUForBrandLicense_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> DefaultSKUForBrandLicense_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandName_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> BrandName_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseName_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> BrandLicenseName_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseLicenseType_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> BrandLicenseLicenseType_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandIsPublic_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> BrandIsPublic_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnology_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> SSioTechnology_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologySKUCode_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> SSioTechnologySKUCode_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyPercent_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> SSioTechnologyPercent_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioPercent_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> SSioPercent_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyName_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> SSioTechnologyName_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseTypePrimaryTrackingField_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> LicenseTypePrimaryTrackingField_LicenseSKUsExpanded { get; set; }
            

        
        
        private static string CreateBrandLicenseWhere(IEnumerable<BrandLicense> brandLicenses, String forignKeyFieldName = "BrandLicenseId")
        {
            if (!brandLicenses.Any()) return "1=1";
            else 
            {
                var idList = brandLicenses.Select(selectBrandLicense => String.Format("'{0}'", selectBrandLicense.BrandLicenseId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
