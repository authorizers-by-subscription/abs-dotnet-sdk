/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - An odxml42 Tool
    This file WILL NOT be overwritten once changes are made.
*************************************************/
using System;
using System.ComponentModel;
                        
namespace SmartSubs.io.Lib.DataClasses
{                   
    
    public partial class ProductLicenseMeter 
    {
        public ProductLicenseMeter()
        {
            this.InitPoco();
        }

        public SKUMeterAdjustment SKUMeterAdjustment { get; set; }

        public override String ToString()
        {
            return String.Format("ProductLicenseMeter: {0}", this.Name);
        }
                            
    }
}