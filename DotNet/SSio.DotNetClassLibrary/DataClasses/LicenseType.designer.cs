using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class LicenseType
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseTypeId")]
        public String LicenseTypeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundles")]
        [RemoteIsCollection]
        public String[] LicenseBundles { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PrimaryTrackingField")]
        public String PrimaryTrackingField { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicensesesExpanded")]
        public BindingList<BrandLicense> BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseTypePrimaryTrackingField_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> LicenseTypePrimaryTrackingField_BrandLicensesExpanded { get; set; }
            

        
        
        private static string CreateLicenseTypeWhere(IEnumerable<LicenseType> licenseTypes, String forignKeyFieldName = "LicenseTypeId")
        {
            if (!licenseTypes.Any()) return "1=1";
            else 
            {
                var idList = licenseTypes.Select(selectLicenseType => String.Format("'{0}'", selectLicenseType.LicenseTypeId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
