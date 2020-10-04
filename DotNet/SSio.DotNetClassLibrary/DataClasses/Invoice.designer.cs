using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace SmartSubs.io.Lib.DataClasses
{                            
    public partial class Invoice
    {
        private void InitPoco()
        {
        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceId")]
        public String InvoiceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Notes")]
        public String Notes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Attachments")]
        public AirtableAttachment[] Attachments { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Status")]
        public String Status { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Autonumber")]
        public String Autonumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceNumber")]
        public Nullable<Int32> InvoiceNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItems")]
        [RemoteIsCollection]
        public String[] InvoiceLineItems { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountHolder")]
        public String AccountHolder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceDate")]
        public Nullable<DateTime> InvoiceDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AccountStartDate")]
        [RemoteIsCollection]
        public Nullable<DateTime> AccountStartDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensee")]
        [RemoteIsCollection]
        public String Licensee { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress")]
        [RemoteIsCollection]
        public String LicenseeEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceSubTotal")]
        [RemoteIsCollection]
        public Nullable<decimal> InvoiceSubTotal { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Createdtime")]
        public Nullable<DateTime> Createdtime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OverrideInvoiceDate")]
        public Nullable<DateTime> OverrideInvoiceDate { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorInvoiceId")]
        public String PaymentProcessorInvoiceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaidAt")]
        public Nullable<DateTime> PaidAt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorMetadata")]
        public String PaymentProcessorMetadata { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorPaymentUrl")]
        public String PaymentProcessorPaymentUrl { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsUnpaid")]
        public Nullable<Int32> IsUnpaid { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Licensor")]
        [RemoteIsCollection]
        public String Licensor { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensorEmailAddress")]
        [RemoteIsCollection]
        public String LicensorEmailAddress { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentStatus")]
        public String PaymentStatus { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoicePaidAt")]
        public Nullable<DateTime> InvoicePaidAt { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PaymentProcessorName")]
        [RemoteIsCollection]
        public String PaymentProcessorName { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicenseeEmailAddress_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> LicenseeEmailAddress_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoiceStatus_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> InvoiceStatus_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsUnpaid_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> IsUnpaid_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoicePaymentProcessorPaymentUrl_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> InvoicePaymentProcessorPaymentUrl_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoicePaymentStatus_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> InvoicePaymentStatus_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InvoicePaymentProcessorStatus_InvoiceLineItemsesExpanded")]
        public BindingList<InvoiceLineItem> InvoicePaymentProcessorStatus_InvoiceLineItemsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Invoices_SSioUsersesExpanded")]
        public BindingList<SSioUser> Invoices_SSioUsersExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Invoices2_SSioUsersesExpanded")]
        public BindingList<SSioUser> Invoices2_SSioUsersExpanded { get; set; }
            

        
        
        private static string CreateInvoiceWhere(IEnumerable<Invoice> invoices, String forignKeyFieldName = "InvoiceId")
        {
            if (!invoices.Any()) return "1=1";
            else 
            {
                var idList = invoices.Select(selectInvoice => String.Format("'{0}'", selectInvoice.InvoiceId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
