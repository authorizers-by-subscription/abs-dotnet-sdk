using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class LicensedProduct
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensedProductId")]
        public String LicensedProductId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor")]
        [RemoteIsCollection]
        public String Licensor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OverrideCreatedOn")]
        public Nullable<DateTime> OverrideCreatedOn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsActive")]
        public Nullable<Int32> IsActive { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsPrivate")]
        public Nullable<Boolean> IsPrivate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DisplayName")]
        public String DisplayName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LowerName")]
        public String LowerName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UpperName")]
        public String UpperName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LowerHyphenName")]
        public String LowerHyphenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ReadMeMD")]
        public String ReadMeMD { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UsageCount")]
        public Nullable<Int32> UsageCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsRecommended")]
        public Nullable<Int32> IsRecommended { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Category")]
        public String Category { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountHolderUUID")]
        public String[] AccountHolderUUID { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OriginalName")]
        public String OriginalName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersions")]
        [RemoteIsCollection]
        public String[] ProductVersions { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorIsVerified")]
        [RemoteIsCollection]
        public Nullable<Boolean> LicensorIsVerified { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadVersion")]
        [RemoteIsCollection]
        public String HeadVersion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadName")]
        [RemoteIsCollection]
        public String HeadName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadLambdaEndpoint")]
        [RemoteIsCollection]
        public String HeadLambdaEndpoint { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadCount")]
        public Nullable<Int32> HeadCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CalculatedLowerName")]
        public String CalculatedLowerName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CalculatedOriginalName")]
        public String CalculatedOriginalName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CalculatedUpperName")]
        public String CalculatedUpperName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CalculatedLowerHyphenName")]
        public String CalculatedLowerHyphenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasMissingNames")]
        public Nullable<Int32> HasMissingNames { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "VersionCount")]
        public Nullable<Int32> VersionCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName")]
        [RemoteIsCollection]
        public String LicensorScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadUsesV1Proxy")]
        public Nullable<Int32> HeadUsesV1Proxy { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasMissingMarkdown")]
        public Nullable<Int32> HasMissingMarkdown { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadDescription")]
        [RemoteIsCollection]
        public String HeadDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadReadMeMD")]
        [RemoteIsCollection]
        public String HeadReadMeMD { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadInputDescriptionMD")]
        [RemoteIsCollection]
        public String HeadInputDescriptionMD { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadOutputDescriptionMD")]
        [RemoteIsCollection]
        public String HeadOutputDescriptionMD { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RecordCreatedtime")]
        public Nullable<DateTime> RecordCreatedtime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedOn")]
        public Nullable<DateTime> CreatedOn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountIsActive")]
        [RemoteIsCollection]
        public Nullable<Boolean> AccountIsActive { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsDisabled")]
        public Nullable<Boolean> IsDisabled { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FullName")]
        public String FullName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequestCount")]
        [RemoteIsCollection]
        public Nullable<Int32> ProductUseRequestCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UsageCountMismatch")]
        public String UsageCountMismatch { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasRecentProductVersion")]
        [RemoteIsCollection]
        public Nullable<Int32> HasRecentProductVersion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MostRecentVersion")]
        public Nullable<Int32> MostRecentVersion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NextVersionNumber")]
        public Nullable<Int32> NextVersionNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MostRecentVersionRollup")]
        [RemoteIsCollection]
        public Nullable<Int32> MostRecentVersionRollup { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorUUID")]
        [RemoteIsCollection]
        public String LicensorUUID { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUUID")]
        public String ProductUUID { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AWSLambdaFunctionName")]
        public String AWSLambdaFunctionName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSAccountId")]
        [RemoteIsCollection]
        public String LicensorAWSAccountId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSAPIGatewayId")]
        [RemoteIsCollection]
        public String LicensorAWSAPIGatewayId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSLambdaRegion")]
        [RemoteIsCollection]
        public String LicensorAWSLambdaRegion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Brand")]
        [RemoteIsCollection]
        public String Brand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleAWSAPIGatewayId")]
        [RemoteIsCollection]
        public String BundleAWSAPIGatewayId { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensedProducts_BrandsesExpanded")]
        public BindingList<Brand> LicensedProducts_BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Products_SSioUsersesExpanded")]
        public BindingList<SSioUser> Products_SSioUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionsesExpanded")]
        public BindingList<ProductVersion> ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountHolder_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> AccountHolder_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> LicensorEmailAddress_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountHolderIsVerified_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> AccountHolderIsVerified_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadVersion_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> HeadVersion_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionCount_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> ProductVersionCount_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> LicensorScreenName_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CurrentProductDescription_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> CurrentProductDescription_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CurrentProductReadMeMD_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> CurrentProductReadMeMD_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLowerName_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> ProductLowerName_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductHyphenLowerName_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> ProductHyphenLowerName_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUpperName_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> ProductUpperName_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSAccountId_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> LicensorAWSAccountId_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSAPIGatewayId_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> LicensorAWSAPIGatewayId_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSLambdaRegion_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> LicensorAWSLambdaRegion_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductAWSLambdaFunctionName_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> ProductAWSLambdaFunctionName_ProductVersionsExpanded { get; set; }
            

        
        
        private static string CreateLicensedProductWhere(IEnumerable<LicensedProduct> licensedProducts, String forignKeyFieldName = "LicensedProductId")
        {
            if (!licensedProducts.Any()) return "1=1";
            else 
            {
                var idList = licensedProducts.Select(selectLicensedProduct => String.Format("'{0}'", selectLicensedProduct.LicensedProductId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
