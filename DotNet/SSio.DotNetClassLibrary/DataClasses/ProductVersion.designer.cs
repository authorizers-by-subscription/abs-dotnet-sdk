using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class ProductVersion
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionId")]
        public String ProductVersionId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensedProduct")]
        [RemoteIsCollection]
        public String LicensedProduct { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Version")]
        public String Version { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OverrideCreatedOn")]
        public Nullable<DateTime> OverrideCreatedOn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsActive")]
        public Nullable<Boolean> IsActive { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountHolder")]
        [RemoteIsCollection]
        public String AccountHolder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LambdaEndpoint")]
        public String LambdaEndpoint { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TranspilerVersionUUID")]
        public String TranspilerVersionUUID { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductName")]
        public String ProductName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountHolderIsVerified")]
        [RemoteIsCollection]
        public Nullable<Boolean> AccountHolderIsVerified { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequests")]
        [RemoteIsCollection]
        public String[] ProductUseRequests { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadVersion")]
        [RemoteIsCollection]
        public String HeadVersion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionCount")]
        [RemoteIsCollection]
        public Nullable<Int32> ProductVersionCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName")]
        [RemoteIsCollection]
        public String LicensorScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CurrentProductDescription")]
        [RemoteIsCollection]
        public String CurrentProductDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionDescription")]
        public String ProductVersionDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CurrentProductReadMeMD")]
        [RemoteIsCollection]
        public String CurrentProductReadMeMD { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionReadMeMD")]
        public String ProductVersionReadMeMD { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionInputDescriptionMD")]
        public String ProductVersionInputDescriptionMD { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionOutputDescriptionMD")]
        public String ProductVersionOutputDescriptionMD { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLowerName")]
        [RemoteIsCollection]
        public String ProductLowerName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductHyphenLowerName")]
        [RemoteIsCollection]
        public String ProductHyphenLowerName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUpperName")]
        [RemoteIsCollection]
        public String ProductUpperName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RecordCreatedtime")]
        public Nullable<DateTime> RecordCreatedtime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedOn")]
        public String CreatedOn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyProductUseRequests")]
        [RemoteIsCollection]
        public String[] MonthlyProductUseRequests { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyProductUseRequestCount")]
        [RemoteIsCollection]
        public Nullable<Int32> MonthlyProductUseRequestCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActiveProductUseRequestCount")]
        public Nullable<Int32> ActiveProductUseRequestCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequestCount")]
        public Nullable<Int32> ProductUseRequestCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsRecentVersion")]
        public Nullable<Int32> IsRecentVersion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "VersionNumber")]
        public Nullable<Int32> VersionNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PublishedVersion")]
        public String PublishedVersion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultAWSLambdaArn")]
        public String DefaultAWSLambdaArn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AWSLambdaVersion")]
        public Nullable<Int32> AWSLambdaVersion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSAccountId")]
        [RemoteIsCollection]
        public String LicensorAWSAccountId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSAPIGatewayId")]
        [RemoteIsCollection]
        public String LicensorAWSAPIGatewayId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorAWSLambdaRegion")]
        [RemoteIsCollection]
        public String LicensorAWSLambdaRegion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductAWSLambdaFunctionName")]
        [RemoteIsCollection]
        public String ProductAWSLambdaFunctionName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OverrideAWSLambdaArn")]
        public String OverrideAWSLambdaArn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AWSLambdaArn")]
        public String AWSLambdaArn { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersions_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> ProductVersions_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadVersion_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> HeadVersion_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadName_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> HeadName_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadLambdaEndpoint_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> HeadLambdaEndpoint_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadDescription_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> HeadDescription_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadReadMeMD_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> HeadReadMeMD_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadInputDescriptionMD_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> HeadInputDescriptionMD_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadOutputDescriptionMD_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> HeadOutputDescriptionMD_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequestCount_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> ProductUseRequestCount_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HasRecentProductVersion_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> HasRecentProductVersion_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MostRecentVersionRollup_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> MostRecentVersionRollup_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Product_ProductUseRequestsesExpanded")]
        public BindingList<ProductUseRequest> Product_ProductUseRequestsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequestsesExpanded")]
        public BindingList<ProductUseRequest> ProductUseRequestsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionName_MonthlyProductUseRequestsesExpanded")]
        public BindingList<MonthlyProductUseRequest> ProductVersionName_MonthlyProductUseRequestsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVesion_MonthlyProductUseRequestsesExpanded")]
        public BindingList<MonthlyProductUseRequest> ProductVesion_MonthlyProductUseRequestsExpanded { get; set; }
            

        
        
        private static string CreateProductVersionWhere(IEnumerable<ProductVersion> productVersions, String forignKeyFieldName = "ProductVersionId")
        {
            if (!productVersions.Any()) return "1=1";
            else 
            {
                var idList = productVersions.Select(selectProductVersion => String.Format("'{0}'", selectProductVersion.ProductVersionId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
