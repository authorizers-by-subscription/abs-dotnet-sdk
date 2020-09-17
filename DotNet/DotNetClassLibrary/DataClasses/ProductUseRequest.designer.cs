using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class ProductUseRequest
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequestId")]
        public String ProductUseRequestId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RequestStatus")]
        [RemoteIsCollection]
        public String RequestStatus { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedOn")]
        public String CreatedOn { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Product")]
        [RemoteIsCollection]
        public String Product { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensee")]
        [RemoteIsCollection]
        public String Licensee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductVersion")]
        [RemoteIsCollection]
        public String ProductVersion { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequests_ProductUseStatusesesExpanded")]
        public BindingList<ProductUseStatus> ProductUseRequests_ProductUseStatusesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequests_ABSUsersesExpanded")]
        public BindingList<ABSUser> ProductUseRequests_ABSUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequests_ProductVersionsesExpanded")]
        public BindingList<ProductVersion> ProductUseRequests_ProductVersionsExpanded { get; set; }
            

        
        
        private static string CreateProductUseRequestWhere(IEnumerable<ProductUseRequest> productUseRequests, String forignKeyFieldName = "ProductUseRequestId")
        {
            if (!productUseRequests.Any()) return "1=1";
            else 
            {
                var idList = productUseRequests.Select(selectProductUseRequest => String.Format("'{0}'", selectProductUseRequest.ProductUseRequestId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
