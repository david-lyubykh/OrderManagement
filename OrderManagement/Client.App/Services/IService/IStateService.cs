using Models.LocationDtos;
using System.Collections.Generic;

namespace Client.App.Services.IService
{
    public interface IStateService
    {
        List<StateDto> GetStates();
        StateDto GetState(int stateId);
    }
}
