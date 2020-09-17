using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class MonthlyProductUseRequest
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyProductUseRequestId")]
        public String MonthlyProductUseRequestId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountHolder")]
        public String AccountHolder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensee")]
        [RemoteIsCollection]
        public String Licensee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseYear")]
        public Nullable<Int32> ProductUseYear { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseMonth")]
        public Nullable<Int32> ProductUseMonth { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseCount")]
        public Nullable<Int32> ProductUseCount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersionName")]
        [RemoteIsCollection]
        public String ProductVersionName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVesion")]
        [RemoteIsCollection]
        public String ProductVesion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseYearMonth")]
        public String ProductUseYearMonth { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyProductUseRequests_ABSUsersesExpanded")]
        public BindingList<ABSUser> MonthlyProductUseRequests_ABSUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyProductUseRequests_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> MonthlyProductUseRequests_ProductVersionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyProductUseRequestCount_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> MonthlyProductUseRequestCount_ProductVersionsExpanded { get; set; }
            

        
        
        private static string CreateMonthlyProductUseRequestWhere(IEnumerable<MonthlyProductUseRequest> monthlyProductUseRequests, String forignKeyFieldName = "MonthlyProductUseRequestId")
        {
            if (!monthlyProductUseRequests.Any()) return "1=1";
            else 
            {
                var idList = monthlyProductUseRequests.Select(selectMonthlyProductUseRequest => String.Format("'{0}'", selectMonthlyProductUseRequest.MonthlyProductUseRequestId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
