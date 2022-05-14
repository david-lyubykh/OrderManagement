using Models.SupplierDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.App.Services.IService
{
    public interface ISupplierService
    {
        Task<IEnumerable<SupplierDto>> GetSuppliers();
        Task<UpdateSupplierDto> GetSupplier(int supplierId);
        Task<SupplierDto> CreateSupplier(CreateSupplierDto createSupplierDto);
        Task<SupplierDto> UpdateSupplier(UpdateSupplierDto updateSupplierDto);
        Task<bool> DeleteSupplier(int supplierId);
    }
}
