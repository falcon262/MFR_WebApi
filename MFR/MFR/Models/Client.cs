using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MFR.Models
{
    [Table("Client")]
    [Index(nameof(IndustryId), Name = "IX_Client_IndustryId")]
    [Index(nameof(RotationLawId), Name = "IX_Client_RotationLawId")]
    [Index(nameof(SubIndustryId), Name = "IX_Client_SubIndustryId")]
    public partial class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSecRegistrant { get; set; }
        public bool IsListedOnStockExchange { get; set; }
        public bool IsListedOnGhanaAlternativeMarket { get; set; }
        public int? RotationLawId { get; set; }
        public string PredecessorAuditor { get; set; }
        public string GlobalGroupAuditor { get; set; }
        public string ParentCompanyCountry { get; set; }
        public DateTime ExpectedRotationYear { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public bool IsContactAlumni { get; set; }
        public string CeoName { get; set; }
        public string BoardChairName { get; set; }
        public string CfoName { get; set; }
        public string AltContactName { get; set; }
        public string AltContactPhone { get; set; }
        public string AltContactEmail { get; set; }
        public bool IsAltContactAlumni { get; set; }
        public bool IsClientSalesforce { get; set; }
        public int? IndustryId { get; set; }
        public int? SubIndustryId { get; set; }

        [ForeignKey(nameof(IndustryId))]
        [InverseProperty("ClientIndustries")]
        public virtual Industry Industry { get; set; }
        [ForeignKey(nameof(RotationLawId))]
        [InverseProperty("Clients")]
        public virtual RotationLaw RotationLaw { get; set; }
        [ForeignKey(nameof(SubIndustryId))]
        [InverseProperty("ClientSubIndustries")]
        public virtual Industry SubIndustry { get; set; }
    }
}
