using EcoModeSwitcher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher.AbstractClasses
{
    /// <summary>
    /// Abstract class that contains Activate and Deactivate logic with IsActive field.
    /// Inherits from IListener interface and all derived call will implement this method
    /// </summary>
    public abstract class PublisherAbstract : IListener
    {
        private bool _isActive { get; set; }

        /// <summary>
        /// Return boolean, checks if the listener is active 
        /// </summary>
        /// <returns>Boolean</returns>
        public bool IsActive()
        {
            return _isActive;
        }

        /// <summary>
        /// Sets IsActive property to true
        /// </summary>
        public void Activate()
        {
            _isActive = true;
        }

        /// <summary>
        /// Sets IsActive property to false
        /// </summary>
        public void Deactivate()
        {
            _isActive = false;
        }

        public abstract void Update(IEnumerable<LockerState> lockerStates);
    }
}
