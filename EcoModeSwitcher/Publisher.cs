using EcoModeSwitcher.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoModeSwitcher
{
    public class Publisher : IPublisher
    {
        private readonly List<IListener> _listener;
        private readonly ILockerSystemManager _lockerSystem;
        private readonly ILogger<Publisher> _logger;


        public Publisher(ILogger<Publisher> logger, ILockerSystemManager lockerSystemManager)
        {
            _logger = logger;
            _lockerSystem = lockerSystemManager;
            _listener = new List<IListener>();

        }

        /// <summary>
        /// Adding Listener object into List<Ilistener>
        /// </summary>
        /// <param name="listener">All object that inherits from IListener object</param>
        public void Register(IListener listener)
        {
            if (listener == null)
            {
                _logger.LogInformation("listener cannot be null when Registering");
                throw new ArgumentNullException(paramName: nameof(listener), message: "parameter cannot be null");
            }

            if (!_listener.Contains(listener))
                _listener.Add(listener);
        }


        /// <summary>
        /// Removes listeners from List<Listener>
        /// </summary>
        /// <param name="listener">All object that inherits from IListener object</param>
        public void Unregister(IListener listener)
        {
            try
            {
                _listener.Remove(listener);
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex.Message);
                throw new ArgumentException(ex.Message);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }

        }


        /// <summary>
        /// Instantiate a Lockerstate with RunsEcoMode property equal to true by calling LockerSystemManager EcoModeOn method 
        /// </summary>
        public async void SetToEcoMode()
        {
            var states = await _lockerSystem.SwitchEcoOn();
            Notify(states);
        }


        /// <summary>
        /// Instantiate a Lockerstate with RunsEcoMode property equal to false by calling LockerSystemManager EcoModeOff method 
        /// </summary>
        public async void SetToNormalMode()
        {
            var states = await _lockerSystem.SwitchEcoOff();
            Notify(states);

        }


        /// <summary>
        /// Calls all the Listener's Update() method
        /// </summary>
        /// <param name="states">Collection of registered LockerStates</param>
        private void Notify(IEnumerable<LockerState> states)
        {
            if (states != null)
                foreach (var item in _listener)
                {
                    if (item.IsActive() != false)
                        try
                        {
                            item.Update(states);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex.Source, ex.Message);
                            continue;
                            throw new Exception();
                        }
                    else
                    {
                        continue;
                    }
                }
        }
    }
}
