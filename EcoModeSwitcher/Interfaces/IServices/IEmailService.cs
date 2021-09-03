using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher.Interfaces
{
    interface IEmailService
    {
        Task SendEmail(IEnumerable<LockerState> states);
    }
}
