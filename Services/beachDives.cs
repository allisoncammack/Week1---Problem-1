using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Services
{
    public class beachDives
    {
        public DateTime ReleaseDate { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public string otherInfo { get; set; }

        public override string ToString()
        {
            output += string.Format("{0}\n{1}\n{2}\{3}", this.ReleaseDate, this.Level, this.Description, this.otherInfo);
            return output;
        }
    }
}
