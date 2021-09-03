using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher.Interfaces
{
    public interface IListener
    {
        bool IsActive();
        void Update(IEnumerable<LockerState> lockerStates);
    }
}
