using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class ABSUser
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSUserId")]
        public String ABSUserId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ScreenName")]
        public String ScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorUUID")]
        public String LicensorUUID { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EmailAddress")]
        public String EmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HashOfSecret")]
        public String HashOfSecret { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountSubscriptionFee")]
        public String AccountSubscriptionFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountLocked")]
        public Nullable<Boolean> AccountLocked { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Products")]
        [RemoteIsCollection]
        public String[] Products { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsActive")]
        public Nullable<Boolean> IsActive { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedOn")]
        public Nullable<DateTime> CreatedOn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Role")]
        public String Role { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DemoPassword")]
        public String DemoPassword { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SHA256Password")]
        public String SHA256Password { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsVerified")]
        public Nullable<Boolean> IsVerified { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LowerScreenName")]
        public String LowerScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ChosenScreenName")]
        public String ChosenScreenName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ChosenEmailAddress")]
        public String ChosenEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RECORD_ID")]
        public String RECORDID { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DisplayName")]
        public String DisplayName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Imported table")]
        public String Importedtable { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountPlan")]
        public String[] AccountPlan { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountSubscriptions")]
        public String[] AccountSubscriptions { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Invoices")]
        [RemoteIsCollection]
        public String[] Invoices { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Table 14")]
        public String Table14 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Table 14 (2)")]
        public String[] Table142 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequests")]
        [RemoteIsCollection]
        public String[] ProductUseRequests { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyProductUseRequests")]
        [RemoteIsCollection]
        public String[] MonthlyProductUseRequests { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLisences")]
        [RemoteIsCollection]
        public String[] ProductLisences { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenses")]
        [RemoteIsCollection]
        public String[] ProductLicenses { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsLicensor")]
        public Nullable<Boolean> IsLicensor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductBundle")]
        [RemoteIsCollection]
        public String[] ProductBundle { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTechnologies")]
        [RemoteIsCollection]
        public String[] ABSTechnologies { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUCode")]
        public String SKUCode { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> Licensor_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> LicensorEmailAddress_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> LicensorScreenName_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorSKUCode_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> LicensorSKUCode_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Owner_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> Owner_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OwnerScreenName_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> OwnerScreenName_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OwnerSKUCode_ProductBundlesesExpanded")]
        public BindingList<ProductBundle> OwnerSKUCode_ProductBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ABSTOwner_ABSTechnologiesesExpanded")]
        public BindingList<ABSTechnology> ABSTOwner_ABSTechnologiesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensee_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> Licensee_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> LicenseeEmailAddress_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> Licensor_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorIsVerified_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensorIsVerified_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensorEmailAddress_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorScreenName_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensorScreenName_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountIsActive_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> AccountIsActive_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorUUID_LicensedProductsesExpanded")]
        public BindingList<LicensedProduct> LicensorUUID_LicensedProductsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountStartDate_InvoicesesExpanded")]
        public BindingList<Invoice> AccountStartDate_InvoicesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensee_InvoicesesExpanded")]
        public BindingList<Invoice> Licensee_InvoicesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress_InvoicesesExpanded")]
        public BindingList<Invoice> LicenseeEmailAddress_InvoicesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddresss_LicenseBundlesesExpanded")]
        public BindingList<LicenseBundle> LicensorEmailAddresss_LicenseBundlesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensee_ProductUseRequestsesExpanded")]
        public BindingList<ProductUseRequest> Licensee_ProductUseRequestsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensee_MonthlyProductUseRequestsesExpanded")]
        public BindingList<MonthlyProductUseRequest> Licensee_MonthlyProductUseRequestsExpanded { get; set; }
            

        
        
        private static string CreateABSUserWhere(IEnumerable<ABSUser> aBSUsers, String forignKeyFieldName = "ABSUserId")
        {
            if (!aBSUsers.Any()) return "1=1";
            else 
            {
                var idList = aBSUsers.Select(selectABSUser => String.Format("'{0}'", selectABSUser.ABSUserId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
