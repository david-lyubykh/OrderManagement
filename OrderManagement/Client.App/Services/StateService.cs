using Client.App.Services.IService;
using Models.LocationDtos;
using System.Collections.Generic;
using System.Linq;

namespace Client.App.Services
{
    public class StateService : IStateService
    {
        private List<StateDto> _states;

        public StateService()
        {
            _states = new List<StateDto>()
            {
                new StateDto() { Id = 1, Name = "Alabama" },
                new StateDto() { Id = 2, Name = "California" },
                new StateDto() { Id = 3, Name = "Delaware" },
                new StateDto() { Id = 4, Name = "Florida" },
                new StateDto() { Id = 5, Name = "New Jersey" }
            };
        }

        public StateDto GetState(int stateId)
        {
            return _states[stateId];
        }

        public List<StateDto> GetStates()
        {
            return _states.ToList();
        }
    }
}
