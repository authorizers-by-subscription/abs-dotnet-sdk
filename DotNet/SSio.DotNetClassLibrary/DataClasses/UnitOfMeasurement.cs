/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - An odxml42 Tool
    This file WILL NOT be overwritten once changes are made.
*************************************************/
using System;
using System.ComponentModel;
                        
namespace SmartSubs.io.Lib.DataClasses
{                   
    
    public partial class UnitOfMeasurement 
    {
        public UnitOfMeasurement()
        {
            this.InitPoco();
        }

        public override String ToString()
        {
            return String.Format("UnitOfMeasurement: {0}", this.Name);
        }

        public UnitOfMeasurement Minimize()
        {
            this.CaseSensativeCode = null;
            this.MeasurementType = null;
            this.LongCode = null;
            this.NameSingular = null;
            this.NamePlural = null;
            this.SuggestedMeasurementValue = null;
            this.RelatedMeasurementUnit = null;
            this.RelatedMeasurementUnitLongCode = null;
            this.RelatedMeasurementUnit_UnitOfMeasurementsExpanded = null;
            this.RelatedMeasurementUnitLongCode_UnitOfMeasurementsExpanded = null;
            this.RelatedTimeUnitLongCode_UnitOfMeasurementsExpanded = null;
            this.BaseUnit_UnitOfMeasurementsExpanded = null;
            this.RelatedTimeUnit_UnitOfMeasurementsExpanded = null;
            this.BaseUnitNamePlural_UnitOfMeasurementsExpanded = null;
            this.UnitOfMeasurementscopy_MeasurementTypesExpanded = null;
            return this;
        }
    }
}