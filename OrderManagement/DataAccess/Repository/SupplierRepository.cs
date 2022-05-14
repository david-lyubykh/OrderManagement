using DataAccess.DataModel;
using DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Models.SupplierDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SupplierRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Supplier>> GetSupplier()
        {
            try
            {
                return await _dbContext.Suppliers.Where(x => x.Disable == false).ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Supplier> GetSupplier(int supplierId)
        {
            try
            {
                return await _dbContext.Suppliers.FirstOrDefaultAsync(x => x.Id == supplierId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Supplier> CreateSupplier(Supplier supplier)
        {
            try
            {
                var createdSupplier = await _dbContext.Suppliers.AddAsync(supplier);
                await _dbContext.SaveChangesAsync();
                return createdSupplier.Entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Supplier> UpdateSupplier(Supplier supplier)
        {
            try
            {
                var updatedSupplier = _dbContext.Suppliers.Update(supplier);
                await _dbContext.SaveChangesAsync();
                return updatedSupplier.Entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> DeleteSupplier(int supplierId)
        {
            try
            {
                var updatedSupplier = _dbContext.Suppliers.Find(supplierId);
                updatedSupplier.Disable = true;
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
