using System;
using System.Linq;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using System.Threading.Tasks;

namespace EffortlessAPI.SSio.SassyMQ
{
    public partial class SMQCRUDCoordinator : SMQActorBase
    {

        public SMQCRUDCoordinator(String amqpConnectionString)
            : base(amqpConnectionString, "crudcoordinator")
        {
        }

        protected override void CheckRouting(StandardPayload payload, BasicDeliverEventArgs  bdea)
        {
            var originalAccessToken = payload.AccessToken;
            try
            {
                switch (bdea.RoutingKey)
                {
                    
                    case "crudcoordinator.general.guest.requesttoken":
                        this.OnGuestRequestTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.guest.validatetemporaryaccesstoken":
                        this.OnGuestValidateTemporaryAccessTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.guest.whoami":
                        this.OnGuestWhoAmIReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.guest.whoareyou":
                        this.OnGuestWhoAreYouReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.utlity.guest.storetempfile":
                        this.OnGuestStoreTempFileReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.crudcoordinator.resetrabbitsassymqconfiguration":
                        this.OnCRUDCoordinatorResetRabbitSassyMQConfigurationReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.general.crudcoordinator.resetjwtsecretkey":
                        this.OnCRUDCoordinatorResetJWTSecretKeyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.guest.getbrands":
                        this.OnGuestGetBrandsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addbrand":
                        this.OnLicenseCoordinatorAddBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getbrands":
                        this.OnLicenseCoordinatorGetBrandsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatebrand":
                        this.OnLicenseCoordinatorUpdateBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletebrand":
                        this.OnLicenseCoordinatorDeleteBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.addbrand":
                        this.OnSSioUserAddBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getbrands":
                        this.OnSSioUserGetBrandsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.updatebrand":
                        this.OnSSioUserUpdateBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.deletebrand":
                        this.OnSSioUserDeleteBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addbrand":
                        this.OnAdminAddBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getbrands":
                        this.OnAdminGetBrandsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatebrand":
                        this.OnAdminUpdateBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletebrand":
                        this.OnAdminDeleteBrandReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.guest.getproductusestatuses":
                        this.OnGuestGetProductUseStatusesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addproductusestatus":
                        this.OnLicenseCoordinatorAddProductUseStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getproductusestatuses":
                        this.OnLicenseCoordinatorGetProductUseStatusesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateproductusestatus":
                        this.OnLicenseCoordinatorUpdateProductUseStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteproductusestatus":
                        this.OnLicenseCoordinatorDeleteProductUseStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addproductusestatus":
                        this.OnAdminAddProductUseStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getproductusestatuses":
                        this.OnAdminGetProductUseStatusesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateproductusestatus":
                        this.OnAdminUpdateProductUseStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteproductusestatus":
                        this.OnAdminDeleteProductUseStatusReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addclioption":
                        this.OnLicenseCoordinatorAddCLIOptionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getclioptions":
                        this.OnLicenseCoordinatorGetCLIOptionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateclioption":
                        this.OnLicenseCoordinatorUpdateCLIOptionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteclioption":
                        this.OnLicenseCoordinatorDeleteCLIOptionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addclioption":
                        this.OnAdminAddCLIOptionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getclioptions":
                        this.OnAdminGetCLIOptionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateclioption":
                        this.OnAdminUpdateCLIOptionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteclioption":
                        this.OnAdminDeleteCLIOptionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addunitconversion":
                        this.OnLicenseCoordinatorAddUnitConversionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getunitconversions":
                        this.OnLicenseCoordinatorGetUnitConversionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateunitconversion":
                        this.OnLicenseCoordinatorUpdateUnitConversionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteunitconversion":
                        this.OnLicenseCoordinatorDeleteUnitConversionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addunitconversion":
                        this.OnAdminAddUnitConversionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getunitconversions":
                        this.OnAdminGetUnitConversionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateunitconversion":
                        this.OnAdminUpdateUnitConversionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteunitconversion":
                        this.OnAdminDeleteUnitConversionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addinvoicelineitem":
                        this.OnLicenseCoordinatorAddInvoiceLineItemReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getinvoicelineitems":
                        this.OnLicenseCoordinatorGetInvoiceLineItemsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateinvoicelineitem":
                        this.OnLicenseCoordinatorUpdateInvoiceLineItemReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteinvoicelineitem":
                        this.OnLicenseCoordinatorDeleteInvoiceLineItemReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getinvoicelineitems":
                        this.OnSSioUserGetInvoiceLineItemsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addinvoicelineitem":
                        this.OnAdminAddInvoiceLineItemReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getinvoicelineitems":
                        this.OnAdminGetInvoiceLineItemsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateinvoicelineitem":
                        this.OnAdminUpdateInvoiceLineItemReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteinvoicelineitem":
                        this.OnAdminDeleteInvoiceLineItemReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.guest.getssiotechnologies":
                        this.OnGuestGetSSioTechnologiesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addssiotechnology":
                        this.OnLicenseCoordinatorAddSSioTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getssiotechnologies":
                        this.OnLicenseCoordinatorGetSSioTechnologiesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatessiotechnology":
                        this.OnLicenseCoordinatorUpdateSSioTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletessiotechnology":
                        this.OnLicenseCoordinatorDeleteSSioTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addssiotechnology":
                        this.OnAdminAddSSioTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getssiotechnologies":
                        this.OnAdminGetSSioTechnologiesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatessiotechnology":
                        this.OnAdminUpdateSSioTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletessiotechnology":
                        this.OnAdminDeleteSSioTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addssiouser":
                        this.OnLicenseCoordinatorAddSSioUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getssiousers":
                        this.OnLicenseCoordinatorGetSSioUsersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatessiouser":
                        this.OnLicenseCoordinatorUpdateSSioUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletessiouser":
                        this.OnLicenseCoordinatorDeleteSSioUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addssiouser":
                        this.OnAdminAddSSioUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getssiousers":
                        this.OnAdminGetSSioUsersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatessiouser":
                        this.OnAdminUpdateSSioUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletessiouser":
                        this.OnAdminDeleteSSioUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addmicroservicecandidate":
                        this.OnLicenseCoordinatorAddMicroServiceCandidateReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getmicroservicecandidates":
                        this.OnLicenseCoordinatorGetMicroServiceCandidatesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatemicroservicecandidate":
                        this.OnLicenseCoordinatorUpdateMicroServiceCandidateReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletemicroservicecandidate":
                        this.OnLicenseCoordinatorDeleteMicroServiceCandidateReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addmicroservicecandidate":
                        this.OnAdminAddMicroServiceCandidateReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getmicroservicecandidates":
                        this.OnAdminGetMicroServiceCandidatesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatemicroservicecandidate":
                        this.OnAdminUpdateMicroServiceCandidateReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletemicroservicecandidate":
                        this.OnAdminDeleteMicroServiceCandidateReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addlicensedproduct":
                        this.OnLicenseCoordinatorAddLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getlicensedproducts":
                        this.OnLicenseCoordinatorGetLicensedProductsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatelicensedproduct":
                        this.OnLicenseCoordinatorUpdateLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletelicensedproduct":
                        this.OnLicenseCoordinatorDeleteLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.addlicensedproduct":
                        this.OnSSioUserAddLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getlicensedproducts":
                        this.OnSSioUserGetLicensedProductsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.updatelicensedproduct":
                        this.OnSSioUserUpdateLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.deletelicensedproduct":
                        this.OnSSioUserDeleteLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addlicensedproduct":
                        this.OnAdminAddLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getlicensedproducts":
                        this.OnAdminGetLicensedProductsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatelicensedproduct":
                        this.OnAdminUpdateLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletelicensedproduct":
                        this.OnAdminDeleteLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addlimitedusetoken":
                        this.OnLicenseCoordinatorAddLimitedUseTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getlimitedusetokens":
                        this.OnLicenseCoordinatorGetLimitedUseTokensReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatelimitedusetoken":
                        this.OnLicenseCoordinatorUpdateLimitedUseTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletelimitedusetoken":
                        this.OnLicenseCoordinatorDeleteLimitedUseTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addlimitedusetoken":
                        this.OnAdminAddLimitedUseTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getlimitedusetokens":
                        this.OnAdminGetLimitedUseTokensReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatelimitedusetoken":
                        this.OnAdminUpdateLimitedUseTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletelimitedusetoken":
                        this.OnAdminDeleteLimitedUseTokenReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addopenissue":
                        this.OnLicenseCoordinatorAddOpenIssueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getopenissues":
                        this.OnLicenseCoordinatorGetOpenIssuesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateopenissue":
                        this.OnLicenseCoordinatorUpdateOpenIssueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteopenissue":
                        this.OnLicenseCoordinatorDeleteOpenIssueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addopenissue":
                        this.OnAdminAddOpenIssueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getopenissues":
                        this.OnAdminGetOpenIssuesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateopenissue":
                        this.OnAdminUpdateOpenIssueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteopenissue":
                        this.OnAdminDeleteOpenIssueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addskumeteradjustment":
                        this.OnLicenseCoordinatorAddSKUMeterAdjustmentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getskumeteradjustments":
                        this.OnLicenseCoordinatorGetSKUMeterAdjustmentsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateskumeteradjustment":
                        this.OnLicenseCoordinatorUpdateSKUMeterAdjustmentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteskumeteradjustment":
                        this.OnLicenseCoordinatorDeleteSKUMeterAdjustmentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addskumeteradjustment":
                        this.OnAdminAddSKUMeterAdjustmentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getskumeteradjustments":
                        this.OnAdminGetSKUMeterAdjustmentsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateskumeteradjustment":
                        this.OnAdminUpdateSKUMeterAdjustmentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteskumeteradjustment":
                        this.OnAdminDeleteSKUMeterAdjustmentReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addproductlicensemeter":
                        this.OnLicenseCoordinatorAddProductLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getproductlicensemeters":
                        this.OnLicenseCoordinatorGetProductLicenseMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateproductlicensemeter":
                        this.OnLicenseCoordinatorUpdateProductLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteproductlicensemeter":
                        this.OnLicenseCoordinatorDeleteProductLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getproductlicensemeters":
                        this.OnSSioUserGetProductLicenseMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addproductlicensemeter":
                        this.OnAdminAddProductLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getproductlicensemeters":
                        this.OnAdminGetProductLicenseMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateproductlicensemeter":
                        this.OnAdminUpdateProductLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteproductlicensemeter":
                        this.OnAdminDeleteProductLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.guest.getlicensemeters":
                        this.OnGuestGetLicenseMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addlicensemeter":
                        this.OnLicenseCoordinatorAddLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getlicensemeters":
                        this.OnLicenseCoordinatorGetLicenseMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatelicensemeter":
                        this.OnLicenseCoordinatorUpdateLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletelicensemeter":
                        this.OnLicenseCoordinatorDeleteLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.addlicensemeter":
                        this.OnSSioUserAddLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getlicensemeters":
                        this.OnSSioUserGetLicenseMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.updatelicensemeter":
                        this.OnSSioUserUpdateLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.deletelicensemeter":
                        this.OnSSioUserDeleteLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addlicensemeter":
                        this.OnAdminAddLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getlicensemeters":
                        this.OnAdminGetLicenseMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatelicensemeter":
                        this.OnAdminUpdateLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletelicensemeter":
                        this.OnAdminDeleteLicenseMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addinvoice":
                        this.OnLicenseCoordinatorAddInvoiceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getinvoices":
                        this.OnLicenseCoordinatorGetInvoicesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateinvoice":
                        this.OnLicenseCoordinatorUpdateInvoiceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteinvoice":
                        this.OnLicenseCoordinatorDeleteInvoiceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getinvoices":
                        this.OnSSioUserGetInvoicesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addinvoice":
                        this.OnAdminAddInvoiceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getinvoices":
                        this.OnAdminGetInvoicesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateinvoice":
                        this.OnAdminUpdateInvoiceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteinvoice":
                        this.OnAdminDeleteInvoiceReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.guest.getbrandlicenses":
                        this.OnGuestGetBrandLicensesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addbrandlicense":
                        this.OnLicenseCoordinatorAddBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getbrandlicenses":
                        this.OnLicenseCoordinatorGetBrandLicensesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatebrandlicense":
                        this.OnLicenseCoordinatorUpdateBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletebrandlicense":
                        this.OnLicenseCoordinatorDeleteBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.addbrandlicense":
                        this.OnSSioUserAddBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getbrandlicenses":
                        this.OnSSioUserGetBrandLicensesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.updatebrandlicense":
                        this.OnSSioUserUpdateBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.deletebrandlicense":
                        this.OnSSioUserDeleteBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addbrandlicense":
                        this.OnAdminAddBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getbrandlicenses":
                        this.OnAdminGetBrandLicensesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatebrandlicense":
                        this.OnAdminUpdateBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletebrandlicense":
                        this.OnAdminDeleteBrandLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addproductuserequest":
                        this.OnLicenseCoordinatorAddProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getproductuserequests":
                        this.OnLicenseCoordinatorGetProductUseRequestsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateproductuserequest":
                        this.OnLicenseCoordinatorUpdateProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteproductuserequest":
                        this.OnLicenseCoordinatorDeleteProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addproductuserequest":
                        this.OnAdminAddProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getproductuserequests":
                        this.OnAdminGetProductUseRequestsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateproductuserequest":
                        this.OnAdminUpdateProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteproductuserequest":
                        this.OnAdminDeleteProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addlicensetype":
                        this.OnLicenseCoordinatorAddLicenseTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getlicensetypes":
                        this.OnLicenseCoordinatorGetLicenseTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatelicensetype":
                        this.OnLicenseCoordinatorUpdateLicenseTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletelicensetype":
                        this.OnLicenseCoordinatorDeleteLicenseTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addlicensetype":
                        this.OnAdminAddLicenseTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getlicensetypes":
                        this.OnAdminGetLicenseTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatelicensetype":
                        this.OnAdminUpdateLicenseTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletelicensetype":
                        this.OnAdminDeleteLicenseTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addmetertransaction":
                        this.OnLicenseCoordinatorAddMeterTransactionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getmetertransactions":
                        this.OnLicenseCoordinatorGetMeterTransactionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatemetertransaction":
                        this.OnLicenseCoordinatorUpdateMeterTransactionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletemetertransaction":
                        this.OnLicenseCoordinatorDeleteMeterTransactionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addmetertransaction":
                        this.OnAdminAddMeterTransactionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getmetertransactions":
                        this.OnAdminGetMeterTransactionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatemetertransaction":
                        this.OnAdminUpdateMeterTransactionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletemetertransaction":
                        this.OnAdminDeleteMeterTransactionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.guest.getlicenseskus":
                        this.OnGuestGetLicenseSKUsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addlicensesku":
                        this.OnLicenseCoordinatorAddLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getlicenseskus":
                        this.OnLicenseCoordinatorGetLicenseSKUsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatelicensesku":
                        this.OnLicenseCoordinatorUpdateLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletelicensesku":
                        this.OnLicenseCoordinatorDeleteLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.addlicensesku":
                        this.OnSSioUserAddLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getlicenseskus":
                        this.OnSSioUserGetLicenseSKUsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.updatelicensesku":
                        this.OnSSioUserUpdateLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.deletelicensesku":
                        this.OnSSioUserDeleteLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addlicensesku":
                        this.OnAdminAddLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getlicenseskus":
                        this.OnAdminGetLicenseSKUsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatelicensesku":
                        this.OnAdminUpdateLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletelicensesku":
                        this.OnAdminDeleteLicenseSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addssioversion":
                        this.OnLicenseCoordinatorAddSSioVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getssioversions":
                        this.OnLicenseCoordinatorGetSSioVersionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatessioversion":
                        this.OnLicenseCoordinatorUpdateSSioVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletessioversion":
                        this.OnLicenseCoordinatorDeleteSSioVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addssioversion":
                        this.OnAdminAddSSioVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getssioversions":
                        this.OnAdminGetSSioVersionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatessioversion":
                        this.OnAdminUpdateSSioVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletessioversion":
                        this.OnAdminDeleteSSioVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addproductlicense":
                        this.OnLicenseCoordinatorAddProductLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getproductlicenses":
                        this.OnLicenseCoordinatorGetProductLicensesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateproductlicense":
                        this.OnLicenseCoordinatorUpdateProductLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteproductlicense":
                        this.OnLicenseCoordinatorDeleteProductLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.ssiouser.getproductlicenses":
                        this.OnSSioUserGetProductLicensesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addproductlicense":
                        this.OnAdminAddProductLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getproductlicenses":
                        this.OnAdminGetProductLicensesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateproductlicense":
                        this.OnAdminUpdateProductLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteproductlicense":
                        this.OnAdminDeleteProductLicenseReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addproductversion":
                        this.OnLicenseCoordinatorAddProductVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getproductversions":
                        this.OnLicenseCoordinatorGetProductVersionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateproductversion":
                        this.OnLicenseCoordinatorUpdateProductVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteproductversion":
                        this.OnLicenseCoordinatorDeleteProductVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addproductversion":
                        this.OnAdminAddProductVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getproductversions":
                        this.OnAdminGetProductVersionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateproductversion":
                        this.OnAdminUpdateProductVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteproductversion":
                        this.OnAdminDeleteProductVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addunitofmeasurement":
                        this.OnLicenseCoordinatorAddUnitOfMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getunitofmeasurements":
                        this.OnLicenseCoordinatorGetUnitOfMeasurementsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateunitofmeasurement":
                        this.OnLicenseCoordinatorUpdateUnitOfMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteunitofmeasurement":
                        this.OnLicenseCoordinatorDeleteUnitOfMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addunitofmeasurement":
                        this.OnAdminAddUnitOfMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getunitofmeasurements":
                        this.OnAdminGetUnitOfMeasurementsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateunitofmeasurement":
                        this.OnAdminUpdateUnitOfMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteunitofmeasurement":
                        this.OnAdminDeleteUnitOfMeasurementReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addproductlicensedmqueue":
                        this.OnLicenseCoordinatorAddProductLicenseDMQueueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getproductlicensedmqueues":
                        this.OnLicenseCoordinatorGetProductLicenseDMQueuesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateproductlicensedmqueue":
                        this.OnLicenseCoordinatorUpdateProductLicenseDMQueueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteproductlicensedmqueue":
                        this.OnLicenseCoordinatorDeleteProductLicenseDMQueueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addproductlicensedmqueue":
                        this.OnAdminAddProductLicenseDMQueueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getproductlicensedmqueues":
                        this.OnAdminGetProductLicenseDMQueuesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateproductlicensedmqueue":
                        this.OnAdminUpdateProductLicenseDMQueueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteproductlicensedmqueue":
                        this.OnAdminDeleteProductLicenseDMQueueReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addmeasurementtype":
                        this.OnLicenseCoordinatorAddMeasurementTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getmeasurementtypes":
                        this.OnLicenseCoordinatorGetMeasurementTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatemeasurementtype":
                        this.OnLicenseCoordinatorUpdateMeasurementTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletemeasurementtype":
                        this.OnLicenseCoordinatorDeleteMeasurementTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addmeasurementtype":
                        this.OnAdminAddMeasurementTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getmeasurementtypes":
                        this.OnAdminGetMeasurementTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatemeasurementtype":
                        this.OnAdminUpdateMeasurementTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletemeasurementtype":
                        this.OnAdminDeleteMeasurementTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addmonthlyproductuserequest":
                        this.OnLicenseCoordinatorAddMonthlyProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getmonthlyproductuserequests":
                        this.OnLicenseCoordinatorGetMonthlyProductUseRequestsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatemonthlyproductuserequest":
                        this.OnLicenseCoordinatorUpdateMonthlyProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletemonthlyproductuserequest":
                        this.OnLicenseCoordinatorDeleteMonthlyProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addmonthlyproductuserequest":
                        this.OnAdminAddMonthlyProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getmonthlyproductuserequests":
                        this.OnAdminGetMonthlyProductUseRequestsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatemonthlyproductuserequest":
                        this.OnAdminUpdateMonthlyProductUseRequestReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletemonthlyproductuserequest":
                        this.OnAdminDeleteMonthlyProductUseRequestReceived(payload, bdea);
                        break;
                    
                }

            }
            catch (Exception ex)
            {
                payload.ErrorMessage = ex.Message;
            }
            if (payload.AccessToken == originalAccessToken) payload.AccessToken = null;            
            this.Reply(payload, bdea.BasicProperties);
        }

        
        /// <summary>
        /// Responds to: RequestToken from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestRequestTokenReceived;
        protected virtual void OnGuestRequestTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestRequestTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestRequestTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: ValidateTemporaryAccessToken from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestValidateTemporaryAccessTokenReceived;
        protected virtual void OnGuestValidateTemporaryAccessTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestValidateTemporaryAccessTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestValidateTemporaryAccessTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: WhoAmI from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestWhoAmIReceived;
        protected virtual void OnGuestWhoAmIReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestWhoAmIReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestWhoAmIReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: WhoAreYou from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestWhoAreYouReceived;
        protected virtual void OnGuestWhoAreYouReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestWhoAreYouReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestWhoAreYouReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: StoreTempFile from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestStoreTempFileReceived;
        protected virtual void OnGuestStoreTempFileReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestStoreTempFileReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestStoreTempFileReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: ResetRabbitSassyMQConfiguration from CRUDCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> CRUDCoordinatorResetRabbitSassyMQConfigurationReceived;
        protected virtual void OnCRUDCoordinatorResetRabbitSassyMQConfigurationReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.CRUDCoordinatorResetRabbitSassyMQConfigurationReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.CRUDCoordinatorResetRabbitSassyMQConfigurationReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: ResetJWTSecretKey from CRUDCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> CRUDCoordinatorResetJWTSecretKeyReceived;
        protected virtual void OnCRUDCoordinatorResetJWTSecretKeyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.CRUDCoordinatorResetJWTSecretKeyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.CRUDCoordinatorResetJWTSecretKeyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBrands from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetBrandsReceived;
        protected virtual void OnGuestGetBrandsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetBrandsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetBrandsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBrand from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddBrandReceived;
        protected virtual void OnLicenseCoordinatorAddBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBrands from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetBrandsReceived;
        protected virtual void OnLicenseCoordinatorGetBrandsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetBrandsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetBrandsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBrand from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateBrandReceived;
        protected virtual void OnLicenseCoordinatorUpdateBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBrand from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteBrandReceived;
        protected virtual void OnLicenseCoordinatorDeleteBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBrand from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserAddBrandReceived;
        protected virtual void OnSSioUserAddBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserAddBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserAddBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBrands from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetBrandsReceived;
        protected virtual void OnSSioUserGetBrandsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetBrandsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetBrandsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBrand from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserUpdateBrandReceived;
        protected virtual void OnSSioUserUpdateBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserUpdateBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserUpdateBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBrand from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserDeleteBrandReceived;
        protected virtual void OnSSioUserDeleteBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserDeleteBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserDeleteBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBrand from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddBrandReceived;
        protected virtual void OnAdminAddBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBrands from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetBrandsReceived;
        protected virtual void OnAdminGetBrandsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetBrandsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetBrandsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBrand from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateBrandReceived;
        protected virtual void OnAdminUpdateBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBrand from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteBrandReceived;
        protected virtual void OnAdminDeleteBrandReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteBrandReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteBrandReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductUseStatuses from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetProductUseStatusesReceived;
        protected virtual void OnGuestGetProductUseStatusesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetProductUseStatusesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetProductUseStatusesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductUseStatus from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddProductUseStatusReceived;
        protected virtual void OnLicenseCoordinatorAddProductUseStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddProductUseStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddProductUseStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductUseStatuses from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetProductUseStatusesReceived;
        protected virtual void OnLicenseCoordinatorGetProductUseStatusesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetProductUseStatusesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetProductUseStatusesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductUseStatus from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateProductUseStatusReceived;
        protected virtual void OnLicenseCoordinatorUpdateProductUseStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateProductUseStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateProductUseStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductUseStatus from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteProductUseStatusReceived;
        protected virtual void OnLicenseCoordinatorDeleteProductUseStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteProductUseStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteProductUseStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductUseStatus from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddProductUseStatusReceived;
        protected virtual void OnAdminAddProductUseStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddProductUseStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddProductUseStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductUseStatuses from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetProductUseStatusesReceived;
        protected virtual void OnAdminGetProductUseStatusesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetProductUseStatusesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetProductUseStatusesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductUseStatus from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateProductUseStatusReceived;
        protected virtual void OnAdminUpdateProductUseStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateProductUseStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateProductUseStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductUseStatus from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteProductUseStatusReceived;
        protected virtual void OnAdminDeleteProductUseStatusReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteProductUseStatusReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteProductUseStatusReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddCLIOption from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddCLIOptionReceived;
        protected virtual void OnLicenseCoordinatorAddCLIOptionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddCLIOptionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddCLIOptionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetCLIOptions from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetCLIOptionsReceived;
        protected virtual void OnLicenseCoordinatorGetCLIOptionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetCLIOptionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetCLIOptionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateCLIOption from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateCLIOptionReceived;
        protected virtual void OnLicenseCoordinatorUpdateCLIOptionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateCLIOptionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateCLIOptionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteCLIOption from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteCLIOptionReceived;
        protected virtual void OnLicenseCoordinatorDeleteCLIOptionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteCLIOptionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteCLIOptionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddCLIOption from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddCLIOptionReceived;
        protected virtual void OnAdminAddCLIOptionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddCLIOptionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddCLIOptionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetCLIOptions from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetCLIOptionsReceived;
        protected virtual void OnAdminGetCLIOptionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetCLIOptionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetCLIOptionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateCLIOption from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateCLIOptionReceived;
        protected virtual void OnAdminUpdateCLIOptionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateCLIOptionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateCLIOptionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteCLIOption from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteCLIOptionReceived;
        protected virtual void OnAdminDeleteCLIOptionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteCLIOptionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteCLIOptionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddUnitConversion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddUnitConversionReceived;
        protected virtual void OnLicenseCoordinatorAddUnitConversionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddUnitConversionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddUnitConversionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetUnitConversions from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetUnitConversionsReceived;
        protected virtual void OnLicenseCoordinatorGetUnitConversionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetUnitConversionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetUnitConversionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateUnitConversion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateUnitConversionReceived;
        protected virtual void OnLicenseCoordinatorUpdateUnitConversionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateUnitConversionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateUnitConversionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteUnitConversion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteUnitConversionReceived;
        protected virtual void OnLicenseCoordinatorDeleteUnitConversionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteUnitConversionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteUnitConversionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddUnitConversion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddUnitConversionReceived;
        protected virtual void OnAdminAddUnitConversionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddUnitConversionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddUnitConversionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetUnitConversions from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetUnitConversionsReceived;
        protected virtual void OnAdminGetUnitConversionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetUnitConversionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetUnitConversionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateUnitConversion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateUnitConversionReceived;
        protected virtual void OnAdminUpdateUnitConversionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateUnitConversionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateUnitConversionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteUnitConversion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteUnitConversionReceived;
        protected virtual void OnAdminDeleteUnitConversionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteUnitConversionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteUnitConversionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddInvoiceLineItem from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddInvoiceLineItemReceived;
        protected virtual void OnLicenseCoordinatorAddInvoiceLineItemReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddInvoiceLineItemReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddInvoiceLineItemReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetInvoiceLineItems from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetInvoiceLineItemsReceived;
        protected virtual void OnLicenseCoordinatorGetInvoiceLineItemsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetInvoiceLineItemsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetInvoiceLineItemsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateInvoiceLineItem from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateInvoiceLineItemReceived;
        protected virtual void OnLicenseCoordinatorUpdateInvoiceLineItemReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateInvoiceLineItemReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateInvoiceLineItemReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteInvoiceLineItem from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteInvoiceLineItemReceived;
        protected virtual void OnLicenseCoordinatorDeleteInvoiceLineItemReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteInvoiceLineItemReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteInvoiceLineItemReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetInvoiceLineItems from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetInvoiceLineItemsReceived;
        protected virtual void OnSSioUserGetInvoiceLineItemsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetInvoiceLineItemsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetInvoiceLineItemsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddInvoiceLineItem from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddInvoiceLineItemReceived;
        protected virtual void OnAdminAddInvoiceLineItemReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddInvoiceLineItemReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddInvoiceLineItemReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetInvoiceLineItems from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetInvoiceLineItemsReceived;
        protected virtual void OnAdminGetInvoiceLineItemsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetInvoiceLineItemsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetInvoiceLineItemsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateInvoiceLineItem from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateInvoiceLineItemReceived;
        protected virtual void OnAdminUpdateInvoiceLineItemReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateInvoiceLineItemReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateInvoiceLineItemReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteInvoiceLineItem from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteInvoiceLineItemReceived;
        protected virtual void OnAdminDeleteInvoiceLineItemReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteInvoiceLineItemReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteInvoiceLineItemReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSSioTechnologies from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetSSioTechnologiesReceived;
        protected virtual void OnGuestGetSSioTechnologiesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetSSioTechnologiesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetSSioTechnologiesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSSioTechnology from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddSSioTechnologyReceived;
        protected virtual void OnLicenseCoordinatorAddSSioTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddSSioTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddSSioTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSSioTechnologies from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetSSioTechnologiesReceived;
        protected virtual void OnLicenseCoordinatorGetSSioTechnologiesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetSSioTechnologiesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetSSioTechnologiesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSSioTechnology from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateSSioTechnologyReceived;
        protected virtual void OnLicenseCoordinatorUpdateSSioTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateSSioTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateSSioTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSSioTechnology from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteSSioTechnologyReceived;
        protected virtual void OnLicenseCoordinatorDeleteSSioTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteSSioTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteSSioTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSSioTechnology from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddSSioTechnologyReceived;
        protected virtual void OnAdminAddSSioTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddSSioTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddSSioTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSSioTechnologies from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetSSioTechnologiesReceived;
        protected virtual void OnAdminGetSSioTechnologiesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetSSioTechnologiesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetSSioTechnologiesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSSioTechnology from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateSSioTechnologyReceived;
        protected virtual void OnAdminUpdateSSioTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateSSioTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateSSioTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSSioTechnology from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteSSioTechnologyReceived;
        protected virtual void OnAdminDeleteSSioTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteSSioTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteSSioTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSSioUser from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddSSioUserReceived;
        protected virtual void OnLicenseCoordinatorAddSSioUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddSSioUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddSSioUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSSioUsers from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetSSioUsersReceived;
        protected virtual void OnLicenseCoordinatorGetSSioUsersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetSSioUsersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetSSioUsersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSSioUser from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateSSioUserReceived;
        protected virtual void OnLicenseCoordinatorUpdateSSioUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateSSioUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateSSioUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSSioUser from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteSSioUserReceived;
        protected virtual void OnLicenseCoordinatorDeleteSSioUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteSSioUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteSSioUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSSioUser from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddSSioUserReceived;
        protected virtual void OnAdminAddSSioUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddSSioUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddSSioUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSSioUsers from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetSSioUsersReceived;
        protected virtual void OnAdminGetSSioUsersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetSSioUsersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetSSioUsersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSSioUser from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateSSioUserReceived;
        protected virtual void OnAdminUpdateSSioUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateSSioUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateSSioUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSSioUser from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteSSioUserReceived;
        protected virtual void OnAdminDeleteSSioUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteSSioUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteSSioUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMicroServiceCandidate from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddMicroServiceCandidateReceived;
        protected virtual void OnLicenseCoordinatorAddMicroServiceCandidateReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddMicroServiceCandidateReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddMicroServiceCandidateReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMicroServiceCandidates from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetMicroServiceCandidatesReceived;
        protected virtual void OnLicenseCoordinatorGetMicroServiceCandidatesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetMicroServiceCandidatesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetMicroServiceCandidatesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMicroServiceCandidate from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateMicroServiceCandidateReceived;
        protected virtual void OnLicenseCoordinatorUpdateMicroServiceCandidateReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateMicroServiceCandidateReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateMicroServiceCandidateReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMicroServiceCandidate from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteMicroServiceCandidateReceived;
        protected virtual void OnLicenseCoordinatorDeleteMicroServiceCandidateReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteMicroServiceCandidateReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteMicroServiceCandidateReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMicroServiceCandidate from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMicroServiceCandidateReceived;
        protected virtual void OnAdminAddMicroServiceCandidateReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMicroServiceCandidateReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMicroServiceCandidateReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMicroServiceCandidates from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMicroServiceCandidatesReceived;
        protected virtual void OnAdminGetMicroServiceCandidatesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMicroServiceCandidatesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMicroServiceCandidatesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMicroServiceCandidate from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMicroServiceCandidateReceived;
        protected virtual void OnAdminUpdateMicroServiceCandidateReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMicroServiceCandidateReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMicroServiceCandidateReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMicroServiceCandidate from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMicroServiceCandidateReceived;
        protected virtual void OnAdminDeleteMicroServiceCandidateReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMicroServiceCandidateReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMicroServiceCandidateReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicensedProduct from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddLicensedProductReceived;
        protected virtual void OnLicenseCoordinatorAddLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicensedProducts from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetLicensedProductsReceived;
        protected virtual void OnLicenseCoordinatorGetLicensedProductsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetLicensedProductsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetLicensedProductsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicensedProduct from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateLicensedProductReceived;
        protected virtual void OnLicenseCoordinatorUpdateLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicensedProduct from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteLicensedProductReceived;
        protected virtual void OnLicenseCoordinatorDeleteLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicensedProduct from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserAddLicensedProductReceived;
        protected virtual void OnSSioUserAddLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserAddLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserAddLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicensedProducts from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetLicensedProductsReceived;
        protected virtual void OnSSioUserGetLicensedProductsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetLicensedProductsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetLicensedProductsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicensedProduct from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserUpdateLicensedProductReceived;
        protected virtual void OnSSioUserUpdateLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserUpdateLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserUpdateLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicensedProduct from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserDeleteLicensedProductReceived;
        protected virtual void OnSSioUserDeleteLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserDeleteLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserDeleteLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicensedProduct from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddLicensedProductReceived;
        protected virtual void OnAdminAddLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicensedProducts from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetLicensedProductsReceived;
        protected virtual void OnAdminGetLicensedProductsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetLicensedProductsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetLicensedProductsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicensedProduct from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateLicensedProductReceived;
        protected virtual void OnAdminUpdateLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicensedProduct from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteLicensedProductReceived;
        protected virtual void OnAdminDeleteLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLimitedUseToken from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddLimitedUseTokenReceived;
        protected virtual void OnLicenseCoordinatorAddLimitedUseTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddLimitedUseTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddLimitedUseTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLimitedUseTokens from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetLimitedUseTokensReceived;
        protected virtual void OnLicenseCoordinatorGetLimitedUseTokensReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetLimitedUseTokensReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetLimitedUseTokensReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLimitedUseToken from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateLimitedUseTokenReceived;
        protected virtual void OnLicenseCoordinatorUpdateLimitedUseTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateLimitedUseTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateLimitedUseTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLimitedUseToken from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteLimitedUseTokenReceived;
        protected virtual void OnLicenseCoordinatorDeleteLimitedUseTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteLimitedUseTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteLimitedUseTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLimitedUseToken from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddLimitedUseTokenReceived;
        protected virtual void OnAdminAddLimitedUseTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddLimitedUseTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddLimitedUseTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLimitedUseTokens from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetLimitedUseTokensReceived;
        protected virtual void OnAdminGetLimitedUseTokensReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetLimitedUseTokensReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetLimitedUseTokensReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLimitedUseToken from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateLimitedUseTokenReceived;
        protected virtual void OnAdminUpdateLimitedUseTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateLimitedUseTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateLimitedUseTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLimitedUseToken from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteLimitedUseTokenReceived;
        protected virtual void OnAdminDeleteLimitedUseTokenReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteLimitedUseTokenReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteLimitedUseTokenReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddOpenIssue from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddOpenIssueReceived;
        protected virtual void OnLicenseCoordinatorAddOpenIssueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddOpenIssueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddOpenIssueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetOpenIssues from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetOpenIssuesReceived;
        protected virtual void OnLicenseCoordinatorGetOpenIssuesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetOpenIssuesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetOpenIssuesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateOpenIssue from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateOpenIssueReceived;
        protected virtual void OnLicenseCoordinatorUpdateOpenIssueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateOpenIssueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateOpenIssueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteOpenIssue from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteOpenIssueReceived;
        protected virtual void OnLicenseCoordinatorDeleteOpenIssueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteOpenIssueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteOpenIssueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddOpenIssue from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddOpenIssueReceived;
        protected virtual void OnAdminAddOpenIssueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddOpenIssueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddOpenIssueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetOpenIssues from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetOpenIssuesReceived;
        protected virtual void OnAdminGetOpenIssuesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetOpenIssuesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetOpenIssuesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateOpenIssue from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateOpenIssueReceived;
        protected virtual void OnAdminUpdateOpenIssueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateOpenIssueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateOpenIssueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteOpenIssue from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteOpenIssueReceived;
        protected virtual void OnAdminDeleteOpenIssueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteOpenIssueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteOpenIssueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSKUMeterAdjustment from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddSKUMeterAdjustmentReceived;
        protected virtual void OnLicenseCoordinatorAddSKUMeterAdjustmentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddSKUMeterAdjustmentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddSKUMeterAdjustmentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSKUMeterAdjustments from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetSKUMeterAdjustmentsReceived;
        protected virtual void OnLicenseCoordinatorGetSKUMeterAdjustmentsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetSKUMeterAdjustmentsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetSKUMeterAdjustmentsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSKUMeterAdjustment from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateSKUMeterAdjustmentReceived;
        protected virtual void OnLicenseCoordinatorUpdateSKUMeterAdjustmentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateSKUMeterAdjustmentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateSKUMeterAdjustmentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSKUMeterAdjustment from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteSKUMeterAdjustmentReceived;
        protected virtual void OnLicenseCoordinatorDeleteSKUMeterAdjustmentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteSKUMeterAdjustmentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteSKUMeterAdjustmentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSKUMeterAdjustment from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddSKUMeterAdjustmentReceived;
        protected virtual void OnAdminAddSKUMeterAdjustmentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddSKUMeterAdjustmentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddSKUMeterAdjustmentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSKUMeterAdjustments from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetSKUMeterAdjustmentsReceived;
        protected virtual void OnAdminGetSKUMeterAdjustmentsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetSKUMeterAdjustmentsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetSKUMeterAdjustmentsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSKUMeterAdjustment from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateSKUMeterAdjustmentReceived;
        protected virtual void OnAdminUpdateSKUMeterAdjustmentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateSKUMeterAdjustmentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateSKUMeterAdjustmentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSKUMeterAdjustment from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteSKUMeterAdjustmentReceived;
        protected virtual void OnAdminDeleteSKUMeterAdjustmentReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteSKUMeterAdjustmentReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteSKUMeterAdjustmentReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductLicenseMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddProductLicenseMeterReceived;
        protected virtual void OnLicenseCoordinatorAddProductLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddProductLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddProductLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductLicenseMeters from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetProductLicenseMetersReceived;
        protected virtual void OnLicenseCoordinatorGetProductLicenseMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetProductLicenseMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetProductLicenseMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductLicenseMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateProductLicenseMeterReceived;
        protected virtual void OnLicenseCoordinatorUpdateProductLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateProductLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateProductLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductLicenseMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteProductLicenseMeterReceived;
        protected virtual void OnLicenseCoordinatorDeleteProductLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteProductLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteProductLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductLicenseMeters from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetProductLicenseMetersReceived;
        protected virtual void OnSSioUserGetProductLicenseMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetProductLicenseMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetProductLicenseMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductLicenseMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddProductLicenseMeterReceived;
        protected virtual void OnAdminAddProductLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddProductLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddProductLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductLicenseMeters from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetProductLicenseMetersReceived;
        protected virtual void OnAdminGetProductLicenseMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetProductLicenseMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetProductLicenseMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductLicenseMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateProductLicenseMeterReceived;
        protected virtual void OnAdminUpdateProductLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateProductLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateProductLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductLicenseMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteProductLicenseMeterReceived;
        protected virtual void OnAdminDeleteProductLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteProductLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteProductLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseMeters from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetLicenseMetersReceived;
        protected virtual void OnGuestGetLicenseMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetLicenseMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetLicenseMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddLicenseMeterReceived;
        protected virtual void OnLicenseCoordinatorAddLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseMeters from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetLicenseMetersReceived;
        protected virtual void OnLicenseCoordinatorGetLicenseMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetLicenseMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetLicenseMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateLicenseMeterReceived;
        protected virtual void OnLicenseCoordinatorUpdateLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteLicenseMeterReceived;
        protected virtual void OnLicenseCoordinatorDeleteLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseMeter from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserAddLicenseMeterReceived;
        protected virtual void OnSSioUserAddLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserAddLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserAddLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseMeters from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetLicenseMetersReceived;
        protected virtual void OnSSioUserGetLicenseMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetLicenseMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetLicenseMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseMeter from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserUpdateLicenseMeterReceived;
        protected virtual void OnSSioUserUpdateLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserUpdateLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserUpdateLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseMeter from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserDeleteLicenseMeterReceived;
        protected virtual void OnSSioUserDeleteLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserDeleteLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserDeleteLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddLicenseMeterReceived;
        protected virtual void OnAdminAddLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseMeters from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetLicenseMetersReceived;
        protected virtual void OnAdminGetLicenseMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetLicenseMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetLicenseMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateLicenseMeterReceived;
        protected virtual void OnAdminUpdateLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteLicenseMeterReceived;
        protected virtual void OnAdminDeleteLicenseMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteLicenseMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteLicenseMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddInvoice from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddInvoiceReceived;
        protected virtual void OnLicenseCoordinatorAddInvoiceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddInvoiceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddInvoiceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetInvoices from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetInvoicesReceived;
        protected virtual void OnLicenseCoordinatorGetInvoicesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetInvoicesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetInvoicesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateInvoice from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateInvoiceReceived;
        protected virtual void OnLicenseCoordinatorUpdateInvoiceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateInvoiceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateInvoiceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteInvoice from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteInvoiceReceived;
        protected virtual void OnLicenseCoordinatorDeleteInvoiceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteInvoiceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteInvoiceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetInvoices from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetInvoicesReceived;
        protected virtual void OnSSioUserGetInvoicesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetInvoicesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetInvoicesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddInvoice from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddInvoiceReceived;
        protected virtual void OnAdminAddInvoiceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddInvoiceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddInvoiceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetInvoices from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetInvoicesReceived;
        protected virtual void OnAdminGetInvoicesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetInvoicesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetInvoicesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateInvoice from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateInvoiceReceived;
        protected virtual void OnAdminUpdateInvoiceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateInvoiceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateInvoiceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteInvoice from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteInvoiceReceived;
        protected virtual void OnAdminDeleteInvoiceReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteInvoiceReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteInvoiceReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBrandLicenses from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetBrandLicensesReceived;
        protected virtual void OnGuestGetBrandLicensesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetBrandLicensesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetBrandLicensesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBrandLicense from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddBrandLicenseReceived;
        protected virtual void OnLicenseCoordinatorAddBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBrandLicenses from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetBrandLicensesReceived;
        protected virtual void OnLicenseCoordinatorGetBrandLicensesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetBrandLicensesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetBrandLicensesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBrandLicense from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateBrandLicenseReceived;
        protected virtual void OnLicenseCoordinatorUpdateBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBrandLicense from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteBrandLicenseReceived;
        protected virtual void OnLicenseCoordinatorDeleteBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBrandLicense from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserAddBrandLicenseReceived;
        protected virtual void OnSSioUserAddBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserAddBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserAddBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBrandLicenses from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetBrandLicensesReceived;
        protected virtual void OnSSioUserGetBrandLicensesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetBrandLicensesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetBrandLicensesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBrandLicense from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserUpdateBrandLicenseReceived;
        protected virtual void OnSSioUserUpdateBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserUpdateBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserUpdateBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBrandLicense from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserDeleteBrandLicenseReceived;
        protected virtual void OnSSioUserDeleteBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserDeleteBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserDeleteBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBrandLicense from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddBrandLicenseReceived;
        protected virtual void OnAdminAddBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBrandLicenses from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetBrandLicensesReceived;
        protected virtual void OnAdminGetBrandLicensesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetBrandLicensesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetBrandLicensesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBrandLicense from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateBrandLicenseReceived;
        protected virtual void OnAdminUpdateBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBrandLicense from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteBrandLicenseReceived;
        protected virtual void OnAdminDeleteBrandLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteBrandLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteBrandLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductUseRequest from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddProductUseRequestReceived;
        protected virtual void OnLicenseCoordinatorAddProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductUseRequests from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetProductUseRequestsReceived;
        protected virtual void OnLicenseCoordinatorGetProductUseRequestsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetProductUseRequestsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetProductUseRequestsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductUseRequest from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateProductUseRequestReceived;
        protected virtual void OnLicenseCoordinatorUpdateProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductUseRequest from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteProductUseRequestReceived;
        protected virtual void OnLicenseCoordinatorDeleteProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductUseRequest from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddProductUseRequestReceived;
        protected virtual void OnAdminAddProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductUseRequests from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetProductUseRequestsReceived;
        protected virtual void OnAdminGetProductUseRequestsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetProductUseRequestsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetProductUseRequestsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductUseRequest from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateProductUseRequestReceived;
        protected virtual void OnAdminUpdateProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductUseRequest from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteProductUseRequestReceived;
        protected virtual void OnAdminDeleteProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddLicenseTypeReceived;
        protected virtual void OnLicenseCoordinatorAddLicenseTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddLicenseTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddLicenseTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseTypes from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetLicenseTypesReceived;
        protected virtual void OnLicenseCoordinatorGetLicenseTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetLicenseTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetLicenseTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateLicenseTypeReceived;
        protected virtual void OnLicenseCoordinatorUpdateLicenseTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateLicenseTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateLicenseTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteLicenseTypeReceived;
        protected virtual void OnLicenseCoordinatorDeleteLicenseTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteLicenseTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteLicenseTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddLicenseTypeReceived;
        protected virtual void OnAdminAddLicenseTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddLicenseTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddLicenseTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseTypes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetLicenseTypesReceived;
        protected virtual void OnAdminGetLicenseTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetLicenseTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetLicenseTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateLicenseTypeReceived;
        protected virtual void OnAdminUpdateLicenseTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateLicenseTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateLicenseTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteLicenseTypeReceived;
        protected virtual void OnAdminDeleteLicenseTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteLicenseTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteLicenseTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMeterTransaction from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddMeterTransactionReceived;
        protected virtual void OnLicenseCoordinatorAddMeterTransactionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddMeterTransactionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddMeterTransactionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMeterTransactions from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetMeterTransactionsReceived;
        protected virtual void OnLicenseCoordinatorGetMeterTransactionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetMeterTransactionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetMeterTransactionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMeterTransaction from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateMeterTransactionReceived;
        protected virtual void OnLicenseCoordinatorUpdateMeterTransactionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateMeterTransactionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateMeterTransactionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMeterTransaction from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteMeterTransactionReceived;
        protected virtual void OnLicenseCoordinatorDeleteMeterTransactionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteMeterTransactionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteMeterTransactionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMeterTransaction from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMeterTransactionReceived;
        protected virtual void OnAdminAddMeterTransactionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMeterTransactionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMeterTransactionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMeterTransactions from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMeterTransactionsReceived;
        protected virtual void OnAdminGetMeterTransactionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMeterTransactionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMeterTransactionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMeterTransaction from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMeterTransactionReceived;
        protected virtual void OnAdminUpdateMeterTransactionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMeterTransactionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMeterTransactionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMeterTransaction from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMeterTransactionReceived;
        protected virtual void OnAdminDeleteMeterTransactionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMeterTransactionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMeterTransactionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseSKUs from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetLicenseSKUsReceived;
        protected virtual void OnGuestGetLicenseSKUsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetLicenseSKUsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetLicenseSKUsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseSKU from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddLicenseSKUReceived;
        protected virtual void OnLicenseCoordinatorAddLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseSKUs from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetLicenseSKUsReceived;
        protected virtual void OnLicenseCoordinatorGetLicenseSKUsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetLicenseSKUsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetLicenseSKUsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseSKU from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateLicenseSKUReceived;
        protected virtual void OnLicenseCoordinatorUpdateLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseSKU from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteLicenseSKUReceived;
        protected virtual void OnLicenseCoordinatorDeleteLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseSKU from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserAddLicenseSKUReceived;
        protected virtual void OnSSioUserAddLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserAddLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserAddLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseSKUs from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetLicenseSKUsReceived;
        protected virtual void OnSSioUserGetLicenseSKUsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetLicenseSKUsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetLicenseSKUsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseSKU from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserUpdateLicenseSKUReceived;
        protected virtual void OnSSioUserUpdateLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserUpdateLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserUpdateLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseSKU from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserDeleteLicenseSKUReceived;
        protected virtual void OnSSioUserDeleteLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserDeleteLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserDeleteLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseSKU from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddLicenseSKUReceived;
        protected virtual void OnAdminAddLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseSKUs from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetLicenseSKUsReceived;
        protected virtual void OnAdminGetLicenseSKUsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetLicenseSKUsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetLicenseSKUsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseSKU from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateLicenseSKUReceived;
        protected virtual void OnAdminUpdateLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseSKU from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteLicenseSKUReceived;
        protected virtual void OnAdminDeleteLicenseSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteLicenseSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteLicenseSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSSioVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddSSioVersionReceived;
        protected virtual void OnLicenseCoordinatorAddSSioVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddSSioVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddSSioVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSSioVersions from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetSSioVersionsReceived;
        protected virtual void OnLicenseCoordinatorGetSSioVersionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetSSioVersionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetSSioVersionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSSioVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateSSioVersionReceived;
        protected virtual void OnLicenseCoordinatorUpdateSSioVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateSSioVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateSSioVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSSioVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteSSioVersionReceived;
        protected virtual void OnLicenseCoordinatorDeleteSSioVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteSSioVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteSSioVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddSSioVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddSSioVersionReceived;
        protected virtual void OnAdminAddSSioVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddSSioVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddSSioVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetSSioVersions from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetSSioVersionsReceived;
        protected virtual void OnAdminGetSSioVersionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetSSioVersionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetSSioVersionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateSSioVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateSSioVersionReceived;
        protected virtual void OnAdminUpdateSSioVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateSSioVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateSSioVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteSSioVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteSSioVersionReceived;
        protected virtual void OnAdminDeleteSSioVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteSSioVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteSSioVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductLicense from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddProductLicenseReceived;
        protected virtual void OnLicenseCoordinatorAddProductLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddProductLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddProductLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductLicenses from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetProductLicensesReceived;
        protected virtual void OnLicenseCoordinatorGetProductLicensesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetProductLicensesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetProductLicensesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductLicense from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateProductLicenseReceived;
        protected virtual void OnLicenseCoordinatorUpdateProductLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateProductLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateProductLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductLicense from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteProductLicenseReceived;
        protected virtual void OnLicenseCoordinatorDeleteProductLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteProductLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteProductLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductLicenses from SSioUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> SSioUserGetProductLicensesReceived;
        protected virtual void OnSSioUserGetProductLicensesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.SSioUserGetProductLicensesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.SSioUserGetProductLicensesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductLicense from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddProductLicenseReceived;
        protected virtual void OnAdminAddProductLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddProductLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddProductLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductLicenses from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetProductLicensesReceived;
        protected virtual void OnAdminGetProductLicensesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetProductLicensesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetProductLicensesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductLicense from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateProductLicenseReceived;
        protected virtual void OnAdminUpdateProductLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateProductLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateProductLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductLicense from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteProductLicenseReceived;
        protected virtual void OnAdminDeleteProductLicenseReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteProductLicenseReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteProductLicenseReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddProductVersionReceived;
        protected virtual void OnLicenseCoordinatorAddProductVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddProductVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddProductVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductVersions from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetProductVersionsReceived;
        protected virtual void OnLicenseCoordinatorGetProductVersionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetProductVersionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetProductVersionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateProductVersionReceived;
        protected virtual void OnLicenseCoordinatorUpdateProductVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateProductVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateProductVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteProductVersionReceived;
        protected virtual void OnLicenseCoordinatorDeleteProductVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteProductVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteProductVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddProductVersionReceived;
        protected virtual void OnAdminAddProductVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddProductVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddProductVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductVersions from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetProductVersionsReceived;
        protected virtual void OnAdminGetProductVersionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetProductVersionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetProductVersionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateProductVersionReceived;
        protected virtual void OnAdminUpdateProductVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateProductVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateProductVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteProductVersionReceived;
        protected virtual void OnAdminDeleteProductVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteProductVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteProductVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddUnitOfMeasurement from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddUnitOfMeasurementReceived;
        protected virtual void OnLicenseCoordinatorAddUnitOfMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddUnitOfMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddUnitOfMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetUnitOfMeasurements from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetUnitOfMeasurementsReceived;
        protected virtual void OnLicenseCoordinatorGetUnitOfMeasurementsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetUnitOfMeasurementsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetUnitOfMeasurementsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateUnitOfMeasurement from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateUnitOfMeasurementReceived;
        protected virtual void OnLicenseCoordinatorUpdateUnitOfMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateUnitOfMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateUnitOfMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteUnitOfMeasurement from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteUnitOfMeasurementReceived;
        protected virtual void OnLicenseCoordinatorDeleteUnitOfMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteUnitOfMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteUnitOfMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddUnitOfMeasurement from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddUnitOfMeasurementReceived;
        protected virtual void OnAdminAddUnitOfMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddUnitOfMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddUnitOfMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetUnitOfMeasurements from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetUnitOfMeasurementsReceived;
        protected virtual void OnAdminGetUnitOfMeasurementsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetUnitOfMeasurementsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetUnitOfMeasurementsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateUnitOfMeasurement from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateUnitOfMeasurementReceived;
        protected virtual void OnAdminUpdateUnitOfMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateUnitOfMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateUnitOfMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteUnitOfMeasurement from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteUnitOfMeasurementReceived;
        protected virtual void OnAdminDeleteUnitOfMeasurementReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteUnitOfMeasurementReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteUnitOfMeasurementReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductLicenseDMQueue from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddProductLicenseDMQueueReceived;
        protected virtual void OnLicenseCoordinatorAddProductLicenseDMQueueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddProductLicenseDMQueueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddProductLicenseDMQueueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductLicenseDMQueues from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetProductLicenseDMQueuesReceived;
        protected virtual void OnLicenseCoordinatorGetProductLicenseDMQueuesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetProductLicenseDMQueuesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetProductLicenseDMQueuesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductLicenseDMQueue from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateProductLicenseDMQueueReceived;
        protected virtual void OnLicenseCoordinatorUpdateProductLicenseDMQueueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateProductLicenseDMQueueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateProductLicenseDMQueueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductLicenseDMQueue from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteProductLicenseDMQueueReceived;
        protected virtual void OnLicenseCoordinatorDeleteProductLicenseDMQueueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteProductLicenseDMQueueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteProductLicenseDMQueueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductLicenseDMQueue from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddProductLicenseDMQueueReceived;
        protected virtual void OnAdminAddProductLicenseDMQueueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddProductLicenseDMQueueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddProductLicenseDMQueueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductLicenseDMQueues from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetProductLicenseDMQueuesReceived;
        protected virtual void OnAdminGetProductLicenseDMQueuesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetProductLicenseDMQueuesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetProductLicenseDMQueuesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductLicenseDMQueue from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateProductLicenseDMQueueReceived;
        protected virtual void OnAdminUpdateProductLicenseDMQueueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateProductLicenseDMQueueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateProductLicenseDMQueueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductLicenseDMQueue from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteProductLicenseDMQueueReceived;
        protected virtual void OnAdminDeleteProductLicenseDMQueueReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteProductLicenseDMQueueReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteProductLicenseDMQueueReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMeasurementType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddMeasurementTypeReceived;
        protected virtual void OnLicenseCoordinatorAddMeasurementTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddMeasurementTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddMeasurementTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMeasurementTypes from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetMeasurementTypesReceived;
        protected virtual void OnLicenseCoordinatorGetMeasurementTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetMeasurementTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetMeasurementTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMeasurementType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateMeasurementTypeReceived;
        protected virtual void OnLicenseCoordinatorUpdateMeasurementTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateMeasurementTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateMeasurementTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMeasurementType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteMeasurementTypeReceived;
        protected virtual void OnLicenseCoordinatorDeleteMeasurementTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteMeasurementTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteMeasurementTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMeasurementType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMeasurementTypeReceived;
        protected virtual void OnAdminAddMeasurementTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMeasurementTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMeasurementTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMeasurementTypes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMeasurementTypesReceived;
        protected virtual void OnAdminGetMeasurementTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMeasurementTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMeasurementTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMeasurementType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMeasurementTypeReceived;
        protected virtual void OnAdminUpdateMeasurementTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMeasurementTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMeasurementTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMeasurementType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMeasurementTypeReceived;
        protected virtual void OnAdminDeleteMeasurementTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMeasurementTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMeasurementTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMonthlyProductUseRequest from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddMonthlyProductUseRequestReceived;
        protected virtual void OnLicenseCoordinatorAddMonthlyProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddMonthlyProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddMonthlyProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMonthlyProductUseRequests from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetMonthlyProductUseRequestsReceived;
        protected virtual void OnLicenseCoordinatorGetMonthlyProductUseRequestsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetMonthlyProductUseRequestsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetMonthlyProductUseRequestsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMonthlyProductUseRequest from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateMonthlyProductUseRequestReceived;
        protected virtual void OnLicenseCoordinatorUpdateMonthlyProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateMonthlyProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateMonthlyProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMonthlyProductUseRequest from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteMonthlyProductUseRequestReceived;
        protected virtual void OnLicenseCoordinatorDeleteMonthlyProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteMonthlyProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteMonthlyProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMonthlyProductUseRequest from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMonthlyProductUseRequestReceived;
        protected virtual void OnAdminAddMonthlyProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMonthlyProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMonthlyProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMonthlyProductUseRequests from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMonthlyProductUseRequestsReceived;
        protected virtual void OnAdminGetMonthlyProductUseRequestsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMonthlyProductUseRequestsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMonthlyProductUseRequestsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMonthlyProductUseRequest from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMonthlyProductUseRequestReceived;
        protected virtual void OnAdminUpdateMonthlyProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMonthlyProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMonthlyProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMonthlyProductUseRequest from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMonthlyProductUseRequestReceived;
        protected virtual void OnAdminDeleteMonthlyProductUseRequestReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMonthlyProductUseRequestReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMonthlyProductUseRequestReceived(this, plea);
            }
        }

        /// <summary>
        /// ResetRabbitSassyMQConfiguration - 
        /// </summary>
        public Task ResetRabbitSassyMQConfiguration(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.ResetRabbitSassyMQConfiguration(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// ResetRabbitSassyMQConfiguration - 
        /// </summary>
        public Task ResetRabbitSassyMQConfiguration(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.ResetRabbitSassyMQConfiguration(payload, replyHandler, timeoutHandler, waitTimeout);
        }
    
        
        /// <summary>
        /// ResetRabbitSassyMQConfiguration - 
        /// </summary>
        public Task ResetRabbitSassyMQConfiguration(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.crudcoordinator.resetrabbitsassymqconfiguration", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        
        
        /// <summary>
        /// ResetJWTSecretKey - 
        /// </summary>
        public Task ResetJWTSecretKey(PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.ResetJWTSecretKey(this.CreatePayload(), replyHandler, timeoutHandler, waitTimeout);
        }

        /// <summary>
        /// ResetJWTSecretKey - 
        /// </summary>
        public Task ResetJWTSecretKey(String content, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            var payload = this.CreatePayload(content);
            return this.ResetJWTSecretKey(payload, replyHandler, timeoutHandler, waitTimeout);
        }
    
        
        /// <summary>
        /// ResetJWTSecretKey - 
        /// </summary>
        public Task ResetJWTSecretKey(StandardPayload payload, PayloadHandler replyHandler = null, PayloadHandler timeoutHandler = null, int waitTimeout = StandardPayload.DEFAULT_TIMEOUT)
        {
            return this.SendMessage("crudcoordinator.general.crudcoordinator.resetjwtsecretkey", payload, replyHandler, timeoutHandler, waitTimeout);
        }
        
        
    }
}

                    
