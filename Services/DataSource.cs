using System;
using System.Collections.Generic;

namespace Services
{
    // Here is some data for our event service (DiveFinderService)
    public static class DataSource
    {
        public static IList<beachDive> beachDives
        {
            get
            {
                return new List<beachDive>
                {
                    new beachDives {ReleaseDate = new DateTime(2015,9, 12), Level = "Beginner", Description = "Easy Night Beach Dive", otherInfo = "7 PM at 65 North Beach Rd, Dania Beach, FL"},
                    new beachDives {ReleaseDate = new DateTime(2015,9, 19), Level = "Intermediate", Description = "Wreck Dive", otherInfo = "1 PM at 65 North Beach Rd, Dania Beach, FL"},
                    new beachDives {ReleaseDate = new DateTime(2015,9, 26), Level = "Beginner", Description = "Easy Night Beach Dive", otherInfo = "7 PM at 65 North Beach Rd, Dania Beach, FL"},
                    new beachDives {ReleaseDate = new DateTime(2015,10, 3), Level = "Intermediate", Description = "Wreck Dive", otherInfo = "1 PM at 65 North Beach Rd, Dania Beach, FL"},
                    new beachDives {ReleaseDate = new DateTime(2015,10, 10), Level = "Beginner", Description = "Easy Night Beach Dive", otherInfo = "7 PM at 65 North Beach Rd, Dania Beach, FL"}
                };
            }
        }       
    }
}