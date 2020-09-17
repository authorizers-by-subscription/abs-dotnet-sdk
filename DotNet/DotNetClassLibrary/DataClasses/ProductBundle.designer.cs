using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class ProductBundle
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundleId")]
        public String ProductBundleId { get; set; }
    
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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundles")]
        [RemoteIsCollection]
        public String[] LicenseBundles { get; set; }
    
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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnology")]
        [RemoteIsCollection]
        public String ABSTechnology { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologySKUCode")]
        [RemoteIsCollection]
        public String ABSTechnologySKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> ABSTechnologyPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSPercent")]
        [RemoteIsCollection]
        public Nullable<decimal> ABSPercent { get; set; }
    
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
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyName")]
        [RemoteIsCollection]
        public String ABSTechnologyName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ModifiedTime")]
        public Nullable<DateTime> ModifiedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedTime")]
        public Nullable<DateTime> CreatedTime { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundles_ABSTechnologiesesExpanded")]
        public BindingList<ABSTechnology> ProductBundles_ABSTechnologiesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSUsersesExpanded")]
        public BindingList<ABSUser> ABSUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSAccountId_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensorAWSAccountId_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSLambdaRegion_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensorAWSLambdaRegion_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleAWSAPIGatewayId_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> BundleAWSAPIGatewayId_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> Licensor_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> LicensorScreenName_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> LicensorEmailAddress_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnology_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> ABSTechnology_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyPercent_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> ABSTechnologyPercent_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologySKUCode_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> ABSTechnologySKUCode_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> LicensorSKUCode_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundleSKU_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> ProductBundleSKU_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSPercent_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> ABSPercent_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> PaymentProcessorPercent_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> TotalMarketPercent_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundleName_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> ProductBundleName_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologyName_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> ABSTechnologyName_LicenseBundlesExpanded { get; set; }
            

        
        
        private static string CreateProductBundleWhere(IEnumerable<ProductBundle> productBundles, String forignKeyFieldName = "ProductBundleId")
        {
            if (!productBundles.Any()) return "1=1";
            else 
            {
                var idList = productBundles.Select(selectProductBundle => String.Format("'{0}'", selectProductBundle.ProductBundleId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
