using System;
using System.Collections.Generic;

namespace Services
{
    public class DiveFinderService : IDiveFinderService
    {
        //This is here to hold our dive data
        private IList<beachDive> beachDives;

        public DiveFinderService()
        {
            // Load data
            beachDives = DataSource.beachDives;
        }

        public virtual IEnumerable<beachDive> GetAvailableDives()
        {
            return this.beachDives;
        }

    }
}
