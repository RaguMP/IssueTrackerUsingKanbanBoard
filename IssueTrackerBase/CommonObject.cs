using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackerBase
{
    public class CommonObject
    {

    }


    /// <summary>
    /// Get the Status Details
    /// </summary>
    public class StatausDetails
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int SortOrder { get; set; }
    }
}
