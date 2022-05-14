using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SupplierDtos
{
    public class UpdateSupplierDto : CreateSupplierDto
    {
        [Required(ErrorMessage = "Invalid Supplier.")]
        public int Id { get; set; }
    }
}
