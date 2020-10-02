using smq = EffortlessAPI.SSio.SassyMQ;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using SSoT.me.AirtableToDotNetLib;
using dc = SmartSubs.io.Lib.DataClasses;
using System.Collections.Generic;

namespace SassyMQ.AirtableCRUD
{
    public partial class SMQAirtableCRUDHandler
    {
    
        private void InitActions()  // SSioUser
        
        {
            // Guest Handlers        
    
            
        }

      
    
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
        // CRUDCoordinator Handler Methods.  --
        
    
    }

    public static class OnDemandCRUDExtensions
    {
         
        
        // Guest Cleaning Extension Methods.  -R-
        
        // Brand
        public static List<dc.Brand> GuestCleanForGet(this IEnumerable<dc.Brand> cleanBrands)
        {
            return cleanBrands.Select(Brand => Brand.GuestCleanForGet())
                            .ToList();
        }
        
        public static dc.Brand GuestCleanForGet(this dc.Brand cleanBrand)
        {
            var GuestBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                GuestBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Name = cleanBrand.Name,
                    BundleName = cleanBrand.BundleName,
                    LicensorScreenName = cleanBrand.LicensorScreenName,
                    SKU = cleanBrand.SKU
                };
            }

            return GuestBrand;
        }
        
        
        // Guest Cleaning Extension Methods.  -R-
        
        // ProductUseStatus
        public static List<dc.ProductUseStatus> GuestCleanForGet(this IEnumerable<dc.ProductUseStatus> cleanProductUseStatuses)
        {
            return cleanProductUseStatuses.Select(ProductUseStatus => ProductUseStatus.GuestCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductUseStatus GuestCleanForGet(this dc.ProductUseStatus cleanProductUseStatus)
        {
            var GuestProductUseStatus = default(dc.ProductUseStatus);

            if (!ReferenceEquals(cleanProductUseStatus, null))
            {
                GuestProductUseStatus = new dc.ProductUseStatus()
                {
                    ProductUseStatusId = cleanProductUseStatus.ProductUseStatusId,
                    Name = cleanProductUseStatus.Name,
                    Description = cleanProductUseStatus.Description,
                    SortOrder = cleanProductUseStatus.SortOrder
                };
            }

            return GuestProductUseStatus;
        }
        
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  -R-
        
        // SSioTechnology
        public static List<dc.SSioTechnology> GuestCleanForGet(this IEnumerable<dc.SSioTechnology> cleanSSioTechnologies)
        {
            return cleanSSioTechnologies.Select(SSioTechnology => SSioTechnology.GuestCleanForGet())
                            .ToList();
        }
        
        public static dc.SSioTechnology GuestCleanForGet(this dc.SSioTechnology cleanSSioTechnology)
        {
            var GuestSSioTechnology = default(dc.SSioTechnology);

            if (!ReferenceEquals(cleanSSioTechnology, null))
            {
                GuestSSioTechnology = new dc.SSioTechnology()
                {
                    SSioTechnologyId = cleanSSioTechnology.SSioTechnologyId,
                    Name = cleanSSioTechnology.Name,
                    TechnologyPercentage = cleanSSioTechnology.TechnologyPercentage,
                    PaymentProcessorPercent = cleanSSioTechnology.PaymentProcessorPercent,
                    TotalMarketPercent = cleanSSioTechnology.TotalMarketPercent,
                    SKUCode = cleanSSioTechnology.SKUCode,
                    SortOrder = cleanSSioTechnology.SortOrder,
                    SSioTCode = cleanSSioTechnology.SSioTCode,
                    SSioPercent = cleanSSioTechnology.SSioPercent
                };
            }

            return GuestSSioTechnology;
        }
        
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  -R-
        
        // LicenseMeter
        public static List<dc.LicenseMeter> GuestCleanForGet(this IEnumerable<dc.LicenseMeter> cleanLicenseMeters)
        {
            return cleanLicenseMeters.Select(LicenseMeter => LicenseMeter.GuestCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseMeter GuestCleanForGet(this dc.LicenseMeter cleanLicenseMeter)
        {
            var GuestLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                GuestLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Name = cleanLicenseMeter.Name,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    TotalSKUMeterLimit = cleanLicenseMeter.TotalSKUMeterLimit,
                    BundleMonthsIncluded = cleanLicenseMeter.BundleMonthsIncluded
                };
            }

            return GuestLicenseMeter;
        }
        
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  -R-
        
        // BrandLicense
        public static List<dc.BrandLicense> GuestCleanForGet(this IEnumerable<dc.BrandLicense> cleanBrandLicenses)
        {
            return cleanBrandLicenses.Select(BrandLicense => BrandLicense.GuestCleanForGet())
                            .ToList();
        }
        
        public static dc.BrandLicense GuestCleanForGet(this dc.BrandLicense cleanBrandLicense)
        {
            var GuestBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                GuestBrandLicense = new dc.BrandLicense()
                {
                    Name = cleanBrandLicense.Name,
                    PlanName = cleanBrandLicense.PlanName,
                    LicensorScreenName = cleanBrandLicense.LicensorScreenName,
                    LicenseType = cleanBrandLicense.LicenseType,
                    InitialFee = cleanBrandLicense.InitialFee,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    SKU = cleanBrandLicense.SKU,
                    BrandName = cleanBrandLicense.BrandName,
                    DefaultTerm = cleanBrandLicense.DefaultTerm,
                    DefaultRenewalFee = cleanBrandLicense.DefaultRenewalFee,
                    DefaultTermDays = cleanBrandLicense.DefaultTermDays,
                    SSioTechnologySKUCode = cleanBrandLicense.SSioTechnologySKUCode
                };
            }

            return GuestBrandLicense;
        }
        
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  -R-
        
        // LicenseSKU
        public static List<dc.LicenseSKU> GuestCleanForGet(this IEnumerable<dc.LicenseSKU> cleanLicenseSKUs)
        {
            return cleanLicenseSKUs.Select(LicenseSKU => LicenseSKU.GuestCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseSKU GuestCleanForGet(this dc.LicenseSKU cleanLicenseSKU)
        {
            var GuestLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                GuestLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Name = cleanLicenseSKU.Name,
                    MonthsIncluded = cleanLicenseSKU.MonthsIncluded,
                    LicensorEmailAddress = cleanLicenseSKU.LicensorEmailAddress,
                    SKU = cleanLicenseSKU.SKU,
                    PlanName = cleanLicenseSKU.PlanName,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    SSioTechnologySKUCode = cleanLicenseSKU.SSioTechnologySKUCode
                };
            }

            return GuestLicenseSKU;
        }
        
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
        // Guest Cleaning Extension Methods.  --
        
    
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // Brand
        public static dc.Brand LicenseCoordinatorCleanForAdd(this dc.Brand cleanBrand)
        {
            var LicenseCoordinatorBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                LicenseCoordinatorBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    SKUCode = cleanBrand.SKUCode,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorBrand;
        }
        
        
        public static List<dc.Brand> LicenseCoordinatorCleanForGet(this IEnumerable<dc.Brand> cleanBrands)
        {
            return cleanBrands.Select(Brand => Brand.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.Brand LicenseCoordinatorCleanForGet(this dc.Brand cleanBrand)
        {
            var LicenseCoordinatorBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                LicenseCoordinatorBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Name = cleanBrand.Name,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    LicensorEmailAddress = cleanBrand.LicensorEmailAddress,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    LicensorScreenName = cleanBrand.LicensorScreenName,
                    SKUCode = cleanBrand.SKUCode,
                    LicensorSKUCode = cleanBrand.LicensorSKUCode,
                    SKU = cleanBrand.SKU,
                    PaymentProcessorPercent = cleanBrand.PaymentProcessorPercent,
                    TotalMarketPercent = cleanBrand.TotalMarketPercent,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    OwnerScreenName = cleanBrand.OwnerScreenName,
                    OwnerSKUCode = cleanBrand.OwnerSKUCode,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    ModifiedTime = cleanBrand.ModifiedTime,
                    CreatedTime = cleanBrand.CreatedTime,
                    OwnerIsVerified = cleanBrand.OwnerIsVerified,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    SSioTechnologySKUCode = cleanBrand.SSioTechnologySKUCode,
                    SSioTechnologyPercent = cleanBrand.SSioTechnologyPercent,
                    SSioPercent = cleanBrand.SSioPercent,
                    SSioTechnologyName = cleanBrand.SSioTechnologyName,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    NameForBrand = cleanBrand.NameForBrand,
                    PluralNameForBrand = cleanBrand.PluralNameForBrand,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    LicensorLicenseEventWebhookUrl = cleanBrand.LicensorLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanBrand.LicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorBrand;
        }
        
        
        public static dc.Brand LicenseCoordinatorCleanForUpdate(this dc.Brand cleanBrand)
        {
            var LicenseCoordinatorBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                LicenseCoordinatorBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    SKUCode = cleanBrand.SKUCode,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorBrand;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // ProductUseStatus
        public static dc.ProductUseStatus LicenseCoordinatorCleanForAdd(this dc.ProductUseStatus cleanProductUseStatus)
        {
            var LicenseCoordinatorProductUseStatus = default(dc.ProductUseStatus);

            if (!ReferenceEquals(cleanProductUseStatus, null))
            {
                LicenseCoordinatorProductUseStatus = new dc.ProductUseStatus()
                {
                    ProductUseStatusId = cleanProductUseStatus.ProductUseStatusId,
                    Name = cleanProductUseStatus.Name,
                    Description = cleanProductUseStatus.Description,
                    SortOrder = cleanProductUseStatus.SortOrder,
                    ProductUseRequests = cleanProductUseStatus.ProductUseRequests,
                    ProductUseRequestStatusUUID = cleanProductUseStatus.ProductUseRequestStatusUUID
                };
            }

            return LicenseCoordinatorProductUseStatus;
        }
        
        
        public static List<dc.ProductUseStatus> LicenseCoordinatorCleanForGet(this IEnumerable<dc.ProductUseStatus> cleanProductUseStatuses)
        {
            return cleanProductUseStatuses.Select(ProductUseStatus => ProductUseStatus.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductUseStatus LicenseCoordinatorCleanForGet(this dc.ProductUseStatus cleanProductUseStatus)
        {
            var LicenseCoordinatorProductUseStatus = default(dc.ProductUseStatus);

            if (!ReferenceEquals(cleanProductUseStatus, null))
            {
                LicenseCoordinatorProductUseStatus = new dc.ProductUseStatus()
                {
                    ProductUseStatusId = cleanProductUseStatus.ProductUseStatusId,
                    Name = cleanProductUseStatus.Name,
                    Description = cleanProductUseStatus.Description,
                    SortOrder = cleanProductUseStatus.SortOrder,
                    ProductUseRequests = cleanProductUseStatus.ProductUseRequests,
                    ProductUseRequestStatusUUID = cleanProductUseStatus.ProductUseRequestStatusUUID
                };
            }

            return LicenseCoordinatorProductUseStatus;
        }
        
        
        public static dc.ProductUseStatus LicenseCoordinatorCleanForUpdate(this dc.ProductUseStatus cleanProductUseStatus)
        {
            var LicenseCoordinatorProductUseStatus = default(dc.ProductUseStatus);

            if (!ReferenceEquals(cleanProductUseStatus, null))
            {
                LicenseCoordinatorProductUseStatus = new dc.ProductUseStatus()
                {
                    ProductUseStatusId = cleanProductUseStatus.ProductUseStatusId,
                    Name = cleanProductUseStatus.Name,
                    Description = cleanProductUseStatus.Description,
                    SortOrder = cleanProductUseStatus.SortOrder,
                    ProductUseRequests = cleanProductUseStatus.ProductUseRequests,
                    ProductUseRequestStatusUUID = cleanProductUseStatus.ProductUseRequestStatusUUID
                };
            }

            return LicenseCoordinatorProductUseStatus;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // CLIOption
        public static dc.CLIOption LicenseCoordinatorCleanForAdd(this dc.CLIOption cleanCLIOption)
        {
            var LicenseCoordinatorCLIOption = default(dc.CLIOption);

            if (!ReferenceEquals(cleanCLIOption, null))
            {
                LicenseCoordinatorCLIOption = new dc.CLIOption()
                {
                    CLIOptionId = cleanCLIOption.CLIOptionId,
                    Name = cleanCLIOption.Name,
                    Description = cleanCLIOption.Description,
                    Aliases = cleanCLIOption.Aliases,
                    DataType = cleanCLIOption.DataType,
                    IsOptional = cleanCLIOption.IsOptional,
                    IsList = cleanCLIOption.IsList,
                    DefaultValue = cleanCLIOption.DefaultValue,
                    ExampleValue = cleanCLIOption.ExampleValue,
                    Enabled = cleanCLIOption.Enabled,
                    Version = cleanCLIOption.Version,
                    SortOrder = cleanCLIOption.SortOrder,
                    Category = cleanCLIOption.Category
                };
            }

            return LicenseCoordinatorCLIOption;
        }
        
        
        public static List<dc.CLIOption> LicenseCoordinatorCleanForGet(this IEnumerable<dc.CLIOption> cleanCLIOptions)
        {
            return cleanCLIOptions.Select(CLIOption => CLIOption.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.CLIOption LicenseCoordinatorCleanForGet(this dc.CLIOption cleanCLIOption)
        {
            var LicenseCoordinatorCLIOption = default(dc.CLIOption);

            if (!ReferenceEquals(cleanCLIOption, null))
            {
                LicenseCoordinatorCLIOption = new dc.CLIOption()
                {
                    CLIOptionId = cleanCLIOption.CLIOptionId,
                    Name = cleanCLIOption.Name,
                    Description = cleanCLIOption.Description,
                    Aliases = cleanCLIOption.Aliases,
                    DataType = cleanCLIOption.DataType,
                    IsOptional = cleanCLIOption.IsOptional,
                    IsList = cleanCLIOption.IsList,
                    DefaultValue = cleanCLIOption.DefaultValue,
                    ExampleValue = cleanCLIOption.ExampleValue,
                    Enabled = cleanCLIOption.Enabled,
                    Version = cleanCLIOption.Version,
                    SortOrder = cleanCLIOption.SortOrder,
                    Category = cleanCLIOption.Category
                };
            }

            return LicenseCoordinatorCLIOption;
        }
        
        
        public static dc.CLIOption LicenseCoordinatorCleanForUpdate(this dc.CLIOption cleanCLIOption)
        {
            var LicenseCoordinatorCLIOption = default(dc.CLIOption);

            if (!ReferenceEquals(cleanCLIOption, null))
            {
                LicenseCoordinatorCLIOption = new dc.CLIOption()
                {
                    CLIOptionId = cleanCLIOption.CLIOptionId,
                    Name = cleanCLIOption.Name,
                    Description = cleanCLIOption.Description,
                    Aliases = cleanCLIOption.Aliases,
                    DataType = cleanCLIOption.DataType,
                    IsOptional = cleanCLIOption.IsOptional,
                    IsList = cleanCLIOption.IsList,
                    DefaultValue = cleanCLIOption.DefaultValue,
                    ExampleValue = cleanCLIOption.ExampleValue,
                    Enabled = cleanCLIOption.Enabled,
                    Version = cleanCLIOption.Version,
                    SortOrder = cleanCLIOption.SortOrder,
                    Category = cleanCLIOption.Category
                };
            }

            return LicenseCoordinatorCLIOption;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // UnitConversion
        public static dc.UnitConversion LicenseCoordinatorCleanForAdd(this dc.UnitConversion cleanUnitConversion)
        {
            var LicenseCoordinatorUnitConversion = default(dc.UnitConversion);

            if (!ReferenceEquals(cleanUnitConversion, null))
            {
                LicenseCoordinatorUnitConversion = new dc.UnitConversion()
                {
                    UnitConversionId = cleanUnitConversion.UnitConversionId,
                    Notes = cleanUnitConversion.Notes,
                    Attachments = cleanUnitConversion.Attachments,
                    Status = cleanUnitConversion.Status,
                    ToUnit = cleanUnitConversion.ToUnit,
                    FromUnit = cleanUnitConversion.FromUnit,
                    ConversionRatio = cleanUnitConversion.ConversionRatio,
                    MeterTransactions = cleanUnitConversion.MeterTransactions
                };
            }

            return LicenseCoordinatorUnitConversion;
        }
        
        
        public static List<dc.UnitConversion> LicenseCoordinatorCleanForGet(this IEnumerable<dc.UnitConversion> cleanUnitConversions)
        {
            return cleanUnitConversions.Select(UnitConversion => UnitConversion.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.UnitConversion LicenseCoordinatorCleanForGet(this dc.UnitConversion cleanUnitConversion)
        {
            var LicenseCoordinatorUnitConversion = default(dc.UnitConversion);

            if (!ReferenceEquals(cleanUnitConversion, null))
            {
                LicenseCoordinatorUnitConversion = new dc.UnitConversion()
                {
                    UnitConversionId = cleanUnitConversion.UnitConversionId,
                    Name = cleanUnitConversion.Name,
                    Notes = cleanUnitConversion.Notes,
                    Attachments = cleanUnitConversion.Attachments,
                    Status = cleanUnitConversion.Status,
                    ToUnit = cleanUnitConversion.ToUnit,
                    FromUnit = cleanUnitConversion.FromUnit,
                    ConversionRatio = cleanUnitConversion.ConversionRatio,
                    MeterTransactions = cleanUnitConversion.MeterTransactions
                };
            }

            return LicenseCoordinatorUnitConversion;
        }
        
        
        public static dc.UnitConversion LicenseCoordinatorCleanForUpdate(this dc.UnitConversion cleanUnitConversion)
        {
            var LicenseCoordinatorUnitConversion = default(dc.UnitConversion);

            if (!ReferenceEquals(cleanUnitConversion, null))
            {
                LicenseCoordinatorUnitConversion = new dc.UnitConversion()
                {
                    UnitConversionId = cleanUnitConversion.UnitConversionId,
                    Notes = cleanUnitConversion.Notes,
                    Attachments = cleanUnitConversion.Attachments,
                    Status = cleanUnitConversion.Status,
                    ToUnit = cleanUnitConversion.ToUnit,
                    FromUnit = cleanUnitConversion.FromUnit,
                    ConversionRatio = cleanUnitConversion.ConversionRatio,
                    MeterTransactions = cleanUnitConversion.MeterTransactions
                };
            }

            return LicenseCoordinatorUnitConversion;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // InvoiceLineItem
        public static dc.InvoiceLineItem LicenseCoordinatorCleanForAdd(this dc.InvoiceLineItem cleanInvoiceLineItem)
        {
            var LicenseCoordinatorInvoiceLineItem = default(dc.InvoiceLineItem);

            if (!ReferenceEquals(cleanInvoiceLineItem, null))
            {
                LicenseCoordinatorInvoiceLineItem = new dc.InvoiceLineItem()
                {
                    InvoiceLineItemId = cleanInvoiceLineItem.InvoiceLineItemId,
                    Notes = cleanInvoiceLineItem.Notes,
                    Attachments = cleanInvoiceLineItem.Attachments,
                    Status = cleanInvoiceLineItem.Status,
                    Invoice = cleanInvoiceLineItem.Invoice,
                    AccountSubscription = cleanInvoiceLineItem.AccountSubscription,
                    DiscountApplied = cleanInvoiceLineItem.DiscountApplied,
                    SubTotal = cleanInvoiceLineItem.SubTotal,
                    ProductLicense = cleanInvoiceLineItem.ProductLicense,
                    MonthsInvoiced = cleanInvoiceLineItem.MonthsInvoiced
                };
            }

            return LicenseCoordinatorInvoiceLineItem;
        }
        
        
        public static List<dc.InvoiceLineItem> LicenseCoordinatorCleanForGet(this IEnumerable<dc.InvoiceLineItem> cleanInvoiceLineItems)
        {
            return cleanInvoiceLineItems.Select(InvoiceLineItem => InvoiceLineItem.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.InvoiceLineItem LicenseCoordinatorCleanForGet(this dc.InvoiceLineItem cleanInvoiceLineItem)
        {
            var LicenseCoordinatorInvoiceLineItem = default(dc.InvoiceLineItem);

            if (!ReferenceEquals(cleanInvoiceLineItem, null))
            {
                LicenseCoordinatorInvoiceLineItem = new dc.InvoiceLineItem()
                {
                    InvoiceLineItemId = cleanInvoiceLineItem.InvoiceLineItemId,
                    Name = cleanInvoiceLineItem.Name,
                    Notes = cleanInvoiceLineItem.Notes,
                    Attachments = cleanInvoiceLineItem.Attachments,
                    Status = cleanInvoiceLineItem.Status,
                    Invoice = cleanInvoiceLineItem.Invoice,
                    AccountSubscription = cleanInvoiceLineItem.AccountSubscription,
                    SubscriptionRenewalPrice = cleanInvoiceLineItem.SubscriptionRenewalPrice,
                    MonthsPaidFor = cleanInvoiceLineItem.MonthsPaidFor,
                    DiscountApplied = cleanInvoiceLineItem.DiscountApplied,
                    SubTotal = cleanInvoiceLineItem.SubTotal,
                    ProductLicense = cleanInvoiceLineItem.ProductLicense,
                    LicenseeEmailAddress = cleanInvoiceLineItem.LicenseeEmailAddress,
                    FinalMonthlyCost = cleanInvoiceLineItem.FinalMonthlyCost,
                    MonthsInvoiced = cleanInvoiceLineItem.MonthsInvoiced,
                    InvoiceStripeStatus = cleanInvoiceLineItem.InvoiceStripeStatus,
                    InvoiceStatus = cleanInvoiceLineItem.InvoiceStatus,
                    IsUnpaid = cleanInvoiceLineItem.IsUnpaid,
                    InvoiceStripePaymentUrl = cleanInvoiceLineItem.InvoiceStripePaymentUrl,
                    LicensorEmailAddress = cleanInvoiceLineItem.LicensorEmailAddress,
                    SubscriptionContractTerm = cleanInvoiceLineItem.SubscriptionContractTerm,
                    ContractDiscount = cleanInvoiceLineItem.ContractDiscount
                };
            }

            return LicenseCoordinatorInvoiceLineItem;
        }
        
        
        public static dc.InvoiceLineItem LicenseCoordinatorCleanForUpdate(this dc.InvoiceLineItem cleanInvoiceLineItem)
        {
            var LicenseCoordinatorInvoiceLineItem = default(dc.InvoiceLineItem);

            if (!ReferenceEquals(cleanInvoiceLineItem, null))
            {
                LicenseCoordinatorInvoiceLineItem = new dc.InvoiceLineItem()
                {
                    InvoiceLineItemId = cleanInvoiceLineItem.InvoiceLineItemId,
                    Notes = cleanInvoiceLineItem.Notes,
                    Attachments = cleanInvoiceLineItem.Attachments,
                    Status = cleanInvoiceLineItem.Status,
                    Invoice = cleanInvoiceLineItem.Invoice,
                    AccountSubscription = cleanInvoiceLineItem.AccountSubscription,
                    DiscountApplied = cleanInvoiceLineItem.DiscountApplied,
                    SubTotal = cleanInvoiceLineItem.SubTotal,
                    ProductLicense = cleanInvoiceLineItem.ProductLicense,
                    MonthsInvoiced = cleanInvoiceLineItem.MonthsInvoiced
                };
            }

            return LicenseCoordinatorInvoiceLineItem;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // SSioTechnology
        public static dc.SSioTechnology LicenseCoordinatorCleanForAdd(this dc.SSioTechnology cleanSSioTechnology)
        {
            var LicenseCoordinatorSSioTechnology = default(dc.SSioTechnology);

            if (!ReferenceEquals(cleanSSioTechnology, null))
            {
                LicenseCoordinatorSSioTechnology = new dc.SSioTechnology()
                {
                    SSioTechnologyId = cleanSSioTechnology.SSioTechnologyId,
                    Name = cleanSSioTechnology.Name,
                    Notes = cleanSSioTechnology.Notes,
                    Attachments = cleanSSioTechnology.Attachments,
                    Status = cleanSSioTechnology.Status,
                    TechnologyPercentage = cleanSSioTechnology.TechnologyPercentage,
                    PaymentProcessorPercent = cleanSSioTechnology.PaymentProcessorPercent,
                    TechnologyMeters = cleanSSioTechnology.TechnologyMeters,
                    SKUCode = cleanSSioTechnology.SKUCode,
                    Brands = cleanSSioTechnology.Brands,
                    SortOrder = cleanSSioTechnology.SortOrder,
                    SSioTOwner = cleanSSioTechnology.SSioTOwner,
                    SSioPercent = cleanSSioTechnology.SSioPercent
                };
            }

            return LicenseCoordinatorSSioTechnology;
        }
        
        
        public static List<dc.SSioTechnology> LicenseCoordinatorCleanForGet(this IEnumerable<dc.SSioTechnology> cleanSSioTechnologies)
        {
            return cleanSSioTechnologies.Select(SSioTechnology => SSioTechnology.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.SSioTechnology LicenseCoordinatorCleanForGet(this dc.SSioTechnology cleanSSioTechnology)
        {
            var LicenseCoordinatorSSioTechnology = default(dc.SSioTechnology);

            if (!ReferenceEquals(cleanSSioTechnology, null))
            {
                LicenseCoordinatorSSioTechnology = new dc.SSioTechnology()
                {
                    SSioTechnologyId = cleanSSioTechnology.SSioTechnologyId,
                    Name = cleanSSioTechnology.Name,
                    Notes = cleanSSioTechnology.Notes,
                    Attachments = cleanSSioTechnology.Attachments,
                    Status = cleanSSioTechnology.Status,
                    TechnologyPercentage = cleanSSioTechnology.TechnologyPercentage,
                    PaymentProcessorPercent = cleanSSioTechnology.PaymentProcessorPercent,
                    TotalMarketPercent = cleanSSioTechnology.TotalMarketPercent,
                    TechnologyMeters = cleanSSioTechnology.TechnologyMeters,
                    SKUCode = cleanSSioTechnology.SKUCode,
                    Brands = cleanSSioTechnology.Brands,
                    SortOrder = cleanSSioTechnology.SortOrder,
                    SSioTCode = cleanSSioTechnology.SSioTCode,
                    SSioTOwner = cleanSSioTechnology.SSioTOwner,
                    SSioPercent = cleanSSioTechnology.SSioPercent
                };
            }

            return LicenseCoordinatorSSioTechnology;
        }
        
        
        public static dc.SSioTechnology LicenseCoordinatorCleanForUpdate(this dc.SSioTechnology cleanSSioTechnology)
        {
            var LicenseCoordinatorSSioTechnology = default(dc.SSioTechnology);

            if (!ReferenceEquals(cleanSSioTechnology, null))
            {
                LicenseCoordinatorSSioTechnology = new dc.SSioTechnology()
                {
                    SSioTechnologyId = cleanSSioTechnology.SSioTechnologyId,
                    Name = cleanSSioTechnology.Name,
                    Notes = cleanSSioTechnology.Notes,
                    Attachments = cleanSSioTechnology.Attachments,
                    Status = cleanSSioTechnology.Status,
                    TechnologyPercentage = cleanSSioTechnology.TechnologyPercentage,
                    PaymentProcessorPercent = cleanSSioTechnology.PaymentProcessorPercent,
                    TechnologyMeters = cleanSSioTechnology.TechnologyMeters,
                    SKUCode = cleanSSioTechnology.SKUCode,
                    Brands = cleanSSioTechnology.Brands,
                    SortOrder = cleanSSioTechnology.SortOrder,
                    SSioTOwner = cleanSSioTechnology.SSioTOwner,
                    SSioPercent = cleanSSioTechnology.SSioPercent
                };
            }

            return LicenseCoordinatorSSioTechnology;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // SSioUser
        public static dc.SSioUser LicenseCoordinatorCleanForAdd(this dc.SSioUser cleanSSioUser)
        {
            var LicenseCoordinatorSSioUser = default(dc.SSioUser);

            if (!ReferenceEquals(cleanSSioUser, null))
            {
                LicenseCoordinatorSSioUser = new dc.SSioUser()
                {
                    SSioUserId = cleanSSioUser.SSioUserId,
                    LicensorUUID = cleanSSioUser.LicensorUUID,
                    HashOfSecret = cleanSSioUser.HashOfSecret,
                    AccountSubscriptionFee = cleanSSioUser.AccountSubscriptionFee,
                    Description = cleanSSioUser.Description,
                    AccountLocked = cleanSSioUser.AccountLocked,
                    Products = cleanSSioUser.Products,
                    Name = cleanSSioUser.Name,
                    IsActive = cleanSSioUser.IsActive,
                    Role = cleanSSioUser.Role,
                    DemoPassword = cleanSSioUser.DemoPassword,
                    SHA256Password = cleanSSioUser.SHA256Password,
                    IsVerified = cleanSSioUser.IsVerified,
                    ChosenScreenName = cleanSSioUser.ChosenScreenName,
                    ChosenEmailAddress = cleanSSioUser.ChosenEmailAddress,
                    Importedtable = cleanSSioUser.Importedtable,
                    AccountPlan = cleanSSioUser.AccountPlan,
                    AccountSubscriptions = cleanSSioUser.AccountSubscriptions,
                    Invoices = cleanSSioUser.Invoices,
                    Table14 = cleanSSioUser.Table14,
                    Table142 = cleanSSioUser.Table142,
                    ProductUseRequests = cleanSSioUser.ProductUseRequests,
                    MonthlyProductUseRequests = cleanSSioUser.MonthlyProductUseRequests,
                    ProductLisences = cleanSSioUser.ProductLisences,
                    ProductLicenses = cleanSSioUser.ProductLicenses,
                    IsLicensor = cleanSSioUser.IsLicensor,
                    Brands = cleanSSioUser.Brands,
                    SKUCode = cleanSSioUser.SKUCode,
                    SSioTechnologies = cleanSSioUser.SSioTechnologies,
                    NameForBrand = cleanSSioUser.NameForBrand,
                    PluralNameForBrand = cleanSSioUser.PluralNameForBrand,
                    DefaultLicenseEventWebhookUrl = cleanSSioUser.DefaultLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorSSioUser;
        }
        
        
        public static List<dc.SSioUser> LicenseCoordinatorCleanForGet(this IEnumerable<dc.SSioUser> cleanSSioUsers)
        {
            return cleanSSioUsers.Select(SSioUser => SSioUser.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.SSioUser LicenseCoordinatorCleanForGet(this dc.SSioUser cleanSSioUser)
        {
            var LicenseCoordinatorSSioUser = default(dc.SSioUser);

            if (!ReferenceEquals(cleanSSioUser, null))
            {
                LicenseCoordinatorSSioUser = new dc.SSioUser()
                {
                    SSioUserId = cleanSSioUser.SSioUserId,
                    ScreenName = cleanSSioUser.ScreenName,
                    LicensorUUID = cleanSSioUser.LicensorUUID,
                    EmailAddress = cleanSSioUser.EmailAddress,
                    HashOfSecret = cleanSSioUser.HashOfSecret,
                    AccountSubscriptionFee = cleanSSioUser.AccountSubscriptionFee,
                    Description = cleanSSioUser.Description,
                    AccountLocked = cleanSSioUser.AccountLocked,
                    Products = cleanSSioUser.Products,
                    Name = cleanSSioUser.Name,
                    IsActive = cleanSSioUser.IsActive,
                    CreatedOn = cleanSSioUser.CreatedOn,
                    Role = cleanSSioUser.Role,
                    DemoPassword = cleanSSioUser.DemoPassword,
                    SHA256Password = cleanSSioUser.SHA256Password,
                    IsVerified = cleanSSioUser.IsVerified,
                    LowerScreenName = cleanSSioUser.LowerScreenName,
                    ChosenScreenName = cleanSSioUser.ChosenScreenName,
                    ChosenEmailAddress = cleanSSioUser.ChosenEmailAddress,
                    RECORDID = cleanSSioUser.RECORDID,
                    DisplayName = cleanSSioUser.DisplayName,
                    Importedtable = cleanSSioUser.Importedtable,
                    AccountPlan = cleanSSioUser.AccountPlan,
                    AccountSubscriptions = cleanSSioUser.AccountSubscriptions,
                    Invoices = cleanSSioUser.Invoices,
                    Table14 = cleanSSioUser.Table14,
                    Table142 = cleanSSioUser.Table142,
                    ProductUseRequests = cleanSSioUser.ProductUseRequests,
                    MonthlyProductUseRequests = cleanSSioUser.MonthlyProductUseRequests,
                    ProductLisences = cleanSSioUser.ProductLisences,
                    ProductLicenses = cleanSSioUser.ProductLicenses,
                    IsLicensor = cleanSSioUser.IsLicensor,
                    Brands = cleanSSioUser.Brands,
                    SKUCode = cleanSSioUser.SKUCode,
                    SSioTechnologies = cleanSSioUser.SSioTechnologies,
                    NameForBrand = cleanSSioUser.NameForBrand,
                    PluralNameForBrand = cleanSSioUser.PluralNameForBrand,
                    DefaultLicenseEventWebhookUrl = cleanSSioUser.DefaultLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorSSioUser;
        }
        
        
        public static dc.SSioUser LicenseCoordinatorCleanForUpdate(this dc.SSioUser cleanSSioUser)
        {
            var LicenseCoordinatorSSioUser = default(dc.SSioUser);

            if (!ReferenceEquals(cleanSSioUser, null))
            {
                LicenseCoordinatorSSioUser = new dc.SSioUser()
                {
                    SSioUserId = cleanSSioUser.SSioUserId,
                    LicensorUUID = cleanSSioUser.LicensorUUID,
                    HashOfSecret = cleanSSioUser.HashOfSecret,
                    AccountSubscriptionFee = cleanSSioUser.AccountSubscriptionFee,
                    Description = cleanSSioUser.Description,
                    AccountLocked = cleanSSioUser.AccountLocked,
                    Products = cleanSSioUser.Products,
                    Name = cleanSSioUser.Name,
                    IsActive = cleanSSioUser.IsActive,
                    Role = cleanSSioUser.Role,
                    DemoPassword = cleanSSioUser.DemoPassword,
                    SHA256Password = cleanSSioUser.SHA256Password,
                    IsVerified = cleanSSioUser.IsVerified,
                    ChosenScreenName = cleanSSioUser.ChosenScreenName,
                    ChosenEmailAddress = cleanSSioUser.ChosenEmailAddress,
                    Importedtable = cleanSSioUser.Importedtable,
                    AccountPlan = cleanSSioUser.AccountPlan,
                    AccountSubscriptions = cleanSSioUser.AccountSubscriptions,
                    Invoices = cleanSSioUser.Invoices,
                    Table14 = cleanSSioUser.Table14,
                    Table142 = cleanSSioUser.Table142,
                    ProductUseRequests = cleanSSioUser.ProductUseRequests,
                    MonthlyProductUseRequests = cleanSSioUser.MonthlyProductUseRequests,
                    ProductLisences = cleanSSioUser.ProductLisences,
                    ProductLicenses = cleanSSioUser.ProductLicenses,
                    IsLicensor = cleanSSioUser.IsLicensor,
                    Brands = cleanSSioUser.Brands,
                    SKUCode = cleanSSioUser.SKUCode,
                    SSioTechnologies = cleanSSioUser.SSioTechnologies,
                    NameForBrand = cleanSSioUser.NameForBrand,
                    PluralNameForBrand = cleanSSioUser.PluralNameForBrand,
                    DefaultLicenseEventWebhookUrl = cleanSSioUser.DefaultLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorSSioUser;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // MicroServiceCandidate
        public static dc.MicroServiceCandidate LicenseCoordinatorCleanForAdd(this dc.MicroServiceCandidate cleanMicroServiceCandidate)
        {
            var LicenseCoordinatorMicroServiceCandidate = default(dc.MicroServiceCandidate);

            if (!ReferenceEquals(cleanMicroServiceCandidate, null))
            {
                LicenseCoordinatorMicroServiceCandidate = new dc.MicroServiceCandidate()
                {
                    MicroServiceCandidateId = cleanMicroServiceCandidate.MicroServiceCandidateId,
                    Name = cleanMicroServiceCandidate.Name,
                    Notes = cleanMicroServiceCandidate.Notes,
                    Attachments = cleanMicroServiceCandidate.Attachments,
                    Status = cleanMicroServiceCandidate.Status
                };
            }

            return LicenseCoordinatorMicroServiceCandidate;
        }
        
        
        public static List<dc.MicroServiceCandidate> LicenseCoordinatorCleanForGet(this IEnumerable<dc.MicroServiceCandidate> cleanMicroServiceCandidates)
        {
            return cleanMicroServiceCandidates.Select(MicroServiceCandidate => MicroServiceCandidate.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.MicroServiceCandidate LicenseCoordinatorCleanForGet(this dc.MicroServiceCandidate cleanMicroServiceCandidate)
        {
            var LicenseCoordinatorMicroServiceCandidate = default(dc.MicroServiceCandidate);

            if (!ReferenceEquals(cleanMicroServiceCandidate, null))
            {
                LicenseCoordinatorMicroServiceCandidate = new dc.MicroServiceCandidate()
                {
                    MicroServiceCandidateId = cleanMicroServiceCandidate.MicroServiceCandidateId,
                    Name = cleanMicroServiceCandidate.Name,
                    Notes = cleanMicroServiceCandidate.Notes,
                    Attachments = cleanMicroServiceCandidate.Attachments,
                    Status = cleanMicroServiceCandidate.Status
                };
            }

            return LicenseCoordinatorMicroServiceCandidate;
        }
        
        
        public static dc.MicroServiceCandidate LicenseCoordinatorCleanForUpdate(this dc.MicroServiceCandidate cleanMicroServiceCandidate)
        {
            var LicenseCoordinatorMicroServiceCandidate = default(dc.MicroServiceCandidate);

            if (!ReferenceEquals(cleanMicroServiceCandidate, null))
            {
                LicenseCoordinatorMicroServiceCandidate = new dc.MicroServiceCandidate()
                {
                    MicroServiceCandidateId = cleanMicroServiceCandidate.MicroServiceCandidateId,
                    Name = cleanMicroServiceCandidate.Name,
                    Notes = cleanMicroServiceCandidate.Notes,
                    Attachments = cleanMicroServiceCandidate.Attachments,
                    Status = cleanMicroServiceCandidate.Status
                };
            }

            return LicenseCoordinatorMicroServiceCandidate;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // ProductLicense
        public static dc.ProductLicense LicenseCoordinatorCleanForAdd(this dc.ProductLicense cleanProductLicense)
        {
            var LicenseCoordinatorProductLicense = default(dc.ProductLicense);

            if (!ReferenceEquals(cleanProductLicense, null))
            {
                LicenseCoordinatorProductLicense = new dc.ProductLicense()
                {
                    ProductLicenseId = cleanProductLicense.ProductLicenseId,
                    Notes = cleanProductLicense.Notes,
                    Attachments = cleanProductLicense.Attachments,
                    Status = cleanProductLicense.Status,
                    LicenseGroup = cleanProductLicense.LicenseGroup,
                    Licensee = cleanProductLicense.Licensee,
                    InvoiceLineItems = cleanProductLicense.InvoiceLineItems,
                    MonthsRenewed = cleanProductLicense.MonthsRenewed,
                    BrandLicense = cleanProductLicense.BrandLicense,
                    TermDate = cleanProductLicense.TermDate,
                    AuthorizedLambdaFunctionRegEx = cleanProductLicense.AuthorizedLambdaFunctionRegEx,
                    LimitedUseToken = cleanProductLicense.LimitedUseToken,
                    CustomStartDate = cleanProductLicense.CustomStartDate,
                    ReplacementExposureOverflow = cleanProductLicense.ReplacementExposureOverflow,
                    ExposuresForwarded = cleanProductLicense.ExposuresForwarded,
                    ExposuresRequested = cleanProductLicense.ExposuresRequested,
                    UnpaidExposures = cleanProductLicense.UnpaidExposures,
                    ExposuresIncluded = cleanProductLicense.ExposuresIncluded,
                    ExposuresUsed = cleanProductLicense.ExposuresUsed,
                    ExposureOverflow = cleanProductLicense.ExposureOverflow,
                    UnusedExposures = cleanProductLicense.UnusedExposures,
                    ExposuresRemaining = cleanProductLicense.ExposuresRemaining,
                    UnpaidInvoiceCount = cleanProductLicense.UnpaidInvoiceCount,
                    RenewalSKU = cleanProductLicense.RenewalSKU,
                    ProductLicenseMeters = cleanProductLicense.ProductLicenseMeters,
                    MetersInWarning = cleanProductLicense.MetersInWarning,
                    MetersExceeded = cleanProductLicense.MetersExceeded,
                    ProductLicenseDMQueue = cleanProductLicense.ProductLicenseDMQueue,
                    CustomLicenseEventWebhookUrl = cleanProductLicense.CustomLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorProductLicense;
        }
        
        
        public static List<dc.ProductLicense> LicenseCoordinatorCleanForGet(this IEnumerable<dc.ProductLicense> cleanProductLicenses)
        {
            return cleanProductLicenses.Select(ProductLicense => ProductLicense.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductLicense LicenseCoordinatorCleanForGet(this dc.ProductLicense cleanProductLicense)
        {
            var LicenseCoordinatorProductLicense = default(dc.ProductLicense);

            if (!ReferenceEquals(cleanProductLicense, null))
            {
                LicenseCoordinatorProductLicense = new dc.ProductLicense()
                {
                    ProductLicenseId = cleanProductLicense.ProductLicenseId,
                    Name = cleanProductLicense.Name,
                    Notes = cleanProductLicense.Notes,
                    Attachments = cleanProductLicense.Attachments,
                    Status = cleanProductLicense.Status,
                    LicenseGroup = cleanProductLicense.LicenseGroup,
                    Licensee = cleanProductLicense.Licensee,
                    StartDate = cleanProductLicense.StartDate,
                    InvoiceLineItems = cleanProductLicense.InvoiceLineItems,
                    PlanMonthyFee = cleanProductLicense.PlanMonthyFee,
                    MonthlyFee = cleanProductLicense.MonthlyFee,
                    Term = cleanProductLicense.Term,
                    PlanQuarterlyDiscount = cleanProductLicense.PlanQuarterlyDiscount,
                    PlanSemiAnnualDiscount = cleanProductLicense.PlanSemiAnnualDiscount,
                    PlanAnnualDiscount = cleanProductLicense.PlanAnnualDiscount,
                    MonthsRenewed = cleanProductLicense.MonthsRenewed,
                    PaidThroughDate = cleanProductLicense.PaidThroughDate,
                    LicenseeEmailAddress = cleanProductLicense.LicenseeEmailAddress,
                    IsExpiring = cleanProductLicense.IsExpiring,
                    IsExpired = cleanProductLicense.IsExpired,
                    Licensor = cleanProductLicense.Licensor,
                    BrandLicense = cleanProductLicense.BrandLicense,
                    TermDate = cleanProductLicense.TermDate,
                    LicensorEmailAddress = cleanProductLicense.LicensorEmailAddress,
                    PlanName = cleanProductLicense.PlanName,
                    AuthorizedLambdaFunctionRegEx = cleanProductLicense.AuthorizedLambdaFunctionRegEx,
                    LimitedUseToken = cleanProductLicense.LimitedUseToken,
                    CreatedTime = cleanProductLicense.CreatedTime,
                    CustomStartDate = cleanProductLicense.CustomStartDate,
                    ReplacementExposureOverflow = cleanProductLicense.ReplacementExposureOverflow,
                    ExposuresForwarded = cleanProductLicense.ExposuresForwarded,
                    ExposuresRequested = cleanProductLicense.ExposuresRequested,
                    UnpaidExposures = cleanProductLicense.UnpaidExposures,
                    ExposuresIncluded = cleanProductLicense.ExposuresIncluded,
                    ExposuresUsed = cleanProductLicense.ExposuresUsed,
                    ExposureOverflow = cleanProductLicense.ExposureOverflow,
                    UnusedExposures = cleanProductLicense.UnusedExposures,
                    ExposuresRemaining = cleanProductLicense.ExposuresRemaining,
                    BrandLicenseName = cleanProductLicense.BrandLicenseName,
                    UnpaidInvoiceCount = cleanProductLicense.UnpaidInvoiceCount,
                    StripePaymentUrl = cleanProductLicense.StripePaymentUrl,
                    RenewalFee = cleanProductLicense.RenewalFee,
                    RenewalSKU = cleanProductLicense.RenewalSKU,
                    ProductLicenseMeters = cleanProductLicense.ProductLicenseMeters,
                    BrandLicenseSKU = cleanProductLicense.BrandLicenseSKU,
                    DefaultRenewalSKU = cleanProductLicense.DefaultRenewalSKU,
                    ContractTerm = cleanProductLicense.ContractTerm,
                    ContractDiscount = cleanProductLicense.ContractDiscount,
                    DefaultRenewalSKULimits = cleanProductLicense.DefaultRenewalSKULimits,
                    MetersInWarning = cleanProductLicense.MetersInWarning,
                    MetersExceeded = cleanProductLicense.MetersExceeded,
                    BrandName = cleanProductLicense.BrandName,
                    RenewalSKUSKU = cleanProductLicense.RenewalSKUSKU,
                    SSioTechnology = cleanProductLicense.SSioTechnology,
                    DefaultSKUMeterAdjustments = cleanProductLicense.DefaultSKUMeterAdjustments,
                    ProductLicenseDMQueue = cleanProductLicense.ProductLicenseDMQueue,
                    LicensorLicenseEvent = cleanProductLicense.LicensorLicenseEvent,
                    BrandLicenseLicenseEventWebhookUrl = cleanProductLicense.BrandLicenseLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanProductLicense.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanProductLicense.LicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorProductLicense;
        }
        
        
        public static dc.ProductLicense LicenseCoordinatorCleanForUpdate(this dc.ProductLicense cleanProductLicense)
        {
            var LicenseCoordinatorProductLicense = default(dc.ProductLicense);

            if (!ReferenceEquals(cleanProductLicense, null))
            {
                LicenseCoordinatorProductLicense = new dc.ProductLicense()
                {
                    ProductLicenseId = cleanProductLicense.ProductLicenseId,
                    Notes = cleanProductLicense.Notes,
                    Attachments = cleanProductLicense.Attachments,
                    Status = cleanProductLicense.Status,
                    LicenseGroup = cleanProductLicense.LicenseGroup,
                    Licensee = cleanProductLicense.Licensee,
                    InvoiceLineItems = cleanProductLicense.InvoiceLineItems,
                    MonthsRenewed = cleanProductLicense.MonthsRenewed,
                    BrandLicense = cleanProductLicense.BrandLicense,
                    TermDate = cleanProductLicense.TermDate,
                    AuthorizedLambdaFunctionRegEx = cleanProductLicense.AuthorizedLambdaFunctionRegEx,
                    LimitedUseToken = cleanProductLicense.LimitedUseToken,
                    CustomStartDate = cleanProductLicense.CustomStartDate,
                    ReplacementExposureOverflow = cleanProductLicense.ReplacementExposureOverflow,
                    ExposuresForwarded = cleanProductLicense.ExposuresForwarded,
                    ExposuresRequested = cleanProductLicense.ExposuresRequested,
                    UnpaidExposures = cleanProductLicense.UnpaidExposures,
                    ExposuresIncluded = cleanProductLicense.ExposuresIncluded,
                    ExposuresUsed = cleanProductLicense.ExposuresUsed,
                    ExposureOverflow = cleanProductLicense.ExposureOverflow,
                    UnusedExposures = cleanProductLicense.UnusedExposures,
                    ExposuresRemaining = cleanProductLicense.ExposuresRemaining,
                    UnpaidInvoiceCount = cleanProductLicense.UnpaidInvoiceCount,
                    RenewalSKU = cleanProductLicense.RenewalSKU,
                    ProductLicenseMeters = cleanProductLicense.ProductLicenseMeters,
                    MetersInWarning = cleanProductLicense.MetersInWarning,
                    MetersExceeded = cleanProductLicense.MetersExceeded,
                    ProductLicenseDMQueue = cleanProductLicense.ProductLicenseDMQueue,
                    CustomLicenseEventWebhookUrl = cleanProductLicense.CustomLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorProductLicense;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // LicensedProduct
        public static dc.LicensedProduct LicenseCoordinatorCleanForAdd(this dc.LicensedProduct cleanLicensedProduct)
        {
            var LicenseCoordinatorLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                LicenseCoordinatorLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    Brand = cleanLicensedProduct.Brand
                };
            }

            return LicenseCoordinatorLicensedProduct;
        }
        
        
        public static List<dc.LicensedProduct> LicenseCoordinatorCleanForGet(this IEnumerable<dc.LicensedProduct> cleanLicensedProducts)
        {
            return cleanLicensedProducts.Select(LicensedProduct => LicensedProduct.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.LicensedProduct LicenseCoordinatorCleanForGet(this dc.LicensedProduct cleanLicensedProduct)
        {
            var LicenseCoordinatorLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                LicenseCoordinatorLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Name = cleanLicensedProduct.Name,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsActive = cleanLicensedProduct.IsActive,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    LicensorIsVerified = cleanLicensedProduct.LicensorIsVerified,
                    LicensorEmailAddress = cleanLicensedProduct.LicensorEmailAddress,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadName = cleanLicensedProduct.HeadName,
                    HeadLambdaEndpoint = cleanLicensedProduct.HeadLambdaEndpoint,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    CalculatedLowerName = cleanLicensedProduct.CalculatedLowerName,
                    CalculatedOriginalName = cleanLicensedProduct.CalculatedOriginalName,
                    CalculatedUpperName = cleanLicensedProduct.CalculatedUpperName,
                    CalculatedLowerHyphenName = cleanLicensedProduct.CalculatedLowerHyphenName,
                    HasMissingNames = cleanLicensedProduct.HasMissingNames,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    LicensorScreenName = cleanLicensedProduct.LicensorScreenName,
                    HeadUsesV1Proxy = cleanLicensedProduct.HeadUsesV1Proxy,
                    HasMissingMarkdown = cleanLicensedProduct.HasMissingMarkdown,
                    HeadDescription = cleanLicensedProduct.HeadDescription,
                    HeadReadMeMD = cleanLicensedProduct.HeadReadMeMD,
                    HeadInputDescriptionMD = cleanLicensedProduct.HeadInputDescriptionMD,
                    HeadOutputDescriptionMD = cleanLicensedProduct.HeadOutputDescriptionMD,
                    RecordCreatedtime = cleanLicensedProduct.RecordCreatedtime,
                    CreatedOn = cleanLicensedProduct.CreatedOn,
                    AccountIsActive = cleanLicensedProduct.AccountIsActive,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    FullName = cleanLicensedProduct.FullName,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    UsageCountMismatch = cleanLicensedProduct.UsageCountMismatch,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersion = cleanLicensedProduct.MostRecentVersion,
                    NextVersionNumber = cleanLicensedProduct.NextVersionNumber,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    LicensorUUID = cleanLicensedProduct.LicensorUUID,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    AWSLambdaFunctionName = cleanLicensedProduct.AWSLambdaFunctionName,
                    LicensorAWSAccountId = cleanLicensedProduct.LicensorAWSAccountId,
                    LicensorAWSAPIGatewayId = cleanLicensedProduct.LicensorAWSAPIGatewayId,
                    LicensorAWSLambdaRegion = cleanLicensedProduct.LicensorAWSLambdaRegion,
                    Brand = cleanLicensedProduct.Brand,
                    BundleAWSAPIGatewayId = cleanLicensedProduct.BundleAWSAPIGatewayId
                };
            }

            return LicenseCoordinatorLicensedProduct;
        }
        
        
        public static dc.LicensedProduct LicenseCoordinatorCleanForUpdate(this dc.LicensedProduct cleanLicensedProduct)
        {
            var LicenseCoordinatorLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                LicenseCoordinatorLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    Brand = cleanLicensedProduct.Brand
                };
            }

            return LicenseCoordinatorLicensedProduct;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // LimitedUseToken
        public static dc.LimitedUseToken LicenseCoordinatorCleanForAdd(this dc.LimitedUseToken cleanLimitedUseToken)
        {
            var LicenseCoordinatorLimitedUseToken = default(dc.LimitedUseToken);

            if (!ReferenceEquals(cleanLimitedUseToken, null))
            {
                LicenseCoordinatorLimitedUseToken = new dc.LimitedUseToken()
                {
                    LimitedUseTokenId = cleanLimitedUseToken.LimitedUseTokenId,
                    Name = cleanLimitedUseToken.Name,
                    Notes = cleanLimitedUseToken.Notes,
                    Attachments = cleanLimitedUseToken.Attachments,
                    Status = cleanLimitedUseToken.Status,
                    ProductLicense = cleanLimitedUseToken.ProductLicense,
                    MaxUses = cleanLimitedUseToken.MaxUses,
                    TermDate = cleanLimitedUseToken.TermDate
                };
            }

            return LicenseCoordinatorLimitedUseToken;
        }
        
        
        public static List<dc.LimitedUseToken> LicenseCoordinatorCleanForGet(this IEnumerable<dc.LimitedUseToken> cleanLimitedUseTokens)
        {
            return cleanLimitedUseTokens.Select(LimitedUseToken => LimitedUseToken.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.LimitedUseToken LicenseCoordinatorCleanForGet(this dc.LimitedUseToken cleanLimitedUseToken)
        {
            var LicenseCoordinatorLimitedUseToken = default(dc.LimitedUseToken);

            if (!ReferenceEquals(cleanLimitedUseToken, null))
            {
                LicenseCoordinatorLimitedUseToken = new dc.LimitedUseToken()
                {
                    LimitedUseTokenId = cleanLimitedUseToken.LimitedUseTokenId,
                    Name = cleanLimitedUseToken.Name,
                    Notes = cleanLimitedUseToken.Notes,
                    Attachments = cleanLimitedUseToken.Attachments,
                    Status = cleanLimitedUseToken.Status,
                    ProductLicense = cleanLimitedUseToken.ProductLicense,
                    Token = cleanLimitedUseToken.Token,
                    MaxUses = cleanLimitedUseToken.MaxUses,
                    TermDate = cleanLimitedUseToken.TermDate
                };
            }

            return LicenseCoordinatorLimitedUseToken;
        }
        
        
        public static dc.LimitedUseToken LicenseCoordinatorCleanForUpdate(this dc.LimitedUseToken cleanLimitedUseToken)
        {
            var LicenseCoordinatorLimitedUseToken = default(dc.LimitedUseToken);

            if (!ReferenceEquals(cleanLimitedUseToken, null))
            {
                LicenseCoordinatorLimitedUseToken = new dc.LimitedUseToken()
                {
                    LimitedUseTokenId = cleanLimitedUseToken.LimitedUseTokenId,
                    Name = cleanLimitedUseToken.Name,
                    Notes = cleanLimitedUseToken.Notes,
                    Attachments = cleanLimitedUseToken.Attachments,
                    Status = cleanLimitedUseToken.Status,
                    ProductLicense = cleanLimitedUseToken.ProductLicense,
                    MaxUses = cleanLimitedUseToken.MaxUses,
                    TermDate = cleanLimitedUseToken.TermDate
                };
            }

            return LicenseCoordinatorLimitedUseToken;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // OpenIssue
        public static dc.OpenIssue LicenseCoordinatorCleanForAdd(this dc.OpenIssue cleanOpenIssue)
        {
            var LicenseCoordinatorOpenIssue = default(dc.OpenIssue);

            if (!ReferenceEquals(cleanOpenIssue, null))
            {
                LicenseCoordinatorOpenIssue = new dc.OpenIssue()
                {
                    OpenIssueId = cleanOpenIssue.OpenIssueId,
                    Name = cleanOpenIssue.Name,
                    Notes = cleanOpenIssue.Notes,
                    Attachments = cleanOpenIssue.Attachments,
                    CompletedOn = cleanOpenIssue.CompletedOn,
                    Who = cleanOpenIssue.Who,
                    Priority = cleanOpenIssue.Priority,
                    SortOrder = cleanOpenIssue.SortOrder
                };
            }

            return LicenseCoordinatorOpenIssue;
        }
        
        
        public static List<dc.OpenIssue> LicenseCoordinatorCleanForGet(this IEnumerable<dc.OpenIssue> cleanOpenIssues)
        {
            return cleanOpenIssues.Select(OpenIssue => OpenIssue.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.OpenIssue LicenseCoordinatorCleanForGet(this dc.OpenIssue cleanOpenIssue)
        {
            var LicenseCoordinatorOpenIssue = default(dc.OpenIssue);

            if (!ReferenceEquals(cleanOpenIssue, null))
            {
                LicenseCoordinatorOpenIssue = new dc.OpenIssue()
                {
                    OpenIssueId = cleanOpenIssue.OpenIssueId,
                    Name = cleanOpenIssue.Name,
                    Notes = cleanOpenIssue.Notes,
                    Attachments = cleanOpenIssue.Attachments,
                    CompletedOn = cleanOpenIssue.CompletedOn,
                    Who = cleanOpenIssue.Who,
                    Priority = cleanOpenIssue.Priority,
                    SortOrder = cleanOpenIssue.SortOrder,
                    DaysAgo = cleanOpenIssue.DaysAgo
                };
            }

            return LicenseCoordinatorOpenIssue;
        }
        
        
        public static dc.OpenIssue LicenseCoordinatorCleanForUpdate(this dc.OpenIssue cleanOpenIssue)
        {
            var LicenseCoordinatorOpenIssue = default(dc.OpenIssue);

            if (!ReferenceEquals(cleanOpenIssue, null))
            {
                LicenseCoordinatorOpenIssue = new dc.OpenIssue()
                {
                    OpenIssueId = cleanOpenIssue.OpenIssueId,
                    Name = cleanOpenIssue.Name,
                    Notes = cleanOpenIssue.Notes,
                    Attachments = cleanOpenIssue.Attachments,
                    CompletedOn = cleanOpenIssue.CompletedOn,
                    Who = cleanOpenIssue.Who,
                    Priority = cleanOpenIssue.Priority,
                    SortOrder = cleanOpenIssue.SortOrder
                };
            }

            return LicenseCoordinatorOpenIssue;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // SKUMeterAdjustment
        public static dc.SKUMeterAdjustment LicenseCoordinatorCleanForAdd(this dc.SKUMeterAdjustment cleanSKUMeterAdjustment)
        {
            var LicenseCoordinatorSKUMeterAdjustment = default(dc.SKUMeterAdjustment);

            if (!ReferenceEquals(cleanSKUMeterAdjustment, null))
            {
                LicenseCoordinatorSKUMeterAdjustment = new dc.SKUMeterAdjustment()
                {
                    SKUMeterAdjustmentId = cleanSKUMeterAdjustment.SKUMeterAdjustmentId,
                    Notes = cleanSKUMeterAdjustment.Notes,
                    Attachments = cleanSKUMeterAdjustment.Attachments,
                    Status = cleanSKUMeterAdjustment.Status,
                    BundleSKU = cleanSKUMeterAdjustment.BundleSKU,
                    TechnologyMeter = cleanSKUMeterAdjustment.TechnologyMeter,
                    MonthlyMeterLimit = cleanSKUMeterAdjustment.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanSKUMeterAdjustment.ProductLicenseMeters,
                    LicenseSKU = cleanSKUMeterAdjustment.LicenseSKU,
                    LicenseMeter = cleanSKUMeterAdjustment.LicenseMeter,
                    Adjustment = cleanSKUMeterAdjustment.Adjustment,
                    AdjustmentType = cleanSKUMeterAdjustment.AdjustmentType,
                    Source = cleanSKUMeterAdjustment.Source,
                    MeterTransactions = cleanSKUMeterAdjustment.MeterTransactions
                };
            }

            return LicenseCoordinatorSKUMeterAdjustment;
        }
        
        
        public static List<dc.SKUMeterAdjustment> LicenseCoordinatorCleanForGet(this IEnumerable<dc.SKUMeterAdjustment> cleanSKUMeterAdjustments)
        {
            return cleanSKUMeterAdjustments.Select(SKUMeterAdjustment => SKUMeterAdjustment.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.SKUMeterAdjustment LicenseCoordinatorCleanForGet(this dc.SKUMeterAdjustment cleanSKUMeterAdjustment)
        {
            var LicenseCoordinatorSKUMeterAdjustment = default(dc.SKUMeterAdjustment);

            if (!ReferenceEquals(cleanSKUMeterAdjustment, null))
            {
                LicenseCoordinatorSKUMeterAdjustment = new dc.SKUMeterAdjustment()
                {
                    SKUMeterAdjustmentId = cleanSKUMeterAdjustment.SKUMeterAdjustmentId,
                    Name = cleanSKUMeterAdjustment.Name,
                    Notes = cleanSKUMeterAdjustment.Notes,
                    Attachments = cleanSKUMeterAdjustment.Attachments,
                    Status = cleanSKUMeterAdjustment.Status,
                    BundleSKU = cleanSKUMeterAdjustment.BundleSKU,
                    TechnologyMeter = cleanSKUMeterAdjustment.TechnologyMeter,
                    ProductBundle = cleanSKUMeterAdjustment.ProductBundle,
                    MonthlyMeterLimit = cleanSKUMeterAdjustment.MonthlyMeterLimit,
                    TotalSKUMeterLimit = cleanSKUMeterAdjustment.TotalSKUMeterLimit,
                    BundleMonthsIncluded = cleanSKUMeterAdjustment.BundleMonthsIncluded,
                    MeterTypeSKUCode = cleanSKUMeterAdjustment.MeterTypeSKUCode,
                    ProductLicenseMeters = cleanSKUMeterAdjustment.ProductLicenseMeters,
                    LimitSKU = cleanSKUMeterAdjustment.LimitSKU,
                    LicensorEmailAddress = cleanSKUMeterAdjustment.LicensorEmailAddress,
                    LicenseSKU = cleanSKUMeterAdjustment.LicenseSKU,
                    LicenseMeter = cleanSKUMeterAdjustment.LicenseMeter,
                    BrandLicense = cleanSKUMeterAdjustment.BrandLicense,
                    Adjustment = cleanSKUMeterAdjustment.Adjustment,
                    AdjustmentDescription = cleanSKUMeterAdjustment.AdjustmentDescription,
                    AdjustmentType = cleanSKUMeterAdjustment.AdjustmentType,
                    Source = cleanSKUMeterAdjustment.Source,
                    MeterTransactions = cleanSKUMeterAdjustment.MeterTransactions,
                    LicenseMeterUnitOfMeasurement = cleanSKUMeterAdjustment.LicenseMeterUnitOfMeasurement,
                    Meter = cleanSKUMeterAdjustment.Meter
                };
            }

            return LicenseCoordinatorSKUMeterAdjustment;
        }
        
        
        public static dc.SKUMeterAdjustment LicenseCoordinatorCleanForUpdate(this dc.SKUMeterAdjustment cleanSKUMeterAdjustment)
        {
            var LicenseCoordinatorSKUMeterAdjustment = default(dc.SKUMeterAdjustment);

            if (!ReferenceEquals(cleanSKUMeterAdjustment, null))
            {
                LicenseCoordinatorSKUMeterAdjustment = new dc.SKUMeterAdjustment()
                {
                    SKUMeterAdjustmentId = cleanSKUMeterAdjustment.SKUMeterAdjustmentId,
                    Notes = cleanSKUMeterAdjustment.Notes,
                    Attachments = cleanSKUMeterAdjustment.Attachments,
                    Status = cleanSKUMeterAdjustment.Status,
                    BundleSKU = cleanSKUMeterAdjustment.BundleSKU,
                    TechnologyMeter = cleanSKUMeterAdjustment.TechnologyMeter,
                    MonthlyMeterLimit = cleanSKUMeterAdjustment.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanSKUMeterAdjustment.ProductLicenseMeters,
                    LicenseSKU = cleanSKUMeterAdjustment.LicenseSKU,
                    LicenseMeter = cleanSKUMeterAdjustment.LicenseMeter,
                    Adjustment = cleanSKUMeterAdjustment.Adjustment,
                    AdjustmentType = cleanSKUMeterAdjustment.AdjustmentType,
                    Source = cleanSKUMeterAdjustment.Source,
                    MeterTransactions = cleanSKUMeterAdjustment.MeterTransactions
                };
            }

            return LicenseCoordinatorSKUMeterAdjustment;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // ProductLicenseMeter
        public static dc.ProductLicenseMeter LicenseCoordinatorCleanForAdd(this dc.ProductLicenseMeter cleanProductLicenseMeter)
        {
            var LicenseCoordinatorProductLicenseMeter = default(dc.ProductLicenseMeter);

            if (!ReferenceEquals(cleanProductLicenseMeter, null))
            {
                LicenseCoordinatorProductLicenseMeter = new dc.ProductLicenseMeter()
                {
                    ProductLicenseMeterId = cleanProductLicenseMeter.ProductLicenseMeterId,
                    Notes = cleanProductLicenseMeter.Notes,
                    Attachments = cleanProductLicenseMeter.Attachments,
                    Status = cleanProductLicenseMeter.Status,
                    ProductLicense = cleanProductLicenseMeter.ProductLicense,
                    SKULimit = cleanProductLicenseMeter.SKULimit,
                    MeterTransactions = cleanProductLicenseMeter.MeterTransactions,
                    ActiveMeterTransactionBalance = cleanProductLicenseMeter.ActiveMeterTransactionBalance,
                    Limit = cleanProductLicenseMeter.Limit,
                    MeterOffset = cleanProductLicenseMeter.MeterOffset,
                    LicenseMeter = cleanProductLicenseMeter.LicenseMeter,
                    ActiveUsageMeterTransactionBalance = cleanProductLicenseMeter.ActiveUsageMeterTransactionBalance,
                    ActiveMeterLimit = cleanProductLicenseMeter.ActiveMeterLimit,
                    CustomResetDate = cleanProductLicenseMeter.CustomResetDate,
                    ActiveUsageValueRollup = cleanProductLicenseMeter.ActiveUsageValueRollup,
                    ActiveUsageValueOffset = cleanProductLicenseMeter.ActiveUsageValueOffset,
                    CustomWarningPercent = cleanProductLicenseMeter.CustomWarningPercent
                };
            }

            return LicenseCoordinatorProductLicenseMeter;
        }
        
        
        public static List<dc.ProductLicenseMeter> LicenseCoordinatorCleanForGet(this IEnumerable<dc.ProductLicenseMeter> cleanProductLicenseMeters)
        {
            return cleanProductLicenseMeters.Select(ProductLicenseMeter => ProductLicenseMeter.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductLicenseMeter LicenseCoordinatorCleanForGet(this dc.ProductLicenseMeter cleanProductLicenseMeter)
        {
            var LicenseCoordinatorProductLicenseMeter = default(dc.ProductLicenseMeter);

            if (!ReferenceEquals(cleanProductLicenseMeter, null))
            {
                LicenseCoordinatorProductLicenseMeter = new dc.ProductLicenseMeter()
                {
                    ProductLicenseMeterId = cleanProductLicenseMeter.ProductLicenseMeterId,
                    Name = cleanProductLicenseMeter.Name,
                    Notes = cleanProductLicenseMeter.Notes,
                    Attachments = cleanProductLicenseMeter.Attachments,
                    Status = cleanProductLicenseMeter.Status,
                    ProductLicense = cleanProductLicenseMeter.ProductLicense,
                    LicenseMeters = cleanProductLicenseMeter.LicenseMeters,
                    DefaultRenewalSKULimits = cleanProductLicenseMeter.DefaultRenewalSKULimits,
                    SKULimit = cleanProductLicenseMeter.SKULimit,
                    RenewalSKU = cleanProductLicenseMeter.RenewalSKU,
                    SKULimitSKU = cleanProductLicenseMeter.SKULimitSKU,
                    InitialMeterLimit = cleanProductLicenseMeter.InitialMeterLimit,
                    MeterTransactions = cleanProductLicenseMeter.MeterTransactions,
                    ActiveMeterTransactionBalance = cleanProductLicenseMeter.ActiveMeterTransactionBalance,
                    Limit = cleanProductLicenseMeter.Limit,
                    MeterRemaining = cleanProductLicenseMeter.MeterRemaining,
                    MeterInWarning = cleanProductLicenseMeter.MeterInWarning,
                    MeterOffset = cleanProductLicenseMeter.MeterOffset,
                    Balance = cleanProductLicenseMeter.Balance,
                    MeterPercent = cleanProductLicenseMeter.MeterPercent,
                    MeterExceeded = cleanProductLicenseMeter.MeterExceeded,
                    TransactionResetDate = cleanProductLicenseMeter.TransactionResetDate,
                    LicenseeEmailAddress = cleanProductLicenseMeter.LicenseeEmailAddress,
                    LicensorEmailAddress = cleanProductLicenseMeter.LicensorEmailAddress,
                    DefaultSKUMeterAdjustments = cleanProductLicenseMeter.DefaultSKUMeterAdjustments,
                    LicenseMeter = cleanProductLicenseMeter.LicenseMeter,
                    ActiveUsageMeterTransactionBalance = cleanProductLicenseMeter.ActiveUsageMeterTransactionBalance,
                    ActiveMeterLimit = cleanProductLicenseMeter.ActiveMeterLimit,
                    MeterSKU = cleanProductLicenseMeter.MeterSKU,
                    CreatedTime = cleanProductLicenseMeter.CreatedTime,
                    CustomResetDate = cleanProductLicenseMeter.CustomResetDate,
                    MeterDataType = cleanProductLicenseMeter.MeterDataType,
                    IsTime = cleanProductLicenseMeter.IsTime,
                    Expires = cleanProductLicenseMeter.Expires,
                    AddsMinutes = cleanProductLicenseMeter.AddsMinutes,
                    AddsMonths = cleanProductLicenseMeter.AddsMonths,
                    AddDateType = cleanProductLicenseMeter.AddDateType,
                    DaysTillExpires = cleanProductLicenseMeter.DaysTillExpires,
                    LicenseMeterUnitOfMeasurement = cleanProductLicenseMeter.LicenseMeterUnitOfMeasurement,
                    LicenseMeterUnitOfMeasurementSingular = cleanProductLicenseMeter.LicenseMeterUnitOfMeasurementSingular,
                    LicenseMeterUnitOfMeasurementPlural = cleanProductLicenseMeter.LicenseMeterUnitOfMeasurementPlural,
                    ActiveUsageValueRollup = cleanProductLicenseMeter.ActiveUsageValueRollup,
                    ActiveUsageValueOffset = cleanProductLicenseMeter.ActiveUsageValueOffset,
                    ActiveMeterUsage = cleanProductLicenseMeter.ActiveMeterUsage,
                    TotalDaysMeasured = cleanProductLicenseMeter.TotalDaysMeasured,
                    LicenseMeterLimitDirection = cleanProductLicenseMeter.LicenseMeterLimitDirection,
                    CustomWarningPercent = cleanProductLicenseMeter.CustomWarningPercent,
                    DefaultMeterWarningPercent = cleanProductLicenseMeter.DefaultMeterWarningPercent,
                    WarningPercent = cleanProductLicenseMeter.WarningPercent
                };
            }

            return LicenseCoordinatorProductLicenseMeter;
        }
        
        
        public static dc.ProductLicenseMeter LicenseCoordinatorCleanForUpdate(this dc.ProductLicenseMeter cleanProductLicenseMeter)
        {
            var LicenseCoordinatorProductLicenseMeter = default(dc.ProductLicenseMeter);

            if (!ReferenceEquals(cleanProductLicenseMeter, null))
            {
                LicenseCoordinatorProductLicenseMeter = new dc.ProductLicenseMeter()
                {
                    ProductLicenseMeterId = cleanProductLicenseMeter.ProductLicenseMeterId,
                    Notes = cleanProductLicenseMeter.Notes,
                    Attachments = cleanProductLicenseMeter.Attachments,
                    Status = cleanProductLicenseMeter.Status,
                    ProductLicense = cleanProductLicenseMeter.ProductLicense,
                    SKULimit = cleanProductLicenseMeter.SKULimit,
                    MeterTransactions = cleanProductLicenseMeter.MeterTransactions,
                    ActiveMeterTransactionBalance = cleanProductLicenseMeter.ActiveMeterTransactionBalance,
                    Limit = cleanProductLicenseMeter.Limit,
                    MeterOffset = cleanProductLicenseMeter.MeterOffset,
                    LicenseMeter = cleanProductLicenseMeter.LicenseMeter,
                    ActiveUsageMeterTransactionBalance = cleanProductLicenseMeter.ActiveUsageMeterTransactionBalance,
                    ActiveMeterLimit = cleanProductLicenseMeter.ActiveMeterLimit,
                    CustomResetDate = cleanProductLicenseMeter.CustomResetDate,
                    ActiveUsageValueRollup = cleanProductLicenseMeter.ActiveUsageValueRollup,
                    ActiveUsageValueOffset = cleanProductLicenseMeter.ActiveUsageValueOffset,
                    CustomWarningPercent = cleanProductLicenseMeter.CustomWarningPercent
                };
            }

            return LicenseCoordinatorProductLicenseMeter;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // LicenseMeter
        public static dc.LicenseMeter LicenseCoordinatorCleanForAdd(this dc.LicenseMeter cleanLicenseMeter)
        {
            var LicenseCoordinatorLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                LicenseCoordinatorLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return LicenseCoordinatorLicenseMeter;
        }
        
        
        public static List<dc.LicenseMeter> LicenseCoordinatorCleanForGet(this IEnumerable<dc.LicenseMeter> cleanLicenseMeters)
        {
            return cleanLicenseMeters.Select(LicenseMeter => LicenseMeter.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseMeter LicenseCoordinatorCleanForGet(this dc.LicenseMeter cleanLicenseMeter)
        {
            var LicenseCoordinatorLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                LicenseCoordinatorLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Name = cleanLicenseMeter.Name,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    TotalSKUMeterLimit = cleanLicenseMeter.TotalSKUMeterLimit,
                    BundleMonthsIncluded = cleanLicenseMeter.BundleMonthsIncluded,
                    MeterTypeSKUCode = cleanLicenseMeter.MeterTypeSKUCode,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LimitSKU = cleanLicenseMeter.LimitSKU,
                    LicensorEmailAddress = cleanLicenseMeter.LicensorEmailAddress,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    LicenseBundleName = cleanLicenseMeter.LicenseBundleName,
                    MeterTypeName = cleanLicenseMeter.MeterTypeName,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    BrandLicenseName = cleanLicenseMeter.BrandLicenseName,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    UnitOfMeasurementPlural = cleanLicenseMeter.UnitOfMeasurementPlural,
                    MeasurementType = cleanLicenseMeter.MeasurementType,
                    AddsMinutes = cleanLicenseMeter.AddsMinutes,
                    AddsMonths = cleanLicenseMeter.AddsMonths,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    BrandLicenseSKU = cleanLicenseMeter.BrandLicenseSKU,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    MeterSKU = cleanLicenseMeter.MeterSKU,
                    UnitOfMeasurementSingular = cleanLicenseMeter.UnitOfMeasurementSingular,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    NameForBrand = cleanLicenseMeter.NameForBrand,
                    PluralNameForBrand = cleanLicenseMeter.PluralNameForBrand,
                    NameForBrandLicense = cleanLicenseMeter.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanLicenseMeter.PluralNameForBrandLicense,
                    NameForMeter = cleanLicenseMeter.NameForMeter,
                    PluralNameForMeter = cleanLicenseMeter.PluralNameForMeter,
                    NameForSKU = cleanLicenseMeter.NameForSKU,
                    PluralNameForSKU = cleanLicenseMeter.PluralNameForSKU,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return LicenseCoordinatorLicenseMeter;
        }
        
        
        public static dc.LicenseMeter LicenseCoordinatorCleanForUpdate(this dc.LicenseMeter cleanLicenseMeter)
        {
            var LicenseCoordinatorLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                LicenseCoordinatorLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return LicenseCoordinatorLicenseMeter;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // Invoice
        public static dc.Invoice LicenseCoordinatorCleanForAdd(this dc.Invoice cleanInvoice)
        {
            var LicenseCoordinatorInvoice = default(dc.Invoice);

            if (!ReferenceEquals(cleanInvoice, null))
            {
                LicenseCoordinatorInvoice = new dc.Invoice()
                {
                    InvoiceId = cleanInvoice.InvoiceId,
                    Notes = cleanInvoice.Notes,
                    Attachments = cleanInvoice.Attachments,
                    Status = cleanInvoice.Status,
                    Autonumber = cleanInvoice.Autonumber,
                    InvoiceLineItems = cleanInvoice.InvoiceLineItems,
                    AccountHolder = cleanInvoice.AccountHolder,
                    Licensee = cleanInvoice.Licensee,
                    InvoiceSubTotal = cleanInvoice.InvoiceSubTotal,
                    OverrideInvoiceDate = cleanInvoice.OverrideInvoiceDate,
                    StripeInvoiceId = cleanInvoice.StripeInvoiceId,
                    StripeStatus = cleanInvoice.StripeStatus,
                    StripePaidAt = cleanInvoice.StripePaidAt,
                    StripeMetadata = cleanInvoice.StripeMetadata,
                    StripePaymentUrl = cleanInvoice.StripePaymentUrl
                };
            }

            return LicenseCoordinatorInvoice;
        }
        
        
        public static List<dc.Invoice> LicenseCoordinatorCleanForGet(this IEnumerable<dc.Invoice> cleanInvoices)
        {
            return cleanInvoices.Select(Invoice => Invoice.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.Invoice LicenseCoordinatorCleanForGet(this dc.Invoice cleanInvoice)
        {
            var LicenseCoordinatorInvoice = default(dc.Invoice);

            if (!ReferenceEquals(cleanInvoice, null))
            {
                LicenseCoordinatorInvoice = new dc.Invoice()
                {
                    InvoiceId = cleanInvoice.InvoiceId,
                    Name = cleanInvoice.Name,
                    Notes = cleanInvoice.Notes,
                    Attachments = cleanInvoice.Attachments,
                    Status = cleanInvoice.Status,
                    Autonumber = cleanInvoice.Autonumber,
                    InvoiceNumber = cleanInvoice.InvoiceNumber,
                    InvoiceLineItems = cleanInvoice.InvoiceLineItems,
                    AccountHolder = cleanInvoice.AccountHolder,
                    InvoiceDate = cleanInvoice.InvoiceDate,
                    AccountStartDate = cleanInvoice.AccountStartDate,
                    Licensee = cleanInvoice.Licensee,
                    LicenseeEmailAddress = cleanInvoice.LicenseeEmailAddress,
                    InvoiceSubTotal = cleanInvoice.InvoiceSubTotal,
                    Createdtime = cleanInvoice.Createdtime,
                    OverrideInvoiceDate = cleanInvoice.OverrideInvoiceDate,
                    StripeInvoiceId = cleanInvoice.StripeInvoiceId,
                    StripeStatus = cleanInvoice.StripeStatus,
                    StripePaidAt = cleanInvoice.StripePaidAt,
                    StripeMetadata = cleanInvoice.StripeMetadata,
                    StripePaymentUrl = cleanInvoice.StripePaymentUrl,
                    IsUnpaid = cleanInvoice.IsUnpaid
                };
            }

            return LicenseCoordinatorInvoice;
        }
        
        
        public static dc.Invoice LicenseCoordinatorCleanForUpdate(this dc.Invoice cleanInvoice)
        {
            var LicenseCoordinatorInvoice = default(dc.Invoice);

            if (!ReferenceEquals(cleanInvoice, null))
            {
                LicenseCoordinatorInvoice = new dc.Invoice()
                {
                    InvoiceId = cleanInvoice.InvoiceId,
                    Notes = cleanInvoice.Notes,
                    Attachments = cleanInvoice.Attachments,
                    Status = cleanInvoice.Status,
                    Autonumber = cleanInvoice.Autonumber,
                    InvoiceLineItems = cleanInvoice.InvoiceLineItems,
                    AccountHolder = cleanInvoice.AccountHolder,
                    Licensee = cleanInvoice.Licensee,
                    InvoiceSubTotal = cleanInvoice.InvoiceSubTotal,
                    OverrideInvoiceDate = cleanInvoice.OverrideInvoiceDate,
                    StripeInvoiceId = cleanInvoice.StripeInvoiceId,
                    StripeStatus = cleanInvoice.StripeStatus,
                    StripePaidAt = cleanInvoice.StripePaidAt,
                    StripeMetadata = cleanInvoice.StripeMetadata,
                    StripePaymentUrl = cleanInvoice.StripePaymentUrl
                };
            }

            return LicenseCoordinatorInvoice;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // BrandLicense
        public static dc.BrandLicense LicenseCoordinatorCleanForAdd(this dc.BrandLicense cleanBrandLicense)
        {
            var LicenseCoordinatorBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                LicenseCoordinatorBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicenseType = cleanBrandLicense.LicenseType,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    SKUCode = cleanBrandLicense.SKUCode,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorBrandLicense;
        }
        
        
        public static List<dc.BrandLicense> LicenseCoordinatorCleanForGet(this IEnumerable<dc.BrandLicense> cleanBrandLicenses)
        {
            return cleanBrandLicenses.Select(BrandLicense => BrandLicense.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.BrandLicense LicenseCoordinatorCleanForGet(this dc.BrandLicense cleanBrandLicense)
        {
            var LicenseCoordinatorBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                LicenseCoordinatorBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Name = cleanBrandLicense.Name,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    Licensor = cleanBrandLicense.Licensor,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicensorEmailAddresss = cleanBrandLicense.LicensorEmailAddresss,
                    LicensorScreenName = cleanBrandLicense.LicensorScreenName,
                    LicensorEmailAddress = cleanBrandLicense.LicensorEmailAddress,
                    LicenseType = cleanBrandLicense.LicenseType,
                    LicenseeEmailAddresses = cleanBrandLicense.LicenseeEmailAddresses,
                    Createdtime = cleanBrandLicense.Createdtime,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    MonthlyCostPer1KUses = cleanBrandLicense.MonthlyCostPer1KUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    LicensorSKUCode = cleanBrandLicense.LicensorSKUCode,
                    BrandSKU = cleanBrandLicense.BrandSKU,
                    SKUCode = cleanBrandLicense.SKUCode,
                    SKU = cleanBrandLicense.SKU,
                    PaymentProcessorPercent = cleanBrandLicense.PaymentProcessorPercent,
                    TotalMarketPercent = cleanBrandLicense.TotalMarketPercent,
                    BrandName = cleanBrandLicense.BrandName,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    DefaultTerm = cleanBrandLicense.DefaultTerm,
                    DefaultRenewalFee = cleanBrandLicense.DefaultRenewalFee,
                    ModifiedTime = cleanBrandLicense.ModifiedTime,
                    OwnerIsVerified = cleanBrandLicense.OwnerIsVerified,
                    DefaultBundleSKUSKU = cleanBrandLicense.DefaultBundleSKUSKU,
                    BrandIsPublic = cleanBrandLicense.BrandIsPublic,
                    DefaultTermDays = cleanBrandLicense.DefaultTermDays,
                    SSioTechnology = cleanBrandLicense.SSioTechnology,
                    SSioTechnologyPercent = cleanBrandLicense.SSioTechnologyPercent,
                    SSioTechnologySKUCode = cleanBrandLicense.SSioTechnologySKUCode,
                    SSioPercent = cleanBrandLicense.SSioPercent,
                    SSioTechnologyName = cleanBrandLicense.SSioTechnologyName,
                    LicenseTypePrimaryTrackingField = cleanBrandLicense.LicenseTypePrimaryTrackingField,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForBrand = cleanBrandLicense.NameForBrand,
                    PluralNameForBrand = cleanBrandLicense.PluralNameForBrand,
                    PluralNameForBrandLicense = cleanBrandLicense.PluralNameForBrandLicense,
                    NameForBrandLicense = cleanBrandLicense.NameForBrandLicense,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    BrandLicenseEventWebhookUrl = cleanBrandLicense.BrandLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanBrandLicense.LicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorBrandLicense;
        }
        
        
        public static dc.BrandLicense LicenseCoordinatorCleanForUpdate(this dc.BrandLicense cleanBrandLicense)
        {
            var LicenseCoordinatorBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                LicenseCoordinatorBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicenseType = cleanBrandLicense.LicenseType,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    SKUCode = cleanBrandLicense.SKUCode,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl
                };
            }

            return LicenseCoordinatorBrandLicense;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // ProductUseRequest
        public static dc.ProductUseRequest LicenseCoordinatorCleanForAdd(this dc.ProductUseRequest cleanProductUseRequest)
        {
            var LicenseCoordinatorProductUseRequest = default(dc.ProductUseRequest);

            if (!ReferenceEquals(cleanProductUseRequest, null))
            {
                LicenseCoordinatorProductUseRequest = new dc.ProductUseRequest()
                {
                    ProductUseRequestId = cleanProductUseRequest.ProductUseRequestId,
                    RequestStatus = cleanProductUseRequest.RequestStatus,
                    CreatedOn = cleanProductUseRequest.CreatedOn,
                    Licensee = cleanProductUseRequest.Licensee,
                    ProductVersion = cleanProductUseRequest.ProductVersion
                };
            }

            return LicenseCoordinatorProductUseRequest;
        }
        
        
        public static List<dc.ProductUseRequest> LicenseCoordinatorCleanForGet(this IEnumerable<dc.ProductUseRequest> cleanProductUseRequests)
        {
            return cleanProductUseRequests.Select(ProductUseRequest => ProductUseRequest.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductUseRequest LicenseCoordinatorCleanForGet(this dc.ProductUseRequest cleanProductUseRequest)
        {
            var LicenseCoordinatorProductUseRequest = default(dc.ProductUseRequest);

            if (!ReferenceEquals(cleanProductUseRequest, null))
            {
                LicenseCoordinatorProductUseRequest = new dc.ProductUseRequest()
                {
                    ProductUseRequestId = cleanProductUseRequest.ProductUseRequestId,
                    Name = cleanProductUseRequest.Name,
                    RequestStatus = cleanProductUseRequest.RequestStatus,
                    CreatedOn = cleanProductUseRequest.CreatedOn,
                    Product = cleanProductUseRequest.Product,
                    Licensee = cleanProductUseRequest.Licensee,
                    ProductVersion = cleanProductUseRequest.ProductVersion
                };
            }

            return LicenseCoordinatorProductUseRequest;
        }
        
        
        public static dc.ProductUseRequest LicenseCoordinatorCleanForUpdate(this dc.ProductUseRequest cleanProductUseRequest)
        {
            var LicenseCoordinatorProductUseRequest = default(dc.ProductUseRequest);

            if (!ReferenceEquals(cleanProductUseRequest, null))
            {
                LicenseCoordinatorProductUseRequest = new dc.ProductUseRequest()
                {
                    ProductUseRequestId = cleanProductUseRequest.ProductUseRequestId,
                    RequestStatus = cleanProductUseRequest.RequestStatus,
                    CreatedOn = cleanProductUseRequest.CreatedOn,
                    Licensee = cleanProductUseRequest.Licensee,
                    ProductVersion = cleanProductUseRequest.ProductVersion
                };
            }

            return LicenseCoordinatorProductUseRequest;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // LicenseType
        public static dc.LicenseType LicenseCoordinatorCleanForAdd(this dc.LicenseType cleanLicenseType)
        {
            var LicenseCoordinatorLicenseType = default(dc.LicenseType);

            if (!ReferenceEquals(cleanLicenseType, null))
            {
                LicenseCoordinatorLicenseType = new dc.LicenseType()
                {
                    LicenseTypeId = cleanLicenseType.LicenseTypeId,
                    Name = cleanLicenseType.Name,
                    LicenseBundles = cleanLicenseType.LicenseBundles,
                    Description = cleanLicenseType.Description,
                    PrimaryTrackingField = cleanLicenseType.PrimaryTrackingField
                };
            }

            return LicenseCoordinatorLicenseType;
        }
        
        
        public static List<dc.LicenseType> LicenseCoordinatorCleanForGet(this IEnumerable<dc.LicenseType> cleanLicenseTypes)
        {
            return cleanLicenseTypes.Select(LicenseType => LicenseType.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseType LicenseCoordinatorCleanForGet(this dc.LicenseType cleanLicenseType)
        {
            var LicenseCoordinatorLicenseType = default(dc.LicenseType);

            if (!ReferenceEquals(cleanLicenseType, null))
            {
                LicenseCoordinatorLicenseType = new dc.LicenseType()
                {
                    LicenseTypeId = cleanLicenseType.LicenseTypeId,
                    Name = cleanLicenseType.Name,
                    LicenseBundles = cleanLicenseType.LicenseBundles,
                    Description = cleanLicenseType.Description,
                    PrimaryTrackingField = cleanLicenseType.PrimaryTrackingField
                };
            }

            return LicenseCoordinatorLicenseType;
        }
        
        
        public static dc.LicenseType LicenseCoordinatorCleanForUpdate(this dc.LicenseType cleanLicenseType)
        {
            var LicenseCoordinatorLicenseType = default(dc.LicenseType);

            if (!ReferenceEquals(cleanLicenseType, null))
            {
                LicenseCoordinatorLicenseType = new dc.LicenseType()
                {
                    LicenseTypeId = cleanLicenseType.LicenseTypeId,
                    Name = cleanLicenseType.Name,
                    LicenseBundles = cleanLicenseType.LicenseBundles,
                    Description = cleanLicenseType.Description,
                    PrimaryTrackingField = cleanLicenseType.PrimaryTrackingField
                };
            }

            return LicenseCoordinatorLicenseType;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // MeterTransaction
        public static dc.MeterTransaction LicenseCoordinatorCleanForAdd(this dc.MeterTransaction cleanMeterTransaction)
        {
            var LicenseCoordinatorMeterTransaction = default(dc.MeterTransaction);

            if (!ReferenceEquals(cleanMeterTransaction, null))
            {
                LicenseCoordinatorMeterTransaction = new dc.MeterTransaction()
                {
                    MeterTransactionId = cleanMeterTransaction.MeterTransactionId,
                    Notes = cleanMeterTransaction.Notes,
                    Attachments = cleanMeterTransaction.Attachments,
                    Status = cleanMeterTransaction.Status,
                    ProductLicenseMeter = cleanMeterTransaction.ProductLicenseMeter,
                    AutoNumber = cleanMeterTransaction.AutoNumber,
                    CustomTransactionDate = cleanMeterTransaction.CustomTransactionDate,
                    SKUMeterAdjustment = cleanMeterTransaction.SKUMeterAdjustment,
                    CustomValue = cleanMeterTransaction.CustomValue,
                    AdjustsLimit = cleanMeterTransaction.AdjustsLimit,
                    UnitConversion = cleanMeterTransaction.UnitConversion,
                    ReplacedByMeterTransaction = cleanMeterTransaction.ReplacedByMeterTransaction
                };
            }

            return LicenseCoordinatorMeterTransaction;
        }
        
        
        public static List<dc.MeterTransaction> LicenseCoordinatorCleanForGet(this IEnumerable<dc.MeterTransaction> cleanMeterTransactions)
        {
            return cleanMeterTransactions.Select(MeterTransaction => MeterTransaction.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.MeterTransaction LicenseCoordinatorCleanForGet(this dc.MeterTransaction cleanMeterTransaction)
        {
            var LicenseCoordinatorMeterTransaction = default(dc.MeterTransaction);

            if (!ReferenceEquals(cleanMeterTransaction, null))
            {
                LicenseCoordinatorMeterTransaction = new dc.MeterTransaction()
                {
                    MeterTransactionId = cleanMeterTransaction.MeterTransactionId,
                    Name = cleanMeterTransaction.Name,
                    Notes = cleanMeterTransaction.Notes,
                    Attachments = cleanMeterTransaction.Attachments,
                    Status = cleanMeterTransaction.Status,
                    ProductLicenseMeter = cleanMeterTransaction.ProductLicenseMeter,
                    Value = cleanMeterTransaction.Value,
                    CreatedTime = cleanMeterTransaction.CreatedTime,
                    AutoNumber = cleanMeterTransaction.AutoNumber,
                    TransactionResetDate = cleanMeterTransaction.TransactionResetDate,
                    CustomTransactionDate = cleanMeterTransaction.CustomTransactionDate,
                    TransactionDate = cleanMeterTransaction.TransactionDate,
                    IsActive = cleanMeterTransaction.IsActive,
                    LicenseeEmailAddress = cleanMeterTransaction.LicenseeEmailAddress,
                    LicensorEmailaddress = cleanMeterTransaction.LicensorEmailaddress,
                    SKUMeterAdjustment = cleanMeterTransaction.SKUMeterAdjustment,
                    LicenseMeter = cleanMeterTransaction.LicenseMeter,
                    Adjustment = cleanMeterTransaction.Adjustment,
                    CustomValue = cleanMeterTransaction.CustomValue,
                    ProductLicense = cleanMeterTransaction.ProductLicense,
                    AdjustmentType = cleanMeterTransaction.AdjustmentType,
                    UsageValue = cleanMeterTransaction.UsageValue,
                    LimitValue = cleanMeterTransaction.LimitValue,
                    AdjustsLimit = cleanMeterTransaction.AdjustsLimit,
                    UnitConversion = cleanMeterTransaction.UnitConversion,
                    UnitConversionValue = cleanMeterTransaction.UnitConversionValue,
                    LicenseMeterUnitOfMeasurement = cleanMeterTransaction.LicenseMeterUnitOfMeasurement,
                    ConversionRatio = cleanMeterTransaction.ConversionRatio,
                    LicenseMeterUnitOfMeasurementSingular = cleanMeterTransaction.LicenseMeterUnitOfMeasurementSingular,
                    LicenseMeterUnitOfMeasurementPlural = cleanMeterTransaction.LicenseMeterUnitOfMeasurementPlural,
                    ReplacedByMeterTransaction = cleanMeterTransaction.ReplacedByMeterTransaction
                };
            }

            return LicenseCoordinatorMeterTransaction;
        }
        
        
        public static dc.MeterTransaction LicenseCoordinatorCleanForUpdate(this dc.MeterTransaction cleanMeterTransaction)
        {
            var LicenseCoordinatorMeterTransaction = default(dc.MeterTransaction);

            if (!ReferenceEquals(cleanMeterTransaction, null))
            {
                LicenseCoordinatorMeterTransaction = new dc.MeterTransaction()
                {
                    MeterTransactionId = cleanMeterTransaction.MeterTransactionId,
                    Notes = cleanMeterTransaction.Notes,
                    Attachments = cleanMeterTransaction.Attachments,
                    Status = cleanMeterTransaction.Status,
                    ProductLicenseMeter = cleanMeterTransaction.ProductLicenseMeter,
                    AutoNumber = cleanMeterTransaction.AutoNumber,
                    CustomTransactionDate = cleanMeterTransaction.CustomTransactionDate,
                    SKUMeterAdjustment = cleanMeterTransaction.SKUMeterAdjustment,
                    CustomValue = cleanMeterTransaction.CustomValue,
                    AdjustsLimit = cleanMeterTransaction.AdjustsLimit,
                    UnitConversion = cleanMeterTransaction.UnitConversion,
                    ReplacedByMeterTransaction = cleanMeterTransaction.ReplacedByMeterTransaction
                };
            }

            return LicenseCoordinatorMeterTransaction;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // LicenseSKU
        public static dc.LicenseSKU LicenseCoordinatorCleanForAdd(this dc.LicenseSKU cleanLicenseSKU)
        {
            var LicenseCoordinatorLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                LicenseCoordinatorLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments
                };
            }

            return LicenseCoordinatorLicenseSKU;
        }
        
        
        public static List<dc.LicenseSKU> LicenseCoordinatorCleanForGet(this IEnumerable<dc.LicenseSKU> cleanLicenseSKUs)
        {
            return cleanLicenseSKUs.Select(LicenseSKU => LicenseSKU.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseSKU LicenseCoordinatorCleanForGet(this dc.LicenseSKU cleanLicenseSKU)
        {
            var LicenseCoordinatorLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                LicenseCoordinatorLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Name = cleanLicenseSKU.Name,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    MonthsIncluded = cleanLicenseSKU.MonthsIncluded,
                    BundleLicensor = cleanLicenseSKU.BundleLicensor,
                    LicensorEmailAddress = cleanLicenseSKU.LicensorEmailAddress,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUCode = cleanLicenseSKU.SKUCode,
                    SKUDescription = cleanLicenseSKU.SKUDescription,
                    SKU = cleanLicenseSKU.SKU,
                    PlanName = cleanLicenseSKU.PlanName,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKUTypeCode = cleanLicenseSKU.SKUTypeCode,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    Brand = cleanLicenseSKU.Brand,
                    ParentInitialFee = cleanLicenseSKU.ParentInitialFee,
                    ParentMonthlyFee = cleanLicenseSKU.ParentMonthlyFee,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    ParentRelativeFee = cleanLicenseSKU.ParentRelativeFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    CalculatedMonthlyFee = cleanLicenseSKU.CalculatedMonthlyFee,
                    SKURenewalFee = cleanLicenseSKU.SKURenewalFee,
                    LicensorSKUCode = cleanLicenseSKU.LicensorSKUCode,
                    BrandLicenseSKU = cleanLicenseSKU.BrandLicenseSKU,
                    PaymentProcessorPercent = cleanLicenseSKU.PaymentProcessorPercent,
                    PaymentProcessorFee = cleanLicenseSKU.PaymentProcessorFee,
                    TotalMarketFees = cleanLicenseSKU.TotalMarketFees,
                    LicensorPayment = cleanLicenseSKU.LicensorPayment,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    LicensorFee = cleanLicenseSKU.LicensorFee,
                    BrandName = cleanLicenseSKU.BrandName,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    CreatedTime = cleanLicenseSKU.CreatedTime,
                    ModifiedTime = cleanLicenseSKU.ModifiedTime,
                    BrandLicenseName = cleanLicenseSKU.BrandLicenseName,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    BrandLicenseLicenseType = cleanLicenseSKU.BrandLicenseLicenseType,
                    BrandIsPublic = cleanLicenseSKU.BrandIsPublic,
                    SSioTechnology = cleanLicenseSKU.SSioTechnology,
                    SSioTechnologySKUCode = cleanLicenseSKU.SSioTechnologySKUCode,
                    SSioTechnologyPercent = cleanLicenseSKU.SSioTechnologyPercent,
                    SSioTechnologyFee = cleanLicenseSKU.SSioTechnologyFee,
                    SSioPercent = cleanLicenseSKU.SSioPercent,
                    SSioFee = cleanLicenseSKU.SSioFee,
                    SSioTechnologyName = cleanLicenseSKU.SSioTechnologyName,
                    QuantityIncluded = cleanLicenseSKU.QuantityIncluded,
                    ParentRecurringFee = cleanLicenseSKU.ParentRecurringFee,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    CalculatedRecurringFee = cleanLicenseSKU.CalculatedRecurringFee,
                    LicenseTypePrimaryTrackingField = cleanLicenseSKU.LicenseTypePrimaryTrackingField,
                    CalculatedInitialFee = cleanLicenseSKU.CalculatedInitialFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments,
                    PluralNameForBrand = cleanLicenseSKU.PluralNameForBrand,
                    NameForBrandLicense = cleanLicenseSKU.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanLicenseSKU.PluralNameForBrandLicense,
                    NameForMeter = cleanLicenseSKU.NameForMeter,
                    PluralNameForMeter = cleanLicenseSKU.PluralNameForMeter,
                    NameForSKU = cleanLicenseSKU.NameForSKU,
                    PluralNameForSKU = cleanLicenseSKU.PluralNameForSKU,
                    NameForBrand = cleanLicenseSKU.NameForBrand
                };
            }

            return LicenseCoordinatorLicenseSKU;
        }
        
        
        public static dc.LicenseSKU LicenseCoordinatorCleanForUpdate(this dc.LicenseSKU cleanLicenseSKU)
        {
            var LicenseCoordinatorLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                LicenseCoordinatorLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments
                };
            }

            return LicenseCoordinatorLicenseSKU;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // SSioVersion
        public static dc.SSioVersion LicenseCoordinatorCleanForAdd(this dc.SSioVersion cleanSSioVersion)
        {
            var LicenseCoordinatorSSioVersion = default(dc.SSioVersion);

            if (!ReferenceEquals(cleanSSioVersion, null))
            {
                LicenseCoordinatorSSioVersion = new dc.SSioVersion()
                {
                    SSioVersionId = cleanSSioVersion.SSioVersionId,
                    Name = cleanSSioVersion.Name,
                    Notes = cleanSSioVersion.Notes,
                    Attachments = cleanSSioVersion.Attachments,
                    Status = cleanSSioVersion.Status,
                    TargetDate = cleanSSioVersion.TargetDate
                };
            }

            return LicenseCoordinatorSSioVersion;
        }
        
        
        public static List<dc.SSioVersion> LicenseCoordinatorCleanForGet(this IEnumerable<dc.SSioVersion> cleanSSioVersions)
        {
            return cleanSSioVersions.Select(SSioVersion => SSioVersion.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.SSioVersion LicenseCoordinatorCleanForGet(this dc.SSioVersion cleanSSioVersion)
        {
            var LicenseCoordinatorSSioVersion = default(dc.SSioVersion);

            if (!ReferenceEquals(cleanSSioVersion, null))
            {
                LicenseCoordinatorSSioVersion = new dc.SSioVersion()
                {
                    SSioVersionId = cleanSSioVersion.SSioVersionId,
                    Name = cleanSSioVersion.Name,
                    Notes = cleanSSioVersion.Notes,
                    Attachments = cleanSSioVersion.Attachments,
                    Status = cleanSSioVersion.Status,
                    TargetDate = cleanSSioVersion.TargetDate
                };
            }

            return LicenseCoordinatorSSioVersion;
        }
        
        
        public static dc.SSioVersion LicenseCoordinatorCleanForUpdate(this dc.SSioVersion cleanSSioVersion)
        {
            var LicenseCoordinatorSSioVersion = default(dc.SSioVersion);

            if (!ReferenceEquals(cleanSSioVersion, null))
            {
                LicenseCoordinatorSSioVersion = new dc.SSioVersion()
                {
                    SSioVersionId = cleanSSioVersion.SSioVersionId,
                    Name = cleanSSioVersion.Name,
                    Notes = cleanSSioVersion.Notes,
                    Attachments = cleanSSioVersion.Attachments,
                    Status = cleanSSioVersion.Status,
                    TargetDate = cleanSSioVersion.TargetDate
                };
            }

            return LicenseCoordinatorSSioVersion;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // ProductVersion
        public static dc.ProductVersion LicenseCoordinatorCleanForAdd(this dc.ProductVersion cleanProductVersion)
        {
            var LicenseCoordinatorProductVersion = default(dc.ProductVersion);

            if (!ReferenceEquals(cleanProductVersion, null))
            {
                LicenseCoordinatorProductVersion = new dc.ProductVersion()
                {
                    ProductVersionId = cleanProductVersion.ProductVersionId,
                    LicensedProduct = cleanProductVersion.LicensedProduct,
                    Description = cleanProductVersion.Description,
                    OverrideCreatedOn = cleanProductVersion.OverrideCreatedOn,
                    IsActive = cleanProductVersion.IsActive,
                    LambdaEndpoint = cleanProductVersion.LambdaEndpoint,
                    TranspilerVersionUUID = cleanProductVersion.TranspilerVersionUUID,
                    ProductUseRequests = cleanProductVersion.ProductUseRequests,
                    HeadVersion = cleanProductVersion.HeadVersion,
                    ProductVersionDescription = cleanProductVersion.ProductVersionDescription,
                    ProductVersionReadMeMD = cleanProductVersion.ProductVersionReadMeMD,
                    ProductVersionInputDescriptionMD = cleanProductVersion.ProductVersionInputDescriptionMD,
                    ProductVersionOutputDescriptionMD = cleanProductVersion.ProductVersionOutputDescriptionMD,
                    MonthlyProductUseRequests = cleanProductVersion.MonthlyProductUseRequests,
                    MonthlyProductUseRequestCount = cleanProductVersion.MonthlyProductUseRequestCount,
                    ActiveProductUseRequestCount = cleanProductVersion.ActiveProductUseRequestCount,
                    VersionNumber = cleanProductVersion.VersionNumber,
                    AWSLambdaVersion = cleanProductVersion.AWSLambdaVersion,
                    OverrideAWSLambdaArn = cleanProductVersion.OverrideAWSLambdaArn
                };
            }

            return LicenseCoordinatorProductVersion;
        }
        
        
        public static List<dc.ProductVersion> LicenseCoordinatorCleanForGet(this IEnumerable<dc.ProductVersion> cleanProductVersions)
        {
            return cleanProductVersions.Select(ProductVersion => ProductVersion.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductVersion LicenseCoordinatorCleanForGet(this dc.ProductVersion cleanProductVersion)
        {
            var LicenseCoordinatorProductVersion = default(dc.ProductVersion);

            if (!ReferenceEquals(cleanProductVersion, null))
            {
                LicenseCoordinatorProductVersion = new dc.ProductVersion()
                {
                    ProductVersionId = cleanProductVersion.ProductVersionId,
                    Name = cleanProductVersion.Name,
                    LicensedProduct = cleanProductVersion.LicensedProduct,
                    Version = cleanProductVersion.Version,
                    Description = cleanProductVersion.Description,
                    OverrideCreatedOn = cleanProductVersion.OverrideCreatedOn,
                    IsActive = cleanProductVersion.IsActive,
                    AccountHolder = cleanProductVersion.AccountHolder,
                    LambdaEndpoint = cleanProductVersion.LambdaEndpoint,
                    LicensorEmailAddress = cleanProductVersion.LicensorEmailAddress,
                    TranspilerVersionUUID = cleanProductVersion.TranspilerVersionUUID,
                    ProductName = cleanProductVersion.ProductName,
                    AccountHolderIsVerified = cleanProductVersion.AccountHolderIsVerified,
                    ProductUseRequests = cleanProductVersion.ProductUseRequests,
                    HeadVersion = cleanProductVersion.HeadVersion,
                    ProductVersionCount = cleanProductVersion.ProductVersionCount,
                    LicensorScreenName = cleanProductVersion.LicensorScreenName,
                    CurrentProductDescription = cleanProductVersion.CurrentProductDescription,
                    ProductVersionDescription = cleanProductVersion.ProductVersionDescription,
                    CurrentProductReadMeMD = cleanProductVersion.CurrentProductReadMeMD,
                    ProductVersionReadMeMD = cleanProductVersion.ProductVersionReadMeMD,
                    ProductVersionInputDescriptionMD = cleanProductVersion.ProductVersionInputDescriptionMD,
                    ProductVersionOutputDescriptionMD = cleanProductVersion.ProductVersionOutputDescriptionMD,
                    ProductLowerName = cleanProductVersion.ProductLowerName,
                    ProductHyphenLowerName = cleanProductVersion.ProductHyphenLowerName,
                    ProductUpperName = cleanProductVersion.ProductUpperName,
                    RecordCreatedtime = cleanProductVersion.RecordCreatedtime,
                    CreatedOn = cleanProductVersion.CreatedOn,
                    MonthlyProductUseRequests = cleanProductVersion.MonthlyProductUseRequests,
                    MonthlyProductUseRequestCount = cleanProductVersion.MonthlyProductUseRequestCount,
                    ActiveProductUseRequestCount = cleanProductVersion.ActiveProductUseRequestCount,
                    ProductUseRequestCount = cleanProductVersion.ProductUseRequestCount,
                    IsRecentVersion = cleanProductVersion.IsRecentVersion,
                    VersionNumber = cleanProductVersion.VersionNumber,
                    PublishedVersion = cleanProductVersion.PublishedVersion,
                    DefaultAWSLambdaArn = cleanProductVersion.DefaultAWSLambdaArn,
                    AWSLambdaVersion = cleanProductVersion.AWSLambdaVersion,
                    LicensorAWSAccountId = cleanProductVersion.LicensorAWSAccountId,
                    LicensorAWSAPIGatewayId = cleanProductVersion.LicensorAWSAPIGatewayId,
                    LicensorAWSLambdaRegion = cleanProductVersion.LicensorAWSLambdaRegion,
                    ProductAWSLambdaFunctionName = cleanProductVersion.ProductAWSLambdaFunctionName,
                    OverrideAWSLambdaArn = cleanProductVersion.OverrideAWSLambdaArn,
                    AWSLambdaArn = cleanProductVersion.AWSLambdaArn
                };
            }

            return LicenseCoordinatorProductVersion;
        }
        
        
        public static dc.ProductVersion LicenseCoordinatorCleanForUpdate(this dc.ProductVersion cleanProductVersion)
        {
            var LicenseCoordinatorProductVersion = default(dc.ProductVersion);

            if (!ReferenceEquals(cleanProductVersion, null))
            {
                LicenseCoordinatorProductVersion = new dc.ProductVersion()
                {
                    ProductVersionId = cleanProductVersion.ProductVersionId,
                    LicensedProduct = cleanProductVersion.LicensedProduct,
                    Description = cleanProductVersion.Description,
                    OverrideCreatedOn = cleanProductVersion.OverrideCreatedOn,
                    IsActive = cleanProductVersion.IsActive,
                    LambdaEndpoint = cleanProductVersion.LambdaEndpoint,
                    TranspilerVersionUUID = cleanProductVersion.TranspilerVersionUUID,
                    ProductUseRequests = cleanProductVersion.ProductUseRequests,
                    HeadVersion = cleanProductVersion.HeadVersion,
                    ProductVersionDescription = cleanProductVersion.ProductVersionDescription,
                    ProductVersionReadMeMD = cleanProductVersion.ProductVersionReadMeMD,
                    ProductVersionInputDescriptionMD = cleanProductVersion.ProductVersionInputDescriptionMD,
                    ProductVersionOutputDescriptionMD = cleanProductVersion.ProductVersionOutputDescriptionMD,
                    MonthlyProductUseRequests = cleanProductVersion.MonthlyProductUseRequests,
                    MonthlyProductUseRequestCount = cleanProductVersion.MonthlyProductUseRequestCount,
                    ActiveProductUseRequestCount = cleanProductVersion.ActiveProductUseRequestCount,
                    VersionNumber = cleanProductVersion.VersionNumber,
                    AWSLambdaVersion = cleanProductVersion.AWSLambdaVersion,
                    OverrideAWSLambdaArn = cleanProductVersion.OverrideAWSLambdaArn
                };
            }

            return LicenseCoordinatorProductVersion;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // UnitOfMeasurement
        public static dc.UnitOfMeasurement LicenseCoordinatorCleanForAdd(this dc.UnitOfMeasurement cleanUnitOfMeasurement)
        {
            var LicenseCoordinatorUnitOfMeasurement = default(dc.UnitOfMeasurement);

            if (!ReferenceEquals(cleanUnitOfMeasurement, null))
            {
                LicenseCoordinatorUnitOfMeasurement = new dc.UnitOfMeasurement()
                {
                    UnitOfMeasurementId = cleanUnitOfMeasurement.UnitOfMeasurementId,
                    Notes = cleanUnitOfMeasurement.Notes,
                    Attachments = cleanUnitOfMeasurement.Attachments,
                    Status = cleanUnitOfMeasurement.Status,
                    NameSingular = cleanUnitOfMeasurement.NameSingular,
                    NamePlural = cleanUnitOfMeasurement.NamePlural,
                    CaseSensativeCode = cleanUnitOfMeasurement.CaseSensativeCode,
                    RelatedMeasurementUnit = cleanUnitOfMeasurement.RelatedMeasurementUnit,
                    RelatedTimeUnit = cleanUnitOfMeasurement.RelatedTimeUnit,
                    MeasurementType = cleanUnitOfMeasurement.MeasurementType,
                    LongCode = cleanUnitOfMeasurement.LongCode,
                    MeasurementValue = cleanUnitOfMeasurement.MeasurementValue,
                    BaseUnit = cleanUnitOfMeasurement.BaseUnit,
                    BaseUnitMultiplier = cleanUnitOfMeasurement.BaseUnitMultiplier,
                    SortOrder = cleanUnitOfMeasurement.SortOrder,
                    UnitConversions = cleanUnitOfMeasurement.UnitConversions,
                    UnitConversions2 = cleanUnitOfMeasurement.UnitConversions2,
                    LicenseMeters = cleanUnitOfMeasurement.LicenseMeters,
                    MeterTransactions = cleanUnitOfMeasurement.MeterTransactions
                };
            }

            return LicenseCoordinatorUnitOfMeasurement;
        }
        
        
        public static List<dc.UnitOfMeasurement> LicenseCoordinatorCleanForGet(this IEnumerable<dc.UnitOfMeasurement> cleanUnitOfMeasurements)
        {
            return cleanUnitOfMeasurements.Select(UnitOfMeasurement => UnitOfMeasurement.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.UnitOfMeasurement LicenseCoordinatorCleanForGet(this dc.UnitOfMeasurement cleanUnitOfMeasurement)
        {
            var LicenseCoordinatorUnitOfMeasurement = default(dc.UnitOfMeasurement);

            if (!ReferenceEquals(cleanUnitOfMeasurement, null))
            {
                LicenseCoordinatorUnitOfMeasurement = new dc.UnitOfMeasurement()
                {
                    UnitOfMeasurementId = cleanUnitOfMeasurement.UnitOfMeasurementId,
                    Name = cleanUnitOfMeasurement.Name,
                    Notes = cleanUnitOfMeasurement.Notes,
                    Attachments = cleanUnitOfMeasurement.Attachments,
                    Status = cleanUnitOfMeasurement.Status,
                    MeasurementTypeName = cleanUnitOfMeasurement.MeasurementTypeName,
                    NameSingular = cleanUnitOfMeasurement.NameSingular,
                    NamePlural = cleanUnitOfMeasurement.NamePlural,
                    CaseSensativeCode = cleanUnitOfMeasurement.CaseSensativeCode,
                    RelatedMeasurementUnit = cleanUnitOfMeasurement.RelatedMeasurementUnit,
                    RelatedTimeUnit = cleanUnitOfMeasurement.RelatedTimeUnit,
                    RelatedMeasurementUnitLongCode = cleanUnitOfMeasurement.RelatedMeasurementUnitLongCode,
                    RelatedTimeUnitLongCode = cleanUnitOfMeasurement.RelatedTimeUnitLongCode,
                    INTERNAL_SuggestedCode = cleanUnitOfMeasurement.INTERNAL_SuggestedCode,
                    MeasurementType = cleanUnitOfMeasurement.MeasurementType,
                    LongCode = cleanUnitOfMeasurement.LongCode,
                    MeasurementValue = cleanUnitOfMeasurement.MeasurementValue,
                    BaseUnit = cleanUnitOfMeasurement.BaseUnit,
                    BaseUnitMultiplier = cleanUnitOfMeasurement.BaseUnitMultiplier,
                    SuggestedMeasurementValue = cleanUnitOfMeasurement.SuggestedMeasurementValue,
                    BaseUnitNamePlural = cleanUnitOfMeasurement.BaseUnitNamePlural,
                    SortOrder = cleanUnitOfMeasurement.SortOrder,
                    UnitConversions = cleanUnitOfMeasurement.UnitConversions,
                    UnitConversions2 = cleanUnitOfMeasurement.UnitConversions2,
                    LicenseMeters = cleanUnitOfMeasurement.LicenseMeters,
                    AddsMinutes = cleanUnitOfMeasurement.AddsMinutes,
                    AddsMonths = cleanUnitOfMeasurement.AddsMonths,
                    MeterTransactions = cleanUnitOfMeasurement.MeterTransactions
                };
            }

            return LicenseCoordinatorUnitOfMeasurement;
        }
        
        
        public static dc.UnitOfMeasurement LicenseCoordinatorCleanForUpdate(this dc.UnitOfMeasurement cleanUnitOfMeasurement)
        {
            var LicenseCoordinatorUnitOfMeasurement = default(dc.UnitOfMeasurement);

            if (!ReferenceEquals(cleanUnitOfMeasurement, null))
            {
                LicenseCoordinatorUnitOfMeasurement = new dc.UnitOfMeasurement()
                {
                    UnitOfMeasurementId = cleanUnitOfMeasurement.UnitOfMeasurementId,
                    Notes = cleanUnitOfMeasurement.Notes,
                    Attachments = cleanUnitOfMeasurement.Attachments,
                    Status = cleanUnitOfMeasurement.Status,
                    NameSingular = cleanUnitOfMeasurement.NameSingular,
                    NamePlural = cleanUnitOfMeasurement.NamePlural,
                    CaseSensativeCode = cleanUnitOfMeasurement.CaseSensativeCode,
                    RelatedMeasurementUnit = cleanUnitOfMeasurement.RelatedMeasurementUnit,
                    RelatedTimeUnit = cleanUnitOfMeasurement.RelatedTimeUnit,
                    MeasurementType = cleanUnitOfMeasurement.MeasurementType,
                    LongCode = cleanUnitOfMeasurement.LongCode,
                    MeasurementValue = cleanUnitOfMeasurement.MeasurementValue,
                    BaseUnit = cleanUnitOfMeasurement.BaseUnit,
                    BaseUnitMultiplier = cleanUnitOfMeasurement.BaseUnitMultiplier,
                    SortOrder = cleanUnitOfMeasurement.SortOrder,
                    UnitConversions = cleanUnitOfMeasurement.UnitConversions,
                    UnitConversions2 = cleanUnitOfMeasurement.UnitConversions2,
                    LicenseMeters = cleanUnitOfMeasurement.LicenseMeters,
                    MeterTransactions = cleanUnitOfMeasurement.MeterTransactions
                };
            }

            return LicenseCoordinatorUnitOfMeasurement;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // ProductLicenseDMQueue
        public static dc.ProductLicenseDMQueue LicenseCoordinatorCleanForAdd(this dc.ProductLicenseDMQueue cleanProductLicenseDMQueue)
        {
            var LicenseCoordinatorProductLicenseDMQueue = default(dc.ProductLicenseDMQueue);

            if (!ReferenceEquals(cleanProductLicenseDMQueue, null))
            {
                LicenseCoordinatorProductLicenseDMQueue = new dc.ProductLicenseDMQueue()
                {
                    ProductLicenseDMQueueId = cleanProductLicenseDMQueue.ProductLicenseDMQueueId,
                    Notes = cleanProductLicenseDMQueue.Notes,
                    Attachments = cleanProductLicenseDMQueue.Attachments,
                    Status = cleanProductLicenseDMQueue.Status,
                    DMQueueSubmitted = cleanProductLicenseDMQueue.DMQueueSubmitted,
                    TTL = cleanProductLicenseDMQueue.TTL,
                    ProductLicense = cleanProductLicenseDMQueue.ProductLicense
                };
            }

            return LicenseCoordinatorProductLicenseDMQueue;
        }
        
        
        public static List<dc.ProductLicenseDMQueue> LicenseCoordinatorCleanForGet(this IEnumerable<dc.ProductLicenseDMQueue> cleanProductLicenseDMQueues)
        {
            return cleanProductLicenseDMQueues.Select(ProductLicenseDMQueue => ProductLicenseDMQueue.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductLicenseDMQueue LicenseCoordinatorCleanForGet(this dc.ProductLicenseDMQueue cleanProductLicenseDMQueue)
        {
            var LicenseCoordinatorProductLicenseDMQueue = default(dc.ProductLicenseDMQueue);

            if (!ReferenceEquals(cleanProductLicenseDMQueue, null))
            {
                LicenseCoordinatorProductLicenseDMQueue = new dc.ProductLicenseDMQueue()
                {
                    ProductLicenseDMQueueId = cleanProductLicenseDMQueue.ProductLicenseDMQueueId,
                    Name = cleanProductLicenseDMQueue.Name,
                    Notes = cleanProductLicenseDMQueue.Notes,
                    Attachments = cleanProductLicenseDMQueue.Attachments,
                    Status = cleanProductLicenseDMQueue.Status,
                    CreatedTime = cleanProductLicenseDMQueue.CreatedTime,
                    DMQueueSubmitted = cleanProductLicenseDMQueue.DMQueueSubmitted,
                    TTL = cleanProductLicenseDMQueue.TTL,
                    QueueExpires = cleanProductLicenseDMQueue.QueueExpires,
                    DMQueue = cleanProductLicenseDMQueue.DMQueue,
                    ProductLicense = cleanProductLicenseDMQueue.ProductLicense
                };
            }

            return LicenseCoordinatorProductLicenseDMQueue;
        }
        
        
        public static dc.ProductLicenseDMQueue LicenseCoordinatorCleanForUpdate(this dc.ProductLicenseDMQueue cleanProductLicenseDMQueue)
        {
            var LicenseCoordinatorProductLicenseDMQueue = default(dc.ProductLicenseDMQueue);

            if (!ReferenceEquals(cleanProductLicenseDMQueue, null))
            {
                LicenseCoordinatorProductLicenseDMQueue = new dc.ProductLicenseDMQueue()
                {
                    ProductLicenseDMQueueId = cleanProductLicenseDMQueue.ProductLicenseDMQueueId,
                    Notes = cleanProductLicenseDMQueue.Notes,
                    Attachments = cleanProductLicenseDMQueue.Attachments,
                    Status = cleanProductLicenseDMQueue.Status,
                    DMQueueSubmitted = cleanProductLicenseDMQueue.DMQueueSubmitted,
                    TTL = cleanProductLicenseDMQueue.TTL,
                    ProductLicense = cleanProductLicenseDMQueue.ProductLicense
                };
            }

            return LicenseCoordinatorProductLicenseDMQueue;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // MeasurementType
        public static dc.MeasurementType LicenseCoordinatorCleanForAdd(this dc.MeasurementType cleanMeasurementType)
        {
            var LicenseCoordinatorMeasurementType = default(dc.MeasurementType);

            if (!ReferenceEquals(cleanMeasurementType, null))
            {
                LicenseCoordinatorMeasurementType = new dc.MeasurementType()
                {
                    MeasurementTypeId = cleanMeasurementType.MeasurementTypeId,
                    Name = cleanMeasurementType.Name,
                    UnitOfMeasurements = cleanMeasurementType.UnitOfMeasurements,
                    UnitOfMeasurementscopy = cleanMeasurementType.UnitOfMeasurementscopy,
                    AddsMinutes = cleanMeasurementType.AddsMinutes,
                    AddsMonths = cleanMeasurementType.AddsMonths
                };
            }

            return LicenseCoordinatorMeasurementType;
        }
        
        
        public static List<dc.MeasurementType> LicenseCoordinatorCleanForGet(this IEnumerable<dc.MeasurementType> cleanMeasurementTypes)
        {
            return cleanMeasurementTypes.Select(MeasurementType => MeasurementType.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.MeasurementType LicenseCoordinatorCleanForGet(this dc.MeasurementType cleanMeasurementType)
        {
            var LicenseCoordinatorMeasurementType = default(dc.MeasurementType);

            if (!ReferenceEquals(cleanMeasurementType, null))
            {
                LicenseCoordinatorMeasurementType = new dc.MeasurementType()
                {
                    MeasurementTypeId = cleanMeasurementType.MeasurementTypeId,
                    Name = cleanMeasurementType.Name,
                    UnitOfMeasurements = cleanMeasurementType.UnitOfMeasurements,
                    UnitOfMeasurementscopy = cleanMeasurementType.UnitOfMeasurementscopy,
                    AddsMinutes = cleanMeasurementType.AddsMinutes,
                    AddsMonths = cleanMeasurementType.AddsMonths
                };
            }

            return LicenseCoordinatorMeasurementType;
        }
        
        
        public static dc.MeasurementType LicenseCoordinatorCleanForUpdate(this dc.MeasurementType cleanMeasurementType)
        {
            var LicenseCoordinatorMeasurementType = default(dc.MeasurementType);

            if (!ReferenceEquals(cleanMeasurementType, null))
            {
                LicenseCoordinatorMeasurementType = new dc.MeasurementType()
                {
                    MeasurementTypeId = cleanMeasurementType.MeasurementTypeId,
                    Name = cleanMeasurementType.Name,
                    UnitOfMeasurements = cleanMeasurementType.UnitOfMeasurements,
                    UnitOfMeasurementscopy = cleanMeasurementType.UnitOfMeasurementscopy,
                    AddsMinutes = cleanMeasurementType.AddsMinutes,
                    AddsMonths = cleanMeasurementType.AddsMonths
                };
            }

            return LicenseCoordinatorMeasurementType;       }
        
        // LicenseCoordinator Cleaning Extension Methods.  -CRUD-
        
        // MonthlyProductUseRequest
        public static dc.MonthlyProductUseRequest LicenseCoordinatorCleanForAdd(this dc.MonthlyProductUseRequest cleanMonthlyProductUseRequest)
        {
            var LicenseCoordinatorMonthlyProductUseRequest = default(dc.MonthlyProductUseRequest);

            if (!ReferenceEquals(cleanMonthlyProductUseRequest, null))
            {
                LicenseCoordinatorMonthlyProductUseRequest = new dc.MonthlyProductUseRequest()
                {
                    MonthlyProductUseRequestId = cleanMonthlyProductUseRequest.MonthlyProductUseRequestId,
                    AccountHolder = cleanMonthlyProductUseRequest.AccountHolder,
                    Licensee = cleanMonthlyProductUseRequest.Licensee,
                    ProductUseYear = cleanMonthlyProductUseRequest.ProductUseYear,
                    ProductUseMonth = cleanMonthlyProductUseRequest.ProductUseMonth,
                    ProductUseCount = cleanMonthlyProductUseRequest.ProductUseCount,
                    ProductVesion = cleanMonthlyProductUseRequest.ProductVesion
                };
            }

            return LicenseCoordinatorMonthlyProductUseRequest;
        }
        
        
        public static List<dc.MonthlyProductUseRequest> LicenseCoordinatorCleanForGet(this IEnumerable<dc.MonthlyProductUseRequest> cleanMonthlyProductUseRequests)
        {
            return cleanMonthlyProductUseRequests.Select(MonthlyProductUseRequest => MonthlyProductUseRequest.LicenseCoordinatorCleanForGet())
                            .ToList();
        }
        
        public static dc.MonthlyProductUseRequest LicenseCoordinatorCleanForGet(this dc.MonthlyProductUseRequest cleanMonthlyProductUseRequest)
        {
            var LicenseCoordinatorMonthlyProductUseRequest = default(dc.MonthlyProductUseRequest);

            if (!ReferenceEquals(cleanMonthlyProductUseRequest, null))
            {
                LicenseCoordinatorMonthlyProductUseRequest = new dc.MonthlyProductUseRequest()
                {
                    MonthlyProductUseRequestId = cleanMonthlyProductUseRequest.MonthlyProductUseRequestId,
                    Name = cleanMonthlyProductUseRequest.Name,
                    AccountHolder = cleanMonthlyProductUseRequest.AccountHolder,
                    Licensee = cleanMonthlyProductUseRequest.Licensee,
                    ProductUseYear = cleanMonthlyProductUseRequest.ProductUseYear,
                    ProductUseMonth = cleanMonthlyProductUseRequest.ProductUseMonth,
                    ProductUseCount = cleanMonthlyProductUseRequest.ProductUseCount,
                    ProductVersionName = cleanMonthlyProductUseRequest.ProductVersionName,
                    ProductVesion = cleanMonthlyProductUseRequest.ProductVesion,
                    ProductUseYearMonth = cleanMonthlyProductUseRequest.ProductUseYearMonth
                };
            }

            return LicenseCoordinatorMonthlyProductUseRequest;
        }
        
        
        public static dc.MonthlyProductUseRequest LicenseCoordinatorCleanForUpdate(this dc.MonthlyProductUseRequest cleanMonthlyProductUseRequest)
        {
            var LicenseCoordinatorMonthlyProductUseRequest = default(dc.MonthlyProductUseRequest);

            if (!ReferenceEquals(cleanMonthlyProductUseRequest, null))
            {
                LicenseCoordinatorMonthlyProductUseRequest = new dc.MonthlyProductUseRequest()
                {
                    MonthlyProductUseRequestId = cleanMonthlyProductUseRequest.MonthlyProductUseRequestId,
                    AccountHolder = cleanMonthlyProductUseRequest.AccountHolder,
                    Licensee = cleanMonthlyProductUseRequest.Licensee,
                    ProductUseYear = cleanMonthlyProductUseRequest.ProductUseYear,
                    ProductUseMonth = cleanMonthlyProductUseRequest.ProductUseMonth,
                    ProductUseCount = cleanMonthlyProductUseRequest.ProductUseCount,
                    ProductVesion = cleanMonthlyProductUseRequest.ProductVesion
                };
            }

            return LicenseCoordinatorMonthlyProductUseRequest;       }
        
    
        
        // SSioUser Cleaning Extension Methods.  -CRUD-
        
        // Brand
        public static dc.Brand SSioUserCleanForAdd(this dc.Brand cleanBrand)
        {
            var SSioUserBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                SSioUserBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    SKUCode = cleanBrand.SKUCode,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl
                };
            }

            return SSioUserBrand;
        }
        
        
        public static List<dc.Brand> SSioUserCleanForGet(this IEnumerable<dc.Brand> cleanBrands)
        {
            return cleanBrands.Select(Brand => Brand.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.Brand SSioUserCleanForGet(this dc.Brand cleanBrand)
        {
            var SSioUserBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                SSioUserBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Name = cleanBrand.Name,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    LicensorEmailAddress = cleanBrand.LicensorEmailAddress,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    LicensorScreenName = cleanBrand.LicensorScreenName,
                    SKUCode = cleanBrand.SKUCode,
                    LicensorSKUCode = cleanBrand.LicensorSKUCode,
                    SKU = cleanBrand.SKU,
                    PaymentProcessorPercent = cleanBrand.PaymentProcessorPercent,
                    TotalMarketPercent = cleanBrand.TotalMarketPercent,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    OwnerScreenName = cleanBrand.OwnerScreenName,
                    OwnerSKUCode = cleanBrand.OwnerSKUCode,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    ModifiedTime = cleanBrand.ModifiedTime,
                    CreatedTime = cleanBrand.CreatedTime,
                    OwnerIsVerified = cleanBrand.OwnerIsVerified,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    SSioTechnologySKUCode = cleanBrand.SSioTechnologySKUCode,
                    SSioTechnologyPercent = cleanBrand.SSioTechnologyPercent,
                    SSioPercent = cleanBrand.SSioPercent,
                    SSioTechnologyName = cleanBrand.SSioTechnologyName,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    NameForBrand = cleanBrand.NameForBrand,
                    PluralNameForBrand = cleanBrand.PluralNameForBrand,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    LicensorLicenseEventWebhookUrl = cleanBrand.LicensorLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanBrand.LicenseEventWebhookUrl
                };
            }

            return SSioUserBrand;
        }
        
        
        public static dc.Brand SSioUserCleanForUpdate(this dc.Brand cleanBrand)
        {
            var SSioUserBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                SSioUserBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    SKUCode = cleanBrand.SKUCode,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl
                };
            }

            return SSioUserBrand;       }
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  -R-
        
        // InvoiceLineItem
        public static List<dc.InvoiceLineItem> SSioUserCleanForGet(this IEnumerable<dc.InvoiceLineItem> cleanInvoiceLineItems)
        {
            return cleanInvoiceLineItems.Select(InvoiceLineItem => InvoiceLineItem.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.InvoiceLineItem SSioUserCleanForGet(this dc.InvoiceLineItem cleanInvoiceLineItem)
        {
            var SSioUserInvoiceLineItem = default(dc.InvoiceLineItem);

            if (!ReferenceEquals(cleanInvoiceLineItem, null))
            {
                SSioUserInvoiceLineItem = new dc.InvoiceLineItem()
                {
                    InvoiceLineItemId = cleanInvoiceLineItem.InvoiceLineItemId,
                    Name = cleanInvoiceLineItem.Name,
                    Invoice = cleanInvoiceLineItem.Invoice,
                    MonthsPaidFor = cleanInvoiceLineItem.MonthsPaidFor,
                    DiscountApplied = cleanInvoiceLineItem.DiscountApplied,
                    SubTotal = cleanInvoiceLineItem.SubTotal,
                    ProductLicense = cleanInvoiceLineItem.ProductLicense,
                    MonthsInvoiced = cleanInvoiceLineItem.MonthsInvoiced,
                    InvoiceStripeStatus = cleanInvoiceLineItem.InvoiceStripeStatus,
                    IsUnpaid = cleanInvoiceLineItem.IsUnpaid,
                    InvoiceStripePaymentUrl = cleanInvoiceLineItem.InvoiceStripePaymentUrl,
                    LicensorEmailAddress = cleanInvoiceLineItem.LicensorEmailAddress
                };
            }

            return SSioUserInvoiceLineItem;
        }
        
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  -R-
        
        // ProductLicense
        public static List<dc.ProductLicense> SSioUserCleanForGet(this IEnumerable<dc.ProductLicense> cleanProductLicenses)
        {
            return cleanProductLicenses.Select(ProductLicense => ProductLicense.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductLicense SSioUserCleanForGet(this dc.ProductLicense cleanProductLicense)
        {
            var SSioUserProductLicense = default(dc.ProductLicense);

            if (!ReferenceEquals(cleanProductLicense, null))
            {
                SSioUserProductLicense = new dc.ProductLicense()
                {
                    ProductLicenseId = cleanProductLicense.ProductLicenseId,
                    Name = cleanProductLicense.Name,
                    Notes = cleanProductLicense.Notes,
                    Attachments = cleanProductLicense.Attachments,
                    Status = cleanProductLicense.Status,
                    LicenseGroup = cleanProductLicense.LicenseGroup,
                    Licensee = cleanProductLicense.Licensee,
                    StartDate = cleanProductLicense.StartDate,
                    InvoiceLineItems = cleanProductLicense.InvoiceLineItems,
                    PlanMonthyFee = cleanProductLicense.PlanMonthyFee,
                    MonthlyFee = cleanProductLicense.MonthlyFee,
                    Term = cleanProductLicense.Term,
                    PlanQuarterlyDiscount = cleanProductLicense.PlanQuarterlyDiscount,
                    PlanSemiAnnualDiscount = cleanProductLicense.PlanSemiAnnualDiscount,
                    PlanAnnualDiscount = cleanProductLicense.PlanAnnualDiscount,
                    MonthsRenewed = cleanProductLicense.MonthsRenewed,
                    PaidThroughDate = cleanProductLicense.PaidThroughDate,
                    LicenseeEmailAddress = cleanProductLicense.LicenseeEmailAddress,
                    IsExpiring = cleanProductLicense.IsExpiring,
                    IsExpired = cleanProductLicense.IsExpired,
                    Licensor = cleanProductLicense.Licensor,
                    BrandLicense = cleanProductLicense.BrandLicense,
                    TermDate = cleanProductLicense.TermDate,
                    LicensorEmailAddress = cleanProductLicense.LicensorEmailAddress,
                    PlanName = cleanProductLicense.PlanName,
                    AuthorizedLambdaFunctionRegEx = cleanProductLicense.AuthorizedLambdaFunctionRegEx,
                    LimitedUseToken = cleanProductLicense.LimitedUseToken,
                    CreatedTime = cleanProductLicense.CreatedTime,
                    CustomStartDate = cleanProductLicense.CustomStartDate,
                    ReplacementExposureOverflow = cleanProductLicense.ReplacementExposureOverflow,
                    ExposuresForwarded = cleanProductLicense.ExposuresForwarded,
                    ExposuresRequested = cleanProductLicense.ExposuresRequested,
                    UnpaidExposures = cleanProductLicense.UnpaidExposures,
                    ExposuresIncluded = cleanProductLicense.ExposuresIncluded,
                    ExposuresUsed = cleanProductLicense.ExposuresUsed,
                    ExposureOverflow = cleanProductLicense.ExposureOverflow,
                    UnusedExposures = cleanProductLicense.UnusedExposures,
                    ExposuresRemaining = cleanProductLicense.ExposuresRemaining,
                    BrandLicenseName = cleanProductLicense.BrandLicenseName,
                    UnpaidInvoiceCount = cleanProductLicense.UnpaidInvoiceCount,
                    StripePaymentUrl = cleanProductLicense.StripePaymentUrl,
                    RenewalFee = cleanProductLicense.RenewalFee,
                    RenewalSKU = cleanProductLicense.RenewalSKU,
                    ProductLicenseMeters = cleanProductLicense.ProductLicenseMeters,
                    BrandLicenseSKU = cleanProductLicense.BrandLicenseSKU,
                    DefaultRenewalSKU = cleanProductLicense.DefaultRenewalSKU,
                    ContractTerm = cleanProductLicense.ContractTerm,
                    ContractDiscount = cleanProductLicense.ContractDiscount,
                    DefaultRenewalSKULimits = cleanProductLicense.DefaultRenewalSKULimits,
                    MetersInWarning = cleanProductLicense.MetersInWarning,
                    MetersExceeded = cleanProductLicense.MetersExceeded,
                    BrandName = cleanProductLicense.BrandName,
                    RenewalSKUSKU = cleanProductLicense.RenewalSKUSKU,
                    SSioTechnology = cleanProductLicense.SSioTechnology,
                    DefaultSKUMeterAdjustments = cleanProductLicense.DefaultSKUMeterAdjustments,
                    ProductLicenseDMQueue = cleanProductLicense.ProductLicenseDMQueue,
                    LicensorLicenseEvent = cleanProductLicense.LicensorLicenseEvent,
                    BrandLicenseLicenseEventWebhookUrl = cleanProductLicense.BrandLicenseLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanProductLicense.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanProductLicense.LicenseEventWebhookUrl
                };
            }

            return SSioUserProductLicense;
        }
        
        
        // SSioUser Cleaning Extension Methods.  -CRUD-
        
        // LicensedProduct
        public static dc.LicensedProduct SSioUserCleanForAdd(this dc.LicensedProduct cleanLicensedProduct)
        {
            var SSioUserLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                SSioUserLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    Brand = cleanLicensedProduct.Brand
                };
            }

            return SSioUserLicensedProduct;
        }
        
        
        public static List<dc.LicensedProduct> SSioUserCleanForGet(this IEnumerable<dc.LicensedProduct> cleanLicensedProducts)
        {
            return cleanLicensedProducts.Select(LicensedProduct => LicensedProduct.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.LicensedProduct SSioUserCleanForGet(this dc.LicensedProduct cleanLicensedProduct)
        {
            var SSioUserLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                SSioUserLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Name = cleanLicensedProduct.Name,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsActive = cleanLicensedProduct.IsActive,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    LicensorIsVerified = cleanLicensedProduct.LicensorIsVerified,
                    LicensorEmailAddress = cleanLicensedProduct.LicensorEmailAddress,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadName = cleanLicensedProduct.HeadName,
                    HeadLambdaEndpoint = cleanLicensedProduct.HeadLambdaEndpoint,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    CalculatedLowerName = cleanLicensedProduct.CalculatedLowerName,
                    CalculatedOriginalName = cleanLicensedProduct.CalculatedOriginalName,
                    CalculatedUpperName = cleanLicensedProduct.CalculatedUpperName,
                    CalculatedLowerHyphenName = cleanLicensedProduct.CalculatedLowerHyphenName,
                    HasMissingNames = cleanLicensedProduct.HasMissingNames,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    LicensorScreenName = cleanLicensedProduct.LicensorScreenName,
                    HeadUsesV1Proxy = cleanLicensedProduct.HeadUsesV1Proxy,
                    HasMissingMarkdown = cleanLicensedProduct.HasMissingMarkdown,
                    HeadDescription = cleanLicensedProduct.HeadDescription,
                    HeadReadMeMD = cleanLicensedProduct.HeadReadMeMD,
                    HeadInputDescriptionMD = cleanLicensedProduct.HeadInputDescriptionMD,
                    HeadOutputDescriptionMD = cleanLicensedProduct.HeadOutputDescriptionMD,
                    RecordCreatedtime = cleanLicensedProduct.RecordCreatedtime,
                    CreatedOn = cleanLicensedProduct.CreatedOn,
                    AccountIsActive = cleanLicensedProduct.AccountIsActive,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    FullName = cleanLicensedProduct.FullName,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    UsageCountMismatch = cleanLicensedProduct.UsageCountMismatch,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersion = cleanLicensedProduct.MostRecentVersion,
                    NextVersionNumber = cleanLicensedProduct.NextVersionNumber,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    LicensorUUID = cleanLicensedProduct.LicensorUUID,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    AWSLambdaFunctionName = cleanLicensedProduct.AWSLambdaFunctionName,
                    LicensorAWSAccountId = cleanLicensedProduct.LicensorAWSAccountId,
                    LicensorAWSAPIGatewayId = cleanLicensedProduct.LicensorAWSAPIGatewayId,
                    LicensorAWSLambdaRegion = cleanLicensedProduct.LicensorAWSLambdaRegion,
                    Brand = cleanLicensedProduct.Brand,
                    BundleAWSAPIGatewayId = cleanLicensedProduct.BundleAWSAPIGatewayId
                };
            }

            return SSioUserLicensedProduct;
        }
        
        
        public static dc.LicensedProduct SSioUserCleanForUpdate(this dc.LicensedProduct cleanLicensedProduct)
        {
            var SSioUserLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                SSioUserLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    Brand = cleanLicensedProduct.Brand
                };
            }

            return SSioUserLicensedProduct;       }
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  -R-
        
        // ProductLicenseMeter
        public static List<dc.ProductLicenseMeter> SSioUserCleanForGet(this IEnumerable<dc.ProductLicenseMeter> cleanProductLicenseMeters)
        {
            return cleanProductLicenseMeters.Select(ProductLicenseMeter => ProductLicenseMeter.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductLicenseMeter SSioUserCleanForGet(this dc.ProductLicenseMeter cleanProductLicenseMeter)
        {
            var SSioUserProductLicenseMeter = default(dc.ProductLicenseMeter);

            if (!ReferenceEquals(cleanProductLicenseMeter, null))
            {
                SSioUserProductLicenseMeter = new dc.ProductLicenseMeter()
                {
                    ProductLicenseMeterId = cleanProductLicenseMeter.ProductLicenseMeterId,
                    Name = cleanProductLicenseMeter.Name,
                    ProductLicense = cleanProductLicenseMeter.ProductLicense,
                    RenewalSKU = cleanProductLicenseMeter.RenewalSKU,
                    SKULimitSKU = cleanProductLicenseMeter.SKULimitSKU,
                    InitialMeterLimit = cleanProductLicenseMeter.InitialMeterLimit,
                    ActiveMeterTransactionBalance = cleanProductLicenseMeter.ActiveMeterTransactionBalance,
                    Limit = cleanProductLicenseMeter.Limit,
                    MeterRemaining = cleanProductLicenseMeter.MeterRemaining,
                    MeterInWarning = cleanProductLicenseMeter.MeterInWarning,
                    Balance = cleanProductLicenseMeter.Balance,
                    MeterPercent = cleanProductLicenseMeter.MeterPercent,
                    MeterExceeded = cleanProductLicenseMeter.MeterExceeded,
                    TransactionResetDate = cleanProductLicenseMeter.TransactionResetDate
                };
            }

            return SSioUserProductLicenseMeter;
        }
        
        
        // SSioUser Cleaning Extension Methods.  -CRUD-
        
        // LicenseMeter
        public static dc.LicenseMeter SSioUserCleanForAdd(this dc.LicenseMeter cleanLicenseMeter)
        {
            var SSioUserLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                SSioUserLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return SSioUserLicenseMeter;
        }
        
        
        public static List<dc.LicenseMeter> SSioUserCleanForGet(this IEnumerable<dc.LicenseMeter> cleanLicenseMeters)
        {
            return cleanLicenseMeters.Select(LicenseMeter => LicenseMeter.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseMeter SSioUserCleanForGet(this dc.LicenseMeter cleanLicenseMeter)
        {
            var SSioUserLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                SSioUserLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Name = cleanLicenseMeter.Name,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    TotalSKUMeterLimit = cleanLicenseMeter.TotalSKUMeterLimit,
                    BundleMonthsIncluded = cleanLicenseMeter.BundleMonthsIncluded,
                    MeterTypeSKUCode = cleanLicenseMeter.MeterTypeSKUCode,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LimitSKU = cleanLicenseMeter.LimitSKU,
                    LicensorEmailAddress = cleanLicenseMeter.LicensorEmailAddress,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    LicenseBundleName = cleanLicenseMeter.LicenseBundleName,
                    MeterTypeName = cleanLicenseMeter.MeterTypeName,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    BrandLicenseName = cleanLicenseMeter.BrandLicenseName,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    UnitOfMeasurementPlural = cleanLicenseMeter.UnitOfMeasurementPlural,
                    MeasurementType = cleanLicenseMeter.MeasurementType,
                    AddsMinutes = cleanLicenseMeter.AddsMinutes,
                    AddsMonths = cleanLicenseMeter.AddsMonths,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    BrandLicenseSKU = cleanLicenseMeter.BrandLicenseSKU,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    MeterSKU = cleanLicenseMeter.MeterSKU,
                    UnitOfMeasurementSingular = cleanLicenseMeter.UnitOfMeasurementSingular,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    NameForBrand = cleanLicenseMeter.NameForBrand,
                    PluralNameForBrand = cleanLicenseMeter.PluralNameForBrand,
                    NameForBrandLicense = cleanLicenseMeter.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanLicenseMeter.PluralNameForBrandLicense,
                    NameForMeter = cleanLicenseMeter.NameForMeter,
                    PluralNameForMeter = cleanLicenseMeter.PluralNameForMeter,
                    NameForSKU = cleanLicenseMeter.NameForSKU,
                    PluralNameForSKU = cleanLicenseMeter.PluralNameForSKU,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return SSioUserLicenseMeter;
        }
        
        
        public static dc.LicenseMeter SSioUserCleanForUpdate(this dc.LicenseMeter cleanLicenseMeter)
        {
            var SSioUserLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                SSioUserLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return SSioUserLicenseMeter;       }
        
        // SSioUser Cleaning Extension Methods.  -R-
        
        // Invoice
        public static List<dc.Invoice> SSioUserCleanForGet(this IEnumerable<dc.Invoice> cleanInvoices)
        {
            return cleanInvoices.Select(Invoice => Invoice.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.Invoice SSioUserCleanForGet(this dc.Invoice cleanInvoice)
        {
            var SSioUserInvoice = default(dc.Invoice);

            if (!ReferenceEquals(cleanInvoice, null))
            {
                SSioUserInvoice = new dc.Invoice()
                {
                    Name = cleanInvoice.Name,
                    Notes = cleanInvoice.Notes,
                    InvoiceNumber = cleanInvoice.InvoiceNumber,
                    InvoiceDate = cleanInvoice.InvoiceDate,
                    LicenseeEmailAddress = cleanInvoice.LicenseeEmailAddress,
                    InvoiceSubTotal = cleanInvoice.InvoiceSubTotal
                };
            }

            return SSioUserInvoice;
        }
        
        
        // SSioUser Cleaning Extension Methods.  -CRUD-
        
        // BrandLicense
        public static dc.BrandLicense SSioUserCleanForAdd(this dc.BrandLicense cleanBrandLicense)
        {
            var SSioUserBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                SSioUserBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicenseType = cleanBrandLicense.LicenseType,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    SKUCode = cleanBrandLicense.SKUCode,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl
                };
            }

            return SSioUserBrandLicense;
        }
        
        
        public static List<dc.BrandLicense> SSioUserCleanForGet(this IEnumerable<dc.BrandLicense> cleanBrandLicenses)
        {
            return cleanBrandLicenses.Select(BrandLicense => BrandLicense.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.BrandLicense SSioUserCleanForGet(this dc.BrandLicense cleanBrandLicense)
        {
            var SSioUserBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                SSioUserBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Name = cleanBrandLicense.Name,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    Licensor = cleanBrandLicense.Licensor,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicensorEmailAddresss = cleanBrandLicense.LicensorEmailAddresss,
                    LicensorScreenName = cleanBrandLicense.LicensorScreenName,
                    LicensorEmailAddress = cleanBrandLicense.LicensorEmailAddress,
                    LicenseType = cleanBrandLicense.LicenseType,
                    LicenseeEmailAddresses = cleanBrandLicense.LicenseeEmailAddresses,
                    Createdtime = cleanBrandLicense.Createdtime,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    MonthlyCostPer1KUses = cleanBrandLicense.MonthlyCostPer1KUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    LicensorSKUCode = cleanBrandLicense.LicensorSKUCode,
                    BrandSKU = cleanBrandLicense.BrandSKU,
                    SKUCode = cleanBrandLicense.SKUCode,
                    SKU = cleanBrandLicense.SKU,
                    PaymentProcessorPercent = cleanBrandLicense.PaymentProcessorPercent,
                    TotalMarketPercent = cleanBrandLicense.TotalMarketPercent,
                    BrandName = cleanBrandLicense.BrandName,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    DefaultTerm = cleanBrandLicense.DefaultTerm,
                    DefaultRenewalFee = cleanBrandLicense.DefaultRenewalFee,
                    ModifiedTime = cleanBrandLicense.ModifiedTime,
                    OwnerIsVerified = cleanBrandLicense.OwnerIsVerified,
                    DefaultBundleSKUSKU = cleanBrandLicense.DefaultBundleSKUSKU,
                    BrandIsPublic = cleanBrandLicense.BrandIsPublic,
                    DefaultTermDays = cleanBrandLicense.DefaultTermDays,
                    SSioTechnology = cleanBrandLicense.SSioTechnology,
                    SSioTechnologyPercent = cleanBrandLicense.SSioTechnologyPercent,
                    SSioTechnologySKUCode = cleanBrandLicense.SSioTechnologySKUCode,
                    SSioPercent = cleanBrandLicense.SSioPercent,
                    SSioTechnologyName = cleanBrandLicense.SSioTechnologyName,
                    LicenseTypePrimaryTrackingField = cleanBrandLicense.LicenseTypePrimaryTrackingField,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForBrand = cleanBrandLicense.NameForBrand,
                    PluralNameForBrand = cleanBrandLicense.PluralNameForBrand,
                    PluralNameForBrandLicense = cleanBrandLicense.PluralNameForBrandLicense,
                    NameForBrandLicense = cleanBrandLicense.NameForBrandLicense,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    BrandLicenseEventWebhookUrl = cleanBrandLicense.BrandLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanBrandLicense.LicenseEventWebhookUrl
                };
            }

            return SSioUserBrandLicense;
        }
        
        
        public static dc.BrandLicense SSioUserCleanForUpdate(this dc.BrandLicense cleanBrandLicense)
        {
            var SSioUserBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                SSioUserBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicenseType = cleanBrandLicense.LicenseType,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    SKUCode = cleanBrandLicense.SKUCode,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl
                };
            }

            return SSioUserBrandLicense;       }
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  -NONE-
        
        // SSioUser Cleaning Extension Methods.  -CRUD-
        
        // LicenseSKU
        public static dc.LicenseSKU SSioUserCleanForAdd(this dc.LicenseSKU cleanLicenseSKU)
        {
            var SSioUserLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                SSioUserLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments
                };
            }

            return SSioUserLicenseSKU;
        }
        
        
        public static List<dc.LicenseSKU> SSioUserCleanForGet(this IEnumerable<dc.LicenseSKU> cleanLicenseSKUs)
        {
            return cleanLicenseSKUs.Select(LicenseSKU => LicenseSKU.SSioUserCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseSKU SSioUserCleanForGet(this dc.LicenseSKU cleanLicenseSKU)
        {
            var SSioUserLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                SSioUserLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Name = cleanLicenseSKU.Name,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    MonthsIncluded = cleanLicenseSKU.MonthsIncluded,
                    BundleLicensor = cleanLicenseSKU.BundleLicensor,
                    LicensorEmailAddress = cleanLicenseSKU.LicensorEmailAddress,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUCode = cleanLicenseSKU.SKUCode,
                    SKUDescription = cleanLicenseSKU.SKUDescription,
                    SKU = cleanLicenseSKU.SKU,
                    PlanName = cleanLicenseSKU.PlanName,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKUTypeCode = cleanLicenseSKU.SKUTypeCode,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    Brand = cleanLicenseSKU.Brand,
                    ParentInitialFee = cleanLicenseSKU.ParentInitialFee,
                    ParentMonthlyFee = cleanLicenseSKU.ParentMonthlyFee,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    ParentRelativeFee = cleanLicenseSKU.ParentRelativeFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    CalculatedMonthlyFee = cleanLicenseSKU.CalculatedMonthlyFee,
                    SKURenewalFee = cleanLicenseSKU.SKURenewalFee,
                    LicensorSKUCode = cleanLicenseSKU.LicensorSKUCode,
                    BrandLicenseSKU = cleanLicenseSKU.BrandLicenseSKU,
                    PaymentProcessorPercent = cleanLicenseSKU.PaymentProcessorPercent,
                    PaymentProcessorFee = cleanLicenseSKU.PaymentProcessorFee,
                    TotalMarketFees = cleanLicenseSKU.TotalMarketFees,
                    LicensorPayment = cleanLicenseSKU.LicensorPayment,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    LicensorFee = cleanLicenseSKU.LicensorFee,
                    BrandName = cleanLicenseSKU.BrandName,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    CreatedTime = cleanLicenseSKU.CreatedTime,
                    ModifiedTime = cleanLicenseSKU.ModifiedTime,
                    BrandLicenseName = cleanLicenseSKU.BrandLicenseName,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    BrandLicenseLicenseType = cleanLicenseSKU.BrandLicenseLicenseType,
                    BrandIsPublic = cleanLicenseSKU.BrandIsPublic,
                    SSioTechnology = cleanLicenseSKU.SSioTechnology,
                    SSioTechnologySKUCode = cleanLicenseSKU.SSioTechnologySKUCode,
                    SSioTechnologyPercent = cleanLicenseSKU.SSioTechnologyPercent,
                    SSioTechnologyFee = cleanLicenseSKU.SSioTechnologyFee,
                    SSioPercent = cleanLicenseSKU.SSioPercent,
                    SSioFee = cleanLicenseSKU.SSioFee,
                    SSioTechnologyName = cleanLicenseSKU.SSioTechnologyName,
                    QuantityIncluded = cleanLicenseSKU.QuantityIncluded,
                    ParentRecurringFee = cleanLicenseSKU.ParentRecurringFee,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    CalculatedRecurringFee = cleanLicenseSKU.CalculatedRecurringFee,
                    LicenseTypePrimaryTrackingField = cleanLicenseSKU.LicenseTypePrimaryTrackingField,
                    CalculatedInitialFee = cleanLicenseSKU.CalculatedInitialFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments,
                    PluralNameForBrand = cleanLicenseSKU.PluralNameForBrand,
                    NameForBrandLicense = cleanLicenseSKU.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanLicenseSKU.PluralNameForBrandLicense,
                    NameForMeter = cleanLicenseSKU.NameForMeter,
                    PluralNameForMeter = cleanLicenseSKU.PluralNameForMeter,
                    NameForSKU = cleanLicenseSKU.NameForSKU,
                    PluralNameForSKU = cleanLicenseSKU.PluralNameForSKU,
                    NameForBrand = cleanLicenseSKU.NameForBrand
                };
            }

            return SSioUserLicenseSKU;
        }
        
        
        public static dc.LicenseSKU SSioUserCleanForUpdate(this dc.LicenseSKU cleanLicenseSKU)
        {
            var SSioUserLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                SSioUserLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments
                };
            }

            return SSioUserLicenseSKU;       }
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
        // SSioUser Cleaning Extension Methods.  --
        
    
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // Brand
        public static dc.Brand AdminCleanForAdd(this dc.Brand cleanBrand)
        {
            var AdminBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                AdminBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    SKUCode = cleanBrand.SKUCode,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl
                };
            }

            return AdminBrand;
        }
        
        
        public static List<dc.Brand> AdminCleanForGet(this IEnumerable<dc.Brand> cleanBrands)
        {
            return cleanBrands.Select(Brand => Brand.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.Brand AdminCleanForGet(this dc.Brand cleanBrand)
        {
            var AdminBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                AdminBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Name = cleanBrand.Name,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    LicensorEmailAddress = cleanBrand.LicensorEmailAddress,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    LicensorScreenName = cleanBrand.LicensorScreenName,
                    SKUCode = cleanBrand.SKUCode,
                    LicensorSKUCode = cleanBrand.LicensorSKUCode,
                    SKU = cleanBrand.SKU,
                    PaymentProcessorPercent = cleanBrand.PaymentProcessorPercent,
                    TotalMarketPercent = cleanBrand.TotalMarketPercent,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    OwnerScreenName = cleanBrand.OwnerScreenName,
                    OwnerSKUCode = cleanBrand.OwnerSKUCode,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    ModifiedTime = cleanBrand.ModifiedTime,
                    CreatedTime = cleanBrand.CreatedTime,
                    OwnerIsVerified = cleanBrand.OwnerIsVerified,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    SSioTechnologySKUCode = cleanBrand.SSioTechnologySKUCode,
                    SSioTechnologyPercent = cleanBrand.SSioTechnologyPercent,
                    SSioPercent = cleanBrand.SSioPercent,
                    SSioTechnologyName = cleanBrand.SSioTechnologyName,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    NameForBrand = cleanBrand.NameForBrand,
                    PluralNameForBrand = cleanBrand.PluralNameForBrand,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    LicensorLicenseEventWebhookUrl = cleanBrand.LicensorLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanBrand.LicenseEventWebhookUrl
                };
            }

            return AdminBrand;
        }
        
        
        public static dc.Brand AdminCleanForUpdate(this dc.Brand cleanBrand)
        {
            var AdminBrand = default(dc.Brand);

            if (!ReferenceEquals(cleanBrand, null))
            {
                AdminBrand = new dc.Brand()
                {
                    BrandId = cleanBrand.BrandId,
                    Notes = cleanBrand.Notes,
                    Attachments = cleanBrand.Attachments,
                    Status = cleanBrand.Status,
                    Licensor = cleanBrand.Licensor,
                    BundleName = cleanBrand.BundleName,
                    AWSAPIGatewayId = cleanBrand.AWSAPIGatewayId,
                    AWSAccountId = cleanBrand.AWSAccountId,
                    AWSLambdaRegion = cleanBrand.AWSLambdaRegion,
                    LicensedProducts = cleanBrand.LicensedProducts,
                    CustomDomain = cleanBrand.CustomDomain,
                    BrandLicenses = cleanBrand.BrandLicenses,
                    SKUCode = cleanBrand.SKUCode,
                    IsPublic = cleanBrand.IsPublic,
                    Owner = cleanBrand.Owner,
                    CustomScreenName = cleanBrand.CustomScreenName,
                    CustomLicensorSKUCode = cleanBrand.CustomLicensorSKUCode,
                    SSioTechnology = cleanBrand.SSioTechnology,
                    NameForBrandLicense = cleanBrand.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanBrand.PluralNameForBrandLicense,
                    CustomLicenseEventWebhookUrl = cleanBrand.CustomLicenseEventWebhookUrl
                };
            }

            return AdminBrand;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ProductUseStatus
        public static dc.ProductUseStatus AdminCleanForAdd(this dc.ProductUseStatus cleanProductUseStatus)
        {
            var AdminProductUseStatus = default(dc.ProductUseStatus);

            if (!ReferenceEquals(cleanProductUseStatus, null))
            {
                AdminProductUseStatus = new dc.ProductUseStatus()
                {
                    ProductUseStatusId = cleanProductUseStatus.ProductUseStatusId,
                    Name = cleanProductUseStatus.Name,
                    Description = cleanProductUseStatus.Description,
                    SortOrder = cleanProductUseStatus.SortOrder,
                    ProductUseRequests = cleanProductUseStatus.ProductUseRequests,
                    ProductUseRequestStatusUUID = cleanProductUseStatus.ProductUseRequestStatusUUID
                };
            }

            return AdminProductUseStatus;
        }
        
        
        public static List<dc.ProductUseStatus> AdminCleanForGet(this IEnumerable<dc.ProductUseStatus> cleanProductUseStatuses)
        {
            return cleanProductUseStatuses.Select(ProductUseStatus => ProductUseStatus.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductUseStatus AdminCleanForGet(this dc.ProductUseStatus cleanProductUseStatus)
        {
            var AdminProductUseStatus = default(dc.ProductUseStatus);

            if (!ReferenceEquals(cleanProductUseStatus, null))
            {
                AdminProductUseStatus = new dc.ProductUseStatus()
                {
                    ProductUseStatusId = cleanProductUseStatus.ProductUseStatusId,
                    Name = cleanProductUseStatus.Name,
                    Description = cleanProductUseStatus.Description,
                    SortOrder = cleanProductUseStatus.SortOrder,
                    ProductUseRequests = cleanProductUseStatus.ProductUseRequests,
                    ProductUseRequestStatusUUID = cleanProductUseStatus.ProductUseRequestStatusUUID
                };
            }

            return AdminProductUseStatus;
        }
        
        
        public static dc.ProductUseStatus AdminCleanForUpdate(this dc.ProductUseStatus cleanProductUseStatus)
        {
            var AdminProductUseStatus = default(dc.ProductUseStatus);

            if (!ReferenceEquals(cleanProductUseStatus, null))
            {
                AdminProductUseStatus = new dc.ProductUseStatus()
                {
                    ProductUseStatusId = cleanProductUseStatus.ProductUseStatusId,
                    Name = cleanProductUseStatus.Name,
                    Description = cleanProductUseStatus.Description,
                    SortOrder = cleanProductUseStatus.SortOrder,
                    ProductUseRequests = cleanProductUseStatus.ProductUseRequests,
                    ProductUseRequestStatusUUID = cleanProductUseStatus.ProductUseRequestStatusUUID
                };
            }

            return AdminProductUseStatus;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // CLIOption
        public static dc.CLIOption AdminCleanForAdd(this dc.CLIOption cleanCLIOption)
        {
            var AdminCLIOption = default(dc.CLIOption);

            if (!ReferenceEquals(cleanCLIOption, null))
            {
                AdminCLIOption = new dc.CLIOption()
                {
                    CLIOptionId = cleanCLIOption.CLIOptionId,
                    Name = cleanCLIOption.Name,
                    Description = cleanCLIOption.Description,
                    Aliases = cleanCLIOption.Aliases,
                    DataType = cleanCLIOption.DataType,
                    IsOptional = cleanCLIOption.IsOptional,
                    IsList = cleanCLIOption.IsList,
                    DefaultValue = cleanCLIOption.DefaultValue,
                    ExampleValue = cleanCLIOption.ExampleValue,
                    Enabled = cleanCLIOption.Enabled,
                    Version = cleanCLIOption.Version,
                    SortOrder = cleanCLIOption.SortOrder,
                    Category = cleanCLIOption.Category
                };
            }

            return AdminCLIOption;
        }
        
        
        public static List<dc.CLIOption> AdminCleanForGet(this IEnumerable<dc.CLIOption> cleanCLIOptions)
        {
            return cleanCLIOptions.Select(CLIOption => CLIOption.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.CLIOption AdminCleanForGet(this dc.CLIOption cleanCLIOption)
        {
            var AdminCLIOption = default(dc.CLIOption);

            if (!ReferenceEquals(cleanCLIOption, null))
            {
                AdminCLIOption = new dc.CLIOption()
                {
                    CLIOptionId = cleanCLIOption.CLIOptionId,
                    Name = cleanCLIOption.Name,
                    Description = cleanCLIOption.Description,
                    Aliases = cleanCLIOption.Aliases,
                    DataType = cleanCLIOption.DataType,
                    IsOptional = cleanCLIOption.IsOptional,
                    IsList = cleanCLIOption.IsList,
                    DefaultValue = cleanCLIOption.DefaultValue,
                    ExampleValue = cleanCLIOption.ExampleValue,
                    Enabled = cleanCLIOption.Enabled,
                    Version = cleanCLIOption.Version,
                    SortOrder = cleanCLIOption.SortOrder,
                    Category = cleanCLIOption.Category
                };
            }

            return AdminCLIOption;
        }
        
        
        public static dc.CLIOption AdminCleanForUpdate(this dc.CLIOption cleanCLIOption)
        {
            var AdminCLIOption = default(dc.CLIOption);

            if (!ReferenceEquals(cleanCLIOption, null))
            {
                AdminCLIOption = new dc.CLIOption()
                {
                    CLIOptionId = cleanCLIOption.CLIOptionId,
                    Name = cleanCLIOption.Name,
                    Description = cleanCLIOption.Description,
                    Aliases = cleanCLIOption.Aliases,
                    DataType = cleanCLIOption.DataType,
                    IsOptional = cleanCLIOption.IsOptional,
                    IsList = cleanCLIOption.IsList,
                    DefaultValue = cleanCLIOption.DefaultValue,
                    ExampleValue = cleanCLIOption.ExampleValue,
                    Enabled = cleanCLIOption.Enabled,
                    Version = cleanCLIOption.Version,
                    SortOrder = cleanCLIOption.SortOrder,
                    Category = cleanCLIOption.Category
                };
            }

            return AdminCLIOption;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // UnitConversion
        public static dc.UnitConversion AdminCleanForAdd(this dc.UnitConversion cleanUnitConversion)
        {
            var AdminUnitConversion = default(dc.UnitConversion);

            if (!ReferenceEquals(cleanUnitConversion, null))
            {
                AdminUnitConversion = new dc.UnitConversion()
                {
                    UnitConversionId = cleanUnitConversion.UnitConversionId,
                    Notes = cleanUnitConversion.Notes,
                    Attachments = cleanUnitConversion.Attachments,
                    Status = cleanUnitConversion.Status,
                    ToUnit = cleanUnitConversion.ToUnit,
                    FromUnit = cleanUnitConversion.FromUnit,
                    ConversionRatio = cleanUnitConversion.ConversionRatio,
                    MeterTransactions = cleanUnitConversion.MeterTransactions
                };
            }

            return AdminUnitConversion;
        }
        
        
        public static List<dc.UnitConversion> AdminCleanForGet(this IEnumerable<dc.UnitConversion> cleanUnitConversions)
        {
            return cleanUnitConversions.Select(UnitConversion => UnitConversion.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.UnitConversion AdminCleanForGet(this dc.UnitConversion cleanUnitConversion)
        {
            var AdminUnitConversion = default(dc.UnitConversion);

            if (!ReferenceEquals(cleanUnitConversion, null))
            {
                AdminUnitConversion = new dc.UnitConversion()
                {
                    UnitConversionId = cleanUnitConversion.UnitConversionId,
                    Name = cleanUnitConversion.Name,
                    Notes = cleanUnitConversion.Notes,
                    Attachments = cleanUnitConversion.Attachments,
                    Status = cleanUnitConversion.Status,
                    ToUnit = cleanUnitConversion.ToUnit,
                    FromUnit = cleanUnitConversion.FromUnit,
                    ConversionRatio = cleanUnitConversion.ConversionRatio,
                    MeterTransactions = cleanUnitConversion.MeterTransactions
                };
            }

            return AdminUnitConversion;
        }
        
        
        public static dc.UnitConversion AdminCleanForUpdate(this dc.UnitConversion cleanUnitConversion)
        {
            var AdminUnitConversion = default(dc.UnitConversion);

            if (!ReferenceEquals(cleanUnitConversion, null))
            {
                AdminUnitConversion = new dc.UnitConversion()
                {
                    UnitConversionId = cleanUnitConversion.UnitConversionId,
                    Notes = cleanUnitConversion.Notes,
                    Attachments = cleanUnitConversion.Attachments,
                    Status = cleanUnitConversion.Status,
                    ToUnit = cleanUnitConversion.ToUnit,
                    FromUnit = cleanUnitConversion.FromUnit,
                    ConversionRatio = cleanUnitConversion.ConversionRatio,
                    MeterTransactions = cleanUnitConversion.MeterTransactions
                };
            }

            return AdminUnitConversion;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // InvoiceLineItem
        public static dc.InvoiceLineItem AdminCleanForAdd(this dc.InvoiceLineItem cleanInvoiceLineItem)
        {
            var AdminInvoiceLineItem = default(dc.InvoiceLineItem);

            if (!ReferenceEquals(cleanInvoiceLineItem, null))
            {
                AdminInvoiceLineItem = new dc.InvoiceLineItem()
                {
                    InvoiceLineItemId = cleanInvoiceLineItem.InvoiceLineItemId,
                    Notes = cleanInvoiceLineItem.Notes,
                    Attachments = cleanInvoiceLineItem.Attachments,
                    Status = cleanInvoiceLineItem.Status,
                    Invoice = cleanInvoiceLineItem.Invoice,
                    AccountSubscription = cleanInvoiceLineItem.AccountSubscription,
                    DiscountApplied = cleanInvoiceLineItem.DiscountApplied,
                    SubTotal = cleanInvoiceLineItem.SubTotal,
                    ProductLicense = cleanInvoiceLineItem.ProductLicense,
                    MonthsInvoiced = cleanInvoiceLineItem.MonthsInvoiced
                };
            }

            return AdminInvoiceLineItem;
        }
        
        
        public static List<dc.InvoiceLineItem> AdminCleanForGet(this IEnumerable<dc.InvoiceLineItem> cleanInvoiceLineItems)
        {
            return cleanInvoiceLineItems.Select(InvoiceLineItem => InvoiceLineItem.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.InvoiceLineItem AdminCleanForGet(this dc.InvoiceLineItem cleanInvoiceLineItem)
        {
            var AdminInvoiceLineItem = default(dc.InvoiceLineItem);

            if (!ReferenceEquals(cleanInvoiceLineItem, null))
            {
                AdminInvoiceLineItem = new dc.InvoiceLineItem()
                {
                    InvoiceLineItemId = cleanInvoiceLineItem.InvoiceLineItemId,
                    Name = cleanInvoiceLineItem.Name,
                    Notes = cleanInvoiceLineItem.Notes,
                    Attachments = cleanInvoiceLineItem.Attachments,
                    Status = cleanInvoiceLineItem.Status,
                    Invoice = cleanInvoiceLineItem.Invoice,
                    AccountSubscription = cleanInvoiceLineItem.AccountSubscription,
                    SubscriptionRenewalPrice = cleanInvoiceLineItem.SubscriptionRenewalPrice,
                    MonthsPaidFor = cleanInvoiceLineItem.MonthsPaidFor,
                    DiscountApplied = cleanInvoiceLineItem.DiscountApplied,
                    SubTotal = cleanInvoiceLineItem.SubTotal,
                    ProductLicense = cleanInvoiceLineItem.ProductLicense,
                    LicenseeEmailAddress = cleanInvoiceLineItem.LicenseeEmailAddress,
                    FinalMonthlyCost = cleanInvoiceLineItem.FinalMonthlyCost,
                    MonthsInvoiced = cleanInvoiceLineItem.MonthsInvoiced,
                    InvoiceStripeStatus = cleanInvoiceLineItem.InvoiceStripeStatus,
                    InvoiceStatus = cleanInvoiceLineItem.InvoiceStatus,
                    IsUnpaid = cleanInvoiceLineItem.IsUnpaid,
                    InvoiceStripePaymentUrl = cleanInvoiceLineItem.InvoiceStripePaymentUrl,
                    LicensorEmailAddress = cleanInvoiceLineItem.LicensorEmailAddress,
                    SubscriptionContractTerm = cleanInvoiceLineItem.SubscriptionContractTerm,
                    ContractDiscount = cleanInvoiceLineItem.ContractDiscount
                };
            }

            return AdminInvoiceLineItem;
        }
        
        
        public static dc.InvoiceLineItem AdminCleanForUpdate(this dc.InvoiceLineItem cleanInvoiceLineItem)
        {
            var AdminInvoiceLineItem = default(dc.InvoiceLineItem);

            if (!ReferenceEquals(cleanInvoiceLineItem, null))
            {
                AdminInvoiceLineItem = new dc.InvoiceLineItem()
                {
                    InvoiceLineItemId = cleanInvoiceLineItem.InvoiceLineItemId,
                    Notes = cleanInvoiceLineItem.Notes,
                    Attachments = cleanInvoiceLineItem.Attachments,
                    Status = cleanInvoiceLineItem.Status,
                    Invoice = cleanInvoiceLineItem.Invoice,
                    AccountSubscription = cleanInvoiceLineItem.AccountSubscription,
                    DiscountApplied = cleanInvoiceLineItem.DiscountApplied,
                    SubTotal = cleanInvoiceLineItem.SubTotal,
                    ProductLicense = cleanInvoiceLineItem.ProductLicense,
                    MonthsInvoiced = cleanInvoiceLineItem.MonthsInvoiced
                };
            }

            return AdminInvoiceLineItem;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // SSioTechnology
        public static dc.SSioTechnology AdminCleanForAdd(this dc.SSioTechnology cleanSSioTechnology)
        {
            var AdminSSioTechnology = default(dc.SSioTechnology);

            if (!ReferenceEquals(cleanSSioTechnology, null))
            {
                AdminSSioTechnology = new dc.SSioTechnology()
                {
                    SSioTechnologyId = cleanSSioTechnology.SSioTechnologyId,
                    Name = cleanSSioTechnology.Name,
                    Notes = cleanSSioTechnology.Notes,
                    Attachments = cleanSSioTechnology.Attachments,
                    Status = cleanSSioTechnology.Status,
                    TechnologyPercentage = cleanSSioTechnology.TechnologyPercentage,
                    PaymentProcessorPercent = cleanSSioTechnology.PaymentProcessorPercent,
                    TechnologyMeters = cleanSSioTechnology.TechnologyMeters,
                    SKUCode = cleanSSioTechnology.SKUCode,
                    Brands = cleanSSioTechnology.Brands,
                    SortOrder = cleanSSioTechnology.SortOrder,
                    SSioTOwner = cleanSSioTechnology.SSioTOwner,
                    SSioPercent = cleanSSioTechnology.SSioPercent
                };
            }

            return AdminSSioTechnology;
        }
        
        
        public static List<dc.SSioTechnology> AdminCleanForGet(this IEnumerable<dc.SSioTechnology> cleanSSioTechnologies)
        {
            return cleanSSioTechnologies.Select(SSioTechnology => SSioTechnology.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.SSioTechnology AdminCleanForGet(this dc.SSioTechnology cleanSSioTechnology)
        {
            var AdminSSioTechnology = default(dc.SSioTechnology);

            if (!ReferenceEquals(cleanSSioTechnology, null))
            {
                AdminSSioTechnology = new dc.SSioTechnology()
                {
                    SSioTechnologyId = cleanSSioTechnology.SSioTechnologyId,
                    Name = cleanSSioTechnology.Name,
                    Notes = cleanSSioTechnology.Notes,
                    Attachments = cleanSSioTechnology.Attachments,
                    Status = cleanSSioTechnology.Status,
                    TechnologyPercentage = cleanSSioTechnology.TechnologyPercentage,
                    PaymentProcessorPercent = cleanSSioTechnology.PaymentProcessorPercent,
                    TotalMarketPercent = cleanSSioTechnology.TotalMarketPercent,
                    TechnologyMeters = cleanSSioTechnology.TechnologyMeters,
                    SKUCode = cleanSSioTechnology.SKUCode,
                    Brands = cleanSSioTechnology.Brands,
                    SortOrder = cleanSSioTechnology.SortOrder,
                    SSioTCode = cleanSSioTechnology.SSioTCode,
                    SSioTOwner = cleanSSioTechnology.SSioTOwner,
                    SSioPercent = cleanSSioTechnology.SSioPercent
                };
            }

            return AdminSSioTechnology;
        }
        
        
        public static dc.SSioTechnology AdminCleanForUpdate(this dc.SSioTechnology cleanSSioTechnology)
        {
            var AdminSSioTechnology = default(dc.SSioTechnology);

            if (!ReferenceEquals(cleanSSioTechnology, null))
            {
                AdminSSioTechnology = new dc.SSioTechnology()
                {
                    SSioTechnologyId = cleanSSioTechnology.SSioTechnologyId,
                    Name = cleanSSioTechnology.Name,
                    Notes = cleanSSioTechnology.Notes,
                    Attachments = cleanSSioTechnology.Attachments,
                    Status = cleanSSioTechnology.Status,
                    TechnologyPercentage = cleanSSioTechnology.TechnologyPercentage,
                    PaymentProcessorPercent = cleanSSioTechnology.PaymentProcessorPercent,
                    TechnologyMeters = cleanSSioTechnology.TechnologyMeters,
                    SKUCode = cleanSSioTechnology.SKUCode,
                    Brands = cleanSSioTechnology.Brands,
                    SortOrder = cleanSSioTechnology.SortOrder,
                    SSioTOwner = cleanSSioTechnology.SSioTOwner,
                    SSioPercent = cleanSSioTechnology.SSioPercent
                };
            }

            return AdminSSioTechnology;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // SSioUser
        public static dc.SSioUser AdminCleanForAdd(this dc.SSioUser cleanSSioUser)
        {
            var AdminSSioUser = default(dc.SSioUser);

            if (!ReferenceEquals(cleanSSioUser, null))
            {
                AdminSSioUser = new dc.SSioUser()
                {
                    SSioUserId = cleanSSioUser.SSioUserId,
                    LicensorUUID = cleanSSioUser.LicensorUUID,
                    HashOfSecret = cleanSSioUser.HashOfSecret,
                    AccountSubscriptionFee = cleanSSioUser.AccountSubscriptionFee,
                    Description = cleanSSioUser.Description,
                    AccountLocked = cleanSSioUser.AccountLocked,
                    Products = cleanSSioUser.Products,
                    Name = cleanSSioUser.Name,
                    IsActive = cleanSSioUser.IsActive,
                    Role = cleanSSioUser.Role,
                    DemoPassword = cleanSSioUser.DemoPassword,
                    SHA256Password = cleanSSioUser.SHA256Password,
                    IsVerified = cleanSSioUser.IsVerified,
                    ChosenScreenName = cleanSSioUser.ChosenScreenName,
                    ChosenEmailAddress = cleanSSioUser.ChosenEmailAddress,
                    Importedtable = cleanSSioUser.Importedtable,
                    AccountPlan = cleanSSioUser.AccountPlan,
                    AccountSubscriptions = cleanSSioUser.AccountSubscriptions,
                    Invoices = cleanSSioUser.Invoices,
                    Table14 = cleanSSioUser.Table14,
                    Table142 = cleanSSioUser.Table142,
                    ProductUseRequests = cleanSSioUser.ProductUseRequests,
                    MonthlyProductUseRequests = cleanSSioUser.MonthlyProductUseRequests,
                    ProductLisences = cleanSSioUser.ProductLisences,
                    ProductLicenses = cleanSSioUser.ProductLicenses,
                    IsLicensor = cleanSSioUser.IsLicensor,
                    Brands = cleanSSioUser.Brands,
                    SKUCode = cleanSSioUser.SKUCode,
                    SSioTechnologies = cleanSSioUser.SSioTechnologies,
                    NameForBrand = cleanSSioUser.NameForBrand,
                    PluralNameForBrand = cleanSSioUser.PluralNameForBrand,
                    DefaultLicenseEventWebhookUrl = cleanSSioUser.DefaultLicenseEventWebhookUrl
                };
            }

            return AdminSSioUser;
        }
        
        
        public static List<dc.SSioUser> AdminCleanForGet(this IEnumerable<dc.SSioUser> cleanSSioUsers)
        {
            return cleanSSioUsers.Select(SSioUser => SSioUser.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.SSioUser AdminCleanForGet(this dc.SSioUser cleanSSioUser)
        {
            var AdminSSioUser = default(dc.SSioUser);

            if (!ReferenceEquals(cleanSSioUser, null))
            {
                AdminSSioUser = new dc.SSioUser()
                {
                    SSioUserId = cleanSSioUser.SSioUserId,
                    ScreenName = cleanSSioUser.ScreenName,
                    LicensorUUID = cleanSSioUser.LicensorUUID,
                    EmailAddress = cleanSSioUser.EmailAddress,
                    HashOfSecret = cleanSSioUser.HashOfSecret,
                    AccountSubscriptionFee = cleanSSioUser.AccountSubscriptionFee,
                    Description = cleanSSioUser.Description,
                    AccountLocked = cleanSSioUser.AccountLocked,
                    Products = cleanSSioUser.Products,
                    Name = cleanSSioUser.Name,
                    IsActive = cleanSSioUser.IsActive,
                    CreatedOn = cleanSSioUser.CreatedOn,
                    Role = cleanSSioUser.Role,
                    DemoPassword = cleanSSioUser.DemoPassword,
                    SHA256Password = cleanSSioUser.SHA256Password,
                    IsVerified = cleanSSioUser.IsVerified,
                    LowerScreenName = cleanSSioUser.LowerScreenName,
                    ChosenScreenName = cleanSSioUser.ChosenScreenName,
                    ChosenEmailAddress = cleanSSioUser.ChosenEmailAddress,
                    RECORDID = cleanSSioUser.RECORDID,
                    DisplayName = cleanSSioUser.DisplayName,
                    Importedtable = cleanSSioUser.Importedtable,
                    AccountPlan = cleanSSioUser.AccountPlan,
                    AccountSubscriptions = cleanSSioUser.AccountSubscriptions,
                    Invoices = cleanSSioUser.Invoices,
                    Table14 = cleanSSioUser.Table14,
                    Table142 = cleanSSioUser.Table142,
                    ProductUseRequests = cleanSSioUser.ProductUseRequests,
                    MonthlyProductUseRequests = cleanSSioUser.MonthlyProductUseRequests,
                    ProductLisences = cleanSSioUser.ProductLisences,
                    ProductLicenses = cleanSSioUser.ProductLicenses,
                    IsLicensor = cleanSSioUser.IsLicensor,
                    Brands = cleanSSioUser.Brands,
                    SKUCode = cleanSSioUser.SKUCode,
                    SSioTechnologies = cleanSSioUser.SSioTechnologies,
                    NameForBrand = cleanSSioUser.NameForBrand,
                    PluralNameForBrand = cleanSSioUser.PluralNameForBrand,
                    DefaultLicenseEventWebhookUrl = cleanSSioUser.DefaultLicenseEventWebhookUrl
                };
            }

            return AdminSSioUser;
        }
        
        
        public static dc.SSioUser AdminCleanForUpdate(this dc.SSioUser cleanSSioUser)
        {
            var AdminSSioUser = default(dc.SSioUser);

            if (!ReferenceEquals(cleanSSioUser, null))
            {
                AdminSSioUser = new dc.SSioUser()
                {
                    SSioUserId = cleanSSioUser.SSioUserId,
                    LicensorUUID = cleanSSioUser.LicensorUUID,
                    HashOfSecret = cleanSSioUser.HashOfSecret,
                    AccountSubscriptionFee = cleanSSioUser.AccountSubscriptionFee,
                    Description = cleanSSioUser.Description,
                    AccountLocked = cleanSSioUser.AccountLocked,
                    Products = cleanSSioUser.Products,
                    Name = cleanSSioUser.Name,
                    IsActive = cleanSSioUser.IsActive,
                    Role = cleanSSioUser.Role,
                    DemoPassword = cleanSSioUser.DemoPassword,
                    SHA256Password = cleanSSioUser.SHA256Password,
                    IsVerified = cleanSSioUser.IsVerified,
                    ChosenScreenName = cleanSSioUser.ChosenScreenName,
                    ChosenEmailAddress = cleanSSioUser.ChosenEmailAddress,
                    Importedtable = cleanSSioUser.Importedtable,
                    AccountPlan = cleanSSioUser.AccountPlan,
                    AccountSubscriptions = cleanSSioUser.AccountSubscriptions,
                    Invoices = cleanSSioUser.Invoices,
                    Table14 = cleanSSioUser.Table14,
                    Table142 = cleanSSioUser.Table142,
                    ProductUseRequests = cleanSSioUser.ProductUseRequests,
                    MonthlyProductUseRequests = cleanSSioUser.MonthlyProductUseRequests,
                    ProductLisences = cleanSSioUser.ProductLisences,
                    ProductLicenses = cleanSSioUser.ProductLicenses,
                    IsLicensor = cleanSSioUser.IsLicensor,
                    Brands = cleanSSioUser.Brands,
                    SKUCode = cleanSSioUser.SKUCode,
                    SSioTechnologies = cleanSSioUser.SSioTechnologies,
                    NameForBrand = cleanSSioUser.NameForBrand,
                    PluralNameForBrand = cleanSSioUser.PluralNameForBrand,
                    DefaultLicenseEventWebhookUrl = cleanSSioUser.DefaultLicenseEventWebhookUrl
                };
            }

            return AdminSSioUser;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // MicroServiceCandidate
        public static dc.MicroServiceCandidate AdminCleanForAdd(this dc.MicroServiceCandidate cleanMicroServiceCandidate)
        {
            var AdminMicroServiceCandidate = default(dc.MicroServiceCandidate);

            if (!ReferenceEquals(cleanMicroServiceCandidate, null))
            {
                AdminMicroServiceCandidate = new dc.MicroServiceCandidate()
                {
                    MicroServiceCandidateId = cleanMicroServiceCandidate.MicroServiceCandidateId,
                    Name = cleanMicroServiceCandidate.Name,
                    Notes = cleanMicroServiceCandidate.Notes,
                    Attachments = cleanMicroServiceCandidate.Attachments,
                    Status = cleanMicroServiceCandidate.Status
                };
            }

            return AdminMicroServiceCandidate;
        }
        
        
        public static List<dc.MicroServiceCandidate> AdminCleanForGet(this IEnumerable<dc.MicroServiceCandidate> cleanMicroServiceCandidates)
        {
            return cleanMicroServiceCandidates.Select(MicroServiceCandidate => MicroServiceCandidate.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.MicroServiceCandidate AdminCleanForGet(this dc.MicroServiceCandidate cleanMicroServiceCandidate)
        {
            var AdminMicroServiceCandidate = default(dc.MicroServiceCandidate);

            if (!ReferenceEquals(cleanMicroServiceCandidate, null))
            {
                AdminMicroServiceCandidate = new dc.MicroServiceCandidate()
                {
                    MicroServiceCandidateId = cleanMicroServiceCandidate.MicroServiceCandidateId,
                    Name = cleanMicroServiceCandidate.Name,
                    Notes = cleanMicroServiceCandidate.Notes,
                    Attachments = cleanMicroServiceCandidate.Attachments,
                    Status = cleanMicroServiceCandidate.Status
                };
            }

            return AdminMicroServiceCandidate;
        }
        
        
        public static dc.MicroServiceCandidate AdminCleanForUpdate(this dc.MicroServiceCandidate cleanMicroServiceCandidate)
        {
            var AdminMicroServiceCandidate = default(dc.MicroServiceCandidate);

            if (!ReferenceEquals(cleanMicroServiceCandidate, null))
            {
                AdminMicroServiceCandidate = new dc.MicroServiceCandidate()
                {
                    MicroServiceCandidateId = cleanMicroServiceCandidate.MicroServiceCandidateId,
                    Name = cleanMicroServiceCandidate.Name,
                    Notes = cleanMicroServiceCandidate.Notes,
                    Attachments = cleanMicroServiceCandidate.Attachments,
                    Status = cleanMicroServiceCandidate.Status
                };
            }

            return AdminMicroServiceCandidate;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ProductLicense
        public static dc.ProductLicense AdminCleanForAdd(this dc.ProductLicense cleanProductLicense)
        {
            var AdminProductLicense = default(dc.ProductLicense);

            if (!ReferenceEquals(cleanProductLicense, null))
            {
                AdminProductLicense = new dc.ProductLicense()
                {
                    ProductLicenseId = cleanProductLicense.ProductLicenseId,
                    Notes = cleanProductLicense.Notes,
                    Attachments = cleanProductLicense.Attachments,
                    Status = cleanProductLicense.Status,
                    LicenseGroup = cleanProductLicense.LicenseGroup,
                    Licensee = cleanProductLicense.Licensee,
                    InvoiceLineItems = cleanProductLicense.InvoiceLineItems,
                    MonthsRenewed = cleanProductLicense.MonthsRenewed,
                    BrandLicense = cleanProductLicense.BrandLicense,
                    TermDate = cleanProductLicense.TermDate,
                    AuthorizedLambdaFunctionRegEx = cleanProductLicense.AuthorizedLambdaFunctionRegEx,
                    LimitedUseToken = cleanProductLicense.LimitedUseToken,
                    CustomStartDate = cleanProductLicense.CustomStartDate,
                    ReplacementExposureOverflow = cleanProductLicense.ReplacementExposureOverflow,
                    ExposuresForwarded = cleanProductLicense.ExposuresForwarded,
                    ExposuresRequested = cleanProductLicense.ExposuresRequested,
                    UnpaidExposures = cleanProductLicense.UnpaidExposures,
                    ExposuresIncluded = cleanProductLicense.ExposuresIncluded,
                    ExposuresUsed = cleanProductLicense.ExposuresUsed,
                    ExposureOverflow = cleanProductLicense.ExposureOverflow,
                    UnusedExposures = cleanProductLicense.UnusedExposures,
                    ExposuresRemaining = cleanProductLicense.ExposuresRemaining,
                    UnpaidInvoiceCount = cleanProductLicense.UnpaidInvoiceCount,
                    RenewalSKU = cleanProductLicense.RenewalSKU,
                    ProductLicenseMeters = cleanProductLicense.ProductLicenseMeters,
                    MetersInWarning = cleanProductLicense.MetersInWarning,
                    MetersExceeded = cleanProductLicense.MetersExceeded,
                    ProductLicenseDMQueue = cleanProductLicense.ProductLicenseDMQueue,
                    CustomLicenseEventWebhookUrl = cleanProductLicense.CustomLicenseEventWebhookUrl
                };
            }

            return AdminProductLicense;
        }
        
        
        public static List<dc.ProductLicense> AdminCleanForGet(this IEnumerable<dc.ProductLicense> cleanProductLicenses)
        {
            return cleanProductLicenses.Select(ProductLicense => ProductLicense.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductLicense AdminCleanForGet(this dc.ProductLicense cleanProductLicense)
        {
            var AdminProductLicense = default(dc.ProductLicense);

            if (!ReferenceEquals(cleanProductLicense, null))
            {
                AdminProductLicense = new dc.ProductLicense()
                {
                    ProductLicenseId = cleanProductLicense.ProductLicenseId,
                    Name = cleanProductLicense.Name,
                    Notes = cleanProductLicense.Notes,
                    Attachments = cleanProductLicense.Attachments,
                    Status = cleanProductLicense.Status,
                    LicenseGroup = cleanProductLicense.LicenseGroup,
                    Licensee = cleanProductLicense.Licensee,
                    StartDate = cleanProductLicense.StartDate,
                    InvoiceLineItems = cleanProductLicense.InvoiceLineItems,
                    PlanMonthyFee = cleanProductLicense.PlanMonthyFee,
                    MonthlyFee = cleanProductLicense.MonthlyFee,
                    Term = cleanProductLicense.Term,
                    PlanQuarterlyDiscount = cleanProductLicense.PlanQuarterlyDiscount,
                    PlanSemiAnnualDiscount = cleanProductLicense.PlanSemiAnnualDiscount,
                    PlanAnnualDiscount = cleanProductLicense.PlanAnnualDiscount,
                    MonthsRenewed = cleanProductLicense.MonthsRenewed,
                    PaidThroughDate = cleanProductLicense.PaidThroughDate,
                    LicenseeEmailAddress = cleanProductLicense.LicenseeEmailAddress,
                    IsExpiring = cleanProductLicense.IsExpiring,
                    IsExpired = cleanProductLicense.IsExpired,
                    Licensor = cleanProductLicense.Licensor,
                    BrandLicense = cleanProductLicense.BrandLicense,
                    TermDate = cleanProductLicense.TermDate,
                    LicensorEmailAddress = cleanProductLicense.LicensorEmailAddress,
                    PlanName = cleanProductLicense.PlanName,
                    AuthorizedLambdaFunctionRegEx = cleanProductLicense.AuthorizedLambdaFunctionRegEx,
                    LimitedUseToken = cleanProductLicense.LimitedUseToken,
                    CreatedTime = cleanProductLicense.CreatedTime,
                    CustomStartDate = cleanProductLicense.CustomStartDate,
                    ReplacementExposureOverflow = cleanProductLicense.ReplacementExposureOverflow,
                    ExposuresForwarded = cleanProductLicense.ExposuresForwarded,
                    ExposuresRequested = cleanProductLicense.ExposuresRequested,
                    UnpaidExposures = cleanProductLicense.UnpaidExposures,
                    ExposuresIncluded = cleanProductLicense.ExposuresIncluded,
                    ExposuresUsed = cleanProductLicense.ExposuresUsed,
                    ExposureOverflow = cleanProductLicense.ExposureOverflow,
                    UnusedExposures = cleanProductLicense.UnusedExposures,
                    ExposuresRemaining = cleanProductLicense.ExposuresRemaining,
                    BrandLicenseName = cleanProductLicense.BrandLicenseName,
                    UnpaidInvoiceCount = cleanProductLicense.UnpaidInvoiceCount,
                    StripePaymentUrl = cleanProductLicense.StripePaymentUrl,
                    RenewalFee = cleanProductLicense.RenewalFee,
                    RenewalSKU = cleanProductLicense.RenewalSKU,
                    ProductLicenseMeters = cleanProductLicense.ProductLicenseMeters,
                    BrandLicenseSKU = cleanProductLicense.BrandLicenseSKU,
                    DefaultRenewalSKU = cleanProductLicense.DefaultRenewalSKU,
                    ContractTerm = cleanProductLicense.ContractTerm,
                    ContractDiscount = cleanProductLicense.ContractDiscount,
                    DefaultRenewalSKULimits = cleanProductLicense.DefaultRenewalSKULimits,
                    MetersInWarning = cleanProductLicense.MetersInWarning,
                    MetersExceeded = cleanProductLicense.MetersExceeded,
                    BrandName = cleanProductLicense.BrandName,
                    RenewalSKUSKU = cleanProductLicense.RenewalSKUSKU,
                    SSioTechnology = cleanProductLicense.SSioTechnology,
                    DefaultSKUMeterAdjustments = cleanProductLicense.DefaultSKUMeterAdjustments,
                    ProductLicenseDMQueue = cleanProductLicense.ProductLicenseDMQueue,
                    LicensorLicenseEvent = cleanProductLicense.LicensorLicenseEvent,
                    BrandLicenseLicenseEventWebhookUrl = cleanProductLicense.BrandLicenseLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanProductLicense.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanProductLicense.LicenseEventWebhookUrl
                };
            }

            return AdminProductLicense;
        }
        
        
        public static dc.ProductLicense AdminCleanForUpdate(this dc.ProductLicense cleanProductLicense)
        {
            var AdminProductLicense = default(dc.ProductLicense);

            if (!ReferenceEquals(cleanProductLicense, null))
            {
                AdminProductLicense = new dc.ProductLicense()
                {
                    ProductLicenseId = cleanProductLicense.ProductLicenseId,
                    Notes = cleanProductLicense.Notes,
                    Attachments = cleanProductLicense.Attachments,
                    Status = cleanProductLicense.Status,
                    LicenseGroup = cleanProductLicense.LicenseGroup,
                    Licensee = cleanProductLicense.Licensee,
                    InvoiceLineItems = cleanProductLicense.InvoiceLineItems,
                    MonthsRenewed = cleanProductLicense.MonthsRenewed,
                    BrandLicense = cleanProductLicense.BrandLicense,
                    TermDate = cleanProductLicense.TermDate,
                    AuthorizedLambdaFunctionRegEx = cleanProductLicense.AuthorizedLambdaFunctionRegEx,
                    LimitedUseToken = cleanProductLicense.LimitedUseToken,
                    CustomStartDate = cleanProductLicense.CustomStartDate,
                    ReplacementExposureOverflow = cleanProductLicense.ReplacementExposureOverflow,
                    ExposuresForwarded = cleanProductLicense.ExposuresForwarded,
                    ExposuresRequested = cleanProductLicense.ExposuresRequested,
                    UnpaidExposures = cleanProductLicense.UnpaidExposures,
                    ExposuresIncluded = cleanProductLicense.ExposuresIncluded,
                    ExposuresUsed = cleanProductLicense.ExposuresUsed,
                    ExposureOverflow = cleanProductLicense.ExposureOverflow,
                    UnusedExposures = cleanProductLicense.UnusedExposures,
                    ExposuresRemaining = cleanProductLicense.ExposuresRemaining,
                    UnpaidInvoiceCount = cleanProductLicense.UnpaidInvoiceCount,
                    RenewalSKU = cleanProductLicense.RenewalSKU,
                    ProductLicenseMeters = cleanProductLicense.ProductLicenseMeters,
                    MetersInWarning = cleanProductLicense.MetersInWarning,
                    MetersExceeded = cleanProductLicense.MetersExceeded,
                    ProductLicenseDMQueue = cleanProductLicense.ProductLicenseDMQueue,
                    CustomLicenseEventWebhookUrl = cleanProductLicense.CustomLicenseEventWebhookUrl
                };
            }

            return AdminProductLicense;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // LicensedProduct
        public static dc.LicensedProduct AdminCleanForAdd(this dc.LicensedProduct cleanLicensedProduct)
        {
            var AdminLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                AdminLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    Brand = cleanLicensedProduct.Brand
                };
            }

            return AdminLicensedProduct;
        }
        
        
        public static List<dc.LicensedProduct> AdminCleanForGet(this IEnumerable<dc.LicensedProduct> cleanLicensedProducts)
        {
            return cleanLicensedProducts.Select(LicensedProduct => LicensedProduct.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.LicensedProduct AdminCleanForGet(this dc.LicensedProduct cleanLicensedProduct)
        {
            var AdminLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                AdminLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Name = cleanLicensedProduct.Name,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsActive = cleanLicensedProduct.IsActive,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    LicensorIsVerified = cleanLicensedProduct.LicensorIsVerified,
                    LicensorEmailAddress = cleanLicensedProduct.LicensorEmailAddress,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadName = cleanLicensedProduct.HeadName,
                    HeadLambdaEndpoint = cleanLicensedProduct.HeadLambdaEndpoint,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    CalculatedLowerName = cleanLicensedProduct.CalculatedLowerName,
                    CalculatedOriginalName = cleanLicensedProduct.CalculatedOriginalName,
                    CalculatedUpperName = cleanLicensedProduct.CalculatedUpperName,
                    CalculatedLowerHyphenName = cleanLicensedProduct.CalculatedLowerHyphenName,
                    HasMissingNames = cleanLicensedProduct.HasMissingNames,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    LicensorScreenName = cleanLicensedProduct.LicensorScreenName,
                    HeadUsesV1Proxy = cleanLicensedProduct.HeadUsesV1Proxy,
                    HasMissingMarkdown = cleanLicensedProduct.HasMissingMarkdown,
                    HeadDescription = cleanLicensedProduct.HeadDescription,
                    HeadReadMeMD = cleanLicensedProduct.HeadReadMeMD,
                    HeadInputDescriptionMD = cleanLicensedProduct.HeadInputDescriptionMD,
                    HeadOutputDescriptionMD = cleanLicensedProduct.HeadOutputDescriptionMD,
                    RecordCreatedtime = cleanLicensedProduct.RecordCreatedtime,
                    CreatedOn = cleanLicensedProduct.CreatedOn,
                    AccountIsActive = cleanLicensedProduct.AccountIsActive,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    FullName = cleanLicensedProduct.FullName,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    UsageCountMismatch = cleanLicensedProduct.UsageCountMismatch,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersion = cleanLicensedProduct.MostRecentVersion,
                    NextVersionNumber = cleanLicensedProduct.NextVersionNumber,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    LicensorUUID = cleanLicensedProduct.LicensorUUID,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    AWSLambdaFunctionName = cleanLicensedProduct.AWSLambdaFunctionName,
                    LicensorAWSAccountId = cleanLicensedProduct.LicensorAWSAccountId,
                    LicensorAWSAPIGatewayId = cleanLicensedProduct.LicensorAWSAPIGatewayId,
                    LicensorAWSLambdaRegion = cleanLicensedProduct.LicensorAWSLambdaRegion,
                    Brand = cleanLicensedProduct.Brand,
                    BundleAWSAPIGatewayId = cleanLicensedProduct.BundleAWSAPIGatewayId
                };
            }

            return AdminLicensedProduct;
        }
        
        
        public static dc.LicensedProduct AdminCleanForUpdate(this dc.LicensedProduct cleanLicensedProduct)
        {
            var AdminLicensedProduct = default(dc.LicensedProduct);

            if (!ReferenceEquals(cleanLicensedProduct, null))
            {
                AdminLicensedProduct = new dc.LicensedProduct()
                {
                    LicensedProductId = cleanLicensedProduct.LicensedProductId,
                    Licensor = cleanLicensedProduct.Licensor,
                    Description = cleanLicensedProduct.Description,
                    OverrideCreatedOn = cleanLicensedProduct.OverrideCreatedOn,
                    IsPrivate = cleanLicensedProduct.IsPrivate,
                    DisplayName = cleanLicensedProduct.DisplayName,
                    LowerName = cleanLicensedProduct.LowerName,
                    UpperName = cleanLicensedProduct.UpperName,
                    LowerHyphenName = cleanLicensedProduct.LowerHyphenName,
                    ReadMeMD = cleanLicensedProduct.ReadMeMD,
                    UsageCount = cleanLicensedProduct.UsageCount,
                    IsRecommended = cleanLicensedProduct.IsRecommended,
                    Category = cleanLicensedProduct.Category,
                    AccountHolderUUID = cleanLicensedProduct.AccountHolderUUID,
                    OriginalName = cleanLicensedProduct.OriginalName,
                    ProductVersions = cleanLicensedProduct.ProductVersions,
                    HeadVersion = cleanLicensedProduct.HeadVersion,
                    HeadCount = cleanLicensedProduct.HeadCount,
                    VersionCount = cleanLicensedProduct.VersionCount,
                    IsDisabled = cleanLicensedProduct.IsDisabled,
                    ProductUseRequestCount = cleanLicensedProduct.ProductUseRequestCount,
                    HasRecentProductVersion = cleanLicensedProduct.HasRecentProductVersion,
                    MostRecentVersionRollup = cleanLicensedProduct.MostRecentVersionRollup,
                    ProductUUID = cleanLicensedProduct.ProductUUID,
                    Brand = cleanLicensedProduct.Brand
                };
            }

            return AdminLicensedProduct;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // LimitedUseToken
        public static dc.LimitedUseToken AdminCleanForAdd(this dc.LimitedUseToken cleanLimitedUseToken)
        {
            var AdminLimitedUseToken = default(dc.LimitedUseToken);

            if (!ReferenceEquals(cleanLimitedUseToken, null))
            {
                AdminLimitedUseToken = new dc.LimitedUseToken()
                {
                    LimitedUseTokenId = cleanLimitedUseToken.LimitedUseTokenId,
                    Name = cleanLimitedUseToken.Name,
                    Notes = cleanLimitedUseToken.Notes,
                    Attachments = cleanLimitedUseToken.Attachments,
                    Status = cleanLimitedUseToken.Status,
                    ProductLicense = cleanLimitedUseToken.ProductLicense,
                    MaxUses = cleanLimitedUseToken.MaxUses,
                    TermDate = cleanLimitedUseToken.TermDate
                };
            }

            return AdminLimitedUseToken;
        }
        
        
        public static List<dc.LimitedUseToken> AdminCleanForGet(this IEnumerable<dc.LimitedUseToken> cleanLimitedUseTokens)
        {
            return cleanLimitedUseTokens.Select(LimitedUseToken => LimitedUseToken.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.LimitedUseToken AdminCleanForGet(this dc.LimitedUseToken cleanLimitedUseToken)
        {
            var AdminLimitedUseToken = default(dc.LimitedUseToken);

            if (!ReferenceEquals(cleanLimitedUseToken, null))
            {
                AdminLimitedUseToken = new dc.LimitedUseToken()
                {
                    LimitedUseTokenId = cleanLimitedUseToken.LimitedUseTokenId,
                    Name = cleanLimitedUseToken.Name,
                    Notes = cleanLimitedUseToken.Notes,
                    Attachments = cleanLimitedUseToken.Attachments,
                    Status = cleanLimitedUseToken.Status,
                    ProductLicense = cleanLimitedUseToken.ProductLicense,
                    Token = cleanLimitedUseToken.Token,
                    MaxUses = cleanLimitedUseToken.MaxUses,
                    TermDate = cleanLimitedUseToken.TermDate
                };
            }

            return AdminLimitedUseToken;
        }
        
        
        public static dc.LimitedUseToken AdminCleanForUpdate(this dc.LimitedUseToken cleanLimitedUseToken)
        {
            var AdminLimitedUseToken = default(dc.LimitedUseToken);

            if (!ReferenceEquals(cleanLimitedUseToken, null))
            {
                AdminLimitedUseToken = new dc.LimitedUseToken()
                {
                    LimitedUseTokenId = cleanLimitedUseToken.LimitedUseTokenId,
                    Name = cleanLimitedUseToken.Name,
                    Notes = cleanLimitedUseToken.Notes,
                    Attachments = cleanLimitedUseToken.Attachments,
                    Status = cleanLimitedUseToken.Status,
                    ProductLicense = cleanLimitedUseToken.ProductLicense,
                    MaxUses = cleanLimitedUseToken.MaxUses,
                    TermDate = cleanLimitedUseToken.TermDate
                };
            }

            return AdminLimitedUseToken;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // OpenIssue
        public static dc.OpenIssue AdminCleanForAdd(this dc.OpenIssue cleanOpenIssue)
        {
            var AdminOpenIssue = default(dc.OpenIssue);

            if (!ReferenceEquals(cleanOpenIssue, null))
            {
                AdminOpenIssue = new dc.OpenIssue()
                {
                    OpenIssueId = cleanOpenIssue.OpenIssueId,
                    Name = cleanOpenIssue.Name,
                    Notes = cleanOpenIssue.Notes,
                    Attachments = cleanOpenIssue.Attachments,
                    CompletedOn = cleanOpenIssue.CompletedOn,
                    Who = cleanOpenIssue.Who,
                    Priority = cleanOpenIssue.Priority,
                    SortOrder = cleanOpenIssue.SortOrder
                };
            }

            return AdminOpenIssue;
        }
        
        
        public static List<dc.OpenIssue> AdminCleanForGet(this IEnumerable<dc.OpenIssue> cleanOpenIssues)
        {
            return cleanOpenIssues.Select(OpenIssue => OpenIssue.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.OpenIssue AdminCleanForGet(this dc.OpenIssue cleanOpenIssue)
        {
            var AdminOpenIssue = default(dc.OpenIssue);

            if (!ReferenceEquals(cleanOpenIssue, null))
            {
                AdminOpenIssue = new dc.OpenIssue()
                {
                    OpenIssueId = cleanOpenIssue.OpenIssueId,
                    Name = cleanOpenIssue.Name,
                    Notes = cleanOpenIssue.Notes,
                    Attachments = cleanOpenIssue.Attachments,
                    CompletedOn = cleanOpenIssue.CompletedOn,
                    Who = cleanOpenIssue.Who,
                    Priority = cleanOpenIssue.Priority,
                    SortOrder = cleanOpenIssue.SortOrder,
                    DaysAgo = cleanOpenIssue.DaysAgo
                };
            }

            return AdminOpenIssue;
        }
        
        
        public static dc.OpenIssue AdminCleanForUpdate(this dc.OpenIssue cleanOpenIssue)
        {
            var AdminOpenIssue = default(dc.OpenIssue);

            if (!ReferenceEquals(cleanOpenIssue, null))
            {
                AdminOpenIssue = new dc.OpenIssue()
                {
                    OpenIssueId = cleanOpenIssue.OpenIssueId,
                    Name = cleanOpenIssue.Name,
                    Notes = cleanOpenIssue.Notes,
                    Attachments = cleanOpenIssue.Attachments,
                    CompletedOn = cleanOpenIssue.CompletedOn,
                    Who = cleanOpenIssue.Who,
                    Priority = cleanOpenIssue.Priority,
                    SortOrder = cleanOpenIssue.SortOrder
                };
            }

            return AdminOpenIssue;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // SKUMeterAdjustment
        public static dc.SKUMeterAdjustment AdminCleanForAdd(this dc.SKUMeterAdjustment cleanSKUMeterAdjustment)
        {
            var AdminSKUMeterAdjustment = default(dc.SKUMeterAdjustment);

            if (!ReferenceEquals(cleanSKUMeterAdjustment, null))
            {
                AdminSKUMeterAdjustment = new dc.SKUMeterAdjustment()
                {
                    SKUMeterAdjustmentId = cleanSKUMeterAdjustment.SKUMeterAdjustmentId,
                    Notes = cleanSKUMeterAdjustment.Notes,
                    Attachments = cleanSKUMeterAdjustment.Attachments,
                    Status = cleanSKUMeterAdjustment.Status,
                    BundleSKU = cleanSKUMeterAdjustment.BundleSKU,
                    TechnologyMeter = cleanSKUMeterAdjustment.TechnologyMeter,
                    MonthlyMeterLimit = cleanSKUMeterAdjustment.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanSKUMeterAdjustment.ProductLicenseMeters,
                    LicenseSKU = cleanSKUMeterAdjustment.LicenseSKU,
                    LicenseMeter = cleanSKUMeterAdjustment.LicenseMeter,
                    Adjustment = cleanSKUMeterAdjustment.Adjustment,
                    AdjustmentType = cleanSKUMeterAdjustment.AdjustmentType,
                    Source = cleanSKUMeterAdjustment.Source,
                    MeterTransactions = cleanSKUMeterAdjustment.MeterTransactions
                };
            }

            return AdminSKUMeterAdjustment;
        }
        
        
        public static List<dc.SKUMeterAdjustment> AdminCleanForGet(this IEnumerable<dc.SKUMeterAdjustment> cleanSKUMeterAdjustments)
        {
            return cleanSKUMeterAdjustments.Select(SKUMeterAdjustment => SKUMeterAdjustment.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.SKUMeterAdjustment AdminCleanForGet(this dc.SKUMeterAdjustment cleanSKUMeterAdjustment)
        {
            var AdminSKUMeterAdjustment = default(dc.SKUMeterAdjustment);

            if (!ReferenceEquals(cleanSKUMeterAdjustment, null))
            {
                AdminSKUMeterAdjustment = new dc.SKUMeterAdjustment()
                {
                    SKUMeterAdjustmentId = cleanSKUMeterAdjustment.SKUMeterAdjustmentId,
                    Name = cleanSKUMeterAdjustment.Name,
                    Notes = cleanSKUMeterAdjustment.Notes,
                    Attachments = cleanSKUMeterAdjustment.Attachments,
                    Status = cleanSKUMeterAdjustment.Status,
                    BundleSKU = cleanSKUMeterAdjustment.BundleSKU,
                    TechnologyMeter = cleanSKUMeterAdjustment.TechnologyMeter,
                    ProductBundle = cleanSKUMeterAdjustment.ProductBundle,
                    MonthlyMeterLimit = cleanSKUMeterAdjustment.MonthlyMeterLimit,
                    TotalSKUMeterLimit = cleanSKUMeterAdjustment.TotalSKUMeterLimit,
                    BundleMonthsIncluded = cleanSKUMeterAdjustment.BundleMonthsIncluded,
                    MeterTypeSKUCode = cleanSKUMeterAdjustment.MeterTypeSKUCode,
                    ProductLicenseMeters = cleanSKUMeterAdjustment.ProductLicenseMeters,
                    LimitSKU = cleanSKUMeterAdjustment.LimitSKU,
                    LicensorEmailAddress = cleanSKUMeterAdjustment.LicensorEmailAddress,
                    LicenseSKU = cleanSKUMeterAdjustment.LicenseSKU,
                    LicenseMeter = cleanSKUMeterAdjustment.LicenseMeter,
                    BrandLicense = cleanSKUMeterAdjustment.BrandLicense,
                    Adjustment = cleanSKUMeterAdjustment.Adjustment,
                    AdjustmentDescription = cleanSKUMeterAdjustment.AdjustmentDescription,
                    AdjustmentType = cleanSKUMeterAdjustment.AdjustmentType,
                    Source = cleanSKUMeterAdjustment.Source,
                    MeterTransactions = cleanSKUMeterAdjustment.MeterTransactions,
                    LicenseMeterUnitOfMeasurement = cleanSKUMeterAdjustment.LicenseMeterUnitOfMeasurement,
                    Meter = cleanSKUMeterAdjustment.Meter
                };
            }

            return AdminSKUMeterAdjustment;
        }
        
        
        public static dc.SKUMeterAdjustment AdminCleanForUpdate(this dc.SKUMeterAdjustment cleanSKUMeterAdjustment)
        {
            var AdminSKUMeterAdjustment = default(dc.SKUMeterAdjustment);

            if (!ReferenceEquals(cleanSKUMeterAdjustment, null))
            {
                AdminSKUMeterAdjustment = new dc.SKUMeterAdjustment()
                {
                    SKUMeterAdjustmentId = cleanSKUMeterAdjustment.SKUMeterAdjustmentId,
                    Notes = cleanSKUMeterAdjustment.Notes,
                    Attachments = cleanSKUMeterAdjustment.Attachments,
                    Status = cleanSKUMeterAdjustment.Status,
                    BundleSKU = cleanSKUMeterAdjustment.BundleSKU,
                    TechnologyMeter = cleanSKUMeterAdjustment.TechnologyMeter,
                    MonthlyMeterLimit = cleanSKUMeterAdjustment.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanSKUMeterAdjustment.ProductLicenseMeters,
                    LicenseSKU = cleanSKUMeterAdjustment.LicenseSKU,
                    LicenseMeter = cleanSKUMeterAdjustment.LicenseMeter,
                    Adjustment = cleanSKUMeterAdjustment.Adjustment,
                    AdjustmentType = cleanSKUMeterAdjustment.AdjustmentType,
                    Source = cleanSKUMeterAdjustment.Source,
                    MeterTransactions = cleanSKUMeterAdjustment.MeterTransactions
                };
            }

            return AdminSKUMeterAdjustment;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ProductLicenseMeter
        public static dc.ProductLicenseMeter AdminCleanForAdd(this dc.ProductLicenseMeter cleanProductLicenseMeter)
        {
            var AdminProductLicenseMeter = default(dc.ProductLicenseMeter);

            if (!ReferenceEquals(cleanProductLicenseMeter, null))
            {
                AdminProductLicenseMeter = new dc.ProductLicenseMeter()
                {
                    ProductLicenseMeterId = cleanProductLicenseMeter.ProductLicenseMeterId,
                    Notes = cleanProductLicenseMeter.Notes,
                    Attachments = cleanProductLicenseMeter.Attachments,
                    Status = cleanProductLicenseMeter.Status,
                    ProductLicense = cleanProductLicenseMeter.ProductLicense,
                    SKULimit = cleanProductLicenseMeter.SKULimit,
                    MeterTransactions = cleanProductLicenseMeter.MeterTransactions,
                    ActiveMeterTransactionBalance = cleanProductLicenseMeter.ActiveMeterTransactionBalance,
                    Limit = cleanProductLicenseMeter.Limit,
                    MeterOffset = cleanProductLicenseMeter.MeterOffset,
                    LicenseMeter = cleanProductLicenseMeter.LicenseMeter,
                    ActiveUsageMeterTransactionBalance = cleanProductLicenseMeter.ActiveUsageMeterTransactionBalance,
                    ActiveMeterLimit = cleanProductLicenseMeter.ActiveMeterLimit,
                    CustomResetDate = cleanProductLicenseMeter.CustomResetDate,
                    ActiveUsageValueRollup = cleanProductLicenseMeter.ActiveUsageValueRollup,
                    ActiveUsageValueOffset = cleanProductLicenseMeter.ActiveUsageValueOffset,
                    CustomWarningPercent = cleanProductLicenseMeter.CustomWarningPercent
                };
            }

            return AdminProductLicenseMeter;
        }
        
        
        public static List<dc.ProductLicenseMeter> AdminCleanForGet(this IEnumerable<dc.ProductLicenseMeter> cleanProductLicenseMeters)
        {
            return cleanProductLicenseMeters.Select(ProductLicenseMeter => ProductLicenseMeter.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductLicenseMeter AdminCleanForGet(this dc.ProductLicenseMeter cleanProductLicenseMeter)
        {
            var AdminProductLicenseMeter = default(dc.ProductLicenseMeter);

            if (!ReferenceEquals(cleanProductLicenseMeter, null))
            {
                AdminProductLicenseMeter = new dc.ProductLicenseMeter()
                {
                    ProductLicenseMeterId = cleanProductLicenseMeter.ProductLicenseMeterId,
                    Name = cleanProductLicenseMeter.Name,
                    Notes = cleanProductLicenseMeter.Notes,
                    Attachments = cleanProductLicenseMeter.Attachments,
                    Status = cleanProductLicenseMeter.Status,
                    ProductLicense = cleanProductLicenseMeter.ProductLicense,
                    LicenseMeters = cleanProductLicenseMeter.LicenseMeters,
                    DefaultRenewalSKULimits = cleanProductLicenseMeter.DefaultRenewalSKULimits,
                    SKULimit = cleanProductLicenseMeter.SKULimit,
                    RenewalSKU = cleanProductLicenseMeter.RenewalSKU,
                    SKULimitSKU = cleanProductLicenseMeter.SKULimitSKU,
                    InitialMeterLimit = cleanProductLicenseMeter.InitialMeterLimit,
                    MeterTransactions = cleanProductLicenseMeter.MeterTransactions,
                    ActiveMeterTransactionBalance = cleanProductLicenseMeter.ActiveMeterTransactionBalance,
                    Limit = cleanProductLicenseMeter.Limit,
                    MeterRemaining = cleanProductLicenseMeter.MeterRemaining,
                    MeterInWarning = cleanProductLicenseMeter.MeterInWarning,
                    MeterOffset = cleanProductLicenseMeter.MeterOffset,
                    Balance = cleanProductLicenseMeter.Balance,
                    MeterPercent = cleanProductLicenseMeter.MeterPercent,
                    MeterExceeded = cleanProductLicenseMeter.MeterExceeded,
                    TransactionResetDate = cleanProductLicenseMeter.TransactionResetDate,
                    LicenseeEmailAddress = cleanProductLicenseMeter.LicenseeEmailAddress,
                    LicensorEmailAddress = cleanProductLicenseMeter.LicensorEmailAddress,
                    DefaultSKUMeterAdjustments = cleanProductLicenseMeter.DefaultSKUMeterAdjustments,
                    LicenseMeter = cleanProductLicenseMeter.LicenseMeter,
                    ActiveUsageMeterTransactionBalance = cleanProductLicenseMeter.ActiveUsageMeterTransactionBalance,
                    ActiveMeterLimit = cleanProductLicenseMeter.ActiveMeterLimit,
                    MeterSKU = cleanProductLicenseMeter.MeterSKU,
                    CreatedTime = cleanProductLicenseMeter.CreatedTime,
                    CustomResetDate = cleanProductLicenseMeter.CustomResetDate,
                    MeterDataType = cleanProductLicenseMeter.MeterDataType,
                    IsTime = cleanProductLicenseMeter.IsTime,
                    Expires = cleanProductLicenseMeter.Expires,
                    AddsMinutes = cleanProductLicenseMeter.AddsMinutes,
                    AddsMonths = cleanProductLicenseMeter.AddsMonths,
                    AddDateType = cleanProductLicenseMeter.AddDateType,
                    DaysTillExpires = cleanProductLicenseMeter.DaysTillExpires,
                    LicenseMeterUnitOfMeasurement = cleanProductLicenseMeter.LicenseMeterUnitOfMeasurement,
                    LicenseMeterUnitOfMeasurementSingular = cleanProductLicenseMeter.LicenseMeterUnitOfMeasurementSingular,
                    LicenseMeterUnitOfMeasurementPlural = cleanProductLicenseMeter.LicenseMeterUnitOfMeasurementPlural,
                    ActiveUsageValueRollup = cleanProductLicenseMeter.ActiveUsageValueRollup,
                    ActiveUsageValueOffset = cleanProductLicenseMeter.ActiveUsageValueOffset,
                    ActiveMeterUsage = cleanProductLicenseMeter.ActiveMeterUsage,
                    TotalDaysMeasured = cleanProductLicenseMeter.TotalDaysMeasured,
                    LicenseMeterLimitDirection = cleanProductLicenseMeter.LicenseMeterLimitDirection,
                    CustomWarningPercent = cleanProductLicenseMeter.CustomWarningPercent,
                    DefaultMeterWarningPercent = cleanProductLicenseMeter.DefaultMeterWarningPercent,
                    WarningPercent = cleanProductLicenseMeter.WarningPercent
                };
            }

            return AdminProductLicenseMeter;
        }
        
        
        public static dc.ProductLicenseMeter AdminCleanForUpdate(this dc.ProductLicenseMeter cleanProductLicenseMeter)
        {
            var AdminProductLicenseMeter = default(dc.ProductLicenseMeter);

            if (!ReferenceEquals(cleanProductLicenseMeter, null))
            {
                AdminProductLicenseMeter = new dc.ProductLicenseMeter()
                {
                    ProductLicenseMeterId = cleanProductLicenseMeter.ProductLicenseMeterId,
                    Notes = cleanProductLicenseMeter.Notes,
                    Attachments = cleanProductLicenseMeter.Attachments,
                    Status = cleanProductLicenseMeter.Status,
                    ProductLicense = cleanProductLicenseMeter.ProductLicense,
                    SKULimit = cleanProductLicenseMeter.SKULimit,
                    MeterTransactions = cleanProductLicenseMeter.MeterTransactions,
                    ActiveMeterTransactionBalance = cleanProductLicenseMeter.ActiveMeterTransactionBalance,
                    Limit = cleanProductLicenseMeter.Limit,
                    MeterOffset = cleanProductLicenseMeter.MeterOffset,
                    LicenseMeter = cleanProductLicenseMeter.LicenseMeter,
                    ActiveUsageMeterTransactionBalance = cleanProductLicenseMeter.ActiveUsageMeterTransactionBalance,
                    ActiveMeterLimit = cleanProductLicenseMeter.ActiveMeterLimit,
                    CustomResetDate = cleanProductLicenseMeter.CustomResetDate,
                    ActiveUsageValueRollup = cleanProductLicenseMeter.ActiveUsageValueRollup,
                    ActiveUsageValueOffset = cleanProductLicenseMeter.ActiveUsageValueOffset,
                    CustomWarningPercent = cleanProductLicenseMeter.CustomWarningPercent
                };
            }

            return AdminProductLicenseMeter;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // LicenseMeter
        public static dc.LicenseMeter AdminCleanForAdd(this dc.LicenseMeter cleanLicenseMeter)
        {
            var AdminLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                AdminLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return AdminLicenseMeter;
        }
        
        
        public static List<dc.LicenseMeter> AdminCleanForGet(this IEnumerable<dc.LicenseMeter> cleanLicenseMeters)
        {
            return cleanLicenseMeters.Select(LicenseMeter => LicenseMeter.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseMeter AdminCleanForGet(this dc.LicenseMeter cleanLicenseMeter)
        {
            var AdminLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                AdminLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Name = cleanLicenseMeter.Name,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    TotalSKUMeterLimit = cleanLicenseMeter.TotalSKUMeterLimit,
                    BundleMonthsIncluded = cleanLicenseMeter.BundleMonthsIncluded,
                    MeterTypeSKUCode = cleanLicenseMeter.MeterTypeSKUCode,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LimitSKU = cleanLicenseMeter.LimitSKU,
                    LicensorEmailAddress = cleanLicenseMeter.LicensorEmailAddress,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    LicenseBundleName = cleanLicenseMeter.LicenseBundleName,
                    MeterTypeName = cleanLicenseMeter.MeterTypeName,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    BrandLicenseName = cleanLicenseMeter.BrandLicenseName,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    UnitOfMeasurementPlural = cleanLicenseMeter.UnitOfMeasurementPlural,
                    MeasurementType = cleanLicenseMeter.MeasurementType,
                    AddsMinutes = cleanLicenseMeter.AddsMinutes,
                    AddsMonths = cleanLicenseMeter.AddsMonths,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    BrandLicenseSKU = cleanLicenseMeter.BrandLicenseSKU,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    MeterSKU = cleanLicenseMeter.MeterSKU,
                    UnitOfMeasurementSingular = cleanLicenseMeter.UnitOfMeasurementSingular,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    NameForBrand = cleanLicenseMeter.NameForBrand,
                    PluralNameForBrand = cleanLicenseMeter.PluralNameForBrand,
                    NameForBrandLicense = cleanLicenseMeter.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanLicenseMeter.PluralNameForBrandLicense,
                    NameForMeter = cleanLicenseMeter.NameForMeter,
                    PluralNameForMeter = cleanLicenseMeter.PluralNameForMeter,
                    NameForSKU = cleanLicenseMeter.NameForSKU,
                    PluralNameForSKU = cleanLicenseMeter.PluralNameForSKU,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return AdminLicenseMeter;
        }
        
        
        public static dc.LicenseMeter AdminCleanForUpdate(this dc.LicenseMeter cleanLicenseMeter)
        {
            var AdminLicenseMeter = default(dc.LicenseMeter);

            if (!ReferenceEquals(cleanLicenseMeter, null))
            {
                AdminLicenseMeter = new dc.LicenseMeter()
                {
                    LicenseMeterId = cleanLicenseMeter.LicenseMeterId,
                    SKULimitId = cleanLicenseMeter.SKULimitId,
                    Notes = cleanLicenseMeter.Notes,
                    Attachments = cleanLicenseMeter.Attachments,
                    Status = cleanLicenseMeter.Status,
                    BundleSKU = cleanLicenseMeter.BundleSKU,
                    TechnologyMeter = cleanLicenseMeter.TechnologyMeter,
                    MonthlyMeterLimit = cleanLicenseMeter.MonthlyMeterLimit,
                    ProductLicenseMeters = cleanLicenseMeter.ProductLicenseMeters,
                    LicenseBundle = cleanLicenseMeter.LicenseBundle,
                    MeterType = cleanLicenseMeter.MeterType,
                    MeterDescription = cleanLicenseMeter.MeterDescription,
                    BrandLicense = cleanLicenseMeter.BrandLicense,
                    UnitOfMeasurement = cleanLicenseMeter.UnitOfMeasurement,
                    SKUMeterAdjustments = cleanLicenseMeter.SKUMeterAdjustments,
                    MeterSourceName = cleanLicenseMeter.MeterSourceName,
                    MeterSourceHttpPOSTUrl = cleanLicenseMeter.MeterSourceHttpPOSTUrl,
                    MeterSourceHttpGETUrl = cleanLicenseMeter.MeterSourceHttpGETUrl,
                    MeterDataType = cleanLicenseMeter.MeterDataType,
                    SKUCode = cleanLicenseMeter.SKUCode,
                    LimitDirection = cleanLicenseMeter.LimitDirection,
                    DefaultWarningPercent = cleanLicenseMeter.DefaultWarningPercent
                };
            }

            return AdminLicenseMeter;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // Invoice
        public static dc.Invoice AdminCleanForAdd(this dc.Invoice cleanInvoice)
        {
            var AdminInvoice = default(dc.Invoice);

            if (!ReferenceEquals(cleanInvoice, null))
            {
                AdminInvoice = new dc.Invoice()
                {
                    InvoiceId = cleanInvoice.InvoiceId,
                    Notes = cleanInvoice.Notes,
                    Attachments = cleanInvoice.Attachments,
                    Status = cleanInvoice.Status,
                    Autonumber = cleanInvoice.Autonumber,
                    InvoiceLineItems = cleanInvoice.InvoiceLineItems,
                    AccountHolder = cleanInvoice.AccountHolder,
                    Licensee = cleanInvoice.Licensee,
                    InvoiceSubTotal = cleanInvoice.InvoiceSubTotal,
                    OverrideInvoiceDate = cleanInvoice.OverrideInvoiceDate,
                    StripeInvoiceId = cleanInvoice.StripeInvoiceId,
                    StripeStatus = cleanInvoice.StripeStatus,
                    StripePaidAt = cleanInvoice.StripePaidAt,
                    StripeMetadata = cleanInvoice.StripeMetadata,
                    StripePaymentUrl = cleanInvoice.StripePaymentUrl
                };
            }

            return AdminInvoice;
        }
        
        
        public static List<dc.Invoice> AdminCleanForGet(this IEnumerable<dc.Invoice> cleanInvoices)
        {
            return cleanInvoices.Select(Invoice => Invoice.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.Invoice AdminCleanForGet(this dc.Invoice cleanInvoice)
        {
            var AdminInvoice = default(dc.Invoice);

            if (!ReferenceEquals(cleanInvoice, null))
            {
                AdminInvoice = new dc.Invoice()
                {
                    InvoiceId = cleanInvoice.InvoiceId,
                    Name = cleanInvoice.Name,
                    Notes = cleanInvoice.Notes,
                    Attachments = cleanInvoice.Attachments,
                    Status = cleanInvoice.Status,
                    Autonumber = cleanInvoice.Autonumber,
                    InvoiceNumber = cleanInvoice.InvoiceNumber,
                    InvoiceLineItems = cleanInvoice.InvoiceLineItems,
                    AccountHolder = cleanInvoice.AccountHolder,
                    InvoiceDate = cleanInvoice.InvoiceDate,
                    AccountStartDate = cleanInvoice.AccountStartDate,
                    Licensee = cleanInvoice.Licensee,
                    LicenseeEmailAddress = cleanInvoice.LicenseeEmailAddress,
                    InvoiceSubTotal = cleanInvoice.InvoiceSubTotal,
                    Createdtime = cleanInvoice.Createdtime,
                    OverrideInvoiceDate = cleanInvoice.OverrideInvoiceDate,
                    StripeInvoiceId = cleanInvoice.StripeInvoiceId,
                    StripeStatus = cleanInvoice.StripeStatus,
                    StripePaidAt = cleanInvoice.StripePaidAt,
                    StripeMetadata = cleanInvoice.StripeMetadata,
                    StripePaymentUrl = cleanInvoice.StripePaymentUrl,
                    IsUnpaid = cleanInvoice.IsUnpaid
                };
            }

            return AdminInvoice;
        }
        
        
        public static dc.Invoice AdminCleanForUpdate(this dc.Invoice cleanInvoice)
        {
            var AdminInvoice = default(dc.Invoice);

            if (!ReferenceEquals(cleanInvoice, null))
            {
                AdminInvoice = new dc.Invoice()
                {
                    InvoiceId = cleanInvoice.InvoiceId,
                    Notes = cleanInvoice.Notes,
                    Attachments = cleanInvoice.Attachments,
                    Status = cleanInvoice.Status,
                    Autonumber = cleanInvoice.Autonumber,
                    InvoiceLineItems = cleanInvoice.InvoiceLineItems,
                    AccountHolder = cleanInvoice.AccountHolder,
                    Licensee = cleanInvoice.Licensee,
                    InvoiceSubTotal = cleanInvoice.InvoiceSubTotal,
                    OverrideInvoiceDate = cleanInvoice.OverrideInvoiceDate,
                    StripeInvoiceId = cleanInvoice.StripeInvoiceId,
                    StripeStatus = cleanInvoice.StripeStatus,
                    StripePaidAt = cleanInvoice.StripePaidAt,
                    StripeMetadata = cleanInvoice.StripeMetadata,
                    StripePaymentUrl = cleanInvoice.StripePaymentUrl
                };
            }

            return AdminInvoice;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // BrandLicense
        public static dc.BrandLicense AdminCleanForAdd(this dc.BrandLicense cleanBrandLicense)
        {
            var AdminBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                AdminBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicenseType = cleanBrandLicense.LicenseType,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    SKUCode = cleanBrandLicense.SKUCode,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl
                };
            }

            return AdminBrandLicense;
        }
        
        
        public static List<dc.BrandLicense> AdminCleanForGet(this IEnumerable<dc.BrandLicense> cleanBrandLicenses)
        {
            return cleanBrandLicenses.Select(BrandLicense => BrandLicense.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.BrandLicense AdminCleanForGet(this dc.BrandLicense cleanBrandLicense)
        {
            var AdminBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                AdminBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Name = cleanBrandLicense.Name,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    Licensor = cleanBrandLicense.Licensor,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicensorEmailAddresss = cleanBrandLicense.LicensorEmailAddresss,
                    LicensorScreenName = cleanBrandLicense.LicensorScreenName,
                    LicensorEmailAddress = cleanBrandLicense.LicensorEmailAddress,
                    LicenseType = cleanBrandLicense.LicenseType,
                    LicenseeEmailAddresses = cleanBrandLicense.LicenseeEmailAddresses,
                    Createdtime = cleanBrandLicense.Createdtime,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    MonthlyCostPer1KUses = cleanBrandLicense.MonthlyCostPer1KUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    LicensorSKUCode = cleanBrandLicense.LicensorSKUCode,
                    BrandSKU = cleanBrandLicense.BrandSKU,
                    SKUCode = cleanBrandLicense.SKUCode,
                    SKU = cleanBrandLicense.SKU,
                    PaymentProcessorPercent = cleanBrandLicense.PaymentProcessorPercent,
                    TotalMarketPercent = cleanBrandLicense.TotalMarketPercent,
                    BrandName = cleanBrandLicense.BrandName,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    DefaultTerm = cleanBrandLicense.DefaultTerm,
                    DefaultRenewalFee = cleanBrandLicense.DefaultRenewalFee,
                    ModifiedTime = cleanBrandLicense.ModifiedTime,
                    OwnerIsVerified = cleanBrandLicense.OwnerIsVerified,
                    DefaultBundleSKUSKU = cleanBrandLicense.DefaultBundleSKUSKU,
                    BrandIsPublic = cleanBrandLicense.BrandIsPublic,
                    DefaultTermDays = cleanBrandLicense.DefaultTermDays,
                    SSioTechnology = cleanBrandLicense.SSioTechnology,
                    SSioTechnologyPercent = cleanBrandLicense.SSioTechnologyPercent,
                    SSioTechnologySKUCode = cleanBrandLicense.SSioTechnologySKUCode,
                    SSioPercent = cleanBrandLicense.SSioPercent,
                    SSioTechnologyName = cleanBrandLicense.SSioTechnologyName,
                    LicenseTypePrimaryTrackingField = cleanBrandLicense.LicenseTypePrimaryTrackingField,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForBrand = cleanBrandLicense.NameForBrand,
                    PluralNameForBrand = cleanBrandLicense.PluralNameForBrand,
                    PluralNameForBrandLicense = cleanBrandLicense.PluralNameForBrandLicense,
                    NameForBrandLicense = cleanBrandLicense.NameForBrandLicense,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    BrandLicenseEventWebhookUrl = cleanBrandLicense.BrandLicenseEventWebhookUrl,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl,
                    LicenseEventWebhookUrl = cleanBrandLicense.LicenseEventWebhookUrl
                };
            }

            return AdminBrandLicense;
        }
        
        
        public static dc.BrandLicense AdminCleanForUpdate(this dc.BrandLicense cleanBrandLicense)
        {
            var AdminBrandLicense = default(dc.BrandLicense);

            if (!ReferenceEquals(cleanBrandLicense, null))
            {
                AdminBrandLicense = new dc.BrandLicense()
                {
                    BrandLicenseId = cleanBrandLicense.BrandLicenseId,
                    Notes = cleanBrandLicense.Notes,
                    Attachments = cleanBrandLicense.Attachments,
                    Status = cleanBrandLicense.Status,
                    PlanName = cleanBrandLicense.PlanName,
                    MonthlyFee = cleanBrandLicense.MonthlyFee,
                    LicenseeSubscriptions = cleanBrandLicense.LicenseeSubscriptions,
                    QuarterlyDiscount = cleanBrandLicense.QuarterlyDiscount,
                    SemiAnnualDiscount = cleanBrandLicense.SemiAnnualDiscount,
                    AnnualDiscount = cleanBrandLicense.AnnualDiscount,
                    ProductLicenses = cleanBrandLicense.ProductLicenses,
                    CostFor1KUses = cleanBrandLicense.CostFor1KUses,
                    LicenseType = cleanBrandLicense.LicenseType,
                    InitialFee = cleanBrandLicense.InitialFee,
                    MaxUses = cleanBrandLicense.MaxUses,
                    BrandLicenseName = cleanBrandLicense.BrandLicenseName,
                    BundleSKUs = cleanBrandLicense.BundleSKUs,
                    Brand = cleanBrandLicense.Brand,
                    SKUCode = cleanBrandLicense.SKUCode,
                    DefaultBundleSKU = cleanBrandLicense.DefaultBundleSKU,
                    IsExpired = cleanBrandLicense.IsExpired,
                    LicenseMeters = cleanBrandLicense.LicenseMeters,
                    LicenseSKUs = cleanBrandLicense.LicenseSKUs,
                    DefaultRenewalSKU = cleanBrandLicense.DefaultRenewalSKU,
                    NameForMeter = cleanBrandLicense.NameForMeter,
                    PluralNameForMeter = cleanBrandLicense.PluralNameForMeter,
                    NameForSKU = cleanBrandLicense.NameForSKU,
                    PluralNameForSKU = cleanBrandLicense.PluralNameForSKU,
                    CustomLicenseEventWebhookUrl = cleanBrandLicense.CustomLicenseEventWebhookUrl
                };
            }

            return AdminBrandLicense;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ProductUseRequest
        public static dc.ProductUseRequest AdminCleanForAdd(this dc.ProductUseRequest cleanProductUseRequest)
        {
            var AdminProductUseRequest = default(dc.ProductUseRequest);

            if (!ReferenceEquals(cleanProductUseRequest, null))
            {
                AdminProductUseRequest = new dc.ProductUseRequest()
                {
                    ProductUseRequestId = cleanProductUseRequest.ProductUseRequestId,
                    RequestStatus = cleanProductUseRequest.RequestStatus,
                    CreatedOn = cleanProductUseRequest.CreatedOn,
                    Licensee = cleanProductUseRequest.Licensee,
                    ProductVersion = cleanProductUseRequest.ProductVersion
                };
            }

            return AdminProductUseRequest;
        }
        
        
        public static List<dc.ProductUseRequest> AdminCleanForGet(this IEnumerable<dc.ProductUseRequest> cleanProductUseRequests)
        {
            return cleanProductUseRequests.Select(ProductUseRequest => ProductUseRequest.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductUseRequest AdminCleanForGet(this dc.ProductUseRequest cleanProductUseRequest)
        {
            var AdminProductUseRequest = default(dc.ProductUseRequest);

            if (!ReferenceEquals(cleanProductUseRequest, null))
            {
                AdminProductUseRequest = new dc.ProductUseRequest()
                {
                    ProductUseRequestId = cleanProductUseRequest.ProductUseRequestId,
                    Name = cleanProductUseRequest.Name,
                    RequestStatus = cleanProductUseRequest.RequestStatus,
                    CreatedOn = cleanProductUseRequest.CreatedOn,
                    Product = cleanProductUseRequest.Product,
                    Licensee = cleanProductUseRequest.Licensee,
                    ProductVersion = cleanProductUseRequest.ProductVersion
                };
            }

            return AdminProductUseRequest;
        }
        
        
        public static dc.ProductUseRequest AdminCleanForUpdate(this dc.ProductUseRequest cleanProductUseRequest)
        {
            var AdminProductUseRequest = default(dc.ProductUseRequest);

            if (!ReferenceEquals(cleanProductUseRequest, null))
            {
                AdminProductUseRequest = new dc.ProductUseRequest()
                {
                    ProductUseRequestId = cleanProductUseRequest.ProductUseRequestId,
                    RequestStatus = cleanProductUseRequest.RequestStatus,
                    CreatedOn = cleanProductUseRequest.CreatedOn,
                    Licensee = cleanProductUseRequest.Licensee,
                    ProductVersion = cleanProductUseRequest.ProductVersion
                };
            }

            return AdminProductUseRequest;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // LicenseType
        public static dc.LicenseType AdminCleanForAdd(this dc.LicenseType cleanLicenseType)
        {
            var AdminLicenseType = default(dc.LicenseType);

            if (!ReferenceEquals(cleanLicenseType, null))
            {
                AdminLicenseType = new dc.LicenseType()
                {
                    LicenseTypeId = cleanLicenseType.LicenseTypeId,
                    Name = cleanLicenseType.Name,
                    LicenseBundles = cleanLicenseType.LicenseBundles,
                    Description = cleanLicenseType.Description,
                    PrimaryTrackingField = cleanLicenseType.PrimaryTrackingField
                };
            }

            return AdminLicenseType;
        }
        
        
        public static List<dc.LicenseType> AdminCleanForGet(this IEnumerable<dc.LicenseType> cleanLicenseTypes)
        {
            return cleanLicenseTypes.Select(LicenseType => LicenseType.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseType AdminCleanForGet(this dc.LicenseType cleanLicenseType)
        {
            var AdminLicenseType = default(dc.LicenseType);

            if (!ReferenceEquals(cleanLicenseType, null))
            {
                AdminLicenseType = new dc.LicenseType()
                {
                    LicenseTypeId = cleanLicenseType.LicenseTypeId,
                    Name = cleanLicenseType.Name,
                    LicenseBundles = cleanLicenseType.LicenseBundles,
                    Description = cleanLicenseType.Description,
                    PrimaryTrackingField = cleanLicenseType.PrimaryTrackingField
                };
            }

            return AdminLicenseType;
        }
        
        
        public static dc.LicenseType AdminCleanForUpdate(this dc.LicenseType cleanLicenseType)
        {
            var AdminLicenseType = default(dc.LicenseType);

            if (!ReferenceEquals(cleanLicenseType, null))
            {
                AdminLicenseType = new dc.LicenseType()
                {
                    LicenseTypeId = cleanLicenseType.LicenseTypeId,
                    Name = cleanLicenseType.Name,
                    LicenseBundles = cleanLicenseType.LicenseBundles,
                    Description = cleanLicenseType.Description,
                    PrimaryTrackingField = cleanLicenseType.PrimaryTrackingField
                };
            }

            return AdminLicenseType;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // MeterTransaction
        public static dc.MeterTransaction AdminCleanForAdd(this dc.MeterTransaction cleanMeterTransaction)
        {
            var AdminMeterTransaction = default(dc.MeterTransaction);

            if (!ReferenceEquals(cleanMeterTransaction, null))
            {
                AdminMeterTransaction = new dc.MeterTransaction()
                {
                    MeterTransactionId = cleanMeterTransaction.MeterTransactionId,
                    Notes = cleanMeterTransaction.Notes,
                    Attachments = cleanMeterTransaction.Attachments,
                    Status = cleanMeterTransaction.Status,
                    ProductLicenseMeter = cleanMeterTransaction.ProductLicenseMeter,
                    AutoNumber = cleanMeterTransaction.AutoNumber,
                    CustomTransactionDate = cleanMeterTransaction.CustomTransactionDate,
                    SKUMeterAdjustment = cleanMeterTransaction.SKUMeterAdjustment,
                    CustomValue = cleanMeterTransaction.CustomValue,
                    AdjustsLimit = cleanMeterTransaction.AdjustsLimit,
                    UnitConversion = cleanMeterTransaction.UnitConversion,
                    ReplacedByMeterTransaction = cleanMeterTransaction.ReplacedByMeterTransaction
                };
            }

            return AdminMeterTransaction;
        }
        
        
        public static List<dc.MeterTransaction> AdminCleanForGet(this IEnumerable<dc.MeterTransaction> cleanMeterTransactions)
        {
            return cleanMeterTransactions.Select(MeterTransaction => MeterTransaction.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.MeterTransaction AdminCleanForGet(this dc.MeterTransaction cleanMeterTransaction)
        {
            var AdminMeterTransaction = default(dc.MeterTransaction);

            if (!ReferenceEquals(cleanMeterTransaction, null))
            {
                AdminMeterTransaction = new dc.MeterTransaction()
                {
                    MeterTransactionId = cleanMeterTransaction.MeterTransactionId,
                    Name = cleanMeterTransaction.Name,
                    Notes = cleanMeterTransaction.Notes,
                    Attachments = cleanMeterTransaction.Attachments,
                    Status = cleanMeterTransaction.Status,
                    ProductLicenseMeter = cleanMeterTransaction.ProductLicenseMeter,
                    Value = cleanMeterTransaction.Value,
                    CreatedTime = cleanMeterTransaction.CreatedTime,
                    AutoNumber = cleanMeterTransaction.AutoNumber,
                    TransactionResetDate = cleanMeterTransaction.TransactionResetDate,
                    CustomTransactionDate = cleanMeterTransaction.CustomTransactionDate,
                    TransactionDate = cleanMeterTransaction.TransactionDate,
                    IsActive = cleanMeterTransaction.IsActive,
                    LicenseeEmailAddress = cleanMeterTransaction.LicenseeEmailAddress,
                    LicensorEmailaddress = cleanMeterTransaction.LicensorEmailaddress,
                    SKUMeterAdjustment = cleanMeterTransaction.SKUMeterAdjustment,
                    LicenseMeter = cleanMeterTransaction.LicenseMeter,
                    Adjustment = cleanMeterTransaction.Adjustment,
                    CustomValue = cleanMeterTransaction.CustomValue,
                    ProductLicense = cleanMeterTransaction.ProductLicense,
                    AdjustmentType = cleanMeterTransaction.AdjustmentType,
                    UsageValue = cleanMeterTransaction.UsageValue,
                    LimitValue = cleanMeterTransaction.LimitValue,
                    AdjustsLimit = cleanMeterTransaction.AdjustsLimit,
                    UnitConversion = cleanMeterTransaction.UnitConversion,
                    UnitConversionValue = cleanMeterTransaction.UnitConversionValue,
                    LicenseMeterUnitOfMeasurement = cleanMeterTransaction.LicenseMeterUnitOfMeasurement,
                    ConversionRatio = cleanMeterTransaction.ConversionRatio,
                    LicenseMeterUnitOfMeasurementSingular = cleanMeterTransaction.LicenseMeterUnitOfMeasurementSingular,
                    LicenseMeterUnitOfMeasurementPlural = cleanMeterTransaction.LicenseMeterUnitOfMeasurementPlural,
                    ReplacedByMeterTransaction = cleanMeterTransaction.ReplacedByMeterTransaction
                };
            }

            return AdminMeterTransaction;
        }
        
        
        public static dc.MeterTransaction AdminCleanForUpdate(this dc.MeterTransaction cleanMeterTransaction)
        {
            var AdminMeterTransaction = default(dc.MeterTransaction);

            if (!ReferenceEquals(cleanMeterTransaction, null))
            {
                AdminMeterTransaction = new dc.MeterTransaction()
                {
                    MeterTransactionId = cleanMeterTransaction.MeterTransactionId,
                    Notes = cleanMeterTransaction.Notes,
                    Attachments = cleanMeterTransaction.Attachments,
                    Status = cleanMeterTransaction.Status,
                    ProductLicenseMeter = cleanMeterTransaction.ProductLicenseMeter,
                    AutoNumber = cleanMeterTransaction.AutoNumber,
                    CustomTransactionDate = cleanMeterTransaction.CustomTransactionDate,
                    SKUMeterAdjustment = cleanMeterTransaction.SKUMeterAdjustment,
                    CustomValue = cleanMeterTransaction.CustomValue,
                    AdjustsLimit = cleanMeterTransaction.AdjustsLimit,
                    UnitConversion = cleanMeterTransaction.UnitConversion,
                    ReplacedByMeterTransaction = cleanMeterTransaction.ReplacedByMeterTransaction
                };
            }

            return AdminMeterTransaction;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // LicenseSKU
        public static dc.LicenseSKU AdminCleanForAdd(this dc.LicenseSKU cleanLicenseSKU)
        {
            var AdminLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                AdminLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments
                };
            }

            return AdminLicenseSKU;
        }
        
        
        public static List<dc.LicenseSKU> AdminCleanForGet(this IEnumerable<dc.LicenseSKU> cleanLicenseSKUs)
        {
            return cleanLicenseSKUs.Select(LicenseSKU => LicenseSKU.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.LicenseSKU AdminCleanForGet(this dc.LicenseSKU cleanLicenseSKU)
        {
            var AdminLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                AdminLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Name = cleanLicenseSKU.Name,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    MonthsIncluded = cleanLicenseSKU.MonthsIncluded,
                    BundleLicensor = cleanLicenseSKU.BundleLicensor,
                    LicensorEmailAddress = cleanLicenseSKU.LicensorEmailAddress,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUCode = cleanLicenseSKU.SKUCode,
                    SKUDescription = cleanLicenseSKU.SKUDescription,
                    SKU = cleanLicenseSKU.SKU,
                    PlanName = cleanLicenseSKU.PlanName,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKUTypeCode = cleanLicenseSKU.SKUTypeCode,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    Brand = cleanLicenseSKU.Brand,
                    ParentInitialFee = cleanLicenseSKU.ParentInitialFee,
                    ParentMonthlyFee = cleanLicenseSKU.ParentMonthlyFee,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    ParentRelativeFee = cleanLicenseSKU.ParentRelativeFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    CalculatedMonthlyFee = cleanLicenseSKU.CalculatedMonthlyFee,
                    SKURenewalFee = cleanLicenseSKU.SKURenewalFee,
                    LicensorSKUCode = cleanLicenseSKU.LicensorSKUCode,
                    BrandLicenseSKU = cleanLicenseSKU.BrandLicenseSKU,
                    PaymentProcessorPercent = cleanLicenseSKU.PaymentProcessorPercent,
                    PaymentProcessorFee = cleanLicenseSKU.PaymentProcessorFee,
                    TotalMarketFees = cleanLicenseSKU.TotalMarketFees,
                    LicensorPayment = cleanLicenseSKU.LicensorPayment,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    LicensorFee = cleanLicenseSKU.LicensorFee,
                    BrandName = cleanLicenseSKU.BrandName,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    CreatedTime = cleanLicenseSKU.CreatedTime,
                    ModifiedTime = cleanLicenseSKU.ModifiedTime,
                    BrandLicenseName = cleanLicenseSKU.BrandLicenseName,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    BrandLicenseLicenseType = cleanLicenseSKU.BrandLicenseLicenseType,
                    BrandIsPublic = cleanLicenseSKU.BrandIsPublic,
                    SSioTechnology = cleanLicenseSKU.SSioTechnology,
                    SSioTechnologySKUCode = cleanLicenseSKU.SSioTechnologySKUCode,
                    SSioTechnologyPercent = cleanLicenseSKU.SSioTechnologyPercent,
                    SSioTechnologyFee = cleanLicenseSKU.SSioTechnologyFee,
                    SSioPercent = cleanLicenseSKU.SSioPercent,
                    SSioFee = cleanLicenseSKU.SSioFee,
                    SSioTechnologyName = cleanLicenseSKU.SSioTechnologyName,
                    QuantityIncluded = cleanLicenseSKU.QuantityIncluded,
                    ParentRecurringFee = cleanLicenseSKU.ParentRecurringFee,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    CalculatedRecurringFee = cleanLicenseSKU.CalculatedRecurringFee,
                    LicenseTypePrimaryTrackingField = cleanLicenseSKU.LicenseTypePrimaryTrackingField,
                    CalculatedInitialFee = cleanLicenseSKU.CalculatedInitialFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments,
                    PluralNameForBrand = cleanLicenseSKU.PluralNameForBrand,
                    NameForBrandLicense = cleanLicenseSKU.NameForBrandLicense,
                    PluralNameForBrandLicense = cleanLicenseSKU.PluralNameForBrandLicense,
                    NameForMeter = cleanLicenseSKU.NameForMeter,
                    PluralNameForMeter = cleanLicenseSKU.PluralNameForMeter,
                    NameForSKU = cleanLicenseSKU.NameForSKU,
                    PluralNameForSKU = cleanLicenseSKU.PluralNameForSKU,
                    NameForBrand = cleanLicenseSKU.NameForBrand
                };
            }

            return AdminLicenseSKU;
        }
        
        
        public static dc.LicenseSKU AdminCleanForUpdate(this dc.LicenseSKU cleanLicenseSKU)
        {
            var AdminLicenseSKU = default(dc.LicenseSKU);

            if (!ReferenceEquals(cleanLicenseSKU, null))
            {
                AdminLicenseSKU = new dc.LicenseSKU()
                {
                    LicenseSKUId = cleanLicenseSKU.LicenseSKUId,
                    Notes = cleanLicenseSKU.Notes,
                    Attachments = cleanLicenseSKU.Attachments,
                    Status = cleanLicenseSKU.Status,
                    BrandLicense = cleanLicenseSKU.BrandLicense,
                    InitialFee = cleanLicenseSKU.InitialFee,
                    ParentSKU = cleanLicenseSKU.ParentSKU,
                    SKUType = cleanLicenseSKU.SKUType,
                    SKULimits = cleanLicenseSKU.SKULimits,
                    CustomMonthlyFee = cleanLicenseSKU.CustomMonthlyFee,
                    DiscountPercent = cleanLicenseSKU.DiscountPercent,
                    MonthlyFee = cleanLicenseSKU.MonthlyFee,
                    ProductLicenses = cleanLicenseSKU.ProductLicenses,
                    DefaultSKUForBrandLicense = cleanLicenseSKU.DefaultSKUForBrandLicense,
                    IsHidden = cleanLicenseSKU.IsHidden,
                    DaysIncluded = cleanLicenseSKU.DaysIncluded,
                    RecurringFee = cleanLicenseSKU.RecurringFee,
                    ChosenSKUCode = cleanLicenseSKU.ChosenSKUCode,
                    SKUMeterAdjustments = cleanLicenseSKU.SKUMeterAdjustments
                };
            }

            return AdminLicenseSKU;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // SSioVersion
        public static dc.SSioVersion AdminCleanForAdd(this dc.SSioVersion cleanSSioVersion)
        {
            var AdminSSioVersion = default(dc.SSioVersion);

            if (!ReferenceEquals(cleanSSioVersion, null))
            {
                AdminSSioVersion = new dc.SSioVersion()
                {
                    SSioVersionId = cleanSSioVersion.SSioVersionId,
                    Name = cleanSSioVersion.Name,
                    Notes = cleanSSioVersion.Notes,
                    Attachments = cleanSSioVersion.Attachments,
                    Status = cleanSSioVersion.Status,
                    TargetDate = cleanSSioVersion.TargetDate
                };
            }

            return AdminSSioVersion;
        }
        
        
        public static List<dc.SSioVersion> AdminCleanForGet(this IEnumerable<dc.SSioVersion> cleanSSioVersions)
        {
            return cleanSSioVersions.Select(SSioVersion => SSioVersion.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.SSioVersion AdminCleanForGet(this dc.SSioVersion cleanSSioVersion)
        {
            var AdminSSioVersion = default(dc.SSioVersion);

            if (!ReferenceEquals(cleanSSioVersion, null))
            {
                AdminSSioVersion = new dc.SSioVersion()
                {
                    SSioVersionId = cleanSSioVersion.SSioVersionId,
                    Name = cleanSSioVersion.Name,
                    Notes = cleanSSioVersion.Notes,
                    Attachments = cleanSSioVersion.Attachments,
                    Status = cleanSSioVersion.Status,
                    TargetDate = cleanSSioVersion.TargetDate
                };
            }

            return AdminSSioVersion;
        }
        
        
        public static dc.SSioVersion AdminCleanForUpdate(this dc.SSioVersion cleanSSioVersion)
        {
            var AdminSSioVersion = default(dc.SSioVersion);

            if (!ReferenceEquals(cleanSSioVersion, null))
            {
                AdminSSioVersion = new dc.SSioVersion()
                {
                    SSioVersionId = cleanSSioVersion.SSioVersionId,
                    Name = cleanSSioVersion.Name,
                    Notes = cleanSSioVersion.Notes,
                    Attachments = cleanSSioVersion.Attachments,
                    Status = cleanSSioVersion.Status,
                    TargetDate = cleanSSioVersion.TargetDate
                };
            }

            return AdminSSioVersion;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ProductVersion
        public static dc.ProductVersion AdminCleanForAdd(this dc.ProductVersion cleanProductVersion)
        {
            var AdminProductVersion = default(dc.ProductVersion);

            if (!ReferenceEquals(cleanProductVersion, null))
            {
                AdminProductVersion = new dc.ProductVersion()
                {
                    ProductVersionId = cleanProductVersion.ProductVersionId,
                    LicensedProduct = cleanProductVersion.LicensedProduct,
                    Description = cleanProductVersion.Description,
                    OverrideCreatedOn = cleanProductVersion.OverrideCreatedOn,
                    IsActive = cleanProductVersion.IsActive,
                    LambdaEndpoint = cleanProductVersion.LambdaEndpoint,
                    TranspilerVersionUUID = cleanProductVersion.TranspilerVersionUUID,
                    ProductUseRequests = cleanProductVersion.ProductUseRequests,
                    HeadVersion = cleanProductVersion.HeadVersion,
                    ProductVersionDescription = cleanProductVersion.ProductVersionDescription,
                    ProductVersionReadMeMD = cleanProductVersion.ProductVersionReadMeMD,
                    ProductVersionInputDescriptionMD = cleanProductVersion.ProductVersionInputDescriptionMD,
                    ProductVersionOutputDescriptionMD = cleanProductVersion.ProductVersionOutputDescriptionMD,
                    MonthlyProductUseRequests = cleanProductVersion.MonthlyProductUseRequests,
                    MonthlyProductUseRequestCount = cleanProductVersion.MonthlyProductUseRequestCount,
                    ActiveProductUseRequestCount = cleanProductVersion.ActiveProductUseRequestCount,
                    VersionNumber = cleanProductVersion.VersionNumber,
                    AWSLambdaVersion = cleanProductVersion.AWSLambdaVersion,
                    OverrideAWSLambdaArn = cleanProductVersion.OverrideAWSLambdaArn
                };
            }

            return AdminProductVersion;
        }
        
        
        public static List<dc.ProductVersion> AdminCleanForGet(this IEnumerable<dc.ProductVersion> cleanProductVersions)
        {
            return cleanProductVersions.Select(ProductVersion => ProductVersion.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductVersion AdminCleanForGet(this dc.ProductVersion cleanProductVersion)
        {
            var AdminProductVersion = default(dc.ProductVersion);

            if (!ReferenceEquals(cleanProductVersion, null))
            {
                AdminProductVersion = new dc.ProductVersion()
                {
                    ProductVersionId = cleanProductVersion.ProductVersionId,
                    Name = cleanProductVersion.Name,
                    LicensedProduct = cleanProductVersion.LicensedProduct,
                    Version = cleanProductVersion.Version,
                    Description = cleanProductVersion.Description,
                    OverrideCreatedOn = cleanProductVersion.OverrideCreatedOn,
                    IsActive = cleanProductVersion.IsActive,
                    AccountHolder = cleanProductVersion.AccountHolder,
                    LambdaEndpoint = cleanProductVersion.LambdaEndpoint,
                    LicensorEmailAddress = cleanProductVersion.LicensorEmailAddress,
                    TranspilerVersionUUID = cleanProductVersion.TranspilerVersionUUID,
                    ProductName = cleanProductVersion.ProductName,
                    AccountHolderIsVerified = cleanProductVersion.AccountHolderIsVerified,
                    ProductUseRequests = cleanProductVersion.ProductUseRequests,
                    HeadVersion = cleanProductVersion.HeadVersion,
                    ProductVersionCount = cleanProductVersion.ProductVersionCount,
                    LicensorScreenName = cleanProductVersion.LicensorScreenName,
                    CurrentProductDescription = cleanProductVersion.CurrentProductDescription,
                    ProductVersionDescription = cleanProductVersion.ProductVersionDescription,
                    CurrentProductReadMeMD = cleanProductVersion.CurrentProductReadMeMD,
                    ProductVersionReadMeMD = cleanProductVersion.ProductVersionReadMeMD,
                    ProductVersionInputDescriptionMD = cleanProductVersion.ProductVersionInputDescriptionMD,
                    ProductVersionOutputDescriptionMD = cleanProductVersion.ProductVersionOutputDescriptionMD,
                    ProductLowerName = cleanProductVersion.ProductLowerName,
                    ProductHyphenLowerName = cleanProductVersion.ProductHyphenLowerName,
                    ProductUpperName = cleanProductVersion.ProductUpperName,
                    RecordCreatedtime = cleanProductVersion.RecordCreatedtime,
                    CreatedOn = cleanProductVersion.CreatedOn,
                    MonthlyProductUseRequests = cleanProductVersion.MonthlyProductUseRequests,
                    MonthlyProductUseRequestCount = cleanProductVersion.MonthlyProductUseRequestCount,
                    ActiveProductUseRequestCount = cleanProductVersion.ActiveProductUseRequestCount,
                    ProductUseRequestCount = cleanProductVersion.ProductUseRequestCount,
                    IsRecentVersion = cleanProductVersion.IsRecentVersion,
                    VersionNumber = cleanProductVersion.VersionNumber,
                    PublishedVersion = cleanProductVersion.PublishedVersion,
                    DefaultAWSLambdaArn = cleanProductVersion.DefaultAWSLambdaArn,
                    AWSLambdaVersion = cleanProductVersion.AWSLambdaVersion,
                    LicensorAWSAccountId = cleanProductVersion.LicensorAWSAccountId,
                    LicensorAWSAPIGatewayId = cleanProductVersion.LicensorAWSAPIGatewayId,
                    LicensorAWSLambdaRegion = cleanProductVersion.LicensorAWSLambdaRegion,
                    ProductAWSLambdaFunctionName = cleanProductVersion.ProductAWSLambdaFunctionName,
                    OverrideAWSLambdaArn = cleanProductVersion.OverrideAWSLambdaArn,
                    AWSLambdaArn = cleanProductVersion.AWSLambdaArn
                };
            }

            return AdminProductVersion;
        }
        
        
        public static dc.ProductVersion AdminCleanForUpdate(this dc.ProductVersion cleanProductVersion)
        {
            var AdminProductVersion = default(dc.ProductVersion);

            if (!ReferenceEquals(cleanProductVersion, null))
            {
                AdminProductVersion = new dc.ProductVersion()
                {
                    ProductVersionId = cleanProductVersion.ProductVersionId,
                    LicensedProduct = cleanProductVersion.LicensedProduct,
                    Description = cleanProductVersion.Description,
                    OverrideCreatedOn = cleanProductVersion.OverrideCreatedOn,
                    IsActive = cleanProductVersion.IsActive,
                    LambdaEndpoint = cleanProductVersion.LambdaEndpoint,
                    TranspilerVersionUUID = cleanProductVersion.TranspilerVersionUUID,
                    ProductUseRequests = cleanProductVersion.ProductUseRequests,
                    HeadVersion = cleanProductVersion.HeadVersion,
                    ProductVersionDescription = cleanProductVersion.ProductVersionDescription,
                    ProductVersionReadMeMD = cleanProductVersion.ProductVersionReadMeMD,
                    ProductVersionInputDescriptionMD = cleanProductVersion.ProductVersionInputDescriptionMD,
                    ProductVersionOutputDescriptionMD = cleanProductVersion.ProductVersionOutputDescriptionMD,
                    MonthlyProductUseRequests = cleanProductVersion.MonthlyProductUseRequests,
                    MonthlyProductUseRequestCount = cleanProductVersion.MonthlyProductUseRequestCount,
                    ActiveProductUseRequestCount = cleanProductVersion.ActiveProductUseRequestCount,
                    VersionNumber = cleanProductVersion.VersionNumber,
                    AWSLambdaVersion = cleanProductVersion.AWSLambdaVersion,
                    OverrideAWSLambdaArn = cleanProductVersion.OverrideAWSLambdaArn
                };
            }

            return AdminProductVersion;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // UnitOfMeasurement
        public static dc.UnitOfMeasurement AdminCleanForAdd(this dc.UnitOfMeasurement cleanUnitOfMeasurement)
        {
            var AdminUnitOfMeasurement = default(dc.UnitOfMeasurement);

            if (!ReferenceEquals(cleanUnitOfMeasurement, null))
            {
                AdminUnitOfMeasurement = new dc.UnitOfMeasurement()
                {
                    UnitOfMeasurementId = cleanUnitOfMeasurement.UnitOfMeasurementId,
                    Notes = cleanUnitOfMeasurement.Notes,
                    Attachments = cleanUnitOfMeasurement.Attachments,
                    Status = cleanUnitOfMeasurement.Status,
                    NameSingular = cleanUnitOfMeasurement.NameSingular,
                    NamePlural = cleanUnitOfMeasurement.NamePlural,
                    CaseSensativeCode = cleanUnitOfMeasurement.CaseSensativeCode,
                    RelatedMeasurementUnit = cleanUnitOfMeasurement.RelatedMeasurementUnit,
                    RelatedTimeUnit = cleanUnitOfMeasurement.RelatedTimeUnit,
                    MeasurementType = cleanUnitOfMeasurement.MeasurementType,
                    LongCode = cleanUnitOfMeasurement.LongCode,
                    MeasurementValue = cleanUnitOfMeasurement.MeasurementValue,
                    BaseUnit = cleanUnitOfMeasurement.BaseUnit,
                    BaseUnitMultiplier = cleanUnitOfMeasurement.BaseUnitMultiplier,
                    SortOrder = cleanUnitOfMeasurement.SortOrder,
                    UnitConversions = cleanUnitOfMeasurement.UnitConversions,
                    UnitConversions2 = cleanUnitOfMeasurement.UnitConversions2,
                    LicenseMeters = cleanUnitOfMeasurement.LicenseMeters,
                    MeterTransactions = cleanUnitOfMeasurement.MeterTransactions
                };
            }

            return AdminUnitOfMeasurement;
        }
        
        
        public static List<dc.UnitOfMeasurement> AdminCleanForGet(this IEnumerable<dc.UnitOfMeasurement> cleanUnitOfMeasurements)
        {
            return cleanUnitOfMeasurements.Select(UnitOfMeasurement => UnitOfMeasurement.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.UnitOfMeasurement AdminCleanForGet(this dc.UnitOfMeasurement cleanUnitOfMeasurement)
        {
            var AdminUnitOfMeasurement = default(dc.UnitOfMeasurement);

            if (!ReferenceEquals(cleanUnitOfMeasurement, null))
            {
                AdminUnitOfMeasurement = new dc.UnitOfMeasurement()
                {
                    UnitOfMeasurementId = cleanUnitOfMeasurement.UnitOfMeasurementId,
                    Name = cleanUnitOfMeasurement.Name,
                    Notes = cleanUnitOfMeasurement.Notes,
                    Attachments = cleanUnitOfMeasurement.Attachments,
                    Status = cleanUnitOfMeasurement.Status,
                    MeasurementTypeName = cleanUnitOfMeasurement.MeasurementTypeName,
                    NameSingular = cleanUnitOfMeasurement.NameSingular,
                    NamePlural = cleanUnitOfMeasurement.NamePlural,
                    CaseSensativeCode = cleanUnitOfMeasurement.CaseSensativeCode,
                    RelatedMeasurementUnit = cleanUnitOfMeasurement.RelatedMeasurementUnit,
                    RelatedTimeUnit = cleanUnitOfMeasurement.RelatedTimeUnit,
                    RelatedMeasurementUnitLongCode = cleanUnitOfMeasurement.RelatedMeasurementUnitLongCode,
                    RelatedTimeUnitLongCode = cleanUnitOfMeasurement.RelatedTimeUnitLongCode,
                    INTERNAL_SuggestedCode = cleanUnitOfMeasurement.INTERNAL_SuggestedCode,
                    MeasurementType = cleanUnitOfMeasurement.MeasurementType,
                    LongCode = cleanUnitOfMeasurement.LongCode,
                    MeasurementValue = cleanUnitOfMeasurement.MeasurementValue,
                    BaseUnit = cleanUnitOfMeasurement.BaseUnit,
                    BaseUnitMultiplier = cleanUnitOfMeasurement.BaseUnitMultiplier,
                    SuggestedMeasurementValue = cleanUnitOfMeasurement.SuggestedMeasurementValue,
                    BaseUnitNamePlural = cleanUnitOfMeasurement.BaseUnitNamePlural,
                    SortOrder = cleanUnitOfMeasurement.SortOrder,
                    UnitConversions = cleanUnitOfMeasurement.UnitConversions,
                    UnitConversions2 = cleanUnitOfMeasurement.UnitConversions2,
                    LicenseMeters = cleanUnitOfMeasurement.LicenseMeters,
                    AddsMinutes = cleanUnitOfMeasurement.AddsMinutes,
                    AddsMonths = cleanUnitOfMeasurement.AddsMonths,
                    MeterTransactions = cleanUnitOfMeasurement.MeterTransactions
                };
            }

            return AdminUnitOfMeasurement;
        }
        
        
        public static dc.UnitOfMeasurement AdminCleanForUpdate(this dc.UnitOfMeasurement cleanUnitOfMeasurement)
        {
            var AdminUnitOfMeasurement = default(dc.UnitOfMeasurement);

            if (!ReferenceEquals(cleanUnitOfMeasurement, null))
            {
                AdminUnitOfMeasurement = new dc.UnitOfMeasurement()
                {
                    UnitOfMeasurementId = cleanUnitOfMeasurement.UnitOfMeasurementId,
                    Notes = cleanUnitOfMeasurement.Notes,
                    Attachments = cleanUnitOfMeasurement.Attachments,
                    Status = cleanUnitOfMeasurement.Status,
                    NameSingular = cleanUnitOfMeasurement.NameSingular,
                    NamePlural = cleanUnitOfMeasurement.NamePlural,
                    CaseSensativeCode = cleanUnitOfMeasurement.CaseSensativeCode,
                    RelatedMeasurementUnit = cleanUnitOfMeasurement.RelatedMeasurementUnit,
                    RelatedTimeUnit = cleanUnitOfMeasurement.RelatedTimeUnit,
                    MeasurementType = cleanUnitOfMeasurement.MeasurementType,
                    LongCode = cleanUnitOfMeasurement.LongCode,
                    MeasurementValue = cleanUnitOfMeasurement.MeasurementValue,
                    BaseUnit = cleanUnitOfMeasurement.BaseUnit,
                    BaseUnitMultiplier = cleanUnitOfMeasurement.BaseUnitMultiplier,
                    SortOrder = cleanUnitOfMeasurement.SortOrder,
                    UnitConversions = cleanUnitOfMeasurement.UnitConversions,
                    UnitConversions2 = cleanUnitOfMeasurement.UnitConversions2,
                    LicenseMeters = cleanUnitOfMeasurement.LicenseMeters,
                    MeterTransactions = cleanUnitOfMeasurement.MeterTransactions
                };
            }

            return AdminUnitOfMeasurement;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // ProductLicenseDMQueue
        public static dc.ProductLicenseDMQueue AdminCleanForAdd(this dc.ProductLicenseDMQueue cleanProductLicenseDMQueue)
        {
            var AdminProductLicenseDMQueue = default(dc.ProductLicenseDMQueue);

            if (!ReferenceEquals(cleanProductLicenseDMQueue, null))
            {
                AdminProductLicenseDMQueue = new dc.ProductLicenseDMQueue()
                {
                    ProductLicenseDMQueueId = cleanProductLicenseDMQueue.ProductLicenseDMQueueId,
                    Notes = cleanProductLicenseDMQueue.Notes,
                    Attachments = cleanProductLicenseDMQueue.Attachments,
                    Status = cleanProductLicenseDMQueue.Status,
                    DMQueueSubmitted = cleanProductLicenseDMQueue.DMQueueSubmitted,
                    TTL = cleanProductLicenseDMQueue.TTL,
                    ProductLicense = cleanProductLicenseDMQueue.ProductLicense
                };
            }

            return AdminProductLicenseDMQueue;
        }
        
        
        public static List<dc.ProductLicenseDMQueue> AdminCleanForGet(this IEnumerable<dc.ProductLicenseDMQueue> cleanProductLicenseDMQueues)
        {
            return cleanProductLicenseDMQueues.Select(ProductLicenseDMQueue => ProductLicenseDMQueue.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.ProductLicenseDMQueue AdminCleanForGet(this dc.ProductLicenseDMQueue cleanProductLicenseDMQueue)
        {
            var AdminProductLicenseDMQueue = default(dc.ProductLicenseDMQueue);

            if (!ReferenceEquals(cleanProductLicenseDMQueue, null))
            {
                AdminProductLicenseDMQueue = new dc.ProductLicenseDMQueue()
                {
                    ProductLicenseDMQueueId = cleanProductLicenseDMQueue.ProductLicenseDMQueueId,
                    Name = cleanProductLicenseDMQueue.Name,
                    Notes = cleanProductLicenseDMQueue.Notes,
                    Attachments = cleanProductLicenseDMQueue.Attachments,
                    Status = cleanProductLicenseDMQueue.Status,
                    CreatedTime = cleanProductLicenseDMQueue.CreatedTime,
                    DMQueueSubmitted = cleanProductLicenseDMQueue.DMQueueSubmitted,
                    TTL = cleanProductLicenseDMQueue.TTL,
                    QueueExpires = cleanProductLicenseDMQueue.QueueExpires,
                    DMQueue = cleanProductLicenseDMQueue.DMQueue,
                    ProductLicense = cleanProductLicenseDMQueue.ProductLicense
                };
            }

            return AdminProductLicenseDMQueue;
        }
        
        
        public static dc.ProductLicenseDMQueue AdminCleanForUpdate(this dc.ProductLicenseDMQueue cleanProductLicenseDMQueue)
        {
            var AdminProductLicenseDMQueue = default(dc.ProductLicenseDMQueue);

            if (!ReferenceEquals(cleanProductLicenseDMQueue, null))
            {
                AdminProductLicenseDMQueue = new dc.ProductLicenseDMQueue()
                {
                    ProductLicenseDMQueueId = cleanProductLicenseDMQueue.ProductLicenseDMQueueId,
                    Notes = cleanProductLicenseDMQueue.Notes,
                    Attachments = cleanProductLicenseDMQueue.Attachments,
                    Status = cleanProductLicenseDMQueue.Status,
                    DMQueueSubmitted = cleanProductLicenseDMQueue.DMQueueSubmitted,
                    TTL = cleanProductLicenseDMQueue.TTL,
                    ProductLicense = cleanProductLicenseDMQueue.ProductLicense
                };
            }

            return AdminProductLicenseDMQueue;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // MeasurementType
        public static dc.MeasurementType AdminCleanForAdd(this dc.MeasurementType cleanMeasurementType)
        {
            var AdminMeasurementType = default(dc.MeasurementType);

            if (!ReferenceEquals(cleanMeasurementType, null))
            {
                AdminMeasurementType = new dc.MeasurementType()
                {
                    MeasurementTypeId = cleanMeasurementType.MeasurementTypeId,
                    Name = cleanMeasurementType.Name,
                    UnitOfMeasurements = cleanMeasurementType.UnitOfMeasurements,
                    UnitOfMeasurementscopy = cleanMeasurementType.UnitOfMeasurementscopy,
                    AddsMinutes = cleanMeasurementType.AddsMinutes,
                    AddsMonths = cleanMeasurementType.AddsMonths
                };
            }

            return AdminMeasurementType;
        }
        
        
        public static List<dc.MeasurementType> AdminCleanForGet(this IEnumerable<dc.MeasurementType> cleanMeasurementTypes)
        {
            return cleanMeasurementTypes.Select(MeasurementType => MeasurementType.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.MeasurementType AdminCleanForGet(this dc.MeasurementType cleanMeasurementType)
        {
            var AdminMeasurementType = default(dc.MeasurementType);

            if (!ReferenceEquals(cleanMeasurementType, null))
            {
                AdminMeasurementType = new dc.MeasurementType()
                {
                    MeasurementTypeId = cleanMeasurementType.MeasurementTypeId,
                    Name = cleanMeasurementType.Name,
                    UnitOfMeasurements = cleanMeasurementType.UnitOfMeasurements,
                    UnitOfMeasurementscopy = cleanMeasurementType.UnitOfMeasurementscopy,
                    AddsMinutes = cleanMeasurementType.AddsMinutes,
                    AddsMonths = cleanMeasurementType.AddsMonths
                };
            }

            return AdminMeasurementType;
        }
        
        
        public static dc.MeasurementType AdminCleanForUpdate(this dc.MeasurementType cleanMeasurementType)
        {
            var AdminMeasurementType = default(dc.MeasurementType);

            if (!ReferenceEquals(cleanMeasurementType, null))
            {
                AdminMeasurementType = new dc.MeasurementType()
                {
                    MeasurementTypeId = cleanMeasurementType.MeasurementTypeId,
                    Name = cleanMeasurementType.Name,
                    UnitOfMeasurements = cleanMeasurementType.UnitOfMeasurements,
                    UnitOfMeasurementscopy = cleanMeasurementType.UnitOfMeasurementscopy,
                    AddsMinutes = cleanMeasurementType.AddsMinutes,
                    AddsMonths = cleanMeasurementType.AddsMonths
                };
            }

            return AdminMeasurementType;       }
        
        // Admin Cleaning Extension Methods.  -CRUD-
        
        // MonthlyProductUseRequest
        public static dc.MonthlyProductUseRequest AdminCleanForAdd(this dc.MonthlyProductUseRequest cleanMonthlyProductUseRequest)
        {
            var AdminMonthlyProductUseRequest = default(dc.MonthlyProductUseRequest);

            if (!ReferenceEquals(cleanMonthlyProductUseRequest, null))
            {
                AdminMonthlyProductUseRequest = new dc.MonthlyProductUseRequest()
                {
                    MonthlyProductUseRequestId = cleanMonthlyProductUseRequest.MonthlyProductUseRequestId,
                    AccountHolder = cleanMonthlyProductUseRequest.AccountHolder,
                    Licensee = cleanMonthlyProductUseRequest.Licensee,
                    ProductUseYear = cleanMonthlyProductUseRequest.ProductUseYear,
                    ProductUseMonth = cleanMonthlyProductUseRequest.ProductUseMonth,
                    ProductUseCount = cleanMonthlyProductUseRequest.ProductUseCount,
                    ProductVesion = cleanMonthlyProductUseRequest.ProductVesion
                };
            }

            return AdminMonthlyProductUseRequest;
        }
        
        
        public static List<dc.MonthlyProductUseRequest> AdminCleanForGet(this IEnumerable<dc.MonthlyProductUseRequest> cleanMonthlyProductUseRequests)
        {
            return cleanMonthlyProductUseRequests.Select(MonthlyProductUseRequest => MonthlyProductUseRequest.AdminCleanForGet())
                            .ToList();
        }
        
        public static dc.MonthlyProductUseRequest AdminCleanForGet(this dc.MonthlyProductUseRequest cleanMonthlyProductUseRequest)
        {
            var AdminMonthlyProductUseRequest = default(dc.MonthlyProductUseRequest);

            if (!ReferenceEquals(cleanMonthlyProductUseRequest, null))
            {
                AdminMonthlyProductUseRequest = new dc.MonthlyProductUseRequest()
                {
                    MonthlyProductUseRequestId = cleanMonthlyProductUseRequest.MonthlyProductUseRequestId,
                    Name = cleanMonthlyProductUseRequest.Name,
                    AccountHolder = cleanMonthlyProductUseRequest.AccountHolder,
                    Licensee = cleanMonthlyProductUseRequest.Licensee,
                    ProductUseYear = cleanMonthlyProductUseRequest.ProductUseYear,
                    ProductUseMonth = cleanMonthlyProductUseRequest.ProductUseMonth,
                    ProductUseCount = cleanMonthlyProductUseRequest.ProductUseCount,
                    ProductVersionName = cleanMonthlyProductUseRequest.ProductVersionName,
                    ProductVesion = cleanMonthlyProductUseRequest.ProductVesion,
                    ProductUseYearMonth = cleanMonthlyProductUseRequest.ProductUseYearMonth
                };
            }

            return AdminMonthlyProductUseRequest;
        }
        
        
        public static dc.MonthlyProductUseRequest AdminCleanForUpdate(this dc.MonthlyProductUseRequest cleanMonthlyProductUseRequest)
        {
            var AdminMonthlyProductUseRequest = default(dc.MonthlyProductUseRequest);

            if (!ReferenceEquals(cleanMonthlyProductUseRequest, null))
            {
                AdminMonthlyProductUseRequest = new dc.MonthlyProductUseRequest()
                {
                    MonthlyProductUseRequestId = cleanMonthlyProductUseRequest.MonthlyProductUseRequestId,
                    AccountHolder = cleanMonthlyProductUseRequest.AccountHolder,
                    Licensee = cleanMonthlyProductUseRequest.Licensee,
                    ProductUseYear = cleanMonthlyProductUseRequest.ProductUseYear,
                    ProductUseMonth = cleanMonthlyProductUseRequest.ProductUseMonth,
                    ProductUseCount = cleanMonthlyProductUseRequest.ProductUseCount,
                    ProductVesion = cleanMonthlyProductUseRequest.ProductVesion
                };
            }

            return AdminMonthlyProductUseRequest;       }
        
    
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
        // CRUDCoordinator Cleaning Extension Methods.  --
        
    
                        /*
                        */
    }
}