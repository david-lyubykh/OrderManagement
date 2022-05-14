using Models.SupplierDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ISupplierService
    {
        Task<IEnumerable<SupplierDto>> GetSupplier();
        Task<SupplierDto> GetSupplier(int supplierId);
        Task<SupplierDto> CreateSupplier(CreateSupplierDto supplierToCreate);
        Task<SupplierDto> UpdateSupplier(UpdateSupplierDto supplierToUpdate);
        Task<bool> DeleteSupplier(int supplierId);
    }
}
