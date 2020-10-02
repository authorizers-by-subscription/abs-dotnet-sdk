using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class Brand
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandId")]
        public String BrandId { get; set; }
    
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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleName")]
        public String BundleName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AWSAPIGatewayId")]
        public String AWSAPIGatewayId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AWSAccountId")]
        public String AWSAccountId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AWSLambdaRegion")]
        public String AWSLambdaRegion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensedProducts")]
        [RemoteIsCollection]
        public String[] LicensedProducts { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomDomain")]
        public String CustomDomain { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenses")]
        [RemoteIsCollection]
        public String[] BrandLicenses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName")]
        [RemoteIsCollection]
        public String LicensorScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUCode")]
        public String SKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode")]
        [RemoteIsCollection]
        public String LicensorSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKU")]
        public String SKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> PaymentProcessorPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> TotalMarketPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsPublic")]
        public Nullable<Boolean> IsPublic { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Owner")]
        [RemoteIsCollection]
        public String Owner { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomScreenName")]
        public String CustomScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OwnerScreenName")]
        [RemoteIsCollection]
        public String OwnerScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OwnerSKUCode")]
        [RemoteIsCollection]
        public String OwnerSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomLicensorSKUCode")]
        public String CustomLicensorSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ModifiedTime")]
        public Nullable<DateTime> ModifiedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedTime")]
        public Nullable<DateTime> CreatedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OwnerIsVerified")]
        [RemoteIsCollection]
        public Nullable<Boolean> OwnerIsVerified { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnology")]
        [RemoteIsCollection]
        public String SSioTechnology { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologySKUCode")]
        [RemoteIsCollection]
        public String SSioTechnologySKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> SSioTechnologyPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> SSioPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyName")]
        [RemoteIsCollection]
        public String SSioTechnologyName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForBrandLicense")]
        public String NameForBrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForBrand")]
        [RemoteIsCollection]
        public String NameForBrand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForBrand")]
        [RemoteIsCollection]
        public String PluralNameForBrand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForBrandLicense")]
        public String PluralNameForBrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorLicenseEventWebhookUrl")]
        [RemoteIsCollection]
        public String LicensorLicenseEventWebhookUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomLicenseEventWebhookUrl")]
        public String CustomLicenseEventWebhookUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseEventWebhookUrl")]
        public String LicenseEventWebhookUrl { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Brands_SSioTechnologiesesExpanded")]
        public BindingList<SSioTechnology> Brands_SSioTechnologiesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Brands_SSioUsersesExpanded")]
        public BindingList<SSioUser> Brands_SSioUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSAccountId_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensorAWSAccountId_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSLambdaRegion_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensorAWSLambdaRegion_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleAWSAPIGatewayId_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> BundleAWSAPIGatewayId_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> Licensor_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> LicensorScreenName_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> LicensorEmailAddress_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicensesesExpanded")]
        public BindingList<BrandLicense> BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> LicensorSKUCode_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandSKU_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> BrandSKU_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> PaymentProcessorPercent_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> TotalMarketPercent_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandName_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> BrandName_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OwnerIsVerified_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> OwnerIsVerified_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandIsPublic_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> BrandIsPublic_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnology_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> SSioTechnology_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyPercent_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> SSioTechnologyPercent_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologySKUCode_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> SSioTechnologySKUCode_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioPercent_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> SSioPercent_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyName_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> SSioTechnologyName_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForBrand_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> NameForBrand_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForBrand_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> PluralNameForBrand_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForBrandLicense_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> PluralNameForBrandLicense_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForBrandLicense_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> NameForBrandLicense_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseEventWebhookUrl_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> BrandLicenseEventWebhookUrl_BrandLicensesExpanded { get; set; }
            

        
        
        private static string CreateBrandWhere(IEnumerable<Brand> brands, String forignKeyFieldName = "BrandId")
        {
            if (!brands.Any()) return "1=1";
            else 
            {
                var idList = brands.Select(selectBrand => String.Format("'{0}'", selectBrand.BrandId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
