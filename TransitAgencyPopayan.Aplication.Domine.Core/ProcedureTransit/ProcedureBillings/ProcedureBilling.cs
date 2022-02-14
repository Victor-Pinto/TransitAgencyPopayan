﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransitAgencyPopayan.Aplication.Domine.Core.Base;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Procedures;

namespace TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.ProcedureBillings
{
    public class ProcedureBilling : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProcedureBillingId { get; set; }

        public int BillingId { get; set; }

        public virtual Billing? Billing { get; set; }

        public int ProcedureId { get; set; }

        public virtual Procedure? Procedure { get; set; }
    }
}