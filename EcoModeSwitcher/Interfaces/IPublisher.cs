using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher.Interfaces
{
    public interface IPublisher
    {
        void Register(IListener observer);
        void Unregister(IListener observer);
    }
}
