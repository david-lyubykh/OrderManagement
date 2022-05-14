using DataAccess.DataModel;
using Models.SupplierDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetSupplier();
        Task<Supplier> GetSupplier(int supplierId);
        Task<Supplier> CreateSupplier(Supplier supplier);
        Task<Supplier> UpdateSupplier(Supplier supplier);
        Task<bool> DeleteSupplier(int supplierId);
    }
}
