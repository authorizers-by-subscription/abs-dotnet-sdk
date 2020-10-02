using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class LicenseMeter
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterId")]
        public String LicenseMeterId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKULimitId")]
        public String SKULimitId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleSKU")]
        [RemoteIsCollection]
        public String BundleSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyMeter")]
        [RemoteIsCollection]
        public String TechnologyMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthlyMeterLimit")]
        public Nullable<decimal> MonthlyMeterLimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TotalSKUMeterLimit")]
        public Nullable<Int32> TotalSKUMeterLimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BundleMonthsIncluded")]
        [RemoteIsCollection]
        public Nullable<Int32> BundleMonthsIncluded { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTypeSKUCode")]
        [RemoteIsCollection]
        public String MeterTypeSKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMeters")]
        [RemoteIsCollection]
        public String[] ProductLicenseMeters { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LimitSKU")]
        public String LimitSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundle")]
        public String LicenseBundle { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterType")]
        [RemoteIsCollection]
        public String MeterType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseBundleName")]
        [RemoteIsCollection]
        public String LicenseBundleName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTypeName")]
        [RemoteIsCollection]
        public String MeterTypeName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterDescription")]
        public String MeterDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicense")]
        [RemoteIsCollection]
        public String BrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseName")]
        [RemoteIsCollection]
        public String BrandLicenseName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurement")]
        [RemoteIsCollection]
        public String UnitOfMeasurement { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurementPlural")]
        [RemoteIsCollection]
        public String UnitOfMeasurementPlural { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeasurementType")]
        [RemoteIsCollection]
        public String MeasurementType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMinutes")]
        [RemoteIsCollection]
        public Nullable<Boolean> AddsMinutes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMonths")]
        [RemoteIsCollection]
        public Nullable<Boolean> AddsMonths { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustments")]
        [RemoteIsCollection]
        public String[] SKUMeterAdjustments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterSourceName")]
        public String MeterSourceName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterSourceHttpPOSTUrl")]
        public String MeterSourceHttpPOSTUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterSourceHttpGETUrl")]
        public String MeterSourceHttpGETUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterDataType")]
        public String MeterDataType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BrandLicenseSKU")]
        [RemoteIsCollection]
        public String BrandLicenseSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUCode")]
        public String SKUCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterSKU")]
        public String MeterSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitOfMeasurementSingular")]
        [RemoteIsCollection]
        public String UnitOfMeasurementSingular { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LimitDirection")]
        public String LimitDirection { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForBrand")]
        [RemoteIsCollection]
        public String NameForBrand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForBrand")]
        [RemoteIsCollection]
        public String PluralNameForBrand { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForBrandLicense")]
        [RemoteIsCollection]
        public String NameForBrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForBrandLicense")]
        [RemoteIsCollection]
        public String PluralNameForBrandLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForMeter")]
        [RemoteIsCollection]
        public String NameForMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForMeter")]
        [RemoteIsCollection]
        public String PluralNameForMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NameForSKU")]
        [RemoteIsCollection]
        public String NameForSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PluralNameForSKU")]
        [RemoteIsCollection]
        public String PluralNameForSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultWarningPercent")]
        public Nullable<decimal> DefaultWarningPercent { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTypeSKUCode_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> MeterTypeSKUCode_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterUnitOfMeasurement_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> LicenseMeterUnitOfMeasurement_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Meter_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> Meter_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterSKU_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> MeterSKU_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterDataType_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> MeterDataType_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMinutes_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> AddsMinutes_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AddsMonths_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> AddsMonths_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterUnitOfMeasurement_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> LicenseMeterUnitOfMeasurement_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterUnitOfMeasurementSingular_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> LicenseMeterUnitOfMeasurementSingular_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterUnitOfMeasurementPlural_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> LicenseMeterUnitOfMeasurementPlural_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterLimitDirection_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> LicenseMeterLimitDirection_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultMeterWarningPercent_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> DefaultMeterWarningPercent_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeters_BrandLicensesesExpanded")]
        public BindingList<BrandLicense> LicenseMeters_BrandLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeters_UnitOfMeasurementsesExpanded")]
        public BindingList<UnitOfMeasurement> LicenseMeters_UnitOfMeasurementsExpanded { get; set; }
            

        
        
        private static string CreateLicenseMeterWhere(IEnumerable<LicenseMeter> licenseMeters, String forignKeyFieldName = "LicenseMeterId")
        {
            if (!licenseMeters.Any()) return "1=1";
            else 
            {
                var idList = licenseMeters.Select(selectLicenseMeter => String.Format("'{0}'", selectLicenseMeter.LicenseMeterId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
