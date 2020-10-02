using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using dc = SmartSubs.io.Lib.DataClasses;
using System.Collections.Generic;


namespace EffortlessAPI.SSio.SassyMQ
{
    public partial class StandardPayload
    {
        public string RoutingKey { get; set; }
        
        private StandardPayload(SMQActorBase actor, string content, bool final)
        {
            this.PayloadId = Guid.NewGuid().ToString();

            this.__Actor = actor;
            if (!ReferenceEquals(this.__Actor, null))
            {
                this.SenderId = actor.SenderId.ToString();
                this.SenderName = actor.SenderName;
                this.AccessToken = actor.AccessToken;
            }
            else
            {
                this.SenderId = Guid.NewGuid().ToString();
                this.SenderName = "Unnamed Actor";
                this.AccessToken = null;
            }

            this.Content = content;
        }

        // 27 odxml properties
        
        public String BrandId { get; set; }
        
        public dc.Brand Brand { get; set; }
        
        public List<dc.Brand> Brands { get; set; }
        
        public String ProductUseStatusId { get; set; }
        
        public dc.ProductUseStatus ProductUseStatus { get; set; }
        
        public List<dc.ProductUseStatus> ProductUseStatuses { get; set; }
        
        public String CLIOptionId { get; set; }
        
        public dc.CLIOption CLIOption { get; set; }
        
        public List<dc.CLIOption> CLIOptions { get; set; }
        
        public String UnitConversionId { get; set; }
        
        public dc.UnitConversion UnitConversion { get; set; }
        
        public List<dc.UnitConversion> UnitConversions { get; set; }
        
        public String InvoiceLineItemId { get; set; }
        
        public dc.InvoiceLineItem InvoiceLineItem { get; set; }
        
        public List<dc.InvoiceLineItem> InvoiceLineItems { get; set; }
        
        public String SSioTechnologyId { get; set; }
        
        public dc.SSioTechnology SSioTechnology { get; set; }
        
        public List<dc.SSioTechnology> SSioTechnologies { get; set; }
        
        public String SSioUserId { get; set; }
        
        public dc.SSioUser SSioUser { get; set; }
        
        public List<dc.SSioUser> SSioUsers { get; set; }
        
        public String MicroServiceCandidateId { get; set; }
        
        public dc.MicroServiceCandidate MicroServiceCandidate { get; set; }
        
        public List<dc.MicroServiceCandidate> MicroServiceCandidates { get; set; }
        
        public String ProductLicenseId { get; set; }
        
        public dc.ProductLicense ProductLicense { get; set; }
        
        public List<dc.ProductLicense> ProductLicenses { get; set; }
        
        public String LicensedProductId { get; set; }
        
        public dc.LicensedProduct LicensedProduct { get; set; }
        
        public List<dc.LicensedProduct> LicensedProducts { get; set; }
        
        public String LimitedUseTokenId { get; set; }
        
        public dc.LimitedUseToken LimitedUseToken { get; set; }
        
        public List<dc.LimitedUseToken> LimitedUseTokens { get; set; }
        
        public String OpenIssueId { get; set; }
        
        public dc.OpenIssue OpenIssue { get; set; }
        
        public List<dc.OpenIssue> OpenIssues { get; set; }
        
        public String SKUMeterAdjustmentId { get; set; }
        
        public dc.SKUMeterAdjustment SKUMeterAdjustment { get; set; }
        
        public List<dc.SKUMeterAdjustment> SKUMeterAdjustments { get; set; }
        
        public String ProductLicenseMeterId { get; set; }
        
        public dc.ProductLicenseMeter ProductLicenseMeter { get; set; }
        
        public List<dc.ProductLicenseMeter> ProductLicenseMeters { get; set; }
        
        public String LicenseMeterId { get; set; }
        
        public dc.LicenseMeter LicenseMeter { get; set; }
        
        public List<dc.LicenseMeter> LicenseMeters { get; set; }
        
        public String InvoiceId { get; set; }
        
        public dc.Invoice Invoice { get; set; }
        
        public List<dc.Invoice> Invoices { get; set; }
        
        public String BrandLicenseId { get; set; }
        
        public dc.BrandLicense BrandLicense { get; set; }
        
