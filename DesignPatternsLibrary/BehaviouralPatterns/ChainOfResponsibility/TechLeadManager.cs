using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.BehaviouralPatterns.ChainOfResponsibility
{
    public class TechLeadManager : AbstractManager
    {
        public override object HandleRequest(object request)
        {
            //techlead confirms all sick leaves and annual leaves if the decision is left to her
            var leaveType = (string)request;

            if (leaveType == "SickLeave" || leaveType == "AnnualLeave")
            {
                return $"TechLead confirmed {leaveType}";
            }
            else
            {
                return base.HandleRequest(request);
            }
        }
    }
}
