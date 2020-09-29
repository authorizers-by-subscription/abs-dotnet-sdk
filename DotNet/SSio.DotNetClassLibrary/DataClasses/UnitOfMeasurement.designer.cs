using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class UnitOfMeasurement
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurementId")]
        public String UnitOfMeasurementId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeasurementTypeName")]
        [RemoteIsCollection]
        public String MeasurementTypeName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameSingular")]
        public String NameSingular { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NamePlural")]
        public String NamePlural { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CaseSensativeCode")]
        public String CaseSensativeCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RelatedMeasurementUnit")]
        [RemoteIsCollection]
        public String RelatedMeasurementUnit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RelatedTimeUnit")]
        [RemoteIsCollection]
        public String RelatedTimeUnit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RelatedMeasurementUnitLongCode")]
        [RemoteIsCollection]
        public String RelatedMeasurementUnitLongCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RelatedTimeUnitLongCode")]
        [RemoteIsCollection]
        public String RelatedTimeUnitLongCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "INTERNAL_SuggestedCode")]
        public String INTERNAL_SuggestedCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeasurementType")]
        [RemoteIsCollection]
        public String MeasurementType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LongCode")]
        public String LongCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeasurementValue")]
        public Nullable<decimal> MeasurementValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BaseUnit")]
        [RemoteIsCollection]
        public String BaseUnit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BaseUnitMultiplier")]
        public Nullable<decimal> BaseUnitMultiplier { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SuggestedMeasurementValue")]
        public Nullable<decimal> SuggestedMeasurementValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BaseUnitNamePlural")]
        [RemoteIsCollection]
        public String BaseUnitNamePlural { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SortOrder")]
        public Nullable<Int32> SortOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitConversions")]
        [RemoteIsCollection]
        public String[] UnitConversions { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitConversions 2")]
        [RemoteIsCollection]
        public String[] UnitConversions2 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeters")]
        [RemoteIsCollection]
        public String[] LicenseMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMinutes")]
        [RemoteIsCollection]
        public Nullable<Boolean> AddsMinutes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMonths")]
        [RemoteIsCollection]
        public Nullable<Boolean> AddsMonths { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions")]
        public String MeterTransactions { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToUnit_UnitConversionsesExpanded")]
        public BindingList<UnitConversion> ToUnit_UnitConversionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FromUnit_UnitConversionsesExpanded")]
        public BindingList<UnitConversion> FromUnit_UnitConversionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurementPlural_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> UnitOfMeasurementPlural_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeasurementType_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> MeasurementType_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMinutes_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> AddsMinutes_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMonths_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> AddsMonths_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurementSingular_LicenseMetersesExpanded")]
        public BindingList<LicenseMeter> UnitOfMeasurementSingular_LicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RelatedMeasurementUnit_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> RelatedMeasurementUnit_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RelatedTimeUnit_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> RelatedTimeUnit_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RelatedMeasurementUnitLongCode_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> RelatedMeasurementUnitLongCode_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RelatedTimeUnitLongCode_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> RelatedTimeUnitLongCode_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BaseUnit_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> BaseUnit_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BaseUnitNamePlural_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> BaseUnitNamePlural_UnitOfMeasurementsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurements_MeasurementTypesesExpanded")]
        public BindingList<MeasurementType> UnitOfMeasurements_MeasurementTypesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurementscopy_MeasurementTypesesExpanded")]
        public BindingList<MeasurementType> UnitOfMeasurementscopy_MeasurementTypesExpanded { get; set; }
            

        
        
        private static string CreateUnitOfMeasurementWhere(IEnumerable<UnitOfMeasurement> unitOfMeasurements, String forignKeyFieldName = "UnitOfMeasurementId")
        {
            if (!unitOfMeasurements.Any()) return "1=1";
            else 
            {
                var idList = unitOfMeasurements.Select(selectUnitOfMeasurement => String.Format("'{0}'", selectUnitOfMeasurement.UnitOfMeasurementId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
