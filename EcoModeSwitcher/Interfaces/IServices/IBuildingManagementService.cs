using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher.Interfaces
{
    interface IBuildingManagementService
    {
        Task ManagerLockerStateChanges(IEnumerable<LockerState> lockerStates);
    }
}
