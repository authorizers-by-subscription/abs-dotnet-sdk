using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class ProductLicense
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseId")]
        public String ProductLicenseId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseGroup")]
        [RemoteIsCollection]
        public String LicenseGroup { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensee")]
        [RemoteIsCollection]
        public String Licensee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StartDate")]
        public Nullable<DateTime> StartDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItems")]
        [RemoteIsCollection]
        public String[] InvoiceLineItems { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanMonthyFee")]
        [RemoteIsCollection]
        public Nullable<decimal> PlanMonthyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyFee")]
        [RemoteIsCollection]
        public Nullable<decimal> MonthlyFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Term")]
        [RemoteIsCollection]
        public String Term { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanQuarterlyDiscount")]
        [RemoteIsCollection]
        public Nullable<decimal> PlanQuarterlyDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanSemiAnnualDiscount")]
        [RemoteIsCollection]
        public Nullable<decimal> PlanSemiAnnualDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanAnnualDiscount")]
        [RemoteIsCollection]
        public Nullable<decimal> PlanAnnualDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthsRenewed")]
        [RemoteIsCollection]
        public Nullable<Int32> MonthsRenewed { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaidThroughDate")]
        public Nullable<DateTime> PaidThroughDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress")]
        [RemoteIsCollection]
        public String LicenseeEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsExpiring")]
        public Nullable<Int32> IsExpiring { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsExpired")]
        public Nullable<Int32> IsExpired { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor")]
        [RemoteIsCollection]
        public String Licensor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicense")]
        [RemoteIsCollection]
        public String BrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TermDate")]
        public Nullable<DateTime> TermDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlanName")]
        [RemoteIsCollection]
        public String PlanName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AuthorizedLambdaFunctionRegEx")]
        public String AuthorizedLambdaFunctionRegEx { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LimitedUseToken")]
        [RemoteIsCollection]
        public String[] LimitedUseToken { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedTime")]
        public Nullable<DateTime> CreatedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomStartDate")]
        public Nullable<DateTime> CustomStartDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ReplacementExposureOverflow")]
        public Nullable<Int32> ReplacementExposureOverflow { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExposuresForwarded")]
        public Nullable<Int32> ExposuresForwarded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExposuresRequested")]
        public Nullable<Int32> ExposuresRequested { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnpaidExposures")]
        public Nullable<Int32> UnpaidExposures { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExposuresIncluded")]
        public Nullable<Int32> ExposuresIncluded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExposuresUsed")]
        public Nullable<Int32> ExposuresUsed { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExposureOverflow")]
        public Nullable<Int32> ExposureOverflow { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnusedExposures")]
        public Nullable<Int32> UnusedExposures { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExposuresRemaining")]
        public Nullable<Int32> ExposuresRemaining { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseName")]
        [RemoteIsCollection]
        public String BrandLicenseName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnpaidInvoiceCount")]
        [RemoteIsCollection]
        public Nullable<Int32> UnpaidInvoiceCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StripePaymentUrl")]
        [RemoteIsCollection]
        public String[] StripePaymentUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RenewalFee")]
        [RemoteIsCollection]
        public Nullable<decimal> RenewalFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RenewalSKU")]
        [RemoteIsCollection]
        public String RenewalSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMeters")]
        [RemoteIsCollection]
        public String[] ProductLicenseMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseSKU")]
        [RemoteIsCollection]
        public String BrandLicenseSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKU")]
        [RemoteIsCollection]
        public String DefaultRenewalSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ContractTerm")]
        [RemoteIsCollection]
        public Nullable<Int32> ContractTerm { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ContractDiscount")]
        [RemoteIsCollection]
        public Nullable<decimal> ContractDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKULimits")]
        [RemoteIsCollection]
        public String DefaultRenewalSKULimits { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MetersInWarning")]
        [RemoteIsCollection]
        public Nullable<Int32> MetersInWarning { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MetersExceeded")]
        [RemoteIsCollection]
        public Nullable<Int32> MetersExceeded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandName")]
        [RemoteIsCollection]
        public String BrandName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RenewalSKUSKU")]
        [RemoteIsCollection]
        public String RenewalSKUSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnology")]
        [RemoteIsCollection]
        public String SSioTechnology { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultSKUMeterAdjustments")]
        [RemoteIsCollection]
        public String DefaultSKUMeterAdjustments { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SubscriptionRenewalPrice_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> SubscriptionRenewalPrice_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> LicensorEmailAddress_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SubscriptionContractTerm_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> SubscriptionContractTerm_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ContractDiscount_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> ContractDiscount_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLisences_SSioUsersesExpanded")]
        public BindingList<SSioUser> ProductLisences_SSioUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenses_SSioUsersesExpanded")]
        public BindingList<SSioUser> ProductLicenses_SSioUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LimitedUseTokensesExpanded")]
        public BindingList<LimitedUseToken> LimitedUseTokensExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeters_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> LicenseMeters_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultRenewalSKULimits_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> DefaultRenewalSKULimits_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RenewalSKU_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> RenewalSKU_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> LicenseeEmailAddress_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> LicensorEmailAddress_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultSKUMeterAdjustments_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> DefaultSKUMeterAdjustments_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenses_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> ProductLicenses_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddresses_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> LicenseeEmailAddresses_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenses_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> ProductLicenses_LicenseSKUsExpanded { get; set; }
            

        
        
        private static string CreateProductLicenseWhere(IEnumerable<ProductLicense> productLicenses, String forignKeyFieldName = "ProductLicenseId")
        {
            if (!productLicenses.Any()) return "1=1";
            else 
            {
                var idList = productLicenses.Select(selectProductLicense => String.Format("'{0}'", selectProductLicense.ProductLicenseId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
