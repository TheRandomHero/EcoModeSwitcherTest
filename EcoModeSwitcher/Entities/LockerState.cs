using System;

namespace EcoModeSwitcher
{
    public class LockerState
    {
        public Guid LockerId { get; init; }
        public bool RunsOnEco { get; init; }
    }
}
