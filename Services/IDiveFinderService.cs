using System.Collections.Generic;

namespace Services
{
    public interface IDiveFinderService
    {
        IEnumerable<beachDive> GetAvailableDives();
    }
}