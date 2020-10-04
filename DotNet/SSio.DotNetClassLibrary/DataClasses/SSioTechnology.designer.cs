using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class SSioTechnology
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyId")]
        public String SSioTechnologyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyPercentage")]
        public Nullable<decimal> TechnologyPercentage { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent")]
        public Nullable<decimal> PaymentProcessorPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent")]
        public Nullable<decimal> TotalMarketPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyMeters")]
        [RemoteIsCollection]
        public String TechnologyMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUCode")]
        public String SKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Brands")]
        [RemoteIsCollection]
        public String[] Brands { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SortOrder")]
        public Nullable<Int32> SortOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTCode")]
        public String SSioTCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTOwner")]
        [RemoteIsCollection]
        public String SSioTOwner { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioPercent")]
        public Nullable<decimal> SSioPercent { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessor")]
        [RemoteIsCollection]
        public String PaymentProcessor { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPercent_BrandsesExpanded")]
        public BindingList<Brand> PaymentProcessorPercent_BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalMarketPercent_BrandsesExpanded")]
        public BindingList<Brand> TotalMarketPercent_BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandsesExpanded")]
        public BindingList<Brand> BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologySKUCode_BrandsesExpanded")]
        public BindingList<Brand> SSioTechnologySKUCode_BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyPercent_BrandsesExpanded")]
        public BindingList<Brand> SSioTechnologyPercent_BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioPercent_BrandsesExpanded")]
        public BindingList<Brand> SSioPercent_BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyName_BrandsesExpanded")]
        public BindingList<Brand> SSioTechnologyName_BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologyPaymentProcessor_BrandsesExpanded")]
        public BindingList<Brand> SSioTechnologyPaymentProcessor_BrandsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologies_PaymentProcessorsesExpanded")]
        public BindingList<PaymentProcessor> SSioTechnologies_PaymentProcessorsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SSioTechnologies_SSioUsersesExpanded")]
        public BindingList<SSioUser> SSioTechnologies_SSioUsersExpanded { get; set; }
            

        
        
        private static string CreateSSioTechnologyWhere(IEnumerable<SSioTechnology> sSioTechnologies, String forignKeyFieldName = "SSioTechnologyId")
        {
            if (!sSioTechnologies.Any()) return "1=1";
            else 
            {
                var idList = sSioTechnologies.Select(selectSSioTechnology => String.Format("'{0}'", selectSSioTechnology.SSioTechnologyId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
