using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MFR.Models
{
    [Table("Industry")]
    public partial class Industry
    {
        public Industry()
        {
            ClientIndustries = new HashSet<Client>();
            ClientSubIndustries = new HashSet<Client>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty(nameof(Client.Industry))]
        public virtual ICollection<Client> ClientIndustries { get; set; }
        [InverseProperty(nameof(Client.SubIndustry))]
        public virtual ICollection<Client> ClientSubIndustries { get; set; }
    }
}
