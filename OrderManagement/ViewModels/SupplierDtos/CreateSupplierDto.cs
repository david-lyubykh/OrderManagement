using Models.LocationDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SupplierDtos
{
    public class CreateSupplierDto
    {
        [Required(ErrorMessage = "Name  is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address Line 1 is required")]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Address Line 2 is required")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        public string PostalCode { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "State is required")]
        public int StateId { get; set; }
        public List<StateDto> States { get; set; }
    }
}
