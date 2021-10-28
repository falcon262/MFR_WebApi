using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MFR.Models
{
    [Table("Service")]
    [Index(nameof(ClientId), Name = "IX_Service_ClientId")]
    public partial class Service
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ClientId { get; set; }
    }
}
