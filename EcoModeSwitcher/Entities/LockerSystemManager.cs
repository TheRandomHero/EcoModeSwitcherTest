using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcoModeSwitcher.Interfaces;

namespace EcoModeSwitcher
{
    public class LockerSystemManager : ILockerSystemManager
    {
        private readonly List<LockerState> states;

        public LockerSystemManager()
        {
            states = new List<LockerState>();
        }

        /// <summary>
        /// Instantiate a Lockerstate with RunsEcoMode property equal to false
        /// </summary>
        public async Task<IEnumerable<LockerState>> SwitchEcoOff()
        {
            states.Add(new LockerState
            {
                LockerId = new Guid(),
                RunsOnEco = false
            });

            return states;
        }

        /// <summary>
        /// Instantiate a Lockerstate with RunsEcoMode property equal to true 
        /// </summary>
        public async Task<IEnumerable<LockerState>> SwitchEcoOn()
        {
            states.Add(new LockerState
            {
                LockerId = new Guid(),
                RunsOnEco = true
            });

            return states;
        }
    }
}
