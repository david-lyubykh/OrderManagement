using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataModel
{
    public class State : Auditable<int>
    {
        [Column(Order = 1)]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
