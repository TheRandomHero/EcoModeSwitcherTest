using EcoModeSwitcher.AbstractClasses;
using EcoModeSwitcher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher.Services
{
    public class BuildingManagementService : PublisherAbstract, IBuildingManagementService
    {
        public async Task ManagerLockerStateChanges(IEnumerable<LockerState> lockerStates)
        {
            foreach (var locker in lockerStates)
            {
                Console.WriteLine("in my BM service {0}", locker.RunsOnEco.ToString());
            }
        }

        public async override void Update(IEnumerable<LockerState> lockerStates)
        {
            await ManagerLockerStateChanges(lockerStates);
        }
    }
}
