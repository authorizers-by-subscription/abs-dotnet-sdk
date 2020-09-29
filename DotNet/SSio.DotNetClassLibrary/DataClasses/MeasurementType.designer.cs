using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class MeasurementType
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeasurementTypeId")]
        public String MeasurementTypeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurements")]
        [RemoteIsCollection]
        public String[] UnitOfMeasurements { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurements copy")]
        [RemoteIsCollection]
        public String[] UnitOfMeasurementscopy { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMinutes")]
        public Nullable<Boolean> AddsMinutes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMonths")]
        public Nullable<Boolean> AddsMonths { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeasurementTypeName_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> MeasurementTypeName_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMinutes_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> AddsMinutes_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMonths_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> AddsMonths_UnitOfMeasurementsExpanded { get; set; }
            

        
        
        private static string CreateMeasurementTypeWhere(IEnumerable<MeasurementType> measurementTypes, String forignKeyFieldName = "MeasurementTypeId")
        {
            if (!measurementTypes.Any()) return "1=1";
            else 
            {
                var idList = measurementTypes.Select(selectMeasurementType => String.Format("'{0}'", selectMeasurementType.MeasurementTypeId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
