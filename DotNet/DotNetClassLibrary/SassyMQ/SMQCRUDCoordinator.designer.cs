using System;
using System.Linq;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using System.Threading.Tasks;

namespace EffortlessAPI.ABS.SassyMQ
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
                    
                    case "crudcoordinator.crud.guest.getproductbundles":
                        this.OnGuestGetProductBundlesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addproductbundle":
                        this.OnLicenseCoordinatorAddProductBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getproductbundles":
                        this.OnLicenseCoordinatorGetProductBundlesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateproductbundle":
                        this.OnLicenseCoordinatorUpdateProductBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteproductbundle":
                        this.OnLicenseCoordinatorDeleteProductBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.addproductbundle":
                        this.OnABSUserAddProductBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.getproductbundles":
                        this.OnABSUserGetProductBundlesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.updateproductbundle":
                        this.OnABSUserUpdateProductBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.deleteproductbundle":
                        this.OnABSUserDeleteProductBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addproductbundle":
                        this.OnAdminAddProductBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getproductbundles":
                        this.OnAdminGetProductBundlesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateproductbundle":
                        this.OnAdminUpdateProductBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteproductbundle":
                        this.OnAdminDeleteProductBundleReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.guest.getmetertypes":
                        this.OnGuestGetMeterTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addmetertype":
                        this.OnLicenseCoordinatorAddMeterTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getmetertypes":
                        this.OnLicenseCoordinatorGetMeterTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatemetertype":
                        this.OnLicenseCoordinatorUpdateMeterTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletemetertype":
                        this.OnLicenseCoordinatorDeleteMeterTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addmetertype":
                        this.OnAdminAddMeterTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getmetertypes":
                        this.OnAdminGetMeterTypesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatemetertype":
                        this.OnAdminUpdateMeterTypeReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletemetertype":
                        this.OnAdminDeleteMeterTypeReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.absuser.getinvoicelineitems":
                        this.OnABSUserGetInvoiceLineItemsReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.guest.getabstechnologies":
                        this.OnGuestGetABSTechnologiesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addabstechnology":
                        this.OnLicenseCoordinatorAddABSTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getabstechnologies":
                        this.OnLicenseCoordinatorGetABSTechnologiesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateabstechnology":
                        this.OnLicenseCoordinatorUpdateABSTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteabstechnology":
                        this.OnLicenseCoordinatorDeleteABSTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addabstechnology":
                        this.OnAdminAddABSTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getabstechnologies":
                        this.OnAdminGetABSTechnologiesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateabstechnology":
                        this.OnAdminUpdateABSTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteabstechnology":
                        this.OnAdminDeleteABSTechnologyReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addabsuser":
                        this.OnLicenseCoordinatorAddABSUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getabsusers":
                        this.OnLicenseCoordinatorGetABSUsersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateabsuser":
                        this.OnLicenseCoordinatorUpdateABSUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteabsuser":
                        this.OnLicenseCoordinatorDeleteABSUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addabsuser":
                        this.OnAdminAddABSUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getabsusers":
                        this.OnAdminGetABSUsersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateabsuser":
                        this.OnAdminUpdateABSUserReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteabsuser":
                        this.OnAdminDeleteABSUserReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.absuser.getproductlicenses":
                        this.OnABSUserGetProductLicensesReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.absuser.addlicensedproduct":
                        this.OnABSUserAddLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.getlicensedproducts":
                        this.OnABSUserGetLicensedProductsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.updatelicensedproduct":
                        this.OnABSUserUpdateLicensedProductReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.deletelicensedproduct":
                        this.OnABSUserDeleteLicensedProductReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.absuser.getproductlicensemeters":
                        this.OnABSUserGetProductLicenseMetersReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.guest.getbundleskulimits":
                        this.OnGuestGetBundleSKULimitsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addbundleskulimit":
                        this.OnLicenseCoordinatorAddBundleSKULimitReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getbundleskulimits":
                        this.OnLicenseCoordinatorGetBundleSKULimitsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatebundleskulimit":
                        this.OnLicenseCoordinatorUpdateBundleSKULimitReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletebundleskulimit":
                        this.OnLicenseCoordinatorDeleteBundleSKULimitReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.addbundleskulimit":
                        this.OnABSUserAddBundleSKULimitReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.getbundleskulimits":
                        this.OnABSUserGetBundleSKULimitsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.updatebundleskulimit":
                        this.OnABSUserUpdateBundleSKULimitReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.deletebundleskulimit":
                        this.OnABSUserDeleteBundleSKULimitReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addbundleskulimit":
                        this.OnAdminAddBundleSKULimitReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getbundleskulimits":
                        this.OnAdminGetBundleSKULimitsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatebundleskulimit":
                        this.OnAdminUpdateBundleSKULimitReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletebundleskulimit":
                        this.OnAdminDeleteBundleSKULimitReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.absuser.getinvoices":
                        this.OnABSUserGetInvoicesReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.guest.getlicensebundles":
                        this.OnGuestGetLicenseBundlesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addlicensebundle":
                        this.OnLicenseCoordinatorAddLicenseBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getlicensebundles":
                        this.OnLicenseCoordinatorGetLicenseBundlesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatelicensebundle":
                        this.OnLicenseCoordinatorUpdateLicenseBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletelicensebundle":
                        this.OnLicenseCoordinatorDeleteLicenseBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.addlicensebundle":
                        this.OnABSUserAddLicenseBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.getlicensebundles":
                        this.OnABSUserGetLicenseBundlesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.updatelicensebundle":
                        this.OnABSUserUpdateLicenseBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.deletelicensebundle":
                        this.OnABSUserDeleteLicenseBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addlicensebundle":
                        this.OnAdminAddLicenseBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getlicensebundles":
                        this.OnAdminGetLicenseBundlesReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatelicensebundle":
                        this.OnAdminUpdateLicenseBundleReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletelicensebundle":
                        this.OnAdminDeleteLicenseBundleReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.guest.gettechnologymeters":
                        this.OnGuestGetTechnologyMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addtechnologymeter":
                        this.OnLicenseCoordinatorAddTechnologyMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.gettechnologymeters":
                        this.OnLicenseCoordinatorGetTechnologyMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatetechnologymeter":
                        this.OnLicenseCoordinatorUpdateTechnologyMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletetechnologymeter":
                        this.OnLicenseCoordinatorDeleteTechnologyMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addtechnologymeter":
                        this.OnAdminAddTechnologyMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.gettechnologymeters":
                        this.OnAdminGetTechnologyMetersReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatetechnologymeter":
                        this.OnAdminUpdateTechnologyMeterReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletetechnologymeter":
                        this.OnAdminDeleteTechnologyMeterReceived(payload, bdea);
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
                    
                    case "crudcoordinator.crud.guest.getbundleskus":
                        this.OnGuestGetBundleSKUsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addbundlesku":
                        this.OnLicenseCoordinatorAddBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getbundleskus":
                        this.OnLicenseCoordinatorGetBundleSKUsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updatebundlesku":
                        this.OnLicenseCoordinatorUpdateBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deletebundlesku":
                        this.OnLicenseCoordinatorDeleteBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.addbundlesku":
                        this.OnABSUserAddBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.getbundleskus":
                        this.OnABSUserGetBundleSKUsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.updatebundlesku":
                        this.OnABSUserUpdateBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.absuser.deletebundlesku":
                        this.OnABSUserDeleteBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addbundlesku":
                        this.OnAdminAddBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getbundleskus":
                        this.OnAdminGetBundleSKUsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updatebundlesku":
                        this.OnAdminUpdateBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deletebundlesku":
                        this.OnAdminDeleteBundleSKUReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.addabsversion":
                        this.OnLicenseCoordinatorAddABSVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.getabsversions":
                        this.OnLicenseCoordinatorGetABSVersionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.updateabsversion":
                        this.OnLicenseCoordinatorUpdateABSVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.licensecoordinator.deleteabsversion":
                        this.OnLicenseCoordinatorDeleteABSVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.addabsversion":
                        this.OnAdminAddABSVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.getabsversions":
                        this.OnAdminGetABSVersionsReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.updateabsversion":
                        this.OnAdminUpdateABSVersionReceived(payload, bdea);
                        break;
                    
                    case "crudcoordinator.crud.admin.deleteabsversion":
                        this.OnAdminDeleteABSVersionReceived(payload, bdea);
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
        /// Responds to: GetProductBundles from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetProductBundlesReceived;
        protected virtual void OnGuestGetProductBundlesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetProductBundlesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetProductBundlesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductBundle from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddProductBundleReceived;
        protected virtual void OnLicenseCoordinatorAddProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddProductBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductBundles from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetProductBundlesReceived;
        protected virtual void OnLicenseCoordinatorGetProductBundlesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetProductBundlesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetProductBundlesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductBundle from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateProductBundleReceived;
        protected virtual void OnLicenseCoordinatorUpdateProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateProductBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductBundle from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteProductBundleReceived;
        protected virtual void OnLicenseCoordinatorDeleteProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteProductBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductBundle from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserAddProductBundleReceived;
        protected virtual void OnABSUserAddProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserAddProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserAddProductBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductBundles from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetProductBundlesReceived;
        protected virtual void OnABSUserGetProductBundlesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetProductBundlesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetProductBundlesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductBundle from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserUpdateProductBundleReceived;
        protected virtual void OnABSUserUpdateProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserUpdateProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserUpdateProductBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductBundle from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserDeleteProductBundleReceived;
        protected virtual void OnABSUserDeleteProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserDeleteProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserDeleteProductBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddProductBundle from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddProductBundleReceived;
        protected virtual void OnAdminAddProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddProductBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetProductBundles from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetProductBundlesReceived;
        protected virtual void OnAdminGetProductBundlesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetProductBundlesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetProductBundlesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateProductBundle from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateProductBundleReceived;
        protected virtual void OnAdminUpdateProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateProductBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteProductBundle from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteProductBundleReceived;
        protected virtual void OnAdminDeleteProductBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteProductBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteProductBundleReceived(this, plea);
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
        /// Responds to: GetMeterTypes from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetMeterTypesReceived;
        protected virtual void OnGuestGetMeterTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetMeterTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetMeterTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMeterType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddMeterTypeReceived;
        protected virtual void OnLicenseCoordinatorAddMeterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddMeterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddMeterTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMeterTypes from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetMeterTypesReceived;
        protected virtual void OnLicenseCoordinatorGetMeterTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetMeterTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetMeterTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMeterType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateMeterTypeReceived;
        protected virtual void OnLicenseCoordinatorUpdateMeterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateMeterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateMeterTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMeterType from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteMeterTypeReceived;
        protected virtual void OnLicenseCoordinatorDeleteMeterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteMeterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteMeterTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddMeterType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddMeterTypeReceived;
        protected virtual void OnAdminAddMeterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddMeterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddMeterTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetMeterTypes from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetMeterTypesReceived;
        protected virtual void OnAdminGetMeterTypesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetMeterTypesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetMeterTypesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateMeterType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateMeterTypeReceived;
        protected virtual void OnAdminUpdateMeterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateMeterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateMeterTypeReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteMeterType from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteMeterTypeReceived;
        protected virtual void OnAdminDeleteMeterTypeReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteMeterTypeReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteMeterTypeReceived(this, plea);
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
        /// Responds to: GetInvoiceLineItems from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetInvoiceLineItemsReceived;
        protected virtual void OnABSUserGetInvoiceLineItemsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetInvoiceLineItemsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetInvoiceLineItemsReceived(this, plea);
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
        /// Responds to: GetABSTechnologies from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetABSTechnologiesReceived;
        protected virtual void OnGuestGetABSTechnologiesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetABSTechnologiesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetABSTechnologiesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddABSTechnology from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddABSTechnologyReceived;
        protected virtual void OnLicenseCoordinatorAddABSTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddABSTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddABSTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetABSTechnologies from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetABSTechnologiesReceived;
        protected virtual void OnLicenseCoordinatorGetABSTechnologiesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetABSTechnologiesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetABSTechnologiesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateABSTechnology from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateABSTechnologyReceived;
        protected virtual void OnLicenseCoordinatorUpdateABSTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateABSTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateABSTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteABSTechnology from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteABSTechnologyReceived;
        protected virtual void OnLicenseCoordinatorDeleteABSTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteABSTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteABSTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddABSTechnology from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddABSTechnologyReceived;
        protected virtual void OnAdminAddABSTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddABSTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddABSTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetABSTechnologies from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetABSTechnologiesReceived;
        protected virtual void OnAdminGetABSTechnologiesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetABSTechnologiesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetABSTechnologiesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateABSTechnology from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateABSTechnologyReceived;
        protected virtual void OnAdminUpdateABSTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateABSTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateABSTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteABSTechnology from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteABSTechnologyReceived;
        protected virtual void OnAdminDeleteABSTechnologyReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteABSTechnologyReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteABSTechnologyReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddABSUser from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddABSUserReceived;
        protected virtual void OnLicenseCoordinatorAddABSUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddABSUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddABSUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetABSUsers from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetABSUsersReceived;
        protected virtual void OnLicenseCoordinatorGetABSUsersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetABSUsersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetABSUsersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateABSUser from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateABSUserReceived;
        protected virtual void OnLicenseCoordinatorUpdateABSUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateABSUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateABSUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteABSUser from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteABSUserReceived;
        protected virtual void OnLicenseCoordinatorDeleteABSUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteABSUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteABSUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddABSUser from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddABSUserReceived;
        protected virtual void OnAdminAddABSUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddABSUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddABSUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetABSUsers from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetABSUsersReceived;
        protected virtual void OnAdminGetABSUsersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetABSUsersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetABSUsersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateABSUser from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateABSUserReceived;
        protected virtual void OnAdminUpdateABSUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateABSUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateABSUserReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteABSUser from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteABSUserReceived;
        protected virtual void OnAdminDeleteABSUserReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteABSUserReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteABSUserReceived(this, plea);
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
        /// Responds to: GetProductLicenses from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetProductLicensesReceived;
        protected virtual void OnABSUserGetProductLicensesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetProductLicensesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetProductLicensesReceived(this, plea);
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
        /// Responds to: AddLicensedProduct from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserAddLicensedProductReceived;
        protected virtual void OnABSUserAddLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserAddLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserAddLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicensedProducts from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetLicensedProductsReceived;
        protected virtual void OnABSUserGetLicensedProductsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetLicensedProductsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetLicensedProductsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicensedProduct from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserUpdateLicensedProductReceived;
        protected virtual void OnABSUserUpdateLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserUpdateLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserUpdateLicensedProductReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicensedProduct from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserDeleteLicensedProductReceived;
        protected virtual void OnABSUserDeleteLicensedProductReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserDeleteLicensedProductReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserDeleteLicensedProductReceived(this, plea);
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
        /// Responds to: GetProductLicenseMeters from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetProductLicenseMetersReceived;
        protected virtual void OnABSUserGetProductLicenseMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetProductLicenseMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetProductLicenseMetersReceived(this, plea);
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
        /// Responds to: GetBundleSKULimits from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetBundleSKULimitsReceived;
        protected virtual void OnGuestGetBundleSKULimitsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetBundleSKULimitsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetBundleSKULimitsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBundleSKULimit from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddBundleSKULimitReceived;
        protected virtual void OnLicenseCoordinatorAddBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddBundleSKULimitReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBundleSKULimits from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetBundleSKULimitsReceived;
        protected virtual void OnLicenseCoordinatorGetBundleSKULimitsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetBundleSKULimitsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetBundleSKULimitsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBundleSKULimit from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateBundleSKULimitReceived;
        protected virtual void OnLicenseCoordinatorUpdateBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateBundleSKULimitReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBundleSKULimit from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteBundleSKULimitReceived;
        protected virtual void OnLicenseCoordinatorDeleteBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteBundleSKULimitReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBundleSKULimit from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserAddBundleSKULimitReceived;
        protected virtual void OnABSUserAddBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserAddBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserAddBundleSKULimitReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBundleSKULimits from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetBundleSKULimitsReceived;
        protected virtual void OnABSUserGetBundleSKULimitsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetBundleSKULimitsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetBundleSKULimitsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBundleSKULimit from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserUpdateBundleSKULimitReceived;
        protected virtual void OnABSUserUpdateBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserUpdateBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserUpdateBundleSKULimitReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBundleSKULimit from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserDeleteBundleSKULimitReceived;
        protected virtual void OnABSUserDeleteBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserDeleteBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserDeleteBundleSKULimitReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBundleSKULimit from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddBundleSKULimitReceived;
        protected virtual void OnAdminAddBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddBundleSKULimitReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBundleSKULimits from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetBundleSKULimitsReceived;
        protected virtual void OnAdminGetBundleSKULimitsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetBundleSKULimitsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetBundleSKULimitsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBundleSKULimit from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateBundleSKULimitReceived;
        protected virtual void OnAdminUpdateBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateBundleSKULimitReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBundleSKULimit from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteBundleSKULimitReceived;
        protected virtual void OnAdminDeleteBundleSKULimitReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteBundleSKULimitReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteBundleSKULimitReceived(this, plea);
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
        /// Responds to: GetInvoices from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetInvoicesReceived;
        protected virtual void OnABSUserGetInvoicesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetInvoicesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetInvoicesReceived(this, plea);
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
        /// Responds to: GetLicenseBundles from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetLicenseBundlesReceived;
        protected virtual void OnGuestGetLicenseBundlesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetLicenseBundlesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetLicenseBundlesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseBundle from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddLicenseBundleReceived;
        protected virtual void OnLicenseCoordinatorAddLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddLicenseBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseBundles from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetLicenseBundlesReceived;
        protected virtual void OnLicenseCoordinatorGetLicenseBundlesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetLicenseBundlesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetLicenseBundlesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseBundle from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateLicenseBundleReceived;
        protected virtual void OnLicenseCoordinatorUpdateLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateLicenseBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseBundle from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteLicenseBundleReceived;
        protected virtual void OnLicenseCoordinatorDeleteLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteLicenseBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseBundle from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserAddLicenseBundleReceived;
        protected virtual void OnABSUserAddLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserAddLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserAddLicenseBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseBundles from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetLicenseBundlesReceived;
        protected virtual void OnABSUserGetLicenseBundlesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetLicenseBundlesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetLicenseBundlesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseBundle from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserUpdateLicenseBundleReceived;
        protected virtual void OnABSUserUpdateLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserUpdateLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserUpdateLicenseBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseBundle from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserDeleteLicenseBundleReceived;
        protected virtual void OnABSUserDeleteLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserDeleteLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserDeleteLicenseBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddLicenseBundle from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddLicenseBundleReceived;
        protected virtual void OnAdminAddLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddLicenseBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetLicenseBundles from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetLicenseBundlesReceived;
        protected virtual void OnAdminGetLicenseBundlesReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetLicenseBundlesReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetLicenseBundlesReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateLicenseBundle from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateLicenseBundleReceived;
        protected virtual void OnAdminUpdateLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateLicenseBundleReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteLicenseBundle from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteLicenseBundleReceived;
        protected virtual void OnAdminDeleteLicenseBundleReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteLicenseBundleReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteLicenseBundleReceived(this, plea);
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
        /// Responds to: GetTechnologyMeters from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetTechnologyMetersReceived;
        protected virtual void OnGuestGetTechnologyMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetTechnologyMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetTechnologyMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddTechnologyMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddTechnologyMeterReceived;
        protected virtual void OnLicenseCoordinatorAddTechnologyMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddTechnologyMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddTechnologyMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetTechnologyMeters from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetTechnologyMetersReceived;
        protected virtual void OnLicenseCoordinatorGetTechnologyMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetTechnologyMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetTechnologyMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateTechnologyMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateTechnologyMeterReceived;
        protected virtual void OnLicenseCoordinatorUpdateTechnologyMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateTechnologyMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateTechnologyMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteTechnologyMeter from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteTechnologyMeterReceived;
        protected virtual void OnLicenseCoordinatorDeleteTechnologyMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteTechnologyMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteTechnologyMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddTechnologyMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddTechnologyMeterReceived;
        protected virtual void OnAdminAddTechnologyMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddTechnologyMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddTechnologyMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetTechnologyMeters from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetTechnologyMetersReceived;
        protected virtual void OnAdminGetTechnologyMetersReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetTechnologyMetersReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetTechnologyMetersReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateTechnologyMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateTechnologyMeterReceived;
        protected virtual void OnAdminUpdateTechnologyMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateTechnologyMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateTechnologyMeterReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteTechnologyMeter from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteTechnologyMeterReceived;
        protected virtual void OnAdminDeleteTechnologyMeterReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteTechnologyMeterReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteTechnologyMeterReceived(this, plea);
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
        /// Responds to: GetBundleSKUs from Guest
        /// </summary>
        public event EventHandler<PayloadEventArgs> GuestGetBundleSKUsReceived;
        protected virtual void OnGuestGetBundleSKUsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.GuestGetBundleSKUsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.GuestGetBundleSKUsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBundleSKU from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddBundleSKUReceived;
        protected virtual void OnLicenseCoordinatorAddBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBundleSKUs from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetBundleSKUsReceived;
        protected virtual void OnLicenseCoordinatorGetBundleSKUsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetBundleSKUsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetBundleSKUsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBundleSKU from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateBundleSKUReceived;
        protected virtual void OnLicenseCoordinatorUpdateBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBundleSKU from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteBundleSKUReceived;
        protected virtual void OnLicenseCoordinatorDeleteBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBundleSKU from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserAddBundleSKUReceived;
        protected virtual void OnABSUserAddBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserAddBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserAddBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBundleSKUs from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserGetBundleSKUsReceived;
        protected virtual void OnABSUserGetBundleSKUsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserGetBundleSKUsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserGetBundleSKUsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBundleSKU from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserUpdateBundleSKUReceived;
        protected virtual void OnABSUserUpdateBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserUpdateBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserUpdateBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBundleSKU from ABSUser
        /// </summary>
        public event EventHandler<PayloadEventArgs> ABSUserDeleteBundleSKUReceived;
        protected virtual void OnABSUserDeleteBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.ABSUserDeleteBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.ABSUserDeleteBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddBundleSKU from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddBundleSKUReceived;
        protected virtual void OnAdminAddBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetBundleSKUs from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetBundleSKUsReceived;
        protected virtual void OnAdminGetBundleSKUsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetBundleSKUsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetBundleSKUsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateBundleSKU from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateBundleSKUReceived;
        protected virtual void OnAdminUpdateBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteBundleSKU from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteBundleSKUReceived;
        protected virtual void OnAdminDeleteBundleSKUReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteBundleSKUReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteBundleSKUReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddABSVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorAddABSVersionReceived;
        protected virtual void OnLicenseCoordinatorAddABSVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorAddABSVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorAddABSVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetABSVersions from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorGetABSVersionsReceived;
        protected virtual void OnLicenseCoordinatorGetABSVersionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorGetABSVersionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorGetABSVersionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateABSVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorUpdateABSVersionReceived;
        protected virtual void OnLicenseCoordinatorUpdateABSVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorUpdateABSVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorUpdateABSVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteABSVersion from LicenseCoordinator
        /// </summary>
        public event EventHandler<PayloadEventArgs> LicenseCoordinatorDeleteABSVersionReceived;
        protected virtual void OnLicenseCoordinatorDeleteABSVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.LicenseCoordinatorDeleteABSVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.LicenseCoordinatorDeleteABSVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: AddABSVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminAddABSVersionReceived;
        protected virtual void OnAdminAddABSVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminAddABSVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminAddABSVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: GetABSVersions from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminGetABSVersionsReceived;
        protected virtual void OnAdminGetABSVersionsReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminGetABSVersionsReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminGetABSVersionsReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: UpdateABSVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminUpdateABSVersionReceived;
        protected virtual void OnAdminUpdateABSVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminUpdateABSVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminUpdateABSVersionReceived(this, plea);
            }
        }

        /// <summary>
        /// Responds to: DeleteABSVersion from Admin
        /// </summary>
        public event EventHandler<PayloadEventArgs> AdminDeleteABSVersionReceived;
        protected virtual void OnAdminDeleteABSVersionReceived(StandardPayload payload, BasicDeliverEventArgs bdea)
        {
            var plea = new PayloadEventArgs(payload, bdea);
            if (!ReferenceEquals(this.AdminDeleteABSVersionReceived, null))
            {
                plea.Payload.IsHandled = true;
                this.AdminDeleteABSVersionReceived(this, plea);
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

                    
