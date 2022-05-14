using DataAccess.DataModel;
using DataAccess.Repository.IRepository;
using Models.LocationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.LocationRepository
{
    public class StateRepository : IStateRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StateRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public Task<IEnumerable<State>> GetState()
        {
            throw new NotImplementedException();
        }

        public Task<State> GetState(int stateId)
        {
            throw new NotImplementedException();
        }

        public Task<State> CreateState(State StateToCrete)
        {
            throw new NotImplementedException();
        }

        public Task<State> UpdateState(State StateToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteState(int stateId)
        {
            throw new NotImplementedException();
        }
    }
}
