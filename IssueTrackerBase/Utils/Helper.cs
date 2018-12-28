using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackerBase.Utils
{
    public class Helper
    {
        public static string GetStoryPointInString(decimal input)
        {
            return input.ToString("0.###");
        }
    }
}
