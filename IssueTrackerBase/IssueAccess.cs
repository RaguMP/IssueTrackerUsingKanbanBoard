using IssueTrackerBase.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackerBase
{
    public class IssueAccess
    {
        public List<StatausDetails> GetWorflowDetails(int statusId)
        {
            using (var context = new IssueTrackerEntities())
            {
                if (context.Database.Connection.State == ConnectionState.Closed)
                {
                    context.Database.Connection.Open();
                }
                List<StatausDetails> WorkFlowStatus = (from workflow in context.WorkFlowStatus.Where(i => i.StatusId == statusId)
                                       from status in context.Statuses.Where(s=>s.StatusId== statusId)
                                       select new StatausDetails
                                       {
                                           StatusId = workflow.StatusId,
                                           StatusName= status.StatusName,
                                           SortOrder= workflow.SortOrder
                                       }).ToList();
                return WorkFlowStatus;
            }
        }
    }
}
