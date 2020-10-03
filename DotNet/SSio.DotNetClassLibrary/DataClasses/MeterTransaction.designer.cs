using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class MeterTransaction
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactionId")]
        public String MeterTransactionId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseMeter")]
        [RemoteIsCollection]
        public String ProductLicenseMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Value")]
        public Nullable<decimal> Value { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedTime")]
        public Nullable<DateTime> CreatedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AutoNumber")]
        public String AutoNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransactionResetDate")]
        [RemoteIsCollection]
        public Nullable<DateTime> TransactionResetDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomTransactionDate")]
        public Nullable<DateTime> CustomTransactionDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TransactionDate")]
        public Nullable<DateTime> TransactionDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsActive")]
        public Nullable<Int32> IsActive { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress")]
        [RemoteIsCollection]
        public String LicenseeEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailaddress")]
        [RemoteIsCollection]
        public String LicensorEmailaddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustment")]
        [RemoteIsCollection]
        public String SKUMeterAdjustment { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeter")]
        [RemoteIsCollection]
        public String LicenseMeter { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Adjustment")]
        [RemoteIsCollection]
        public Nullable<Int32> Adjustment { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CustomValue")]
        public Nullable<decimal> CustomValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicense")]
        [RemoteIsCollection]
        public String ProductLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AdjustmentType")]
        [RemoteIsCollection]
        public String AdjustmentType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UsageValue")]
        public Nullable<Int32> UsageValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LimitValue")]
        public Nullable<Int32> LimitValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AdjustsLimit")]
        public Nullable<Boolean> AdjustsLimit { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitConversion")]
        [RemoteIsCollection]
        public String UnitConversion { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitConversionValue")]
        [RemoteIsCollection]
        public Nullable<decimal> UnitConversionValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterUnitOfMeasurement")]
        [RemoteIsCollection]
        public String LicenseMeterUnitOfMeasurement { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ConversionRatio")]
        [RemoteIsCollection]
        public Nullable<decimal> ConversionRatio { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterUnitOfMeasurementSingular")]
        [RemoteIsCollection]
        public String LicenseMeterUnitOfMeasurementSingular { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseMeterUnitOfMeasurementPlural")]
        [RemoteIsCollection]
        public String LicenseMeterUnitOfMeasurementPlural { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ReplacedByMeterTransaction")]
        [RemoteIsCollection]
        public String ReplacedByMeterTransaction { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItem")]
        [RemoteIsCollection]
        public String InvoiceLineItem { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsUnpaid")]
        [RemoteIsCollection]
        public Nullable<Int32> IsUnpaid { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItemProductLicense")]
        [RemoteIsCollection]
        public String InvoiceLineItemProductLicense { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions_UnitConversionsesExpanded")]
        public BindingList<UnitConversion> MeterTransactions_UnitConversionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> MeterTransactions_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions_SKUMeterAdjustmentsesExpanded")]
        public BindingList<SKUMeterAdjustment> MeterTransactions_SKUMeterAdjustmentsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> MeterTransactions_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActiveMeterTransactionBalance_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> ActiveMeterTransactionBalance_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActiveUsageMeterTransactionBalance_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> ActiveUsageMeterTransactionBalance_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActiveMeterLimit_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> ActiveMeterLimit_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ActiveUsageValueRollup_ProductLicenseMetersesExpanded")]
        public BindingList<ProductLicenseMeter> ActiveUsageValueRollup_ProductLicenseMetersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ReplacedByMeterTransaction_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> ReplacedByMeterTransaction_MeterTransactionsExpanded { get; set; }
            

        
        
        private static string CreateMeterTransactionWhere(IEnumerable<MeterTransaction> meterTransactions, String forignKeyFieldName = "MeterTransactionId")
        {
            if (!meterTransactions.Any()) return "1=1";
            else 
            {
                var idList = meterTransactions.Select(selectMeterTransaction => String.Format("'{0}'", selectMeterTransaction.MeterTransactionId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
