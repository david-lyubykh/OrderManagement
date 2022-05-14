using AutoMapper;
using DataAccess.DataModel;
using DataAccess.Repository.IRepository;
using Models.SupplierDtos;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public SupplierService(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SupplierDto>> GetSupplier()
        {
            var suppliers = await _supplierRepository.GetSupplier();
            return _mapper.Map<IEnumerable<SupplierDto>>(suppliers);
        }

        public async Task<SupplierDto> GetSupplier(int supplierId)
        {
            var suppliers = await _supplierRepository.GetSupplier(supplierId);
            return _mapper.Map<SupplierDto>(suppliers);
        }

        public async Task<SupplierDto> CreateSupplier(CreateSupplierDto supplierToCreate)
        {
            Supplier supplier = _mapper.Map<Supplier>(supplierToCreate);
            supplier = await _supplierRepository.CreateSupplier(supplier);
            return _mapper.Map<SupplierDto>(supplier);
        }

        public async Task<SupplierDto> UpdateSupplier(UpdateSupplierDto supplierToUpdate)
        {
            Supplier supplier = _mapper.Map<Supplier>(supplierToUpdate);
            supplier = await _supplierRepository.UpdateSupplier(supplier);
            return _mapper.Map<SupplierDto>(supplier);
        }

        public async Task<bool> DeleteSupplier(int supplierId)
        {
            return await _supplierRepository.DeleteSupplier(supplierId);
        }
    }
}
