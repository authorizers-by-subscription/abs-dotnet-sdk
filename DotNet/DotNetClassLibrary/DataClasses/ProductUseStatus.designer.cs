using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace authorizersbysubscription.Lib.DataClasses
{                            
    public partial class ProductUseStatus
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseStatusId")]
        public String ProductUseStatusId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SortOrder")]
        public String SortOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequests")]
        [RemoteIsCollection]
        public String[] ProductUseRequests { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductUseRequestStatusUUID")]
        public String ProductUseRequestStatusUUID { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RequestStatus_ProductUseRequestsesExpanded")]
        public BindingList<ProductUseRequest> RequestStatus_ProductUseRequestsExpanded { get; set; }
            

        
        
        private static string CreateProductUseStatusWhere(IEnumerable<ProductUseStatus> productUseStatuses, String forignKeyFieldName = "ProductUseStatusId")
        {
            if (!productUseStatuses.Any()) return "1=1";
            else 
            {
                var idList = productUseStatuses.Select(selectProductUseStatus => String.Format("'{0}'", selectProductUseStatus.ProductUseStatusId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
