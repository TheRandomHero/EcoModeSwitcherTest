using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher.Interfaces
{
    public interface ILockerSystemManager
    {
        Task<IEnumerable<LockerState>> SwitchEcoOn();
        Task<IEnumerable<LockerState>> SwitchEcoOff();
    }
}
