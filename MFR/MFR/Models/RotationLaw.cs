using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MFR.Models
{
    [Table("RotationLaw")]
    public partial class RotationLaw
    {
        public RotationLaw()
        {
            Clients = new HashSet<Client>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int RotationPeriod { get; set; }
        public int CoolingPeriod { get; set; }

        [InverseProperty(nameof(Client.RotationLaw))]
        public virtual ICollection<Client> Clients { get; set; }
    }
}