        public List<dc.BrandLicense> BrandLicenses { get; set; }
        
        public String ProductUseRequestId { get; set; }
        
        public dc.ProductUseRequest ProductUseRequest { get; set; }
        
        public List<dc.ProductUseRequest> ProductUseRequests { get; set; }
        
        public String LicenseTypeId { get; set; }
        
        public dc.LicenseType LicenseType { get; set; }
        
        public List<dc.LicenseType> LicenseTypes { get; set; }
        
        public String MeterTransactionId { get; set; }
        
        public dc.MeterTransaction MeterTransaction { get; set; }
        
        public List<dc.MeterTransaction> MeterTransactions { get; set; }
        
        public String LicenseSKUId { get; set; }
        
        public dc.LicenseSKU LicenseSKU { get; set; }
        
        public List<dc.LicenseSKU> LicenseSKUs { get; set; }
        
        public String SSioVersionId { get; set; }
        
        public dc.SSioVersion SSioVersion { get; set; }
        
        public List<dc.SSioVersion> SSioVersions { get; set; }
        
        public String ProductVersionId { get; set; }
        
        public dc.ProductVersion ProductVersion { get; set; }
        
        public List<dc.ProductVersion> ProductVersions { get; set; }
        
        public String UnitOfMeasurementId { get; set; }
        
        public dc.UnitOfMeasurement UnitOfMeasurement { get; set; }
        
        public List<dc.UnitOfMeasurement> UnitOfMeasurements { get; set; }
        
        public String ProductLicenseDMQueueId { get; set; }
        
        public dc.ProductLicenseDMQueue ProductLicenseDMQueue { get; set; }
        
        public List<dc.ProductLicenseDMQueue> ProductLicenseDMQueues { get; set; }
        
        public String MeasurementTypeId { get; set; }
        
        public dc.MeasurementType MeasurementType { get; set; }
        
        public List<dc.MeasurementType> MeasurementTypes { get; set; }
        
        public String MonthlyProductUseRequestId { get; set; }
        
        public dc.MonthlyProductUseRequest MonthlyProductUseRequest { get; set; }
        
        public List<dc.MonthlyProductUseRequest> MonthlyProductUseRequests { get; set; }
        
        
        public String ToJSON() 
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        private void HandleReplyTo(object sender, PayloadEventArgs e)
        {
            if (e.Payload.IsHandled && e.BasicDeliverEventArgs.BasicProperties.CorrelationId == this.PayloadId)
            {
                this.ReplyPayload = e.Payload;
                this.ReplyBDEA = e.BasicDeliverEventArgs;
                this.ReplyRecieved = true;
            }
        }

       
        public Task WaitForReply(PayloadHandler payloadHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var actor = this.__Actor;
            if (ReferenceEquals(actor, null)) throw new Exception("Can't handle response if payload.Actor is null");
            else
            {
                actor.ReplyTo += this.HandleReplyTo;
                var waitTask = Task.Factory.StartNew(() =>
                {
                    try
                    {
                        if (waitTimeout > 0 && !ReferenceEquals(payloadHandler, null))
                        {

                            this.TimedOutWaiting = false;
                            var startedAt = DateTime.Now;

                            while (!this.ReplyRecieved && !this.TimedOutWaiting && DateTime.Now < startedAt.AddSeconds(waitTimeout))
                            {
                                Thread.Sleep(100);
                            }

                            if (!this.ReplyRecieved) this.TimedOutWaiting = true;

                            var errorMessageReceived = !ReferenceEquals(this.ReplyPayload, null) && !String.IsNullOrEmpty(this.ReplyPayload.ErrorMessage);

                            if (this.ReplyRecieved && (!errorMessageReceived || ReferenceEquals(timeoutHandler, null)))
                            {
                                this.ReplyPayload.__Actor = actor;
                                payloadHandler(this.ReplyPayload, this.ReplyBDEA);
                            }
                            else if (!ReferenceEquals(timeoutHandler, null)) timeoutHandler(this.ReplyPayload, default(BasicDeliverEventArgs));
                        }

                    }
                    finally
                    {
                        actor.ReplyTo -= this.HandleReplyTo;
                    }
                });
                return waitTask;
            }
        }
    }
}