using DataAccess.Repository.IRepository;
using Models.LocationDtos;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.LocationServices
{
    public class StateService : IStateService
    {
        private readonly IStateRepository _stateRepository;

        private List<StateDto> _states;

        public StateService(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
            _states = new List<StateDto>()
            {
                new StateDto() { Id = 1, Name = "Alabama" },
                new StateDto() { Id = 2, Name = "California" },
                new StateDto() { Id = 3, Name = "Delaware" },
                new StateDto() { Id = 4, Name = "Florida" },
                new StateDto() { Id = 5, Name = "New Jersey" }
            };
        }

        public List<StateDto> GetStates()
        {
            return _states.ToList();
        }
    }
}
