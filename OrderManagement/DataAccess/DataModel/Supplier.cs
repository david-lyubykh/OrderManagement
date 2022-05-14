using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataModel
{
    public class Supplier : Auditable<int>
    {
        [Column(Order = 1)]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column(Order = 2)]
        [Required]
        [MaxLength(100)]
        public string AddressLine1 { get; set; }

        [Column(Order = 3)]
        [Required]
        [MaxLength(100)]
        public string AddressLine2 { get; set; }

        [Column(Order = 4)]
        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Column(Order = 5)]
        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [Column(Order = 6)]
        [Required]
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
