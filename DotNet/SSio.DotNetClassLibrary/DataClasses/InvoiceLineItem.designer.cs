using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class InvoiceLineItem
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItemId")]
        public String InvoiceLineItemId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Invoice")]
        [RemoteIsCollection]
        public String Invoice { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountSubscription")]
        public String AccountSubscription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SubscriptionRenewalPrice")]
        [RemoteIsCollection]
        public Nullable<decimal> SubscriptionRenewalPrice { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthsPaidFor")]
        public Nullable<Int32> MonthsPaidFor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DiscountApplied")]
        public Nullable<decimal> DiscountApplied { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SubTotal")]
        public Nullable<decimal> SubTotal { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicense")]
        [RemoteIsCollection]
        public String ProductLicense { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress")]
        [RemoteIsCollection]
        public String LicenseeEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FinalMonthlyCost")]
        public Nullable<decimal> FinalMonthlyCost { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthsInvoiced")]
        public Nullable<Int32> MonthsInvoiced { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceStripeStatus")]
        [RemoteIsCollection]
        public String InvoiceStripeStatus { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceStatus")]
        [RemoteIsCollection]
        public String InvoiceStatus { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsUnpaid")]
        [RemoteIsCollection]
        public Nullable<Int32> IsUnpaid { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceStripePaymentUrl")]
        [RemoteIsCollection]
        public String InvoiceStripePaymentUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SubscriptionContractTerm")]
        [RemoteIsCollection]
        public Nullable<Int32> SubscriptionContractTerm { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ContractDiscount")]
        [RemoteIsCollection]
        public Nullable<decimal> ContractDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKU")]
        [RemoteIsCollection]
        public String LicenseSKU { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKURecurringFee")]
        [RemoteIsCollection]
        public Nullable<decimal> LicenseSKURecurringFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKUInitialFee")]
        [RemoteIsCollection]
        public Nullable<decimal> LicenseSKUInitialFee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseRenewalPrice")]
        [RemoteIsCollection]
        public Nullable<decimal> ProductLicenseRenewalPrice { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseDiscount")]
        [RemoteIsCollection]
        public Nullable<decimal> ProductLicenseDiscount { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactions")]
        [RemoteIsCollection]
        public String[] MeterTransactions { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKUUnitPrice")]
        [RemoteIsCollection]
        public Nullable<decimal> LicenseSKUUnitPrice { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CreatedTime")]
        public Nullable<DateTime> CreatedTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SKUMeterAdjustments")]
        [RemoteIsCollection]
        public String SKUMeterAdjustments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProductLicenseName")]
        [RemoteIsCollection]
        public String ProductLicenseName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseSKUName")]
        [RemoteIsCollection]
        public String LicenseSKUName { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItems_InvoicesesExpanded")]
        public BindingList<Invoice> InvoiceLineItems_InvoicesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceSubTotal_InvoicesesExpanded")]
        public BindingList<Invoice> InvoiceSubTotal_InvoicesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsUnpaid_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> IsUnpaid_MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItemProductLicense_MeterTransactionsesExpanded")]
        public BindingList<MeterTransaction> InvoiceLineItemProductLicense_MeterTransactionsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItems_LicenseSKUsesExpanded")]
        public BindingList<LicenseSKU> InvoiceLineItems_LicenseSKUsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItems_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> InvoiceLineItems_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MonthsRenewed_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> MonthsRenewed_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnpaidInvoiceCount_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> UnpaidInvoiceCount_ProductLicensesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StripePaymentUrl_ProductLicensesesExpanded")]
        public BindingList<ProductLicense> StripePaymentUrl_ProductLicensesExpanded { get; set; }
            

        
        
        private static string CreateInvoiceLineItemWhere(IEnumerable<InvoiceLineItem> invoiceLineItems, String forignKeyFieldName = "InvoiceLineItemId")
        {
            if (!invoiceLineItems.Any()) return "1=1";
            else 
            {
                var idList = invoiceLineItems.Select(selectInvoiceLineItem => String.Format("'{0}'", selectInvoiceLineItem.InvoiceLineItemId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
