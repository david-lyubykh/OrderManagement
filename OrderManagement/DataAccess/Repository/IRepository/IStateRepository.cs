using DataAccess.DataModel;
using Models.LocationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IStateRepository
    {
        Task<IEnumerable<State>> GetState();
        Task<State> GetState(int stateId);
        Task<State> CreateState(State StateToCrete);
        Task<State> UpdateState(State StateToUpdate);
        Task<bool> DeleteState(int stateId);
    }
}
