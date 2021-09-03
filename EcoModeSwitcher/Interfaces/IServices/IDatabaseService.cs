using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher.Interfaces
{
    public interface IDatabaseService
    {
        Task SaveLockerStates(IEnumerable<LockerState> lockerStates);
    }
}
