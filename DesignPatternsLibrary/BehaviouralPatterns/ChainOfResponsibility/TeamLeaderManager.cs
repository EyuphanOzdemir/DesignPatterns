using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.ChainOfResponsibility
{
    public class TeamLeaderManager:AbstractManager
    {
        public override object HandleRequest(object request)
        {
            //teamlead confirms all sick leaves nut no annual leave if the decision is left to her
            var leaveType = (string)request;

            if (leaveType == "SickLeave")
            {
                return $"TeamLead confirmed {leaveType}";
            }
            else if (leaveType == "AnnualLeave")
            {
                return $"TeamLead rejected {leaveType}";
            }
            else
            {
                return base.HandleRequest(request);
            }
        }
    }
}
